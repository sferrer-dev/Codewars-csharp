# ✅ Validate Sudoku with size `NxN`

![Codewars](https://img.shields.io/badge/Codewars-4kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une méthode capable de **valider une grille de Sudoku de taille `NxN`**.

La grille est représentée par une structure de données à deux dimensions.
La méthode doit vérifier si la grille est **correctement remplie** en respectant toutes les règles du Sudoku.

🔗 **Kata Codewars** - [Validate Sudoku with size NxN](https://www.codewars.com/kata/540afbe2dc9f615d5e000425)

<p align="center">• • •</p>

## ⚙️ Règles de validation

Une grille est considérée comme valide si **toutes** les conditions suivantes sont respectées :

* la dimension de la grille est de type **`NxN`**
* **`N > 0`**
* **`√N` est un entier**
* chaque **ligne** contient uniquement les entiers de **`1` à `N`**, une seule fois chacun
* chaque **colonne** contient uniquement les entiers de **`1` à `N`**, une seule fois chacun
* chaque **sous-grille** (ou *little square*) contient uniquement les entiers de **`1` à `N`**, une seule fois chacun

Autrement dit, aucune ligne, aucune colonne et aucune sous-grille ne doit :

* contenir de doublon
* contenir de valeur manquante
* contenir de valeur hors de l’intervalle `1..N`

<p align="center">• • •</p>

## 🧠 Principe

Pour valider une grille Sudoku générique de taille `NxN`, il faut contrôler trois axes :

1. **Les lignes**
2. **Les colonnes**
3. **Les sous-grilles carrées**

La taille d’une sous-grille est :

```text
tailleSousGrille = √N
```

Exemples :

* pour une grille `4x4`, les sous-grilles sont en `2x2`
* pour une grille `9x9`, les sous-grilles sont en `3x3`
* pour une grille `16x16`, les sous-grilles sont en `4x4`

L’idée générale consiste à vérifier que chaque ensemble inspecté contient exactement les valeurs attendues de `1` à `N`.

<p align="center">• • •</p>

## 🧩 Exemple de grille valide `9x9`

```text
[
  [7,8,4, 1,5,9, 3,2,6],
  [5,3,9, 6,7,2, 8,4,1],
  [6,1,2, 4,3,8, 7,5,9],

  [9,2,8, 7,1,5, 4,6,3],
  [3,5,7, 8,4,6, 1,9,2],
  [4,6,1, 9,2,3, 5,8,7],

  [8,7,6, 3,9,4, 2,1,5],
  [2,4,3, 5,6,1, 9,7,8],
  [1,9,5, 2,8,7, 6,3,4]
]
```

Cette grille est valide car :

* chaque ligne contient les nombres de `1` à `9`
* chaque colonne contient les nombres de `1` à `9`
* chaque sous-grille `3x3` contient les nombres de `1` à `9`

<p align="center">• • •</p>

## ❌ Exemples d’erreurs à détecter

Une grille doit être rejetée dans les cas suivants :

* taille invalide, par exemple :

  * grille vide
  * grille non carrée
  * `N` dont la racine carrée n’est pas entière
* présence d’une valeur :

  * égale à `0`
  * négative
  * supérieure à `N`
* doublon dans :

  * une ligne
  * une colonne
  * une sous-grille

<p align="center">• • •</p>

## 🔎 Exemple de stratégie d’implémentation

En C#, une implémentation robuste peut suivre ce flux :

```csharp
1. Vérifier que la grille est carrée et que N > 0
2. Vérifier que Math.Sqrt(N) est un entier
3. Contrôler toutes les lignes
4. Contrôler toutes les colonnes
5. Contrôler toutes les sous-grilles
6. Retourner true si tout est valide, sinon false
```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

* 📁 [Projet de tests NUnit](../../../tests/4kyu/Sudoku.Tests/)

Les tests doivent couvrir notamment :

* une grille valide `4x4`
* une grille valide `9x9`
* une ligne invalide
* une colonne invalide
* une sous-grille invalide
* une valeur hors intervalle `1..N`
* une structure non carrée ou de dimension invalide

<p align="center">• • •</p>

## 🏷️ Catégories

* Arrays
* Puzzles
* Algorithms
* Object-oriented Programming

<p align="center">• • •</p>

## 🧾 Résumé

La méthode doit déterminer si une grille Sudoku de taille `NxN` est **entièrement valide**.

Pour cela, elle doit garantir que :

* la structure respecte une dimension autorisée
* chaque ligne est correcte
* chaque colonne est correcte
* chaque sous-grille est correcte

Le résultat attendu est généralement :

* `true` si la grille respecte toutes les règles
* `false` sinon
