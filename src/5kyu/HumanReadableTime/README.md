# ⏱️ Human Readable Time

![Codewars](https://img.shields.io/badge/Codewars-5kyu-red)
![Language](https://img.shields.io/badge/Language-C%23-blue)
![Framework](https://img.shields.io/badge/.NET-8.0-purple)

## 📘 Description

Dans ce kata, vous devez écrire une fonction capable de **convertir un nombre de secondes en un format d'heure lisible par un humain**.

Le format attendu est :

```

HH:MM:SS

```

où :

- **HH** = heures  
- **MM** = minutes  
- **SS** = secondes  

Chaque valeur doit être **complétée avec des zéros à gauche** afin d'avoir **exactement deux chiffres**.

🔗 **Kata Codewars**  
https://www.codewars.com/kata/52685f7382004e774f0001f7

<p align="center">• • •</p>

## ⚙️ Objectif

Écrire une fonction qui :

- prend en entrée un **entier positif ou nul représentant un nombre de secondes**
- retourne une **chaîne de caractères au format `HH:MM:SS`**

<p align="center">• • •</p>

## ⏳ Contraintes

Les valeurs doivent respecter les plages suivantes :

| Unité | Format | Plage |
|------|------|------|
| Heures | HH | 00 – 99 |
| Minutes | MM | 00 – 59 |
| Secondes | SS | 00 – 59 |

La valeur maximale possible est :

```

359999 secondes

```

Ce qui correspond à :

```

99:59:59

```

<p align="center">• • •</p>

## 🧠 Principe

Pour convertir un nombre de secondes en heures, minutes et secondes :

1. Calculer les **heures** :

```

heures = secondes / 3600

```

2. Calculer les **minutes restantes** :

```

minutes = (secondes % 3600) / 60

```

3. Calculer les **secondes restantes** :

```

secondesRestantes = secondes % 60

```

Chaque valeur doit ensuite être **formatée sur deux chiffres**.

<p align="center">• • •</p>

## 🧩 Exemples

### Exemple 1

Entrée :

```

0

```

Résultat :

```

00:00:00

```

---

### Exemple 2

Entrée :

```

5

```

Résultat :

```

00:00:05

```

---

### Exemple 3

Entrée :

```

60

```

Résultat :

```

00:01:00

```

---

### Exemple 4

Entrée :

```

86399

```

Résultat :

```

23:59:59

```

---

### Exemple 5

Entrée :

```

359999

```

Résultat :

```

99:59:59

````

<p align="center">• • •</p>

## 🧩 Exemple d’utilisation

```csharp
HumanTimeFormat.MakeReadable(86399);
````

Résultat :

```
23:59:59
```

<p align="center">• • •</p>

## 🧪 Tests

Les tests unitaires sont disponibles dans le projet :

- 📁 [Projet de tests NUnit](../../../tests/5kyu/HumanReadableTime.Tests/)

Les tests doivent vérifier notamment :

* la conversion correcte des secondes
* les cas limites (`0`, `359999`)
* le remplissage avec des zéros à gauche
* les valeurs intermédiaires

<p align="center">• • •</p>

## 🧠 Concepts abordés

Ce kata permet de travailler plusieurs notions importantes :

* manipulation du temps
* division entière et modulo
* formatage de chaînes de caractères
* gestion des cas limites

<p align="center">• • •</p>

## 🏷️ Catégories

* Date Time
* Mathematics
* Algorithms

<p align="center">• • •</p>

## 🧾 Résumé

Ce kata consiste à transformer un **nombre de secondes** en un **format d'heure lisible**.

La fonction doit :

* convertir les secondes en heures, minutes et secondes
* formater le résultat sous la forme **HH:MM:SS**
* garantir un affichage **toujours sur deux chiffres par unité**.
