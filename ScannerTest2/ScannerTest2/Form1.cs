using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public partial class Form1 : Form
{
    private List<string> stockSymbols = new List<string>();
    private HttpClient httpClient = new HttpClient();
    private const string apiKey = "QRBRDMXFNGMQ1VC8";
    private Timer stockDataTimer = new Timer();

    public Form1()
    {
        InitializeComponent();
        LoadStockSymbols();
        SetupTimer();
    }

    private void LoadStockSymbols()
    {
        // Read stock symbols from file
        foreach (var line in File.ReadAllLines("usstocks.txt"))
        {
            stockSymbols.Add(line.Trim());
        }
    }

    private void SetupTimer()
    {
        stockDataTimer.Interval = 300000; // 5 minutes
        stockDataTimer.Tick += async (sender, e) => await FetchStockData();
        stockDataTimer.Start();
    }

    private async Task FetchStockData()
    {
        foreach (var symbol in stockSymbols)
        {
            var url = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={symbol}&interval=5min&apikey={apiKey}";
            var response = await httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<dynamic>(response);
            // Process and update the DataGridView
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        FetchStockData();
    }
}