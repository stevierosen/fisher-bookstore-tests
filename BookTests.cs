using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Tests
{
    public class BookTests
    {
        [Fact]
        public void TestMemberDiscount()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "My Test Book",
                Price = 9.99
            } ;

            //Act
            book.ApplyMemberDiscount();

            //Assert
            var discountPrice = 9.99 * .9;
            Assert.Equal(discountPrice, book.Price);

        }
    }
}
