# 🧮 Bit Counting

![Codewars](https://img.shields.io/badge/Codewars-6kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Dans ce kata, vous devez écrire une fonction qui **compte le nombre de bits à `1` dans la représentation binaire d’un entier**.

L'entrée est un **entier non négatif** et la fonction doit retourner **le nombre de bits actifs (`1`)** présents dans sa représentation binaire.

🔗 **Kata Codewars**  
https://www.codewars.com/kata/526571aae218b8ee490006f4

<p align="center">• • •</p>

## ⚙️ Objectif

Écrire une fonction qui :

1. prend un **entier non négatif**
2. convertit implicitement ou explicitement ce nombre en **représentation binaire**
3. retourne le **nombre de bits égaux à `1`**

<p align="center">• • •</p>

## 🧠 Principe

En informatique, les nombres sont stockés en **base 2** (binaire).

Exemple :

```

1234 (base 10)

```

Représentation binaire :

```

10011010010

```

Si l’on compte les bits égaux à `1` :

```

1 0 0 1 1 0 1 0 0 1 0

```

On obtient :

```

5 bits à 1

```

La fonction doit donc retourner :

```

5

```

<p align="center">• • •</p>

## 🔎 Exemple

### Entrée

```

1234

```

### Représentation binaire

```

10011010010

```

### Résultat

```

5

````

<p align="center">• • •</p>

## 🧩 Autres exemples

| Entrée | Binaire | Résultat |
|------|------|------|
| 0 | 0 | 0 |
| 4 | 100 | 1 |
| 7 | 111 | 3 |
| 9 | 1001 | 2 |
| 10 | 1010 | 2 |

<p align="center">• • •</p>

## 🧩 Exemple d’utilisation

```csharp
BitCounting.CountBits(1234);
````

Résultat :

```
5
```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/6kyu/BitCouning.Tests/)

Les tests doivent vérifier notamment :

* la conversion correcte en binaire
* le comptage exact des bits à `1`
* le cas particulier `0`
* plusieurs valeurs intermédiaires

<p align="center">• • •</p>

## 🧠 Concepts abordés

Ce kata permet de travailler plusieurs notions importantes :

* représentation binaire des nombres
* opérations sur les bits
* manipulation d'entiers
* algorithmes simples

<p align="center">• • •</p>

## 🏷️ Catégories

* Bits
* Algorithms

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata consiste à **compter les bits actifs (`1`) dans la représentation binaire d’un entier**.

La fonction doit :

* accepter un entier non négatif
* analyser sa représentation binaire
* retourner le **nombre total de bits à `1`**.
