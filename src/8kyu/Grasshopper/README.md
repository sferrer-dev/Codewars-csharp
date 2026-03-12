# 🦗 Grasshopper - Summation

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui **calcule la somme de tous les nombres entiers de `1` jusqu’à `num` inclus**.

Le paramètre `num` est toujours :

- un **entier positif**
- **strictement supérieur à 0**

La fonction doit simplement **retourner la somme totale**.

Les expressions montrées dans les exemples (comme `1 + 2 + 3`) servent uniquement à **illustrer le calcul** et **ne font pas partie du résultat attendu**.

🔗 **Kata Codewars** - [Grasshopper - Summation](https://www.codewars.com/kata/55d24f55d7dd296eb9000030)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- L'entrée est un **entier positif `num`**
- Calculer la somme de **tous les nombres de `1` à `num`**
- Les bornes **1 et `num` sont incluses**
- Retourner **le résultat sous forme de nombre**

<p align="center">• • •</p>

## 💡 Principe

Pour un nombre donné `num`, il faut calculer :

```

1 + 2 + 3 + ... + num

```

Par exemple :

```

num = 4
1 + 2 + 3 + 4 = 10

```

Ce calcul peut être réalisé :

- avec **une boucle**
- ou avec **la formule mathématique de la somme des entiers**

```

num * (num + 1) / 2

```

<p align="center">• • •</p>

## 🔎 Exemples

| Entrée | Calcul illustratif                 | Résultat |
|------|-------------------------------------|----------|
| `1`  | 1                                   | `1`      |
| `2`  | 1 + 2                               | `3`      |
| `4`  | 1 + 2 + 3 + 4                       | `10`     |
| `8`  | 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8       | `36`     |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :  
- 📁 [Projet de tests NUnit](../../../tests/8kyu/Grasshopper.Tests/)

Les tests couvrent notamment :

- des **valeurs simples**
- des **valeurs plus élevées**
- la **validité du calcul de la somme**
- plusieurs **tests automatiques et aléatoires**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un entier positif `num`**
- calculer **la somme de tous les nombres de `1` à `num`**
- retourner **le résultat de cette addition**

Exemple :

```

num = 8
résultat = 36

```
