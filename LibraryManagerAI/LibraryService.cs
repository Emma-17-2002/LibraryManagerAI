namespace LibraryManagerAI
{
    /// <summary>
    /// Service de gestion des livres de la bibliothèque.
    /// </summary>
    public class LibraryService
    {
        private readonly List<Book> _books = new();

        /// <summary>
        /// Ajoute un livre à la bibliothèque.
        /// </summary>
        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            _books.Add(book);
        }

        /// <summary>
        /// Retourne tous les livres.
        /// </summary>
        public List<Book> GetBooks()
        {
            return _books;
        }

        /// <summary>
        /// Retourne uniquement les livres disponibles.
        /// </summary>
        public List<Book> GetAvailableBooks()
        {
            return _books.Where(book => book.Available).ToList();
        }

        /// <summary>
        /// Compte le nombre de livres disponibles.
        /// </summary>
        public int CountAvailableBooks()
        {
            return _books.Count(book => book.Available);
        }

        /// <summary>
        /// Vérifie si le titre correspond au livre recherché.
        /// </summary>
        public bool IsTitleMatching(Book book, string title)
        {
            return book != null &&
                   string.Equals(
                       book.Title,
                       title,
                       StringComparison.OrdinalIgnoreCase);
        }
    }
}