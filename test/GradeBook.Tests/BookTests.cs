namespace GradeBook.Tests;
using Xunit;
public class BookTests
{
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
        // arrange
        var book = new Book("");
        book.AddGrade(89.1);
        book.AddGrade(98.5);
        book.AddGrade(77.3);

        // act
        var result = book.GetStats();
        
        // assert
        Assert.Equal(result.ToString(), book.GetStats().ToString());
    }

    [Fact]
    public void CanNotAddInvalidGrade()
    {
        var book = new Book("");
        Assert.Throws<Exception>(() => book.AddGrade(-1));
    }
}