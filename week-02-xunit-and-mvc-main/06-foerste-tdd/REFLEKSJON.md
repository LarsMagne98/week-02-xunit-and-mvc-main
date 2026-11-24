# Arbeidslogg – Oppdragskort: første Red–Green–Refactor

## Før koding

Min forventning og begrunnelse:

## Forsøk

| Handling / testnavn     | Forventet | Faktisk   | Hva lærte jeg? |
| ----------------------- | --------- | --------- | -------------- |
| TaskIsComplete - rød    | failed    | failed    |                |
| TaskIsComplete - green  | succeeded | succeeded |                |
| TaskIsComplete_Repeated | succeeded | succeeded |                |

## Etterpå

### Hvilke filer endret jeg, og hvorfor?

MissionTask.cs for å implimentere Complete() metoden.
ExerciseTests.cs for å lage flere tester.

Svar på refleksjonsspørsmålene:

### 2.

- TaskIsComplete feilet.
- Den forventer at .IsComplete er true.
- IsComplete er false.
- Den feilet fordi jeg ikke har laget koden for Complete() enda.

### Refleksjon

1. For å bruke TDD metoden.
2. For at jeg ikke hadde implimentert riktig koden enda. hadde vert feil hvis den var vellykket før koden var skrevet.
3. For at den ikke gjorde noe på forhånd.
4. Hvis du i utgangspunktet skriver den leselig og effektiv trenger du ikke endre noe.
