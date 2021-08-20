using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cash_Register_System_CVS
{
    public partial class Form1 : Form
    {

        public string paperpath;
        public string sizepath;
        public string outputpath;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "CSV-file (*.csv)|*.csv";
            openFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Filter = "CSV-file (*.csv)|*.csv";
            saveFileDialog1.RestoreDirectory = true;
        }

        private void butt_paper_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            paperpath = openFileDialog1.FileName;
            txtbox_paperfile.Text = paperpath;
        }

        private void butt_sizes_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            sizepath = openFileDialog1.FileName;
            txtbox_sizefile.Text = sizepath;
        }

        private void butt_output_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            outputpath = saveFileDialog1.FileName;
            txtbox_outputfile.Text = outputpath;
        }

        private void butt_generate_Click(object sender, EventArgs e)
        {

            List<string> papername = new List<string>();
            List<string> paperprice = new List<string>();
            List<string> papercost = new List<string>();

            List<string> size = new List<string>();
            List<string> bagsize = new List<string>();
            List<string> matsize = new List<string>();

            string csvcontent = null;

            string outputpath = txtbox_outputfile.Text;


            csvcontent = "Token,Item Name,Variation Name,SKU,Description,Category,Price,Auto Add Item to Check,Option Name 1,Option Value 1,Current Quantity BSLprints,New Quantity BSLprints,Stock Alert Enabled BSLprints,Stock Alert Count BSLprints,Modifier Set - 4\" x 6\" Sleeve,Modifier Set - 5\" x 7\" Sleeve,Modifier Set - Border,Tax - Mississippi(7%),Non- Taxable Service(0%),Tax - Out of State(No Tax) (0%),Tax - Wholesale(No Tax)(0%)" + Environment.NewLine;

            using (var reader = new StreamReader(txtbox_paperfile.Text))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    papername.Add(values[0]);
                    paperprice.Add(values[1]);
                    papercost.Add(values[2]);
                }
            }

            using (var reader = new StreamReader(txtbox_sizefile.Text))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    size.Add(values[0]);
                    bagsize.Add(values[1]);
                    matsize.Add(values[2]);
                }
            }

            string k = ",";

            
            foreach (string currentpaper in papername)
            {
                if(currentpaper == "Paper Name")
                {

                }
                else
                {
                    foreach (string currentsize in size)
                    {
                        if(currentsize == "Size")
                        {

                        }
                        else
                        {
                            string cursize = size[size.IndexOf(currentsize)].ToString().Replace("\"", "");
                            int xindex = cursize.IndexOf("x");
                            float width = float.Parse(cursize.Substring(0, xindex - 1));
                            float height = float.Parse(cursize.Substring(xindex + 1));
                            float curprice = width * height / 144 * float.Parse(paperprice[papername.IndexOf(currentpaper)]);
                            float curpricedollar = (float)Math.Truncate(curprice);
                            float curpricents = curprice - curpricedollar;
                            float rounded_decimal = (float)((float)Math.Ceiling(curpricents / 0.25) * 0.25);
                            float curpricefull = curpricedollar + rounded_decimal;
                            if(curpricefull < 1)
                            {
                                curpricefull = 1;
                            }
                            csvcontent += "" + k + papername[papername.IndexOf(currentpaper)].Replace("gsm", "").Replace("lb", "") + k + size[size.IndexOf(currentsize)] + k + "" + k + "" + k + "Print" + k + curpricefull.ToString() + k + "" + k + "Print Size" + k + size[size.IndexOf(currentsize)] + k + "" + k + "" + k + "" + k + "" + "" + k + "N" + k + "N" + k + "N" + k + "Y" + k + "N" + k + "N" + k + "N" + Environment.NewLine;
                        }
                    }
                }

            }
            File.WriteAllText(outputpath.ToString(), csvcontent);
        }
    }
}
