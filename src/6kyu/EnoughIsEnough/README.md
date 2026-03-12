# 🔢 Delete occurrences of an element if it occurs more than **N** times

![Codewars](https://img.shields.io/badge/Codewars-6kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Alice et Bob sont partis en vacances et ont pris de nombreuses photos des lieux visités.  
Ils souhaitent maintenant montrer toute leur collection à Charlie.

Cependant, Charlie n'apprécie pas les répétitions.  
Voir **la Tour Eiffel 40 fois** ne l'intéresse pas vraiment.

Il accepte donc de regarder leurs photos **à condition que chaque motif n'apparaisse pas plus de `N` fois**.

Heureusement, Alice et Bob ont encodé chaque motif par **un nombre**.

Votre mission consiste à **filtrer la liste** afin que **chaque nombre n'apparaisse pas plus de `N` fois**, tout en **conservant l'ordre original**.

🔗 **Kata Codewars**  
https://www.codewars.com/kata/554ca54ffa7d91b236000023

<p align="center">• • •</p>

## ⚙️ Objectif

Étant donné :

- une **liste d'entiers**
- un **nombre `N`**

Créer une nouvelle liste dans laquelle :

- chaque valeur apparaît **au maximum `N` fois**
- **l'ordre des éléments est conservé**

<p align="center">• • •</p>

## 🧠 Principe

La stratégie consiste à :

1. Parcourir la liste d'origine.
2. Compter le nombre d'occurrences déjà ajoutées pour chaque valeur.
3. Ajouter l'élément au résultat uniquement si son nombre d'occurrences est **inférieur à `N`**.

Pour cela, une structure de données comme un **dictionnaire (`Dictionary<int,int>`)** peut être utilisée afin de suivre le nombre d'occurrences de chaque élément.

<p align="center">• • •</p>

## 🧩 Exemple

### Entrée

```

N = 2
Liste = [1,2,3,1,2,1,2,3]

```

### Étapes

```

[1]           -> OK
[1,2]         -> OK
[1,2,3]       -> OK
[1,2,3,1]     -> OK (1 apparaît 2 fois)
[1,2,3,1,2]   -> OK (2 apparaît 2 fois)
[1,2,3,1,2]   -> 1 ignoré (déjà présent 2 fois)
[1,2,3,1,2]   -> 2 ignoré (déjà présent 2 fois)
[1,2,3,1,2,3] -> OK

```

### Résultat

```

[1,2,3,1,2,3]

```

<p align="center">• • •</p>

## 🔎 Autre exemple

### Entrée

```

N = 1
Liste = [20,37,20,21]

```

### Résultat

```

[20,37,21]

````

Explication :

- `20` apparaît une seconde fois → ignoré
- les autres valeurs restent présentes une seule fois

<p align="center">• • •</p>

## 🧩 Exemple d’utilisation

```csharp
EnoughIsEnough.DeleteNth(new[] { 1,2,3,1,2,1,2,3 }, 2);
````

Résultat :

```
[1,2,3,1,2,3]
```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires sont disponibles dans le projet :

📁 **Projet NUnit**

```
../../../tests/6kyu/EnoughIsEnough.Tests/
```

Les scénarios de test doivent couvrir notamment :

* une liste contenant plusieurs doublons
* une limite `N = 1`
* une limite `N > 1`
* une liste vide
* une liste sans répétition
* la conservation de l'ordre des éléments

<p align="center">• • •</p>

## 🏷️ Catégories

* Lists
* Fundamentals

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata consiste à **limiter le nombre d'occurrences de chaque élément dans une liste**.

Contraintes principales :

* chaque valeur peut apparaître **au maximum `N` fois**
* **l'ordre original de la liste doit être conservé**
* les occurrences supplémentaires doivent être **ignorées**
