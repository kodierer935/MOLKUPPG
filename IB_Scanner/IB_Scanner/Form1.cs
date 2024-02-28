using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using IBApi;


namespace IB_Scanner
{
    public partial class Form1 : Form
    {

        delegate void SetTextCallback(string text);

        public void AddListBoxItem(string text)
        {
            if (this.lbData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddListBoxItem);
                this.Invoke(d, new object[] { text });

            }
            else
            {
                this.lbData.Items.Add(text);
            }
        }


        //create the iblclient object to present the connection
        IB_Scanner.EWrapperImpl ibClient;
        public Form1()
        {
            InitializeComponent();
            //instantiate the ibClient
            ibClient = new IB_Scanner.EWrapperImpl();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            ibClient.ClientSocket.eConnect("", 7497, 0);
            var reader = new EReader(ibClient.ClientSocket, ibClient.Signal);
            reader.Start();
            new Thread(() =>
            {
                while (ibClient.ClientSocket.IsConnected())
                {
                    ibClient.Signal.waitForSignal();
                    reader.processMsgs();

                }

            })
            { IsBackground = true }.Start();
            while (ibClient.NextOrderId <= 0) { }
        }
    }
}