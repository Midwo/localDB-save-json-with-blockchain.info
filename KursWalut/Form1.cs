using FSharpUtils.Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KursWalut.Program;

namespace KursWalut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime Reflesh;


        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > Reflesh)
            {
                Reflesh = DateTime.Now.AddSeconds(Convert.ToDouble(nUDCoIleMinut.Value));

                WebClient webClient = new WebClient();
                var data = webClient.DownloadString("https://blockchain.info/pl/ticker");
                JObject jsonObject = JObject.Parse(data);

                using (var db = new BitCoinContext())
                {
                    var date = new BitCoinClass
                    {
                        M15 = Convert.ToDecimal(jsonObject["PLN"]["15m"]),
                        Last = Convert.ToDecimal(jsonObject["PLN"]["last"]),
                        Sell = Convert.ToDecimal(jsonObject["PLN"]["sell"]),
                        Symbol = "PLN",
                        Buy = Convert.ToDecimal(jsonObject["PLN"]["buy"]),
                        Date = DateTime.Now
                    };


                    db.BitCoinx.Add(date);
                    db.SaveChanges();
                };

                //MessageBox.Show("PLN: " + jsonObject["PLN"]["15m"]);
                //MessageBox.Show("PLN: " + jsonObject["PLN"]["last"]);
                //MessageBox.Show("PLN: " + jsonObject["PLN"]["buy"]);
                //MessageBox.Show("PLN: " + jsonObject["PLN"]["sell"]);
                //MessageBox.Show("PLN: " + jsonObject["PLN"]["Symbol"]);
            }

        }


    private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
