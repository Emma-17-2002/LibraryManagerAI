namespace LibraryManagerAI
{
    /// <summary>
    /// Représente un livre dans la bibliothèque.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Identifiant unique du livre.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Titre du livre.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Auteur du livre.
        /// </summary>
        public string Author { get; set; } = string.Empty;

        /// <summary>
        /// Année de publication.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Indique si le livre est disponible.
        /// </summary>
        public bool Available { get; set; }

        /// <summary>
        /// Retourne une description complète du livre.
        /// </summary>
        /// <returns>Description formatée du livre.</returns>
        public string GetDescription()
        {
            string availability = Available ? "Disponible" : "Non disponible";

            return $"[{Id}] \"{Title}\" par {Author} ({Year}) - {availability}";
        }
    }
}