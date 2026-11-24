# Arbeidslogg – Oppskytingspris: forbedre grønn kode

## Før koding

Min forventning og begrunnelse:
Forvente å måtte bruke mattekunnskapen min. Som kanskje er helt midt på treet.

## Forsøk

| Handling / testnavn | Forventet | Faktisk | Hva lærte jeg? |
| ------------------- | --------- | ------- | -------------- |
|                     |           |         |                |
|                     |           |         |                |
|                     |           |         |                |
|                     |           |         |                |

## Etterpå

Hvilke filer endret jeg, og hvorfor?
ExerciseTests.cs for å legge til flere inlineData tester.
LaunchPrice.cs for å gjøre koden mer leselig og fjerne unødvendige linjer med beregning.

Svar på refleksjonsspørsmålene:

### 5.

Endret prisen for priority fra 120 til 121.

- Testtilfeller der priority er true feiler fordi det er der jeg endret prisregelen i LaunchPrice.cs
- Testtilfeller der priority er false består enda, fordi det ikke er gjort endring i prisregelen.
- Forventet 2400, faktisk 2420.

### Refleksjon

1. Variablene og utregningen.
2. For å sørge for at endringene jeg gjode ikke ødela ønsket resultat.
3. Å forbedre er å endre hvordan koden regner ut prisen, uten å endre hva regelen sier. Å endre prisregelen er å endre selve forretningsregelen, slik at prisen blir en annen i minst noen tilfeller.
4. Nei, en grønn testpakke viser bare at programmet oppfører seg som forventet for tilfellene testene faktisk undersøker. Selv mange tester kan ikke garantere at all oppførsel er riktig.
