using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegularExam_UASD
{
    public class CoffeeShop
    {
        private string name;
        private List<Coffee> coffees;

        public CoffeeShop()
        {

        }

        public CoffeeShop(string name)
        {
            this.Name = name;
            this.coffees = new List<Coffee>();
        }



        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public List<Coffee> Coffees
        {

            get { return coffees; }
            set { coffees = value; }

        }

        public void AddCoffee(string type, double price)
        {
            Coffee coffee = new Coffee(type, price);
            coffees.Add(coffee);

        }

        public double AveragePriceInRange(double start, double end)
        {
            double sum = 0;
            int num = 0;
            foreach (Coffee coffee in coffees)
            {
                if (coffee.Price >= start && coffee.Price <= end)
                {
                    sum += coffee.Price;
                    num++;
                }
            }
            if (num == 0)
            {
                return 0.0;
            }
            return sum / num;

        }

        public List<string> FilterCoffeesByPrice(double price)
        {
            List<string> filtered = new List<string>();
            foreach (Coffee product in coffees)
            {
                if (product.Price < price)
                {
                    filtered.Add(product.Type);
                }
            }
            return filtered;
        }

        public List<Coffee> SortAscendingByType()
        {
            List<Coffee> sortedCoffee = coffees
                .OrderBy(p => p.Type)
                .ToList();
            coffees.Clear();
            coffees = sortedCoffee;
            return coffees;

        }

        public List<Coffee> SortDescendingByPrice()
        {
            List<Coffee> sortedCoffee = coffees
               .OrderByDescending(p => p.Price)
               .ToList();
            coffees.Clear();
            coffees = sortedCoffee;
            return coffees;
        }

        public bool CheckCoffeeIsInCoffeeShop(string type)
        {
            foreach (Coffee coffee in coffees)
            {
                if (coffee.Type == type)
                {
                    return true;
                }
            }
            return false;

        }

        public string[] ProvideInformationAboutAllCoffees()
        {
            string[] info = new string[coffees.Count];
            for (int i = 0; i < coffees.Count; i++)
            {
                info[i] = coffees[i].ToString();
            }
            return info;
        }
    }
}
