# 🌐 Count IP Addresses

![Codewars](https://img.shields.io/badge/Codewars-5kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Écrire une fonction qui reçoit **deux adresses IPv4** sous forme de chaînes de caractères et retourne le **nombre d’adresses IP situées entre elles**.

Le calcul doit :

* **inclure** la première adresse
* **exclure** la dernière adresse

Toutes les entrées sont des adresses IPv4 valides au format texte, et la seconde adresse est toujours **strictement supérieure** à la première.

🔗 **Kata Codewars** - [Count IP Addresses](https://www.codewars.com/kata/526989a41034285187000de4)

<p align="center">• • •</p>

## ⚙️ Règles

La fonction doit :

* recevoir deux chaînes représentant des adresses IPv4
* convertir chaque adresse en une valeur numérique exploitable
* retourner la différence entre la seconde et la première

Une adresse IPv4 est composée de **4 octets** séparés par des points :

```text
a.b.c.d
```

Chaque octet possède une valeur comprise entre **0 et 255**.

<p align="center">• • •</p>

## 💡 Principe

L’idée consiste à convertir une adresse IPv4 en un entier non signé sur 32 bits.

Par exemple :

```text
10.0.0.0
```

correspond à :

```text
10 × 256³ + 0 × 256² + 0 × 256 + 0
```

Une fois les deux adresses converties, il suffit de calculer :

```csharp
valeurFin - valeurDébut
```

<p align="center">• • •</p>

## 🔎 Exemples

| Adresse de début | Adresse de fin | Résultat |
| ---------------- | -------------- | -------- |
| `10.0.0.0`       | `10.0.0.50`    | `50`     |
| `10.0.0.0`       | `10.0.1.0`     | `256`    |
| `20.0.0.10`      | `20.0.1.0`     | `246`    |

<p align="center">• • •</p>

## 🧠 Approche algorithmique

Une implémentation classique peut suivre les étapes suivantes :

1. découper chaque adresse avec le séparateur `.`
2. convertir chaque bloc en entier
3. reconstruire la valeur numérique complète de l’adresse IPv4
4. soustraire la première valeur à la seconde

Exemple de logique en C# :

```csharp
(((a * 256) + b) * 256 + c) * 256 + d
```

Cette approche permet un calcul :

* **simple**
* **fiable**
* **performant**

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires associés sont disponibles dans le projet :

* 📁 [Projet de tests NUnits](../../../tests/5kyu/CountIPAddresses.Tests/)

Les tests couvrent généralement :

* des écarts simples sur le dernier octet
* des passages d’un sous-réseau à un autre
* des écarts plus larges entre deux adresses IPv4
* la validité du calcul sur plusieurs cas représentatifs

<p align="center">• • •</p>

## 🧾 Résumé

La fonction doit :

* recevoir **deux adresses IPv4**
* les convertir en **valeurs numériques**
* retourner le **nombre d’adresses comprises entre elles**
* **inclure la première** et **exclure la dernière**

C’est un kata classique d’algorithmie autour de :

* la **manipulation de chaînes**
* la **conversion numérique**
* la **représentation binaire / réseau** des adresses IPv4
