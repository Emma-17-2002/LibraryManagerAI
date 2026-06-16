using LibraryManagerAI;

LibraryService library = new();

library.AddBook(new Book
{
    Id = 1,
    Title = "Clean Code",
    Author = "Robert Martin",
    Year = 2008,
    Available = true
});

library.AddBook(new Book
{
    Id = 2,
    Title = "The Pragmatic Programmer",
    Author = "Andy Hunt",
    Year = 1999,
    Available = false
});

library.AddBook(new Book
{
    Id = 3,
    Title = "C# in Depth",
    Author = "Jon Skeet",
    Year = 2019,
    Available = true
});

Console.WriteLine("=== TOUS LES LIVRES ===");

foreach (Book book in library.GetBooks())
{
    Console.WriteLine(book.GetDescription());
}

Console.WriteLine("\n=== LIVRES DISPONIBLES ===");

foreach (Book book in library.GetAvailableBooks())
{
    Console.WriteLine(book.GetDescription());
}

Console.WriteLine($"\nNombre de livres disponibles : {library.CountAvailableBooks()}");

Console.ReadKey();