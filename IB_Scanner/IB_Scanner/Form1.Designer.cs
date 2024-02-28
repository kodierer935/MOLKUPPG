namespace IB_Scanner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnConnect = new Button();
            cbSymbol = new ComboBox();
            lbData = new ListBox();
            SuspendLayout();
            // 
            // BtnConnect
            // 
            BtnConnect.Location = new Point(24, 21);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new Size(115, 35);
            BtnConnect.TabIndex = 0;
            BtnConnect.Text = "Connect";
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += BtnConnect_Click;
            // 
            // cbSymbol
            // 
            cbSymbol.FormattingEnabled = true;
            cbSymbol.Items.AddRange(new object[] { "MSFT", "TSLA", "IBM" });
            cbSymbol.Location = new Point(24, 73);
            cbSymbol.Name = "cbSymbol";
            cbSymbol.Size = new Size(121, 23);
            cbSymbol.TabIndex = 1;
            cbSymbol.Text = "MSFT";
            // 
            // lbData
            // 
            lbData.FormattingEnabled = true;
            lbData.ItemHeight = 15;
            lbData.Location = new Point(24, 112);
            lbData.Name = "lbData";
            lbData.Size = new Size(338, 169);
            lbData.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbData);
            Controls.Add(cbSymbol);
            Controls.Add(BtnConnect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnConnect;
        private ComboBox cbSymbol;
        private ListBox lbData;
    }
}