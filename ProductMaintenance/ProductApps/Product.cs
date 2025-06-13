using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal totalCharge;
        private decimal totalWrap;
        private decimal totalGST;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        
        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }
        

        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        public decimal TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; }
        }

        public decimal TotalWrap
        {
            get { return totalWrap; }
            set { totalWrap = value; }
        }

        public decimal TotalGST
        {
            get { return totalGST; }
            set { totalGST = value; }
        }
        
        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        public void calTotalCharge()
            
        {

            TotalCharge = TotalPayment + 25;
        }
        
        public void calTotalWrapCharge()
        {
            TotalWrap = TotalPayment + 25 + 5;
        }
        
        public void calGST()
        {
            TotalGST = ((TotalPayment + 25 + 5) / 100) * 110;
        }
       
        
    }
}
