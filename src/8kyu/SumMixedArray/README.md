# ➕ Sum Mixed Array

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui **calcule la somme des éléments d’un tableau contenant un mélange de nombres et de chaînes de caractères représentant des nombres**.

Chaque élément du tableau peut être :

- un **entier**
- une **chaîne de caractères représentant un entier**

La fonction doit **traiter tous les éléments comme des nombres** puis **retourner la somme totale**.

🔗 **Kata Codewars** - [Sum Mixed Array](https://www.codewars.com/kata/57eaeb9578748ff92a000009)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Le tableau peut contenir un **mélange de nombres et de chaînes numériques**
- Les chaînes doivent être **converties en nombres**
- La somme doit être **calculée comme si tous les éléments étaient des entiers**
- Le résultat doit être **retourné sous forme de nombre**

Exemples de valeurs possibles dans le tableau :

- `1`
- `"2"`
- `3`
- `"4"`

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à :

1. Parcourir chaque élément du tableau
2. Convertir les chaînes de caractères en nombres
3. Additionner toutes les valeurs

Conceptuellement :

```

somme = addition de tous les éléments convertis en nombres

```

En C#, cela implique généralement une **conversion avec `Convert.ToInt32` ou `int.Parse`**.

<p align="center">• • •</p>

## 🔎 Exemples

| Tableau d'entrée                | Résultat |
|---------------------------------|----------|
| `[9, 3, "7", "3"]`              | `22`     |
| `["5", "0", 9, 3, 2, 1, "9", 6]`| `35`     |
| `["1", "2", "3", 4, 5]`         | `15`     |
| `[1, "1", 1, "1"]`              | `4`      |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :  
- 📁 [Projet de tests NUnits](../../../tests/8kyu/SumMix.Tests/)

Les tests vérifient notamment :

- la **conversion correcte des chaînes en nombres**
- le **calcul correct de la somme**
- des **tableaux contenant différents mélanges de types**
- des **tests aléatoires avec plusieurs combinaisons de valeurs**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un tableau contenant des nombres et des chaînes numériques**
- **convertir les chaînes en entiers**
- **additionner toutes les valeurs**
- retourner **la somme totale sous forme de nombre**
