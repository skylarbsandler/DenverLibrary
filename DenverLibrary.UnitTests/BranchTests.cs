namespace DenverLibrary.UnitTests
{
    public class BranchTests
    {
        [Fact]
        public void Constructor_WhenInstantiated_SetsPropertyValues()
        {
            Branch branch1 = new Branch("Ross");
            Assert.Equal("Ross", branch1.Name);
            Assert.Equal(new List<Book>(), branch1.Books);
        }

        [Fact]
        public void Books_GetAdded_ToListofBooks()
        {
            Branch branch1 = new Branch("Ross");
            Book book1 = new Book("Harry Potter", "J.K. Rowling");
            branch1.AddBook(book1);

            Assert.Equal(book1, branch1.Books.First());
        }

        [Fact]
        public void Authors_GetAdded_ToListofAuthors()
        {
            Branch branch1 = new Branch("Ross");
            Book book1 = new Book("Harry Potter", "J.K. Rowling");
            Book book2 = new Book("The Hunger Games", "Suzanne Collins");
            branch1.AddBook(book1);
            branch1.AddBook(book2);

            Assert.Equal(new List<string>() { book1.Author, book2.Author }, branch1.AllAuthors());
        }
    }
}
