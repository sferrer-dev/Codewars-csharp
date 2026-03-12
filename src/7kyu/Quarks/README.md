# ⚛️ Thinkful - Object Drills: Quarks

![Codewars](https://img.shields.io/badge/Codewars-7kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Dans ce kata, vous allez modéliser une **particule fondamentale de la physique : le quark**.

Les quarks sont des particules élémentaires qui composent notamment les **protons** et **neutrons**.  
Ils sont particuliers car ils sont les **seules particules fondamentales à subir les quatre interactions fondamentales** :

- interaction forte
- interaction faible
- interaction électromagnétique
- interaction gravitationnelle

Pour simuler leur comportement, vous devez implémenter une **classe `Quark`** permettant de créer et manipuler des objets représentant ces particules.

🔗 **Kata Codewars**  
https://www.codewars.com/kata/5882b052bdeafec15e0000e6

<p align="center">• • •</p>

## ⚙️ Objectif

Créer une classe `Quark` qui permet :

- de créer un quark avec une **couleur**
- de créer un quark avec une **saveur (flavor)**
- d'exposer son **nombre baryonique**
- de permettre à deux quarks **d'interagir et d'échanger leur couleur**

<p align="center">• • •</p>

## 🎨 Couleurs possibles

Un quark peut posséder uniquement l'une des couleurs suivantes :

```

red
blue
green

```

Ces couleurs représentent la **charge de couleur** utilisée dans la **chromodynamique quantique (QCD)**.

<p align="center">• • •</p>

## 🍃 Saveurs possibles (Flavors)

Un quark peut avoir l'une des **six saveurs** suivantes :

```

up
down
strange
charm
top
bottom

```

Chaque saveur correspond à un type particulier de quark dans le modèle standard de la physique des particules.

<p align="center">• • •</p>

## 🔢 Nombre baryonique

Tous les quarks possèdent le même **nombre baryonique** :

```

1 / 3

```

Dans l'implémentation C#, cette valeur est exposée via la propriété :

```

BaryonNumber

```

<p align="center">• • •</p>

## 🔄 Interaction entre quarks

Deux quarks peuvent **interagir via l'interaction forte**.

Lorsqu'une interaction se produit :

- les deux quarks **échangent leur couleur**.

Cette interaction est modélisée par la méthode :

```

Interact()

````

<p align="center">• • •</p>

## 🧩 Exemple

### Création de deux quarks

```csharp
Quark q1 = new Quark("red", "up");
Quark q2 = new Quark("blue", "strange");
````

### Accès aux propriétés

```csharp
q1.Color        // "red"
q2.Color        // "blue"
q2.BaryonNumber // 0.3333333333333333
```

### Interaction entre les quarks

```csharp
q1.Interact(q2);
```

### Résultat

```
q1.Color -> "blue"
q2.Color -> "red"
```

Les deux quarks ont **échangé leur couleur**.

<p align="center">• • •</p>

## 🧠 Concepts abordés

Ce kata permet de pratiquer plusieurs notions de **programmation orientée objet** :

* création d'une **classe**
* utilisation de **propriétés**
* encapsulation de données
* interaction entre **instances d'objets**
* modélisation d'un comportement métier

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires sont disponibles dans le projet :

📁 **Projet NUnit**

```
../../../tests/7kyu/Quarks.Tests/
```

Les tests doivent vérifier notamment :

* la création d'un quark avec une couleur et une saveur valides
* la valeur correcte du **BaryonNumber**
* le bon fonctionnement de la méthode **Interact**
* l'échange correct des couleurs entre deux quarks

<p align="center">• • •</p>

## 🏷️ Catégories

* Fundamentals
* Object-oriented Programming

<p align="center">• • •</p>

## 🧾 Résumé

Dans ce kata, vous devez implémenter une classe `Quark` permettant de :

* représenter un **quark avec une couleur et une saveur**
* exposer son **nombre baryonique constant**
* permettre à deux quarks **d'interagir et d'échanger leur couleur**

Ce kata constitue un excellent exercice pour pratiquer les **bases de la programmation orientée objet en C#**.
