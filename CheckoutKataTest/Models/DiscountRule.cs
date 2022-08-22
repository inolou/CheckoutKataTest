using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutKataTest.Interfaces;
using static CheckoutKataTest.Models.DiscountRule;

namespace CheckoutKataTest.Models
{

    public class DiscountRule : IDiscountRule
    {
        public string Item { get; set; }
        public int Discount { get; set; }
        public int Count { get; set; }


    }
}