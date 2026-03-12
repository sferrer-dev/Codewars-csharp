# 📈 Beginner - Reduce but Grow

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui **multiplie tous les éléments d’un tableau d’entiers** et retourne le résultat.

Le tableau fourni en entrée est :

- **non vide**
- composé uniquement **d’entiers**

La fonction doit **multiplier les valeurs dans l’ordre du tableau** et retourner **le produit total**.

🔗 **Kata Codewars** - [Beginner - Reduce but Grow](https://www.codewars.com/kata/57f780909f7e8e3183000078)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **un tableau d'entiers**
- Le tableau contient **au moins un élément**
- Multiplier **tous les éléments du tableau**
- Retourner **le résultat de la multiplication**

<p align="center">• • •</p>

## 💡 Principe

Le calcul consiste à **multiplier chaque valeur du tableau avec le résultat courant**.

Conceptuellement :

```

résultat = valeur1 * valeur2 * valeur3 * ... * valeurN

```

Exemple :

```

[1, 2, 3, 4]
1 * 2 * 3 * 4 = 24

```

En pratique, cela peut être réalisé avec :

- **une boucle**
- ou une **opération de réduction** (par exemple `Aggregate` en LINQ)

<p align="center">• • •</p>

## 🔎 Exemples

| Tableau | Calcul | Résultat |
|-------|-------|----------|
| `[1, 2, 3, 4]` | 1 × 2 × 3 × 4 | `24` |
| `[2, 2, 2, 2]` | 2 × 2 × 2 × 2 | `16` |
| `[5, 1, 3]` | 5 × 1 × 3 | `15` |
| `[10]` | 10 | `10` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/8kyu/ReduceButGrow.Tests/)

Les tests couvrent notamment :

- la **multiplication correcte des éléments**
- des **tableaux de tailles différentes**
- des **valeurs variées**
- plusieurs **tests automatiques avec différents ensembles de données**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un tableau d'entiers non vide**
- **multiplier tous les éléments du tableau**
- retourner **le produit final**

Exemple :

```

[1, 2, 3, 4] → 24

```
