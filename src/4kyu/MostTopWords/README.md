# 📝 Most frequently used words in a text

![Codewars](https://img.shields.io/badge/Codewars-4kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui, à partir d’un **texte** pouvant contenir de la **ponctuation**, des **retours à la ligne** et différents types de séparateurs, retourne un tableau contenant les **3 mots les plus fréquents**, triés par **ordre décroissant de fréquence**.

Le résultat doit contenir les mots en **minuscules**.

🔗 **Kata Codewars** - [Most frequently used words in a text](https://www.codewars.com/kata/51e056fe544cf36c410000fb)

<p align="center">• • •</p>

## ⚙️ Règles

Un **mot** est défini comme :

* une suite de lettres de `A` à `Z`
* pouvant contenir un ou plusieurs apostrophes ASCII `'`
* les apostrophes peuvent apparaître :

  * au début
  * au milieu
  * à la fin

Exemples de mots valides :

* `'abc`
* `abc'`
* `ab'c`

Tous les autres caractères ne font **pas** partie d’un mot et doivent être traités comme des **séparateurs** :

* `#`
* `\`
* `/`
* `.`
* `,`
* `:`
* `;`
* etc.

Le traitement doit aussi respecter les contraintes suivantes :

* la recherche est **insensible à la casse**
* les mots retournés doivent être **normalisés en minuscules**
* en cas d’égalité de fréquence, l’ordre peut être arbitraire
* si le texte contient moins de 3 mots distincts :

  * retourner les **2 premiers**
  * ou le **1er**
  * ou un tableau vide s’il n’y a **aucun mot**

<p align="center">• • •</p>

## 💡 Objectif

La fonction doit :

```text
1. extraire les mots valides du texte
2. compter leurs occurrences
3. retourner les 3 mots les plus fréquents
```

L’enjeu principal du kata est de bien gérer :

* le **parsing du texte**
* les **apostrophes**
* la **normalisation en minuscules**
* le **comptage efficace**
* la **sélection du top 3**

<p align="center">• • •</p>

## 🔎 Exemples

### Exemple 1

Texte :

```text
In a village of La Mancha, the name of which I have no desire to call to
mind, there lived not long since one of those gentlemen that keep a lance
in the lance-rack, an old buckler, a lean hack, and a greyhound for
coursing. An olla of rather more beef than mutton, a salad on most
nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra
on Sundays, made away with three-quarters of his income.
```

Résultat :

```text
["a", "of", "on"]
```

### Exemple 2

Texte :

```text
e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e
```

Résultat :

```text
["e", "ddd", "aa"]
```

### Exemple 3

Texte :

```text
  //wont won't won't
```

Résultat :

```text
["won't", "wont"]
```

<p align="center">• • •</p>

## 🧠 Points d’attention

Ce kata demande de bien distinguer :

* les **vrais mots**
* les séquences composées uniquement d’apostrophes, qui ne doivent **pas** être considérées comme des mots valides
* les caractères spéciaux qui servent de **délimiteurs**

Il faut également veiller à produire une solution robuste sur :

* des textes longs
* des entrées multi-lignes
* des occurrences mélangées en majuscules/minuscules

<p align="center">• • •</p>

## 🚀 Bonus

Quelques pistes d’optimisation intéressantes :

* éviter de créer un tableau intermédiaire aussi volumineux que le texte d’entrée
* éviter de trier l’ensemble complet des mots uniques alors qu’on ne cherche que le **top 3**

Ces optimisations ne sont pas obligatoires pour réussir le kata, mais elles constituent une excellente pratique algorithmique.

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

* 📁 [Projet de tests NUnit](../../../tests/4kyu/MostTopWords.Tests/)

Les tests couvrent généralement :

* les cas nominaux
* les variations de casse
* les textes avec ponctuation
* les apostrophes dans les mots
* les entrées vides ou sans mot valide
* les cas où moins de 3 mots distincts existent

<p align="center">• • •</p>

## 🏷️ Tags

* Strings
* Filtering
* Algorithms
* Regular Expressions

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit analyser un texte libre pour :

* identifier correctement les mots valides
* compter leurs occurrences sans tenir compte de la casse
* retourner les **3 mots les plus fréquents**
* fournir un résultat en **minuscules**

C’est un kata très formateur pour travailler :

* la manipulation de chaînes
* le filtrage lexical
* les expressions régulières
* les structures de comptage
* l’optimisation algorithmique
