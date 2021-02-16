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

namespace Srinivas_Akhil_Assignment4_MS806
{
    public partial class StockAvailability : Form
    {
        public StockAvailability()
        {
            InitializeComponent();
        }

        private void StockAvailability_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader InputFile = File.OpenText("AvailableStockData.txt");
                while (!InputFile.EndOfStream)
                {
                    StockAvailabilityListBox.Items.Add(InputFile.ReadLine());
                }
                InputFile.Close();
            }
            catch (Exception ex) { MessageBox.Show("Unable to fetch the stock details file\nContact Manager\n\n" + ex); }

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
