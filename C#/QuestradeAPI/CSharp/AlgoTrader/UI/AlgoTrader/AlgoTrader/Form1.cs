using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlgoTrader
{
    public partial class Form1 : Form
    {
        static private int accountNumber = 0;
        static private string apiServer = null;
        static private string accessToken = null; 
        static private string[] authorizedData = null;
        static private string[] symbol = { "NFLX", "SPY" };
        static private double[] settings = new double[] { 100000, 100000, 0.7, 0.025 };

        private string[] tradeData;
        private bool alive = false;
        public static bool f2Alive = false;
        private Thread trader;

        Form2 f2;

        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
            
        }

        // Manage trading thread.
        private void ManageThread(string action)
        {
            if (!alive)
            {
                trader = new Thread(() =>
                {
                    tradeData = AlgoTrader.TradeThreadManager(accessToken, apiServer, authorizedData, settings, accountNumber);
                    
                });
                if (tradeData != null)
                {
                    alive = false;
                }

                //SetText(5, (nflx[2] - (nflx[2] * (settings[3] / 2))).ToString());
                // Start thread.
                if (action == "start")
                {
                    trader.Start();

                    // Tell trader to trade.
                    AlgoTrader.trading = true;
                    alive = true;
                }
            }
            else
            {
                // Kill thread.
                if (action == "die")
                {
                    // Tell trader to stop trading.
                    AlgoTrader.trading = false;

                    alive = false;
                }
            }
        }

        // When the program first loads.
        private void Form1_Load(object sender, EventArgs e)
        {
            authorizedData = AlgoTrader.GetData();

            accessToken = authorizedData[0];
            apiServer = authorizedData[4];

            // Get account data.
            string[] accountData = Request.AccountInfo(accessToken, apiServer);
            accountNumber = Convert.ToInt(accountData[1]);
            string accountStatus = accountData[2];
        }

        // Start Trading.
        private void button1_Click(object sender, EventArgs e)
        {
            // If not already trading, start trading.
            ManageThread("start");
        }

        // Stop Trading.
        private void button2_Click(object sender, EventArgs e)
        {
            // Trading thread is running.
            ManageThread("die");
        }

        // Trading Form.
        private void button_Click(object sender, EventArgs e)
        {
            // Create new form.
            if (!f2Alive)
            {
                f2 = new Form2(accessToken, apiServer, symbol, accountNumber, settings[0]);
                f2.Show();
                f2Alive = true;
            }
        }

        // Profit Goal.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBox1.Text, out settings[0]))
                MessageBox.Show("Please enter a number");
            else
                ManageThread("update");
        }

        // Max loss.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBox2.Text, out settings[1]))
                MessageBox.Show("Please enter a number");
            else
                ManageThread("update");
        }

        // Account %
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBox3.Text, out settings[2]))
                MessageBox.Show("Please enter a number");
            else
                ManageThread("update");
        }

        // Profit taking %
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!Double.TryParse(textBox4.Text, out settings[3]))
                MessageBox.Show("Please enter a number");
            else
                ManageThread("update");
        }

        // Close button.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (alive)
            {
                // Confirm user wants to close
                switch (MessageBox.Show(this, "The program is still trading. Are you sure you want to close? (It will stop automatcally if yes.)", "Closing", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        // Kill trader.
                        ManageThread("die");
                        // Wait for trader.
                        trader.Join();
                        break;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void value_Click(object sender, EventArgs e)
        {

        }

        private void size_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void position_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}