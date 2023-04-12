namespace DenverLibrary.UnitTests
{
    public class BookTests
    {
        [Fact]
        public void Constructor_WhenInstantiated_SetsPropertyValues()
        {
            Book book1 = new Book("Harry Potter", "J.K. Rowling");
            Assert.Equal("Harry Potter", book1.Title);
            Assert.Equal("J.K. Rowling", book1.Author);
        }
    }
}