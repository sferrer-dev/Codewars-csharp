# 🧹 List Filtering

![Codewars](https://img.shields.io/badge/Codewars-7kyu-orange)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Dans ce kata, vous devez écrire une fonction qui **filtre une liste contenant des entiers et des chaînes de caractères**.

La fonction reçoit une **liste d'objets** contenant :

- des **entiers non négatifs**
- des **chaînes de caractères**

Votre objectif est de **retourner une nouvelle liste contenant uniquement les entiers**.  
Toutes les **chaînes de caractères doivent être supprimées**.

🔗 **Kata Codewars** - [List Filtering](https://www.codewars.com/kata/53dbd5315a3c69eed20002dd)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **une liste contenant des entiers et des chaînes**
- Identifier les éléments qui sont **des entiers**
- Ignorer tous les éléments qui sont **des chaînes**
- Retourner **une nouvelle liste contenant uniquement les entiers**

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à :

1. Parcourir la liste d’objets
2. Vérifier le **type de chaque élément**
3. Conserver uniquement les **entiers**

Conceptuellement :

```

si élément est un entier
ajouter à la nouvelle liste

````

Le résultat est une **liste filtrée contenant uniquement des valeurs numériques**.

<p align="center">• • •</p>

## 🔎 Exemples

| Liste d'origine | Résultat |
|-----------------|----------|
| `[1, 2, "a", "b"]` | `[1, 2]` |
| `[1, "a", "b", 0, 15]` | `[1, 0, 15]` |
| `[1, 2, "a", "b", "aasf", "1", "123", 123]` | `[1, 2, 123]` |

Exemple en C# :

```csharp
ListFilterer.GetIntegersFromList(new List<object>() {1, 2, "a", "b"}) 
// retourne : {1, 2}
````

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

* 📁 [Projet de tests NUnit](../../../tests/7kyu/ListFilterer.Tests/)

Les tests couvrent notamment :

* le **filtrage correct des chaînes**
* la **conservation des entiers**
* des listes contenant **différentes combinaisons de types**
* plusieurs **tests automatiques avec différentes listes**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

* recevoir **une liste contenant des entiers et des chaînes**
* **supprimer toutes les chaînes**
* retourner **une nouvelle liste contenant uniquement les entiers**
