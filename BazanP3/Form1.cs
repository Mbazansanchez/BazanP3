using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BazanP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void RadMug_CheckedChanged(object sender, EventArgs e)
        {

        }
     

        private void TxbNumItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbPrint_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            LogoOrderItem Order = new LogoOrderItem(TxbPrint.Text, CBLogo.Checked);

         
            
            try
            {
                Order.NumItems = Int32.Parse(TxbNumItems.Text);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error " + exc.Message + "\nException type: " +
                    exc.GetType());
            }

            if (CBLogo.Checked == true)
            {
                string NumberofColors = TxbNumColor.Text;
                Order.NumColors = Int32.Parse(NumberofColors);
            } else
            {
                Order.NumColors = 0;
            }

            string Item = "";
           
            if(RadUSBStick.Checked)
            {
                Item = RadUSBStick.Text;
                
                
            } 
            else if (RadMug.Checked)
            {
                Item = RadMug.Text;
            } 
            else if (RadPen.Checked)
            {
                Item = RadPen.Text;
            }
            Order.ItemType = Item;

            Order.TxT = TxbPrint.Text;
            string Sum = Order.GetOrderSummary();

            if (TxbNumItems.Text == "")
            {
                MessageBox.Show("Please enter in the amount of Items");
                return;
            }
            else if (TxbPrint.Text == "")
            {
                MessageBox.Show("Please enter in the text you would like engraved/printed");
                return;
            }
            else if (Item == "")
            {
                MessageBox.Show("Please select an Item type Option.");
            }
            else
            {
                TxbOrderSummary.Text = Sum;
            }

           


        }

        private void TxbOrderSummary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxbNumColor_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CBLogo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBLogo.Checked == true)
            {
                TxbNumColor.Enabled = true;
            } else
            {
                TxbNumColor.Enabled = false;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxbNumColor.Clear();
            TxbNumItems.Clear();
            TxbPrint.Clear();
            RadMug.Checked = false;
            RadUSBStick.Checked = false;
            RadPen.Checked = false;
            CBLogo.Checked = false;
        }
    }


    class LogoOrderItem
    {
        private const string DefaultItem = "Mug";
        private const int DefaultItemAmt = 0;
        private const int DefaultColorsAmt = 0;
        private const string DefaultText = "TBD";
        private const bool DefaultLogoValue = false;
        private bool _HasLogo;
        public bool HasLogo;
        public bool Logo
        {
            get { return _HasLogo; }
            set { _HasLogo = value; }
        }

        private string _ItemType;
        public string ItemType;
        public string TypeItem
        {
            get { return _ItemType; }
            set { _ItemType = value; }
        }

        private int _NumColors;
        public int NumColors;
        public int ColorNum
        {
            get { return _NumColors; }
            set { _NumColors = value; }
        }

        private int _NumItems;
        public int NumItems;
        public int ItemAmnt
        {
            get { return _NumItems; }
            set { _NumItems = value; }
        }


        private string _Text;
        public string Text;
        public string TxT
        {
            get { return _Text; }
            set { _Text = value; }
        }

       public double Cost;
        readonly decimal TotalCost;

        public LogoOrderItem()
            : this(DefaultLogoValue, DefaultItem, DefaultColorsAmt, DefaultItemAmt, DefaultText)
        {

        }

        public LogoOrderItem(string text, bool logo)
            : this(logo, DefaultItem, DefaultColorsAmt, DefaultItemAmt, text)
        {

        }

        public LogoOrderItem(bool logo, string Item, int ColorsAmt, int ItemAmt, string text)

        {
            this.HasLogo = logo;
            this.ItemType = Item;
            this.NumColors = ColorsAmt;
            this.NumItems = ItemAmt;
            this.Text = text;
        }

        private void Calc()
        {
            
            //* by the amount of items.
            double textprice = 0.05 * NumItems;
            
            double colorprice = NumColors * 0.03;
            // color price is = 3 cents times number of colors * Number of items.
            //total price is = to base price plus text price plus logoprice + colors.


            double baseprice;
            
            if (ItemType == "Mug")
            {
                
                baseprice = 3.50;
            } else if (ItemType == "Pen")
            {
                baseprice = 1.00;

            } else if (ItemType == "USB")
            {
                baseprice = 4.00;
            }
            else
            {
               baseprice = 0;
            }
            double BasePriceCost = baseprice * NumItems;

            double LogoPrice = 0;
            if (HasLogo == true)
            {
                LogoPrice = 0.10;
            } 
            else
            {
                LogoPrice = 0;
            }


            Cost = textprice + LogoPrice + colorprice + BasePriceCost;


        }

        public string GetOrderSummary()
        {
            Calc();
            string Summary;
            if (HasLogo == false)
            {
                Summary = "The cost of " + NumItems + " " + ItemType + "'s " + "  with the following " +
                    "text: " + TxT + " Will Cost " + Cost.ToString("C", CultureInfo.CurrentCulture);
            } else 
            {
                Summary = "The cost of " + NumItems + " " + ItemType + "'s " + " with a " + NumColors + " color logo, with the following " +
                   "text: " + TxT + " Will Cost " + Cost.ToString("C", CultureInfo.CurrentCulture);
            }
            return Summary;
        }
        

   

    }
}
