namespace GradeBook.Tests;
using Xunit;
public class BookTests
{
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
        // arrange
        var book = new InMemoryBook("");
        book.AddGrade(89.1);
        book.AddGrade(98.5);
        book.AddGrade(77.3);

        // act
        var result = book.GetStats();
        
        // assert
        Assert.Equal(result.ToString(), book.GetStats().ToString());
        Assert.Equal('B', result.Letter);
    }

    [Fact]
    public void CanNotAddInvalidGrade()
    {
        var book = new InMemoryBook("");
        Assert.Throws<ArgumentException>(() => book.AddGrade(-1));
    }

}