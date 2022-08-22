global using Xunit;
using NuGet.Frameworks;
using Xunit.Abstractions;

namespace CheckoutKataTest.UnitTests
{
    public class CheckoutServiceTests
    {
        [Fact]

        public void Test_ItemAPurchased()
        {
            // Arrange
            var checkout = new CheckoutService();
            var items = "A";
            int totalPrice = 0;
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i].ToString());
            }

            // Act
            totalPrice = checkout.GetTotal();
            
            // Assert
            Assert.Equal(50, totalPrice);
        }

        [Fact]

        public void Test_ItemAAPurchased()
        {
            // Arrange
            var checkout = new CheckoutService();
            var items = "AA";
            int totalPrice = 0;
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i].ToString());
            }

            // Act
            totalPrice = checkout.GetTotal();

            // Assert
            Assert.Equal(100, totalPrice);
        }

        [Fact]

        public void Test_ItemASpecialPurchased()
        {   
            // Arrange
            var checkout = new CheckoutService();
            var items = "AAA";
            int totalPrice = 0;
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i].ToString());
            }

            // Act
            totalPrice = checkout.GetTotal();

            // Assert    
            Assert.Equal(130, totalPrice);
        }

        [Fact]

        public void Test_ItemBSpecialPurchased()
        {
            // Arrange
            var checkout = new CheckoutService();
            var items = "BB";
            int totalPrice = 0;
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i].ToString());
            }

            // Act
            totalPrice = checkout.GetTotal();

            // Assert
            Assert.Equal(45, totalPrice);
        }


        [Fact]

        public void Test_ItemAnyOrderPurchased()
        {
            // Arrange
            var checkout = new CheckoutService();
            var items = "BAB";
            int totalPrice = 0;
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i].ToString());

            }

            // Act
            totalPrice = checkout.GetTotal();

            // Assert
            Assert.Equal(95, totalPrice);

        }

        [Fact]

        public void Test_ItemMultiSpecialPurchased()
        {
            // Arrange
            var checkout = new CheckoutService();
            var items = "BBBB";
            int totalPrice = 0;
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i].ToString());

            }

            // Act
            totalPrice = checkout.GetTotal();

            // Assert
            Assert.Equal(90, totalPrice);
        }

        [Fact]
        public void Test_AllItemPurchased()
        {
            // Arrange
            var checkout = new CheckoutService();
            var items = "ABCD";
            int totalPrice = 0;
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i].ToString());
            }

            // Act
            totalPrice = checkout.GetTotal();

            // Assert
            Assert.Equal(115, totalPrice);
        }

        [Fact]

        public void Test_AnyOrderItemMultiSpecialPurchased()
        {

            // Arrange
            var checkout = new CheckoutService();
            var items = "AABBBBAACCD";
            int totalPrice = 0;
            for (int i = 0; i < items.Length; i++)
            {
                checkout.Scan(items[i].ToString());
            }

            // Act
            totalPrice = checkout.GetTotal();

            // Assert
            Assert.Equal(325, totalPrice);
        }

       
    }
}