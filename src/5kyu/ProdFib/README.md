# 🧮 Product of Consecutive Fibonacci Numbers

![Codewars](https://img.shields.io/badge/Codewars-5kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Les **nombres de Fibonacci** constituent une suite d'entiers célèbre définie par la relation suivante :

```

0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...

```

Définition mathématique :

```

F(0) = 0
F(1) = 1
F(n) = F(n−1) + F(n−2)

```

Dans ce kata, on vous donne un nombre `prod` représentant un **produit cible**.

Votre objectif est de déterminer **deux nombres de Fibonacci consécutifs** `F(n)` et `F(n+1)` tels que :

```

F(n) * F(n+1) = prod

```

🔗 **Kata Codewars**  
https://www.codewars.com/kata/5541f58a944b85ce6d00006a/

<p align="center">• • •</p>

## ⚙️ Objectif

Écrire une fonction qui :

1. prend un entier `prod` en entrée
2. cherche deux nombres de Fibonacci consécutifs
3. retourne :

```

(F(n), F(n+1), true)

```

si leur produit est exactement égal à `prod`.

Sinon, retourner :

```

(F(n), F(n+1), false)

```

où `F(n)` et `F(n+1)` sont les **premiers nombres consécutifs tels que** :

```

F(n) * F(n+1) > prod

```

<p align="center">• • •</p>

## 🧠 Principe

La stratégie consiste à :

1. Générer progressivement les nombres de Fibonacci.
2. Calculer le produit de deux nombres consécutifs.
3. Comparer ce produit avec la valeur `prod`.
4. S'arrêter dès que :

```

F(n) * F(n+1) >= prod

```

Ensuite :

- si le produit est égal → résultat exact
- sinon → retourner le premier produit supérieur.

<p align="center">• • •</p>

## 🧩 Exemple 1

### Entrée

```

prod = 714

```

Suite de Fibonacci :

```

...
13, 21, 34, 55

```

Calcul :

```

21 * 34 = 714

```

### Résultat

```

(21, 34, true)

```

<p align="center">• • •</p>

## 🧩 Exemple 2

### Entrée

```

prod = 800

```

Calculs :

```

21 * 34 = 714
34 * 55 = 1870

```

On observe :

```

714 < 800 < 1870

```

### Résultat

```

(34, 55, false)

````

<p align="center">• • •</p>

## 🔎 Exemple d’utilisation

```csharp
ProdFib.ProductFib(714);
````

Résultat :

```
(21, 34, true)
```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/5kyu/ProdFib.Tests/)

Les tests doivent couvrir notamment :

* un produit correspondant exactement à deux Fibonacci consécutifs
* un produit situé entre deux produits Fibonacci
* des valeurs de produit relativement grandes
* le bon ordre des valeurs retournées

<p align="center">• • •</p>

## 🧠 Concepts abordés

Ce kata permet de pratiquer plusieurs notions importantes :

* génération de suites mathématiques
* boucles et conditions
* optimisation d'algorithmes
* raisonnement algorithmique

<p align="center">• • •</p>

## 🏷️ Catégories

* Algorithms
* Mathematics

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata consiste à rechercher deux **nombres de Fibonacci consécutifs** dont le **produit correspond à une valeur donnée**.

La fonction doit :

* trouver les deux Fibonacci concernés
* indiquer si le produit correspond **exactement** à la valeur cible
* sinon retourner le **premier couple dont le produit dépasse la valeur demandée**.
