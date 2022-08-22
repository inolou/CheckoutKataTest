using System.ComponentModel.DataAnnotations;
using CheckoutKataTest.Interfaces;
using CheckoutKataTest.Models;

namespace CheckoutKataTest
{
    internal class CheckoutService : ICheckoutService
    {
        private readonly Dictionary<string, int> _skuItemUnitPrices;
        private readonly Dictionary<string, int> _noOfSpecialPriceItems;
        private readonly DiscountRule _itemADiscountRule;
        private readonly DiscountRule _itemBDiscountRule;

        public CheckoutService()
        {
            _skuItemUnitPrices = new Dictionary<string, int>()
            {
                { "A", 50 },
                { "B", 30 },
                { "C", 20 },
                { "D", 15 }
            };

            _noOfSpecialPriceItems = new Dictionary<string, int>()
            {
                { "A", 0 },
                { "B", 0 },
                { "C", 0 },
                { "D", 0 }
            };

            _itemADiscountRule = new DiscountRule
            {
                Item = "A",
                Count = 3,
                Discount = 20
            };

            _itemBDiscountRule = new DiscountRule
            {
                Item = "B",
                Count = 2,
                Discount = 15
            };
        }

        public int Total { get; set; }

        internal int GetTotal()
        {
            return Total;
        }

        internal void Scan(string item)
        {
            _noOfSpecialPriceItems[item]++;
            CalculateTotal(item);
        }

        internal void CalculateTotal(string item)
        {
            Total += _skuItemUnitPrices[item];
            Total -= GetDiscount(item);
        }
        internal int GetDiscount(string item)
        {
            if (_itemADiscountRule.Item == item && _noOfSpecialPriceItems[item] % _itemADiscountRule.Count == 0 && _noOfSpecialPriceItems[item] != 1)
                return _itemADiscountRule.Discount;

            if (_itemBDiscountRule.Item == item && _noOfSpecialPriceItems[item] % _itemBDiscountRule.Count == 0 && _noOfSpecialPriceItems[item] != 1)
                return _itemBDiscountRule.Discount;

            return 0;
        }
    }
}