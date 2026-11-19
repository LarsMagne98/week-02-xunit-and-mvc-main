# Arbeidslogg – Forsyninger: fra krav til testeksempler

## 1. Forventet og faktisk resultat

Fyll inn **Forventet** før du kjører programmet. Etter at du har kjørt alle fem tilfellene, fyller du inn **Faktisk** og om resultatene stemte.

| Inndata               | Forventet | Faktisk | Stemte det? |
| --------------------- | --------- | ------- | ----------- |
| 3 personer, 4 dager   | 24        | 24      | ja          |
| 0 personer, 4 dager   | 0         | 0       | ja          |
| 3 personer, 0 dager   | 0         | 0       | ja          |
| 1 person, 1 dag       | 2         | 2       | ja          |
| 20 personer, 30 dager | 1200      | 1200    | ja          |

Hvordan fant du frem til de forventede resultatene?
Svar: (x _ y) _ 2

## 2. Prøv å innføre en feil

Endre multiplikatoren fra 2 til 3, og kjør programmet på nytt.

**Hvilke tilfeller avslørte feilen?**
Svar: Tilfeller der x elley y IKKE er 0.

**Hvilke tilfeller ga fortsatt riktig resultat?**
Svar: Tilfeller der x eller y ER 0.

**Hvorfor kan nulltilfellene gi riktig resultat selv om multiplikatoren er feil?**
Svar: for at x \* 0 = 0.

Husk å endre multiplikatoren tilbake til 2.

## 3. Refleksjon

Hvorfor er det ikke nok at programmet skriver ut et resultat for å avgjøre om en test består?

Svar: For at det er mange måter å komme til et og samme svar. Tester med flere forskjellige verdier er nødvendig for å sørge for at formelen er riktig.

## 4. Endringer

Hvilke filer endret du, og hvorfor?

Svar: Program.cs for å teste flere verdier.
FuelCalculator.cs for å teste feil multiplikator.
