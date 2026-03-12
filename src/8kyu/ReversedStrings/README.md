# 🔁 Reversed Strings

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui **inverse une chaîne de caractères**.

La fonction reçoit **une chaîne en entrée** et doit retourner **la même chaîne mais avec les caractères dans l'ordre inverse**.

🔗 **Kata Codewars** - [Reversed Strings](https://www.codewars.com/kata/5168bb5dfe9a00b126000018)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **une chaîne de caractères**
- Inverser **l'ordre des caractères**
- Retourner **la nouvelle chaîne inversée**

La fonction doit fonctionner avec :

- des **lettres**
- des **chiffres**
- des **espaces**
- des **caractères spéciaux**

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à **inverser la position des caractères dans la chaîne**.

Conceptuellement :

```

résultat = chaîne originale inversée

```

Exemple :

```

"world" → "dlrow"

```

En C#, cela peut être réalisé de plusieurs manières :

- avec **une boucle**
- en utilisant **LINQ**
- en manipulant **un tableau de caractères**

<p align="center">• • •</p>

## 🔎 Exemples

| Chaîne originale | Résultat |
|------------------|----------|
| `"world"` | `"dlrow"` |
| `"word"` | `"drow"` |
| `"hello"` | `"olleh"` |
| `"abc"` | `"cba"` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/8kyu/ReversedStrings.Tests/)

Les tests couvrent notamment :

- l'**inversion correcte des chaînes**
- des chaînes **courtes et longues**
- des chaînes contenant **espaces et caractères spéciaux**
- plusieurs **tests automatiques avec différentes valeurs**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **une chaîne de caractères**
- **inverser l'ordre des caractères**
- retourner **la chaîne inversée**

Exemple :

```

"world" → "dlrow"

```
