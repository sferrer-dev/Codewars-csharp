# 🔢 Multiples of 3 or 5

![Codewars](https://img.shields.io/badge/Codewars-6kyu-yellow)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Si l’on liste tous les **nombres naturels inférieurs à 10** qui sont des **multiples de 3 ou de 5**, on obtient :

```

3, 5, 6, 9

```

La somme de ces nombres est :

```

23

```

Votre objectif est d’écrire une fonction qui **retourne la somme de tous les multiples de 3 ou de 5 strictement inférieurs au nombre donné en paramètre**.

Si le nombre fourni est **négatif**, la fonction doit retourner **0**.

🔗 **Kata Codewars** - [Multiples of 3 or 5](https://www.codewars.com/kata/514b92a657cdc65150000006)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **un entier `n`**
- Identifier tous les nombres **strictement inférieurs à `n`**
- Conserver uniquement ceux qui sont :
  - multiples de **3**
  - ou multiples de **5**
- Calculer **la somme de ces nombres**
- Si `n` est **négatif**, retourner **0**

⚠️ Si un nombre est **multiple à la fois de 3 et de 5**, il doit être **compté une seule fois**.

<p align="center">• • •</p>

## 💡 Principe

Un nombre est multiple de `3` ou `5` si :

```

nombre % 3 == 0
ou
nombre % 5 == 0

```

Conceptuellement :

```

pour chaque nombre i < n
si i est multiple de 3 ou de 5
ajouter i à la somme

```

<p align="center">• • •</p>

## 🔎 Exemples

| Entrée | Multiples trouvés | Résultat |
|------|-------------------|----------|
| `10` | 3, 5, 6, 9 | `23` |
| `20` | 3,5,6,9,10,12,15,18 | `78` |
| `3` | aucun | `0` |
| `-5` | nombre négatif | `0` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/6kyu/Multiples3or5.Tests/)

Les tests couvrent notamment :

- le **calcul correct des multiples**
- les **nombres multiples de 3 et 5**
- les **petites valeurs**
- les **nombres négatifs**
- plusieurs **tests automatiques**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un entier `n`**
- trouver tous les **multiples de 3 ou de 5 inférieurs à `n`**
- **additionner ces nombres**
- retourner **la somme obtenue**

Cas particulier :

```

si n < 0 → retourner 0

```
