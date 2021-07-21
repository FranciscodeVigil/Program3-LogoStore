using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3_LogoStore
{
    class LogoOrderItem
    {
        private bool hasLogo;
        public bool HasLogo
        {
            get { return hasLogo; }
            set { hasLogo = value; Calc(); }
        }

        private string itemType;
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; Calc(); }
        }

        private int numColors;
        public int NumColors
        {
            get { return numColors; }
            set { numColors = value; Calc(); }
        }

        private int numItems;
        public int NumItems
        {
            get { return numItems; }
            set { numItems = value; Calc(); }
        }

        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; Calc(); }
        }

        //5 parameter constructor
        public LogoOrderItem(bool hasLogo, string itemType, int numColors, int numItems, string text)
        {
            this.HasLogo = hasLogo;
            this.ItemType = itemType;
            this.NumColors = numColors;
            this.NumItems = numItems;
            this.Text = text;
        }
        //2 parameter constructor
        public LogoOrderItem(bool hasLogo, string text) : this( hasLogo, "mug", 0, 0, text)
        {
        }

        //no parameter constructor
        public LogoOrderItem() : this(false,"Mug", 0, 0, "")
        {
        }

        static decimal rate;

        //Calc uses just adss to a general price per item then mulitplies it by the number of items
        private void Calc()
        {
            switch (ItemType)
            {
                case "Pen":
                    rate = 1.00M;
                    break;
                case "Mug":
                    rate = 3.50M;
                    break;

                case "USB":
                    rate = 4.00M;
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            if (hasLogo == true)
            {
                rate += 0.10m;
            }
            if (text != "")
            {
                rate += 0.05m;
            }
            if (this.numColors >= 0)
            {
                rate += (0.03m * numColors);
            }
            totalPrice = (rate * NumItems);
        }

        // i wasn't super sure how to do this with a read-only variable
        private decimal totalPrice { get; set; }
        //One summury if it has a Logo and one if it doesn't
        public string GetOrderSummary()
        {
            if (hasLogo == true)
            { 
                return ("Your order is " + this.NumItems + " " + this.ItemType + "(s) with a " + this.NumColors + " color logo with the following text: "  + this.Text  + " Price: " + this.totalPrice );
                }
            else
            {
                return ("Your order is " + this.NumItems + " " + this.ItemType + "(s) with no logo with the following text: "  + this.Text  + " Price: " + this.totalPrice );
            }
        }
    }
}
