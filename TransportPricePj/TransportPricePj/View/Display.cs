using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TransportPricePj.View
{
    public class Display
    {
        public Display()
        {
            this.Km = 0;
            this.Time = "";
            this.TotalPrice = 0;
            this.GetValues();
        }
        public double Km { get; set; }
        public string Time { get; set; }
        public double TotalPrice { get; set; }
        public void GetValues()
        {
            Console.WriteLine("Enter km:");
            this.Km=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time of the day:");
            this.Time = Console.ReadLine();
        }
        public void ShowPrice()
        {
            Console.WriteLine($"The cheapest price is: {this.TotalPrice:f2}");
            }
    }
}
