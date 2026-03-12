# ➡️ Moving Zeros To The End

![Codewars](https://img.shields.io/badge/Codewars-5kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire un algorithme qui **déplace tous les zéros d’un tableau vers la fin**, tout en **préservant l’ordre des autres éléments**.

Le tableau contient des entiers, et tous les éléments ayant la valeur `0` doivent être **placés à la fin du tableau**, sans modifier l’ordre des autres valeurs.

🔗 **Kata Codewars** - [Moving Zeros To The End](https://www.codewars.com/kata/52597aa56021e91c93000cb0)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **un tableau d’entiers**
- Déplacer **tous les éléments ayant la valeur `0`**
- Conserver **l’ordre des éléments non nuls**
- Retourner **un nouveau tableau avec les zéros placés à la fin**

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à :

1. Parcourir le tableau
2. Conserver **tous les éléments différents de `0`**
3. Ajouter ensuite **tous les zéros à la fin**

Conceptuellement :

```

séparer les valeurs non nulles
puis ajouter les zéros à la fin

```

Le résultat final est un tableau où :

```

tous les zéros sont déplacés à la fin
tout en conservant l’ordre des autres éléments

```

<p align="center">• • •</p>

## 🔎 Exemple

Entrée :

```

[1, 2, 0, 1, 0, 1, 0, 3, 0, 1]

```

Traitement :

```

valeurs non nulles → [1, 2, 1, 1, 3, 1]
zéros → [0, 0, 0, 0]

```

Résultat :

```

[1, 2, 1, 1, 3, 1, 0, 0, 0, 0]

```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/5kyu/MovingZerosToTheEnd.Tests/)

Les tests couvrent notamment :

- le **déplacement correct des zéros**
- la **préservation de l’ordre des autres éléments**
- des **tableaux contenant plusieurs zéros**
- des **tableaux sans zéro**
- plusieurs **tests automatiques**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un tableau d’entiers**
- **déplacer tous les zéros à la fin**
- **préserver l’ordre des autres valeurs**
- retourner **le tableau résultant**

Exemple :

```

[1, 2, 0, 1, 0, 1, 0, 3, 0, 1]
→
[1, 2, 1, 1, 3, 1, 0, 0, 0, 0]

```
