# 🐷 Simple Pig Latin

![Codewars](https://img.shields.io/badge/Codewars-5kyu-yellow)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui **transforme une phrase en Pig Latin**.

La règle du **Pig Latin** consiste à :

1. **déplacer la première lettre de chaque mot à la fin du mot**
2. **ajouter `"ay"` à la fin**

Les **signes de ponctuation ne doivent pas être modifiés**.

🔗 **Kata Codewars** - [Simple Pig Latin](https://www.codewars.com/kata/520b9d2ad5c005041100000f)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **une chaîne de caractères représentant une phrase**
- Appliquer la transformation **Pig Latin sur chaque mot**
- Laisser **la ponctuation intacte**
- Retourner **la nouvelle phrase transformée**

Transformation d’un mot :

```

mot → mot sans première lettre + première lettre + "ay"

```

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à :

1. **séparer la phrase en mots**
2. transformer chaque mot
3. conserver les **caractères de ponctuation**

Conceptuellement :

```

pour chaque mot
si mot est une ponctuation
conserver tel quel
sinon
déplacer la première lettre à la fin
ajouter "ay"

````

<p align="center">• • •</p>

## 🔎 Exemples

| Entrée | Résultat |
|------|----------|
| `"Pig latin is cool"` | `"igPay atinlay siay oolcay"` |
| `"Hello world !"` | `"elloHay orldway !"` |

Exemple en C# :

```csharp
Kata.PigIt("Pig latin is cool");
// igPay atinlay siay oolcay

Kata.PigIt("Hello world !");
// elloHay orldway !
````

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

* 📁 [Projet de tests NUnit](../../../tests/5kyu/SimplePigLatin.Tests/)

Les tests couvrent notamment :

* la **transformation correcte des mots**
* la **gestion de plusieurs mots**
* la **préservation de la ponctuation**
* différents **tests automatiques**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

* recevoir **une phrase**
* transformer chaque mot en **Pig Latin**
* **ne pas modifier la ponctuation**
* retourner **la phrase transformée**

Exemple :

```
Hello world !
→
elloHay orldway !
```
