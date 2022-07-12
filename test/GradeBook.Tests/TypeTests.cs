namespace GradeBook.Tests;

using System;
using Xunit;

public delegate string WriteLogDelegate(string logMessage);

public class TypeTests
{

    int count = 0;
    [Fact]
    public void WriteLogDelegateCanPointToMethod()
    {
        WriteLogDelegate log = ReturnMessage;
        log += ReturnMessage;
        log+= ReturnMessage1;
        var result = log("Hello");
        Assert.Equal(3, count);
    }

    string ReturnMessage(string message){
        count++;
        return message;
    }

    string ReturnMessage1(string message){
        count++;
        return message.ToUpper();
    }

    [Fact]
    public void StringsBehaveLikeValueTypes()
    {
        string name = "Michael";
        string upper = MakeUppercase(name);
        Assert.Equal("Michael", name);
        Assert.Equal("MICHAEL", upper);

    }

    private string MakeUppercase(string name)
    {
        return name.ToUpper();
    }

    [Fact]
    public void ValueTypesPassByValue()
    {
        var x = GetInt();
        SetInt(x);
        Assert.Equal(3, x);
    }

    private void SetInt(int x)
    {
        x = 10;
    }

    [Fact]
    public void ValueTypesCanPassByRef()
    {
        var x = GetInt();
        SetInt(ref x);
        Assert.Equal(10, x);
    }

    private void SetInt(ref int x)
    {
        x = 10;
    }

    private int GetInt()
    {
        return 3;
    }

    [Fact]
    public void GetBookReturnsDifferentObject()
    {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
    }

    [Fact]
    public void TwoVariablesCanReferenceSameObj()
    {
        var book1 = GetBook("Book 1");
        var book2 = book1;

        Assert.Same(book1, book2);
    }

    private Book GetBook(string name)
    {
        return new Book(name);
    }
}