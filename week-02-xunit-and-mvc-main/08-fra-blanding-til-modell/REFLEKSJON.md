# Arbeidslogg – Skill oppskytingsregelen fra konsollen

## Før koding

Min forventning og begrunnelse:

## Forsøk

| Handling / testnavn | Forventet           | Faktisk             | Hva lærte jeg? |
| ------------------- | ------------------- | ------------------- | -------------- |
| 50, "ja"            | Klar for oppskyting | klar for oppskyting |                |
| 49, "ja"            | Oppskyting avvist   | Oppskyting avvist   |                |
| 50, "nei"           | Oppskyting avvist   | oppskyting avvist   |                |

## Etterpå

Hvilke filer endret jeg, og hvorfor?
ExerciseTests.cs for å legge til flere testtilfeller.
Program.cs for å flytte regelen til LaunchPolicy.cs og kalle på LaunchPolicy.CanLaunch() i betingelsen.
LaunchPolicy.cs for å lage regelen til CanLaunch().

Svar på refleksjonsspørsmålene:

### 2.

- InnlineData(50, true, true) feiler.
- Den forventer true
- CanLaunch() returnerer bare false.

### 7.

- InnlineData(50, true, true). Den forventet true, men CanLaunch() returnerte bare false.
- InlineData(50, false, false), InlineData(100, true, true), InlineData(0, true, false).
- Endret CanLaunch() så den behandlet betingelsene der.
- Endret if-sjekken til å kalle .CanLaunch().
- Alle testene var vellykket, og konsollkjøringen fungerte som ønsket.

### Refleksjon

1. Da slipper du å kjøre programmet flere ganger for å teste forskjellige inputs.
2. Finnes den flere steder må du også endre den flere steder.
3. Enhetstester kontrollerer avgrenset oppførsel i koden, f.eks om en metode gir riktig resultat for bestemte inndata. Når du kjører konsollen kontrollerer du at delene fungerer sammen og får forventet resultat i praksis.
4. Hvis forretningsreglene fortsatt er blandet inn i visning eller kontrollflyt er de vanskligere å teste, gjenbruke og endre.
