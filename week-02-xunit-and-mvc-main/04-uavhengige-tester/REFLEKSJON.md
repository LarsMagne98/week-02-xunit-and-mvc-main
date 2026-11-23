# Arbeidslogg – Lasterom: test tilstand uten testrekkefølge

## Før koding

Min forventning og begrunnelse:

## Forsøk

| Handling / testnavn | Forventet                    | Faktisk                      | Hva lærte jeg? |
| ------------------- | ---------------------------- | ---------------------------- | -------------- |
| Tom Cargo           | Count = 0                    | Count = 0                    |                |
| Første innlegging   | True, Count = 1              | True, Count = 1              |                |
| Andre innlegging    | True, True, Count = 2        | True, True, Count = 2        |                |
| Tredje innlegging   | True, True, False, Count = 2 | True, True, False, Count = 2 |                |
| To CargoBays        | Count = 1, Count = 0         | Count = 1, Count = 0         |                |

## Etterpå

Hvilke filer endret jeg, og hvorfor?
ExerciseTests.cs for å legge til alle testtilfellene.

Svar på refleksjonsspørsmålene:

1. For at vi oppretter en ny instanse for listen for hver test.
2. For å kontrollere at innholdet ble endret eller ikke på riktig måte. At ikke TryAdd returnerer false, men så ble likevell innholdet endret, eller omvendt.
3. Hvis CargoBay hadde vert static ville listen vert den samme i alle testtilfellene. Den andre testen ville allerede inneholdt en unit fra første testen. Den ville da feilet når vi prøver å legge til secondAdd, for den ville returnert false i steden for true. osv i de neste testene.
