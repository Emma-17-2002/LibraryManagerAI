# LibraryManagerAI

Application de gestion de bibliothèque développée en C# avec l'assistance d'une intelligence artificielle dans le cadre d'un projet académique.

## Objectif

Cette application permet :

* d'ajouter des livres à une bibliothèque ;
* d'afficher tous les livres enregistrés ;
* d'afficher uniquement les livres disponibles ;
* de compter le nombre de livres disponibles.

## Technologies utilisées

* C# (.NET 8.0)
* Visual Studio 2022
* Git / GitHub
* xUnit (tests unitaires)

## Structure du projet

```text
LibraryManagerAI
│
├── Program.cs
├── Book.cs
├── LibraryService.cs
├── README.md
├── PROMPTS.md
├── ANALYSE.md
└── tests
```

## Description des fichiers

* **Book.cs** : modèle représentant un livre.
* **LibraryService.cs** : service de gestion des livres.
* **Program.cs** : point d'entrée de l'application.
* **PROMPTS.md** : historique des prompts utilisés avec l'IA.
* **ANALYSE.md** : analyse critique des propositions de l'IA.

## Exécution

1. Ouvrir le projet dans Visual Studio 2022.
2. Compiler la solution.
3. Appuyer sur **F5** pour lancer l'application.

## Auteur

Projet réalisé avec l'assistance d'une intelligence artificielle et supervisé par l'étudiant.

## Tests unitaires

Des tests xUnit ont été préparés pour :

- GetDescription()
- CountAvailableBooks()

Les tests couvrent un cas normal et un cas limite.