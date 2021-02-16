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
    public partial class Primaryform : Form
    {
        public Primaryform()
        {
            InitializeComponent();
        }
       //Global Variable Declaration
       static List<string> Watches = new List<string>()
            {"Cartier","Benson","Tudor","Omega","Rolex","Titan","Gusto","Timex","Casio","Fossil","Sonata","Tommy","Diesel"};
       static List<string> CategoryofWatch = new List<string>()
            {"Digital","Analog","Sporty","Leather","Hybrid"};
       static decimal[,] SaleValueofItems = { { 115, 108, 110, 113, 115 },
                                  { 112, 105, 107, 110, 112 },
                                  { 105, 98, 100, 103, 105 },
                                  { 82, 75, 77, 80, 82 },
                                  { 93, 86, 88, 91, 93 },
                                  { 80, 73, 75, 78, 80 },
                                  { 100, 93, 95, 98, 100 },
                                  { 55, 48, 50, 53, 55 },
                                  { 49, 42, 44, 47, 49 },
                                  { 70, 63, 65, 68, 70 },
                                  { 63, 56, 58, 61, 63 },
                                  { 75, 68, 70, 73, 75 },
                                  { 68, 61, 63, 66, 68 } };
        int[,] InitialStockData = { {30, 20, 64, 34, 89 },
                                  { 40, 34, 55, 39, 45 },
                                  { 34, 32, 14, 20, 14 },
                                  { 67, 14, 89, 45, 45 },
                                  { 44, 22, 43, 67, 12 },
                                  { 56, 23, 45, 23, 34 },
                                  { 34, 22, 23, 56, 34 },
                                  { 45, 20, 23, 45, 24 },
                                  { 45, 33, 32, 31, 30 },
                                  { 28, 23, 46, 20, 29 },
                                  { 34, 27, 23, 24, 16 },
                                  { 20, 30, 40, 39, 23 },
                                  { 23, 23, 43, 20, 23 } };
        int[,] WatchesSoldData = new int[13, 5]; int[] ExistingStockData = new int[65]; 
        int[,] CopyofExistingStockData = new int[12, 4];
        int[,] LiveStockData = new int[13, 5]; 
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(AddToBasketButton, "Press to add the item to basket");
            toolTip1.SetToolTip(RemoveButton, "Press to remove the item from basket");
            toolTip1.SetToolTip(PlaceOrderButton, "Press to place the order");
            TwoYearsWarrantyRadioButton.Checked = false;
            OneYearWarrantyRadioButton.Checked = false;
            NoThanksRadioButton.Visible = false;
            if (File.Exists("ClosingStockReport.txt"))
            {
                try
                {
                    StreamReader Outputfile = File.OpenText("ClosingStockReport.txt");
                    for (int k = 0; k <= 64; k++)
                    { ExistingStockData[k] = int.Parse(Outputfile.ReadLine()); Console.WriteLine(ExistingStockData[k]); }
                    int singlearrayvalue = 0;
                    for (int i = 0; i <= 12; i++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {
                            LiveStockData[i, j] = ExistingStockData[singlearrayvalue]; singlearrayvalue++;
                            CopyofExistingStockData[i, j] = LiveStockData[i, j];
                            WatchesSoldData[i, j] = 0;
                            Console.WriteLine(WatchesSoldData[i, j] = 0);
                        }
                    }
                    Outputfile.Close();
                }
                catch (Exception ex) { Console.WriteLine("Closing Stock Report does not exist\n" + ex.Message); }
            }
            else
            {
                LiveStockData = (int[,])this.InitialStockData.Clone();
                CopyofExistingStockData = (int[,])this.LiveStockData.Clone();
            }
            }
        //Global variable Declaration
        decimal unitsofwatches; 
        //Enabling PriceBox only when values inthe list boxes are selected
        private void EnablingPriceBox()
        {
            decimal warrantyrate;

            if (BrandsListBox.SelectedIndex != -1)
            {
                if (CategoryListBox.SelectedIndex != -1)
                {
                    warrantyrate = warrantycalculation();
                    RatePanel.Enabled = true;
                    unitsofwatches = UnitsNumericUpDown.Value;
                    PriceDisplayLabel.Text = "€ " + (((unitsofwatches * SaleValueofItems[BrandsListBox.SelectedIndex, CategoryListBox.SelectedIndex])) + (unitsofwatches * warrantyrate)).ToString();
                    AddToBasketButton.Focus();
                }
            }
        }
        //Calculating price for optional warranty
        decimal[] warrantyrates = new decimal[] { 20, 12, 0 }; string warranty;
        private decimal warrantycalculation()
        {
            decimal warrantyvalue;
            if (TwoYearsWarrantyRadioButton.Checked) { warrantyvalue = warrantyrates[0]; NoThanksRadioButton.Visible = true; warranty = "Two"; }
            else if (OneYearWarrantyRadioButton.Checked) { warrantyvalue = warrantyrates[1]; NoThanksRadioButton.Visible = true; warranty = "One"; }
            else { warrantyvalue = warrantyrates[2]; warranty = "NA"; }
            return warrantyvalue;
        }
        private void TwoYearsWarrantyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnablingPriceBox();
            NoThanksRadioButton.Visible = true;
        }
        private void OneYearWarrantyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnablingPriceBox();
            NoThanksRadioButton.Visible = true;
        }
        private void BrandsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnablingPriceBox();
        }
        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnablingPriceBox();
        }
        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            EnablingPriceBox();
        }
        //Global Variable Declaration
        decimal totalbill = 0, totalitems = 0;
        //Action performed when add to basket button is clicked
        private void AddToBasketButton_Click(object sender, EventArgs e)
        {
            int units = int.Parse(UnitsNumericUpDown.Value.ToString());
            if (CopyofExistingStockData[BrandsListBox.SelectedIndex, CategoryListBox.SelectedIndex] >= units)
            {
                BasketPanel.Visible = true; ViewBasketLabel.Visible = true;
                int uniqueReceiptNO = generateUniquereceiptnumber();
                decimal warrantyvalue = warrantycalculation();
                totalbill += decimal.Parse(PriceDisplayLabel.Text.Substring(1));
                totalitems += UnitsNumericUpDown.Value;
                if (OrderIDLabel.Text == "") { OrderIDLabel.Text = uniqueReceiptNO.ToString("D6"); }
                else { Console.WriteLine("Unique ReceiptNO already created"); }
                CopyofExistingStockData[BrandsListBox.SelectedIndex, CategoryListBox.SelectedIndex] = CopyofExistingStockData[BrandsListBox.SelectedIndex, CategoryListBox.SelectedIndex] - units;
                OrderDataGridView.Rows.Add(Watches[BrandsListBox.SelectedIndex], CategoryofWatch[CategoryListBox.SelectedIndex], warranty, UnitsNumericUpDown.Value.ToString(), PriceDisplayLabel.Text);
                PlaceOrderButton.Focus();
            }
            else {
                string unitserror = "Only " + CopyofExistingStockData[BrandsListBox.SelectedIndex, CategoryListBox.SelectedIndex].ToString() + " are available right now for " + Watches[BrandsListBox.SelectedIndex] + " of category " + CategoryofWatch[CategoryListBox.SelectedIndex];
                MessageBox.Show(unitserror, "OOPS!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                UnitsNumericUpDown.Focus();
            }
        }
        //Generating Unique Receipt Number
        private int generateUniquereceiptnumber()
        {
            Random UniqueNumber = new Random();
            int receiptNO = UniqueNumber.Next(0, 999999);
            string UniqueReceiptValue = "Receipt Number:" + receiptNO.ToString("D6");
            try
            {
                StreamReader Outputfile = new StreamReader("orderdetails.txt");
                while (!Outputfile.EndOfStream)
                {
                    string temp = Outputfile.ReadLine();
                    temp = "Order details: " + temp;
                    if (temp != UniqueReceiptValue) { Console.WriteLine("Searching for repeated TranscationID"); }
                    else { generateUniquereceiptnumber(); };
                }
                Outputfile.Close();
            }
            catch { Console.WriteLine("File does not exist"); }
            return receiptNO;
        }
        //Action Performed when Remove Button is clicked
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            List<string> selectedRowValues = new List<string>();
            selectedRowValues.Clear();
            int rowNumber = OrderDataGridView.CurrentRow.Index;
            DataGridViewRow selectedR = OrderDataGridView.Rows[rowNumber];
            for (int index = 0; index <= 4; index++)
            {
                selectedRowValues.Add(selectedR.Cells[index].Value.ToString());
            }
            int positionoftemptoy = Watches.IndexOf(selectedRowValues[0]);
            int positionoftempmake = CategoryofWatch.IndexOf(selectedRowValues[1]);
            int quantity = int.Parse(selectedRowValues[3]);
            CopyofExistingStockData[positionoftemptoy, positionoftempmake] = CopyofExistingStockData[positionoftemptoy, positionoftempmake] + quantity;
            RemoveButton.Focus();
            totalbill -= (decimal.Parse(selectedRowValues[4].Substring(1)));
            totalitems -= decimal.Parse(selectedRowValues[3]);
            OrderDataGridView.Rows.Remove(OrderDataGridView.Rows[rowNumber]);
            MessageBox.Show(selectedRowValues[3] + " Units of watch " + selectedRowValues[0] + " of Category " + selectedRowValues[1] + " was removed");
            if (OrderDataGridView.Rows.Count == 0) { ViewBasketLabel.Visible = false; MessageBox.Show("No more items on the cart"); BasketPanel.Visible = false; }
            else { Console.WriteLine("Items Still Available"); }
        }
        //Action Performed when Place Order Button is clicked
        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            int[,] dummyWatchesSoldData = new int[13, 5];
            StringBuilder OrderDetails = new StringBuilder();
            OrderDetails.AppendLine(string.Format("Check the Items below:"));
            for (int i = 0; i < OrderDataGridView.Rows.Count; i++)
            {
                OrderDetails.AppendLine(string.Format("\nWatch:\t\t {0}", OrderDataGridView.Rows[i].Cells[0].Value.ToString()));
                OrderDetails.AppendLine(string.Format("Category:\t {0}", OrderDataGridView.Rows[i].Cells[1].Value.ToString()));
                OrderDetails.AppendLine(string.Format("Warranty:\t {0}", OrderDataGridView.Rows[i].Cells[2].Value.ToString()));
                OrderDetails.AppendLine(string.Format("Units:\t\t {0}", OrderDataGridView.Rows[i].Cells[3].Value.ToString()));
                OrderDetails.AppendLine(string.Format("Price:\t\t {0}", OrderDataGridView.Rows[i].Cells[4].Value.ToString()));
            }
            OrderDetails.AppendLine(string.Format("\nTotal Bill:\t\t" + totalbill.ToString() + "\nTotal Units:\t" + totalitems.ToString()));
            if (MessageBox.Show(OrderDetails.ToString(), "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DateTime DateofOrder = DateTime.Now;
                    StreamWriter OutputFile = File.AppendText("orderdetails.txt");
                    OutputFile.WriteLine("Order details: " + OrderIDLabel.Text);
                    OutputFile.WriteLine("Date of Order: " + DateofOrder.ToString("dd-MM-yy"));
                    for (int i = 0; i <= 12; i++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {
                            WatchesSoldData[i, j] += (LiveStockData[i, j] - CopyofExistingStockData[i, j]);
                            dummyWatchesSoldData[i, j] = (LiveStockData[i, j] - CopyofExistingStockData[i, j]);
                            if (dummyWatchesSoldData[i, j] != 0) { OutputFile.WriteLine(Watches[i] + "|" + CategoryofWatch[j] + "|" + dummyWatchesSoldData[i, j]); }
                            else { Console.WriteLine("Sale has not occured for this instance"); }

                        }
                    }
                    OutputFile.WriteLine("Sale Value: " + totalbill); OutputFile.WriteLine();
                    OutputFile.Close();   }
                catch (Exception ex) { MessageBox.Show("Error unable to save orderID file contact manager\n" + ex); }
                int singlearrayloop = 0;
                for (int i = 0; i <= 12; i++)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        LiveStockData[i, j] = CopyofExistingStockData[i, j];
                ExistingStockData[singlearrayloop] = LiveStockData[i, j]; singlearrayloop++; } }
                try
                {
                    StreamWriter StockFile = File.CreateText("ClosingStockReport.txt"); for (int x = 0; x <= 64; x++)
                    { StockFile.WriteLine(ExistingStockData[x]); }
                    StockFile.Close();
                }
                catch (Exception ex) { MessageBox.Show("Unable to create closing stock report\n" + ex); }
                ClearButton_Click(sender, e);
                MessageBox.Show("Thank you for Shopping!!", "Successful");
            }
            else
            {
                ClearButton.Focus();
            }
        }
        //Action Performed when Exit Button is clicked
        private void ExitButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TotalProfitGenerated = 0;
                DateTime getdate = DateTime.Now;
                string today = getdate.ToString("dd-MM-yy");
                StreamWriter OutputFile = File.CreateText(today + "--SaleReport.txt");
                OutputFile.WriteLine("Management Report|Details of Sold Items\n" + getdate);
                for (int k = 0; k <= 4; k++) { OutputFile.Write("\t" + CategoryofWatch[k]); }
                OutputFile.Write("\tProfit");
                for (int i = 0; i <= 12; i++)
                {
                    decimal profitperwatch = 0;
                    OutputFile.WriteLine();
                    OutputFile.Write(Watches[i]);

                    for (int j = 0; j <= 4; j++)
                    {
                        OutputFile.Write("\t" + WatchesSoldData[i, j].ToString());
                        if (WatchesSoldData[i, j] != 0) { TotalProfitGenerated += WatchesSoldData[i, j] * SaleValueofItems[i, j]; }
                        else { TotalProfitGenerated += 0; }
                        profitperwatch += WatchesSoldData[i, j] * SaleValueofItems[i, j];
                    }
                    OutputFile.Write("\t" + profitperwatch);
                }
                OutputFile.WriteLine("\n Total Profit Generated Till Now :" + TotalProfitGenerated);
                OutputFile.Close();
                System.Diagnostics.Process.Start("notepad.exe", today + "--SaleReport.txt").WaitForExit();
            }
            catch (Exception ex) { MessageBox.Show("Error file cannot be generated\nContact your manager\n" + ex); }
            if (MessageBox.Show("Are you sure you want to close the application?\nNote: Management Report has been generated and can be viewed at any time", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK) { this.Close(); }

        }
        //Action Performed when Clear Button is clicked
        private void ClearButton_Click(object sender, EventArgs e)
        {
            BasketPanel.Visible = false;
            ViewBasketLabel.Visible = false;
            CategoryListBox.SelectedIndex = -1;
            BrandsListBox.SelectedIndex = -1;
            TwoYearsWarrantyRadioButton.Checked = false;
            OneYearWarrantyRadioButton.Checked = false;
            NoThanksRadioButton.Visible = false;
            UnitsNumericUpDown.Value = 1;
            PriceDisplayLabel.Text = "";
            OrderIDLabel.Text = "";
            totalbill = 0; totalitems = 0;
            RatePanel.Enabled = false;
            if (OrderDataGridView.Rows.Count != 0)
            {
                for (int x = 0; x <= 12; x++)
                {
                    for (int y = 0; y <= 4; y++)
                    {
                        CopyofExistingStockData[x, y] = LiveStockData[x, y];
                    }
                }
                OrderDataGridView.Rows.Clear();
            }
            else { Console.WriteLine("No watches in the grid"); }
        }
        private void SearchOrderButton_Click(object sender, EventArgs e)
        {
            SearchOrderDetails SearchFORM= new SearchOrderDetails();
            SearchFORM.ShowDialog();
        }
        //Displaying the available stocks
        private void StockAvailableButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter OutputFile = File.CreateText("AvailableStockData.txt");
                DateTime getdate = DateTime.Now;
                OutputFile.WriteLine("Available Stock Report for Management\nTime Stamp --- " + getdate);
                for (int z = 0; z <= 4; z++) { OutputFile.Write("\t" + CategoryofWatch[z]+ "\t"); }
                for (int x = 0; x <= 12; x++)
                {
                    OutputFile.WriteLine();
                    OutputFile.Write(Watches[x]);
                    for (int y = 0; y <= 4; y++)
                    {
                        OutputFile.Write("\t" + LiveStockData[x, y].ToString() + "\t");
                    }
                }
                OutputFile.Close();
                StockAvailability StockDetails = new StockAvailability();
                StockDetails.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Unable to Generate Existing Stock details file\nContact your Manager\n" + ex); }
        }
        public void InputAllOrderDetailsintoList()
        {
            try
            {
                StreamReader InputFile = File.OpenText("orderdetails.txt");
                while (!InputFile.EndOfStream)
                {
                    SearchOrderDetails.OrderDetails.Add(InputFile.ReadLine());
                }
                InputFile.Close();
            }
            catch (Exception ex) { MessageBox.Show("Order Details file is missing\ncontact manager\n" + ex); }
        
        }
    }
    }