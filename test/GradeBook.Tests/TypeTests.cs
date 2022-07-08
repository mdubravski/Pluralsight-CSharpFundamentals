namespace GradeBook.Tests;

using System;
using Xunit;
public class TypeTests
{
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
    public void CSharpCanPassByRef()
    {
        var book1 = GetBook("Book 1");
        GetBookSetName(ref book1, "New Name");

        Assert.Equal("New Name", book1.Name);
    }

    [Fact]
    public void CSharpIsPassByValue()
    {
        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name");

        Assert.Equal("Book 1", book1.Name);
    }

    [Fact]
    public void CanSetNameByReference()
    {
        var book1 = GetBook("Book 1");
        SetName(book1, "New Name");

        Assert.Equal("New Name", book1.Name);
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

    private void SetName(Book book, string newName)
    {
        book.Name(newName);
    }

    private void GetBookSetName(Book book, string newName)
    {
        book = new Book(newName);
        book.Name = newName;
    }

    private void GetBookSetName(ref Book book, string newName)
    {
        book = new Book(newName);
        book.Name = newName;
    }

}