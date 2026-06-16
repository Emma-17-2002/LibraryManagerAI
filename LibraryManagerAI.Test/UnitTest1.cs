using LibraryManagerAI;
using Xunit;

namespace LibraryManagerAI.Test;

public class LibraryTests
{
    [Fact]
    public void GetDescription_ShouldContainTitle()
    {
        var book = new Book
        {
            Id = 1,
            Title = "Clean Code",
            Author = "Robert Martin",
            Year = 2008,
            Available = true
        };

        string result = book.GetDescription();

        Assert.Contains("Clean Code", result);
    }

    [Fact]
    public void CountAvailableBooks_NormalCase()
    {
        var service = new LibraryService();

        service.AddBook(new Book { Available = true });
        service.AddBook(new Book { Available = false });
        service.AddBook(new Book { Available = true });

        Assert.Equal(2, service.CountAvailableBooks());
    }

    [Fact]
    public void CountAvailableBooks_EmptyLibrary()
    {
        var service = new LibraryService();

        Assert.Equal(0, service.CountAvailableBooks());
    }
}