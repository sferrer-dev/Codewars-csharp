# ❗ Remove exclamation marks

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction `RemoveExclamationMarks` qui **supprime tous les points d'exclamation (`!`) d'une chaîne de caractères donnée**.

La fonction reçoit **une chaîne de caractères en entrée** et doit retourner **une nouvelle chaîne sans aucun point d'exclamation**.

Tous les autres caractères doivent être **conservés tels quels**.

🔗 **Kata Codewars** - [Remove exclamation marks](https://www.codewars.com/kata/57a0885cbb9944e24c00008e)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **une chaîne de caractères**
- Supprimer **tous les caractères `!`**
- Conserver **tous les autres caractères**
- Retourner **la nouvelle chaîne obtenue**

La fonction doit fonctionner avec :

- des **lettres**
- des **chiffres**
- des **espaces**
- des **caractères spéciaux**

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste simplement à **retirer tous les caractères `!` de la chaîne**.

Conceptuellement :

```

résultat = chaîne originale sans les caractères "!"

````

En C#, cela peut être réalisé par exemple avec :

```csharp
input.Replace("!", "")
````

<p align="center">• • •</p>

## 🔎 Exemples

| Chaîne originale   | Résultat           |
| ------------------ | ------------------ |
| `"Hello World!"`   | `"Hello World"`    |
| `"Hi!!!"`          | `"Hi"`             |
| `"!Hi! Hi!"`       | `"Hi Hi"`          |
| `"No exclamation"` | `"No exclamation"` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

* 📁 [Projet de tests NUnit](../../../tests/8kyu/RemoveExclamationMarks.Tests/)

Les tests couvrent notamment :

* la **suppression correcte des points d'exclamation**
* des chaînes contenant **plusieurs `!`**
* des chaînes **sans `!`**
* des **tests automatiques avec différentes chaînes**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

* recevoir **une chaîne de caractères**
* **supprimer tous les caractères `!`**
* retourner **la nouvelle chaîne sans point d'exclamation**

```
