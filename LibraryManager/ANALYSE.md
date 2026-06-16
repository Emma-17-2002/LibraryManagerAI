# ANALYSE.md — Analyse du Refactoring et Supervision IA

## PARTIE 4 — Refactoring

### Code original soumis à l'IA
public bool Check(Book b,string t){if(b.Title==t)return true;else return false;Console.WriteLine("ok");}

### Problèmes identifiés

Problème 1 : Les noms b et t ne sont pas clairs
Problème 2 : Le if/else est inutile car une comparaison retourne déjà un booléen
Problème 3 : Console.WriteLine("ok") ne s'exécute jamais, c'est du code mort
Problème 4 : Le nom Check est trop vague
Problème 5 : Pas de documentation XML

### Propositions de l'IA — ACCEPTÉES

✅ Renommer b en book et t en title
Raison : Les noms sont maintenant clairs et compréhensibles.

✅ Remplacer le if/else par return book.Title == title
Raison : Plus simple, même résultat, code plus lisible.

✅ Supprimer Console.WriteLine("ok")
Raison : Cette ligne est après un return, elle ne s'exécute jamais.

✅ Renommer Check en IsTitleMatching
Raison : Le nom décrit exactement ce que fait la méthode.

✅ Ajouter la documentation XML
Raison : Obligatoire pour la maintenabilité du code.

### Code final après refactoring
/// <summary>
/// Vérifie si le titre d'un livre correspond au titre recherché.
/// </summary>
/// <param name="book">Le livre à vérifier.</param>
/// <param name="title">Le titre à comparer.</param>
/// <returns>True si le titre correspond, False sinon.</returns>
public bool IsTitleMatching(Book book, string title)
{
    return book.Title == title;
}

---

## PARTIE 6 — Supervision du Code IA

### Code analysé
string query = $"SELECT * FROM Books WHERE Title='{title}'";

### Faille identifiée : INJECTION SQL
Ce code est dangereux. Un utilisateur malveillant peut écrire dans title :
' OR '1'='1
Et la requête devient :
SELECT * FROM Books WHERE Title='' OR '1'='1'
Ce qui retourne tous les livres de la base de données sans restriction.

### Code corrigé
string query = "SELECT * FROM Books WHERE Title = @title";
cmd.Parameters.AddWithValue("@title", title);

### Explication
Le paramètre @title est traité comme une simple donnée et non comme du code SQL.
L'injection SQL devient donc impossible avec cette correction.