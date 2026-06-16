# PROMPTS.md — Prompts utilisés avec l'IA

## Prompt 1 — Classe Book
Rôle : Tu es un développeur C# senior.
Contexte : Je crée une application de gestion de bibliothèque en C#.
Tâche : Génère une classe Book avec les propriétés Id, Title, Author, Year, Available et une méthode GetDescription().
Contraintes : Documentation XML obligatoire, respecter les conventions C#.
Résultat attendu : Un fichier Book.cs complet et fonctionnel.

## Prompt 2 — LibraryService
Rôle : Tu es un développeur C# expert.
Contexte : J'ai une classe Book dans mon projet de bibliothèque.
Tâche : Crée une classe LibraryService avec les méthodes AddBook(), GetBooks(), GetAvailableBooks() et CountAvailableBooks().
Contraintes : Utiliser une List<Book> en mémoire, documentation XML sur chaque méthode.
Résultat attendu : Un fichier LibraryService.cs complet.

## Prompt 3 — Refactoring
Rôle : Tu es expert en qualité de code C#.
Contexte : J'ai une méthode mal écrite dans mon projet.
Tâche : Refactorise ce code :
public bool Check(Book b,string t){if(b.Title==t)return true;else return false;Console.WriteLine("ok");}
Contraintes : Garder la même logique, ajouter documentation XML, respecter les conventions C#.
Résultat attendu : Méthode propre avec explication de chaque changement.

## Prompt 4 — Tests unitaires
Rôle : Tu es expert en tests unitaires C# avec xUnit.
Contexte : Je dois tester GetDescription() et CountAvailableBooks().
Tâche : Génère des tests unitaires avec un cas normal et un cas limite pour chaque méthode.
Contraintes : Utiliser xUnit, nommer les tests de façon descriptive.
Résultat attendu : Un fichier de tests complet et fonctionnel.