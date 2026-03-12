# ✂️ Remove First and Last Character

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui **supprime le premier et le dernier caractère d’une chaîne de caractères**.

La fonction reçoit **une seule chaîne en paramètre** et doit retourner une **nouvelle chaîne** contenant tous les caractères **sauf le premier et le dernier**.

🔗 **Kata Codewars** - [Remove First and Last Characte](https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0)

<p align="center">• • •</p>

## ⚙️ Règles

Votre fonction doit respecter les règles suivantes :

- La chaîne d'entrée contient **au minimum 2 caractères**
- Si la chaîne contient **exactement 2 caractères**, la fonction doit retourner **une chaîne vide**
- Si la chaîne contient **3 caractères ou plus**, supprimer :
  - le **premier caractère**
  - le **dernier caractère**

La fonction doit fonctionner avec :

- des **lettres**
- des **chiffres**
- des **caractères spéciaux**

<p align="center">• • •</p>

## 💡 Principe

Pour une chaîne donnée :

```

result = string sans le premier et le dernier caractère

````

En C#, cela peut être réalisé avec :

```csharp
input.Substring(1, input.Length - 2);
````

<p align="center">• • •</p>

## 🔎 Exemples

| Chaîne originale | Résultat         |
| ---------------- | ---------------- |
| `eloquent`       | `loquen`         |
| `country`        | `ountr`          |
| `person`         | `erso`           |
| `ab`             | `` (chaîne vide) |
| `xyz`            | `y`              |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :
- 📁 [Projet de tests NUnit](../../../tests/8kyu/RemoveFirstandLastCharacter.Tests/)

Les tests couvrent notamment :

* fonctionnement standard avec des mots courants
* cas limites avec des chaînes de **2 et 3 caractères**
* chaînes contenant **chiffres et caractères spéciaux**
* **tests aléatoires** avec différentes longueurs de chaînes

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

* recevoir **une chaîne de caractères**
* **retirer le premier et le dernier caractère**
* retourner la **nouvelle chaîne obtenue**

Cas particulier :

* si la chaîne contient **exactement 2 caractères**, le résultat est **une chaîne vide**.

