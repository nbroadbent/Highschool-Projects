using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AlgoTrader
{
    public partial class Form2 : Form
    {
        static private int accountNumber = 0;
        static private string apiServer = null;
        static private string accessToken = null;
        static private double profitGoal;

        public Form2(string accessToken1, string apiServer1, string[] symbols, int accountNumber1, double profitGoal1)
        {
            InitializeComponent();

            CreateTabs(symbols);
            //tabPage1.Text = symbol[0];

            accessToken = accessToken1;
            apiServer = apiServer1;
            accountNumber = accountNumber1;
            profitGoal = profitGoal1;

            UpdateData(symbols);
        }

        private void CreateTabs(string[] symbols)
        {
            if (symbols != null)
            {
                /*
                for (int i = 0; i < symbols.Length; i++)
                {
                    //tabControl1.TabPages.Add(symbols[i]);
                    
                }
                */
                tabPage1.Text = symbols[0];
                tabPage2.Text = symbols[1];
            }
        }

        private void UpdateData(string[] symbols)
        {
            double profitT = 0, profit1 = 0, profit2 = 0;

            // Get nflx data.
            double[] sym1 = Request.Positions(accessToken, apiServer, symbols[0], accountNumber);
            double[] sym2 = Request.Positions(accessToken, apiServer, symbols[1], accountNumber);

            if (sym1 != null)
            {
                if (sym1[1] != 0)
                {
                    if (sym1[1] > 0)
                        position.Text = "Long " + symbols[0];
                    else
                        position.Text = "Short " + symbols[0];
                    size.Text = sym1[1].ToString();
                    value.Text = (sym1[1] * sym1[2]).ToString();
                    price.Text = sym1[2].ToString();
                }
                else
                {
                    position.Text = "None";
                }
                profit1 = sym1[3];
            }
            if (sym2 != null)
            {
                if (sym2[1] != 0)
                {
                    if (sym2[1] > 0)
                        position1.Text = "Long " + symbols[1];
                    else
                        position1.Text = "Short " + symbols[1];
                    size1.Text = sym2[1].ToString();
                    value1.Text = (sym2[1] * sym1[2]).ToString();
                    price1.Text = sym2[2].ToString();                
                }
                else
                {
                    position1.Text = "None";
                }
                profit2 = sym2[3];
            }
            
            profitT = profit1 + profit2;
            double ptg = (profitT / profitGoal) * 100;
            MessageBox.Show(ptg.ToString());
            progressBar1.Value = (int)Math.Ceiling(ptg);
            //progressBar1.Value = 23;
            profit.Text = profitT.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Close button.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Form1.f2Alive = false;
        }

        private void position_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}