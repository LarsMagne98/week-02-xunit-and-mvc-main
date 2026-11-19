# Arbeidslogg – Setereservasjon: Theory og grensetilfeller

## Før koding

Min forventning og begrunnelse:
Skal gå ganske greit. Har hatt god undervisning i dette.

## Forsøk

| Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?                  |
| ------------------- | --------- | ------- | ------------------------------- |
| 1,4                 | true      | true    |                                 |
| 3,4                 | true      | true    |                                 |
| 4,4                 | true      | false   | <-- egentlig forventa false pga |
|                     |           |         | feil betingelse i SeatPolicy.cs |
| 5,4                 | false     | false   |                                 |
| 0,4                 | false     | false   |                                 |
| -1,4                | false     | false   |                                 |
| 1,0                 | false     | false   |                                 |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

ExerciseTests.cs for å lage flere testtilfeller.
SeatPolicy.cd for å rette på feil betingelse.

Svar på refleksjonsspørsmålene:

## 1. Undersøk den ferdige testen

- For å enklere teste flere verdier.
- Det er xUnit som leser av [InlineData] og kobler de til testmetoden. Det kjøres like mange testtilfeller som antall [InlineData] det er.
- Assert.Equal(expected, actual) sammenligner om de to tilfellene er like. I vårt tilfelle to booleans. Hvis verdiene er forskjellige feiler testen.

## 2.

- Det er testtillfellet 4,4, true som feiler. Det er fordi betingelsen i SeatPolicy.cs sier at requested skal være MINDRE ENN available. Men det riktige for oss er at den er MINDRE ENN eller LIK.
- Forventet resultat er true, faktisk resultat er false.
- Det burde være godkjent siden 4 ledige seter kan ta 4 personer.

## 4.

- 3 ønskede seter, 4 ledige seter. Betingelsen er sann siden 3 er mindre enn 4.
- 4 ønskede seter, 4 ledige seter. Burder være sann siden 4 er lik 4. men den er usann fordi 4 ikke er MINDRE ENN 4.
- 5 ønskede seter, 4 ledige seter. Betingelsen er usann siden 5 ikke er MINDRE ENN 4.
