namespace CheckoutKataTest.Interfaces
{
    public interface IDiscountRule
    {
        int Count { get; set; }
        int Discount { get; set; }
        string Item { get; set; }
    }
}