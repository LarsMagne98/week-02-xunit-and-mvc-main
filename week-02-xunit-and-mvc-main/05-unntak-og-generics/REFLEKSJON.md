# Arbeidslogg – Lastestabel: LIFO og forventede unntak

## Før koding

Min forventning og begrunnelse:
Forventer å måtte fikse CargoStack.cs for der er det en feil i forhold til hva oppgaven ber om.

## Forsøk

| Handling / testnavn           | Forventet | Faktisk   | Hva lærte jeg? |
| ----------------------------- | --------- | --------- | -------------- |
| Ny Stack - Før CargoStack fix | failed    | failed    |                |
| Ny Stack- Etter fix           | succeeded | succeeded |                |
| LIFO_Test                     | succeeded | succeeded |                |
| Test_Integer                  | succeeded | succeeded |                |
| Test_Reuse                    | succeeded | succeeded |                |

## Etterpå

Hvilke filer endret jeg, og hvorfor?
CargoStack.cs for å sørge for at den kaster en "InvalidOperationException" når stacken er tom.
ExerciseTests.cs for å lage flere testtilfeller.

Svar på refleksjonsspørsmålene:

### 1.

1. Stabelen opprettes i hver test i ExerciseTests.cs.
2. Assert.Throws sjekker at den spesifike exception er den som blir kasta når du prøver å bruke pop på en tom stack.
3. Testen forventer InvalidOperationException

### 2.

1. Pop_EmptyStack_ThrowsInvalidOperationException
2. InvalidOperationException når stacken er tom.
3. ArgumentOutOfRangeException.

### Refleksjon.

1. Da ville vi ikke få ønsket resultat, bare at testen gir success.
2. Fordi Equal sammenligner to verdier, men når .Pop feiler returnerer den ikke en verdi, men kaster ett unntak.
3. At CargoStack er generisk så vi kan bruke den med ulike datatyper.
