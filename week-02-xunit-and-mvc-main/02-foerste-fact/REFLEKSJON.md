# Arbeidslogg – Første xUnit-test og Arrange–Act–Assert

## Før koding

Min forventning og begrunnelse:

Ganske straight forward oppgave. Har hatt god undervisning i dette.

## Forsøk

| Handling / testnavn | Forventet | Faktisk | Hva lærte jeg? |
| ------------------- | --------- | ------- | -------------- |
| \_3crew4days_24     | 24        | 24      |                |
| \_0crew4days_0      | 0         | 0       |                |
| \_1crew1days_2      | 2         | 2       |                |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

ExerciseTests.cd for å skrive flere testtilfeller.
FuelCalculator.cs for å demonstrere at å endre multiplikatoren fra 2 til 3 fremdeles kan gi riktig testresultat. Derfor er det viktig å teste flere verdier.

Svar på refleksjonsspørsmålene:

- testene der verken x eller y er 0 feiler.
- testen der x eller y er 0 er vellykket.
- 3crew4days: Expected 24, actual 36. 1crew2days: Expected 2, actual 3.
