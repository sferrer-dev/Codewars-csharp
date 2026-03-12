# ➖ Array.diff

![Codewars](https://img.shields.io/badge/Codewars-6kyu-yellow)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Implémenter une fonction qui **calcule la différence entre deux listes**.

La fonction doit **supprimer tous les éléments de la première liste (`a`) qui sont présents dans la seconde liste (`b`)**.

L'ordre des éléments de la liste `a` doit être **conservé dans le résultat final**.

🔗 **Kata Codewars** - [Array.diff](https://www.codewars.com/kata/523f5d21c841566fde000009)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **deux listes d'entiers** :
  - `a` → la liste principale
  - `b` → la liste des éléments à supprimer
- Supprimer **toutes les occurrences des valeurs de `b` présentes dans `a`**
- Conserver **l'ordre des éléments restants**
- Retourner **la nouvelle liste filtrée**

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à **parcourir la liste `a` et conserver uniquement les éléments qui ne sont pas présents dans la liste `b`**.

Conceptuellement :

```

pour chaque élément dans a
si élément n'est pas dans b
ajouter au résultat

```

Le résultat correspond donc à :

```

résultat = a - b

```

où toutes les occurrences des éléments de `b` sont supprimées.

<p align="center">• • •</p>

## 🔎 Exemples

| Liste `a` | Liste `b` | Résultat |
|-----------|-----------|----------|
| `[1, 2]` | `[1]` | `[2]` |
| `[1, 2, 2, 2, 3]` | `[2]` | `[1, 3]` |
| `[1, 2, 3]` | `[]` | `[1, 2, 3]` |
| `[1, 1, 2, 3]` | `[1]` | `[2, 3]` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/6kyu/ArrayDiff.Tests/)

Les tests couvrent notamment :

- la **suppression correcte des éléments présents dans la seconde liste**
- la **gestion des occurrences multiples**
- la **conservation de l'ordre des éléments**
- des **cas avec liste vide**
- plusieurs **tests automatiques avec différentes combinaisons de listes**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **deux listes d'entiers `a` et `b`**
- **supprimer toutes les occurrences des éléments de `b` dans `a`**
- **conserver l'ordre des éléments restants**
- retourner **la nouvelle liste obtenue**
