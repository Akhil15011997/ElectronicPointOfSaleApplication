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
    public partial class SearchOrderDetails : Form
    {
        public SearchOrderDetails()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static List<string> OrderDetails = new List<String>();
        private void AddToBasketButton_Click(object sender, EventArgs e)
        {
            OrderDetails.Clear(); OrderDetailsListBox.Items.Clear();
            Primaryform Mainform = new Primaryform(); Mainform.InputAllOrderDetailsintoList();
            try
            {
                string ordernumber = InputTextBox.Text;
                string fullsearchordernumber = "Order details: " + ordernumber;
                int Number = int.Parse(ordernumber);
                if (Number != 0 && ordernumber.Length == 6)
                {
                    for (int index = 0; index < OrderDetails.Count; index++)
                    {
                        if (OrderDetails[index] == fullsearchordernumber)
                        {
                            for (int transcationvalues = index; transcationvalues <= OrderDetails.Count; transcationvalues++)
                            {
                                index++;
                                if (OrderDetails[transcationvalues] == "") { break; }
                                else { OrderDetailsListBox.Items.Add(OrderDetails[transcationvalues]); }
                            }
                        }
                    }
                    if (OrderDetailsListBox.Items.Count == 0) { MessageBox.Show("This ID does not exist\nPlease Verify"); }
                }
                else { MessageBox.Show("Enter Valid Order ID"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Valid Numeric TransactionID in the textBox\t");
                Console.WriteLine(ex); InputTextBox.Focus();
            }
        }

        private void SearchOrderDetails_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ExitButton, "Press to go back");
        }
    }
    }
