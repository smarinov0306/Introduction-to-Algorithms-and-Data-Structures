using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegularExam_UASD
{
    public class Coffee
    {
        private string type;
        private double price;

        public Coffee()
        {

        }

        public Coffee(string type, double price)
        {
            this.Type = type;
            this.Price = price;
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public override string ToString()
        {
            return $"Coffee {Type} costs {Price:F2} lv.";
        }

    }
}
