# 🔢 Sorting by Bits

![Codewars](https://img.shields.io/badge/Codewars-6kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Dans ce kata, vous devez **trier un tableau d'entiers 32 bits** en fonction du **nombre de bits à `1` dans leur représentation binaire**.

Autrement dit, les nombres sont triés selon le **nombre de bits activés** (appelé aussi *popcount* ou *Hamming weight*).

🔗 **Kata Codewars**  
https://www.codewars.com/kata/59fa8e2646d8433ee200003f

<p align="center">• • •</p>

## ⚙️ Objectif

Écrire une fonction qui :

1. prend en entrée un **tableau d'entiers**
2. trie les valeurs selon :
   - le **nombre de bits à `1`** dans leur représentation binaire
   - puis la **valeur numérique** en cas d'égalité
3. modifie le tableau **directement (tri en place)**

<p align="center">• • •</p>

## 🧠 Principe

Chaque entier peut être représenté en **binaire**.

Exemple :

| Nombre | Représentation binaire | Bits à `1` |
|------|------|------|
| 7 | `000...0111` | 3 |
| 6 | `000...0110` | 2 |
| 15 | `000...1111` | 4 |
| 8 | `000...1000` | 1 |

Le tri doit être effectué en priorité selon le **nombre de bits actifs (`1`)**.

<p align="center">• • •</p>

## 🧩 Exemple

### Entrée

```

[7, 6, 15, 8]

```

### Analyse

```

7  -> 3 bits
6  -> 2 bits
15 -> 4 bits
8  -> 1 bit

```

### Résultat

```

[8, 6, 7, 15]

```

Le nombre avec **le moins de bits à 1 apparaît en premier**.

<p align="center">• • •</p>

## ⚖️ Cas d'égalité

Lorsque deux nombres possèdent **le même nombre de bits à `1`**, on les trie selon leur **valeur numérique croissante**.

### Exemple

```

10 -> 1010 -> 2 bits
12 -> 1100 -> 2 bits

```

Les deux valeurs possèdent **2 bits actifs**, mais :

```

10 < 12

```

Donc l'ordre devient :

```

[10, 12]

```

<p align="center">• • •</p>

## 🧩 Exemple complet

### Entrée

```

[3, 8, 3, 6, 5, 7, 9, 1]

```

### Analyse

| Nombre | Binaire | Bits |
|------|------|------|
| 3 | 11 | 2 |
| 8 | 1000 | 1 |
| 3 | 11 | 2 |
| 6 | 110 | 2 |
| 5 | 101 | 2 |
| 7 | 111 | 3 |
| 9 | 1001 | 2 |
| 1 | 1 | 1 |

### Résultat

```

[1, 8, 3, 3, 5, 6, 9, 7]

````

<p align="center">• • •</p>

## 🧩 Exemple d’utilisation

```csharp
SortingByBits.SortByBitCount(new[] { 7, 6, 15, 8 });
````

Résultat :

```
[8, 6, 7, 15]
```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/6kyu/SortingByBits.Tests/)

Les tests doivent vérifier notamment :

* le tri correct selon le nombre de bits
* le tri numérique en cas d'égalité
* la gestion de tableaux contenant des doublons
* le tri effectué **en place**

<p align="center">• • •</p>

## 🧠 Concepts abordés

Ce kata permet de travailler plusieurs notions importantes :

* manipulation de bits
* tri multi-critères
* représentation binaire
* algorithmes de tri
* structures de données

<p align="center">• • •</p>

## 🏷️ Catégories

* Logic
* Arrays
* Algorithms
* Data Structures
* Fundamentals
* Bits
* Binary
* Sorting

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata consiste à **trier un tableau d'entiers en fonction du nombre de bits à `1` dans leur représentation binaire**.

La fonction doit :

* calculer le **nombre de bits actifs**
* trier les valeurs selon ce critère
* départager les égalités par **ordre numérique croissant**
* modifier **directement le tableau d'origine**.
