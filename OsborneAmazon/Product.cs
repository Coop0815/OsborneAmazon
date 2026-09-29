using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsborneAmazon
{
    public class Product
    {
        private readonly DateTime _dateAdded
            ;
        private readonly string _productID; 
        public Product() {
            _dateAdded=DateTime.Now;
        
        }

        public DateTime DateAdded => DateAdded;
        public required string ProductID { get; init; }
        private string _ProductName;
        public string ProductName
        { get
            {
                return _ProductName;
            }

            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    
                    throw new ArgumentException("Product Name Cannot be empty.");

                    _ProductName = value;
                }
               
            }
            
            
            }

        public string ProductDescription { get; set; } = "";

        public string ProductMaterial { get; set; } = "";

        public string ProductColor { get; set; } = "";

        public string DisplayProductInfo()
        {
            return $"Product ID: {ProductID}\nProduct Name: {ProductName}\nDescription: {ProductDescription}\nMaterial: {ProductMaterial}\nColor: {ProductColor}\nDate Added: {_dateAdded}";
        }

    }
}
