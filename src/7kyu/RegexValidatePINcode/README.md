# 🔐 Regex validate PIN code

![Codewars](https://img.shields.io/badge/Codewars-7kyu-orange)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Les distributeurs automatiques (**ATM**) utilisent des **codes PIN** pour sécuriser l'accès aux comptes.

Un code PIN valide doit respecter les règles suivantes :

- contenir **exactement 4 chiffres**
- ou contenir **exactement 6 chiffres**
- ne contenir **aucun autre caractère**

Votre objectif est d'écrire une fonction qui **vérifie si une chaîne correspond à un code PIN valide**.

La fonction doit retourner :

- `true` → si le PIN est valide
- `false` → sinon

🔗 **Kata Codewars** - [Regex validate PIN code](https://www.codewars.com/kata/55f8a9c06c018a0d6e000132)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **une chaîne représentant un code PIN**
- Vérifier que la chaîne contient :
  - **exactement 4 chiffres**
  - **ou exactement 6 chiffres**
- Aucun autre caractère n'est autorisé :
  - pas de **lettres**
  - pas d'**espaces**
  - pas de **symboles**

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à **valider le format du code PIN**.

Deux conditions sont possibles :

```

4 chiffres

```

ou

```

6 chiffres

```

Cette validation peut être réalisée avec une **expression régulière**.

Exemple de motif possible :

```

^[0-9]{4}$ | ^[0-9]{6}$

```

Ce motif vérifie que la chaîne contient **exactement 4 ou 6 chiffres**.

<p align="center">• • •</p>

## 🔎 Exemples

| PIN | Explication | Résultat |
|----|-------------|----------|
| `"1234"` | 4 chiffres | `true` |
| `"123456"` | 6 chiffres | `true` |
| `"12345"` | longueur invalide | `false` |
| `"a234"` | contient une lettre | `false` |
| `"12 34"` | contient un espace | `false` |

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/7kyu/RegexValidatePINcode.Tests/)

Les tests couvrent notamment :

- les **PIN valides à 4 chiffres**
- les **PIN valides à 6 chiffres**
- les **longueurs incorrectes**
- la présence de **lettres ou caractères non numériques**
- plusieurs **tests automatiques**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **une chaîne représentant un code PIN**
- vérifier qu'elle contient **exactement 4 ou 6 chiffres**
- retourner :

```

true  → si le PIN est valide
false → sinon

```
