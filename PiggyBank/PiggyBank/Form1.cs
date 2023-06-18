using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        private MoneyBox Piggy;
        private readonly string PiggyErrMsg = "Couldn't add the money, because PiggyBank has reached max capacity!";
        private readonly string PiggyCaption = "Piggy is Full";
        public Form1()
        {
            InitializeComponent();
            Piggy = new MoneyBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_1kr_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            Coin oneKrs = new Coin("1krs", 0.01, 16.5, 2);
            bool result = Piggy.AddMoney(oneKrs);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "1 kurus successfully added.";
            }      
        }

        private void btn_5kr_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            Coin fiveKrs = new Coin("5krs", 0.05, 17.5, 2);
            bool result = Piggy.AddMoney(fiveKrs);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "5 kurus successfully added.";
            }

        }

        private void btn_10kr_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            Coin tenKrs = new Coin("10krs", 0.1, 18.5, 2);
            bool result = Piggy.AddMoney(tenKrs);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "10 kurus successfully added.";
            }

        }

        private void btn_25kr_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            Coin twntyfiveKrs = new Coin("25krs", 0.25, 20.5, 2);
            bool result = Piggy.AddMoney(twntyfiveKrs);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "25 kurus successfully added.";
            }
        }

        private void btn_50kr_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            Coin fiftyKrs = new Coin("50krs", 0.5, 23.85, 2);
            bool result = Piggy.AddMoney(fiftyKrs);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "50 kurus successfully added.";
            }
        }

        private void btn_1tl_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            Coin oneTl = new Coin("1TL", 1, 26.15, 2);
            bool result = Piggy.AddMoney(oneTl);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "1 Lira successfully added.";
            }

        }

        private void btn_5tl_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            BankNote fiveTL = new BankNote("5TL", 5, 76, 152, 25);
            bool result = Piggy.AddMoney(fiveTL);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "5 Lira successfully added.";
            }

        }

        private void btn_10tl_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            BankNote tenTL = new BankNote("10TL", 10, 76, 152, 25);
            bool result = Piggy.AddMoney(tenTL);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "10 Lira successfully added.";
            }

        }

        private void btn_20tl_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            BankNote twntyTL = new BankNote("20TL", 20, 76, 152, 25);
            bool result = Piggy.AddMoney(twntyTL);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "20 Lira successfully added.";
            }

        }

        private void btn_50tl_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            BankNote fiftyTL = new BankNote("50TL", 50, 81, 152, 25);
            bool result = Piggy.AddMoney(fiftyTL);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "50 Lira successfully added.";
            }

        }

        private void btn_100tl_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            BankNote hundredTL = new BankNote("100TL", 100, 81, 158, 25);
            bool result = Piggy.AddMoney(hundredTL);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "100 Lira successfully added.";
            }

        }

        private void btn_200tl_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            BankNote twoHundredTL = new BankNote("200TL", 200, 81, 158, 25);
            bool result = Piggy.AddMoney(twoHundredTL);
            if (!result)
            {
                MessageBox.Show(PiggyErrMsg, PiggyCaption);
            }
            else
            {
                lblResult.Text = "200 Lira successfully added.";
            }

        }

        private void btn_Break_Click(object sender, EventArgs e)
        {
            double totalMoney = 0;
            int oneKrsAmt = 0, fiveKrsAmt = 0, tenKrsAmt = 0, twntyFiveKrsAmt = 0, fiftyKrsAmt = 0, 
                oneTLAmt = 0, fiveTLAmt = 0, tenTLAmt = 0, twntyTLAmt = 0, fiftyTLAmt = 0, hundredTLAmt = 0,
                twoHndrdAmt = 0;
            string msg = "Piggy had ";
            List<Money> moneyInThePiggy = Piggy.FinishHim();

            foreach(Money item in moneyInThePiggy)
            {
                #region huuuge Switch to assign
                switch (item.Name)
                {
                    case "1krs": totalMoney += 0.01;
                        oneKrsAmt++;
                        break;
                    case "5krs": totalMoney += 0.05;
                        fiveKrsAmt++;
                        break;
                    case "10krs": totalMoney += 0.1;
                        tenKrsAmt++;
                        break;
                    case "25krs": totalMoney += 0.25;
                        twntyFiveKrsAmt++;
                        break;
                    case "50krs": totalMoney += 0.5;
                        fiftyKrsAmt++;
                        break;
                    case "1TL": totalMoney ++;
                        oneTLAmt++;
                        break;
                    case "5TL": totalMoney += 5;
                        fiveTLAmt++;
                        break;
                    case "10TL": totalMoney += 10;
                        tenTLAmt++;
                        break;
                    case "20TL": totalMoney += 20;
                        twntyTLAmt++;
                        break;
                    case "50TL": totalMoney += 50;
                        fiftyTLAmt++;
                        break;
                    case "100TL": totalMoney += 100;
                        hundredTLAmt++;
                        break;
                    case "200TL": totalMoney += 200;
                        twoHndrdAmt++;
                        break;
                    default:
                        break;
                }
                #endregion
            }
            #region Long msg creation
            if(totalMoney > 0) 
            { 
                if (oneKrsAmt > 0)
                {
                    msg += oneKrsAmt.ToString() + " 1 Kurus ";
                }
                if(fiveKrsAmt > 0)
                {
                    msg += fiveKrsAmt.ToString() + " 5 Kurus ";
                }
                if(tenKrsAmt > 0)
                {
                    msg += tenKrsAmt.ToString() + " 10 Kurus ";
                }
                if(twntyFiveKrsAmt > 0)
                {
                    msg += twntyFiveKrsAmt.ToString() + " 25 Kurus ";
                }
                if(fiftyKrsAmt > 0)
                {
                    msg += fiftyKrsAmt.ToString() + " 50 Kurus ";
                }
                if(oneTLAmt > 0)
                {
                    msg += oneTLAmt.ToString() + " 1 TL ";
                }
                if(fiveTLAmt > 0)
                {
                    msg += fiveTLAmt.ToString() + " 5TL ";
                }
                if(tenTLAmt > 0)
                {
                    msg += tenTLAmt.ToString() + " 10TL ";
                }
                if(twntyTLAmt > 0)
                {
                    msg += twntyTLAmt.ToString() + " 20TL ";
                }
                if(fiftyTLAmt > 0)
                {
                    msg += fiftyTLAmt.ToString() + " 50TL ";
                }
                if(hundredTLAmt > 0)
                {
                    msg += hundredTLAmt.ToString() + " 100TL ";
                }
                if(twoHndrdAmt > 0)
                {
                    msg += twoHndrdAmt.ToString() + " 200TL ";
                }
                
                msg += "with total money: " + totalMoney.ToString() + "TL";
            }
            else
            {
                msg += "no money!!";
            }
            #endregion

            DialogResult result = MessageBox.Show(msg, "Piggy is Broken", MessageBoxButtons.OK);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
