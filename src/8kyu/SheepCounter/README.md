# 🐑 Counting sheep

![Codewars](https://img.shields.io/badge/Codewars-8kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

On dispose d’un **tableau représentant un troupeau de moutons**.  
Certains moutons peuvent être **absents de leur place**.

Chaque élément du tableau indique si un mouton est présent :

- `true` → le mouton est présent
- `false` → le mouton est absent

Votre objectif est d’écrire une fonction qui **compte le nombre de moutons présents dans le tableau**.

🔗 **Kata Codewars** - [Counting sheep](https://www.codewars.com/kata/54edbc7200b811e956000556)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit respecter les règles suivantes :

- Recevoir **un tableau de valeurs booléennes**
- Chaque valeur représente la **présence ou l’absence d’un mouton**
- Compter uniquement les valeurs **`true`**
- Retourner **le nombre total de moutons présents**

La fonction doit également **gérer les valeurs incorrectes** éventuelles :

- `null`
- valeurs manquantes

Ces valeurs doivent être **ignorées lors du comptage**.

<p align="center">• • •</p>

## 💡 Principe

Le traitement consiste à **parcourir le tableau et compter chaque valeur `true`**.

Conceptuellement :

```

si valeur == true
compteur++

```

Le résultat final correspond au **nombre total de moutons présents**.

<p align="center">• • •</p>

## 🔎 Exemple

Tableau d'entrée :

```

[true, true, true, false,
true, true, true, true,
true, false, true, false,
true, false, false, true,
true, true, true, true,
false, false, true, true]

```

Nombre de moutons présents :

```

17

```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/8kyu/SheepCounting.Tests/)

Les tests couvrent notamment :

- le **comptage correct des valeurs `true`**
- des tableaux contenant **`true` et `false`**
- la gestion de **valeurs nulles**
- plusieurs **tests automatiques avec différentes configurations de troupeaux**

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

- recevoir **un tableau représentant la présence de moutons**
- **compter les valeurs `true`**
- ignorer les **valeurs nulles ou incorrectes**
- retourner **le nombre total de moutons présents**
