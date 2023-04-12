namespace DenverLibrary.UnitTests
{
    public class LibraryTests
    {
        [Fact]
        public void Constructor_WhenInstantiated_SetsPropertyValues()
        {
            Library library1 = new Library("Denver");
            Assert.Equal("Denver", library1.Name);
            Assert.Equal(new List<Branch>(), library1.Branches);
        }
    }
}
