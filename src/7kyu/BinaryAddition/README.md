# 🧮 Binary Addition

![Codewars](https://img.shields.io/badge/Codewars-7kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui **additionne deux nombres entiers** et retourne leur **somme en représentation binaire**.

La fonction doit effectuer une **addition classique en base décimale**, puis convertir le résultat en **base binaire**.

Le résultat doit être retourné sous forme **de chaîne de caractères (`string`)**.

🔗 **Kata Codewars** [Binary Addition](https://www.codewars.com/kata/551f37452ff852b7bd000139)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- La fonction reçoit **deux entiers**
- Les deux valeurs doivent être **additionnées**
- Le résultat doit être **converti en binaire**
- La valeur binaire doit être retournée sous forme **de chaîne de caractères**

<p align="center">• • •</p>

## 💡 Principe

L’algorithme peut être résumé en plusieurs étapes :

1. Additionner les deux nombres
2. Convertir la somme en **binaire**
3. Retourner le résultat sous forme de **chaîne**

En C#, la conversion en binaire peut être réalisée avec :

```csharp
Convert.ToString(nombre, 2);
````

où `2` représente la **base binaire**.

<p align="center">• • •</p>

## 🔎 Exemples

| Entrée | Résultat |
| ------ | -------- |
| `1, 1` | `"10"`   |
| `5, 9` | `"1110"` |
| `0, 1` | `"1"`    |
| `2, 2` | `"100"`  |

**Explication :**

| Calcul décimal | Résultat binaire |
| -------------- | ---------------- |
| 1 + 1 = 2      | `10`             |
| 5 + 9 = 14     | `1110`           |
| 2 + 2 = 4      | `100`            |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

* 📁 **Projet de tests NUnit**
  `../../../tests/7kyu/BinaryAddition.Tests/`

Les tests couvrent notamment :

* l’addition de différents nombres
* la conversion correcte en **base binaire**
* les cas simples et les cas plus larges

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

* recevoir **deux entiers**
* calculer leur **somme**
* convertir le résultat en **binaire**
* retourner la valeur **sous forme de chaîne de caractères**.
