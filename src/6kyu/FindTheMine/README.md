# 💣 Find the Mine!

![Codewars](https://img.shields.io/badge/Codewars-6kyu-yellow)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Vous venez de découvrir un **terrain carré (NxN)** et vous remarquez un panneau d’avertissement indiquant qu’**une bombe est cachée dans la grille**.

Le terrain est représenté par **un tableau bidimensionnel (2D)** :

- `1` représente **l’emplacement de la mine**
- `0` représente **une zone sans mine**

Votre objectif est d’écrire une fonction qui **localise la mine dans la grille** et retourne **ses coordonnées**.

🔗 **Kata Codewars** - [Find the Mine!](https://www.codewars.com/kata/528d9adf0e03778b9e00067e)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **un tableau 2D carré (NxN)** d'entiers
- La grille contient :
  - `0` → zone sans mine
  - `1` → emplacement de la mine
- Il y a **une seule mine dans toute la grille**
- Retourner **les coordonnées de la mine**

Les coordonnées doivent être retournées sous forme :

```

(row, column)

```

avec :

- `row` → index de la ligne
- `column` → index de la colonne

Les index sont **basés sur 0**.

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à **parcourir la grille ligne par ligne et colonne par colonne**.

Conceptuellement :

```

pour chaque ligne
pour chaque colonne
si valeur == 1
retourner (ligne, colonne)

```

Dès que la mine est trouvée, on retourne **ses coordonnées**.

<p align="center">• • •</p>

## 🔎 Exemples

| Grille | Résultat |
|------|----------|
| `[ [1,0,0], [0,0,0], [0,0,0] ]` | `[0,0]` |
| `[ [0,0,0], [0,1,0], [0,0,0] ]` | `[1,1]` |
| `[ [0,0,0], [0,0,0], [0,1,0] ]` | `[2,1]` |

Exemple visuel :

```

0 0 0
0 1 0
0 0 0

```

La mine se trouve à la position :

```

(1,1)

```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/6kyu/FindTheMine.Tests/)

Les tests couvrent notamment :

- la **détection correcte de la mine**
- différentes **positions possibles dans la grille**
- des **grilles de tailles différentes**
- plusieurs **tests automatiques**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **une grille 2D NxN**
- **trouver la cellule contenant la valeur `1`**
- retourner **les coordonnées `(ligne, colonne)` de la mine**

Exemple :

```

[ [0,0,0],
[0,1,0],
[0,0,0] ]

```

Résultat :

```

(1,1)

```
