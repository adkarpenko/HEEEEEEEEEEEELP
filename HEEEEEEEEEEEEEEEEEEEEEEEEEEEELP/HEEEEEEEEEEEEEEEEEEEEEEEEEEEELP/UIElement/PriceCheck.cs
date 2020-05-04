using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HEEEEEEEEEEEEEEEEEEEEEEEEEEEELP.UIElement
{
    public class PriceCheck : IEnumerable
    {
        public PriceCheck(string price, string fiscalNumber, string fiscalDocument, string fiscalSign, string n, string date)
        {

            Price = price;
            FiscalNumber = fiscalNumber;
            FiscalDocument = fiscalDocument;
            FiscalSign = fiscalSign;
            N = n;
            Date = date;

        }

        private string price;
        private string fiscalNumber;
        private string fiscalDocument;
        private string fiscalSign;
        private string n;
        private string date;



        public string Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                   
                }
            }
        }
        public string FiscalNumber
        {
            get { return fiscalNumber; }
            set
            {
                if (fiscalNumber != value)
                {
                    fiscalNumber = value;
                  
                }
            }
        }
        public string FiscalDocument
        {
            get { return fiscalDocument; }
            set
            {
                if (fiscalDocument != value)
                {
                    fiscalDocument = value;
                   
                }
            }
        }

        public string FiscalSign
        {
            get { return fiscalSign; }
            set
            {
                if (fiscalSign != value)
                {
                    fiscalSign = value;
                    
                }
            }
        }

        public string N
        {
            get { return n; }
            set
            {
                if (n != value)
                {
                    n = value;
                   
                }
            }
        }

        public string Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                   
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return price.GetEnumerator();
        }
    }
}
