# 🔢 Is n divisible by x and y ?

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui vérifie si un nombre **`n` est divisible à la fois par `x` et par `y`**.

Tous les paramètres fournis à la fonction sont :

- des **nombres positifs**
- **différents de zéro**

La fonction doit retourner :

- `true` → si **`n` est divisible par `x` ET par `y`**
- `false` → sinon

🔗 **Kata Codewars** - [Is n divisible by x and y ?](https://www.codewars.com/kata/5545f109004975ea66000086)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **trois entiers positifs** :
  - `n`
  - `x`
  - `y`
- Vérifier si **`n` est divisible par `x`**
- Vérifier si **`n` est divisible par `y`**
- Retourner `true` **uniquement si les deux conditions sont vraies**

La divisibilité d’un nombre se vérifie avec l’opérateur **modulo `%`**.

<p align="center">• • •</p>

## 💡 Principe

Un nombre est divisible par un autre si **le reste de la division est égal à 0**.

En C# :

```

n % x == 0

```

Pour ce kata, les deux conditions doivent être vraies :

```

n % x == 0 && n % y == 0

```

<p align="center">• • •</p>

## 🔎 Exemples

| n | x | y | Explication | Résultat |
|---|---|---|-------------|----------|
| 3 | 1 | 3 | 3 est divisible par 1 et par 3 | `true` |
| 12 | 2 | 6 | 12 est divisible par 2 et par 6 | `true` |
| 100 | 5 | 3 | 100 n'est pas divisible par 3 | `false` |
| 12 | 7 | 5 | 12 n'est divisible ni par 7 ni par 5 | `false` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/8kyu/IsDivisibleBy.Tests/)

Les tests couvrent notamment :

- la **vérification correcte de la divisibilité**
- des **combinaisons de nombres variées**
- des cas où **une seule condition est vraie**
- des cas où **les deux conditions sont vraies ou fausses**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **trois entiers positifs `n`, `x` et `y`**
- vérifier si **`n` est divisible par `x` et par `y`**
- retourner :

```

true  → si n est divisible par x ET par y
false → sinon

```
