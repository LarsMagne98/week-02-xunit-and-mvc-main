# Arbeidslogg – Kontrolleren: koble sammen en hel konsollapp

## Før koding

Min forventning og begrunnelse:

## Forsøk

| Handling / testnavn | Forventet | Faktisk | Hva lærte jeg? |
| ------------------- | --------- | ------- | -------------- |

## Etterpå

Hvilke filer endret jeg, og hvorfor?
MissionController.cs for å implimentere CompleteTask().

Svar på refleksjonsspørsmålene:

### 7.

- MissionView.ReadInput
- CompleteTask() gjør den om til heltall når TryParse bruke på input.
- MissionBoard sjekker om oppdraget finnes.
- MissionTask endrer tilstanden.
- MissionView viser resultatet.

### 8.

- Fikk beskjed om at Fullføring er ikke koblet til ennå.
- I CompleteTask() leses id'en inn som tekst, TryParse prøver å konventere den til et heltall. hvis konventeringen feiler, vises en feilmelding og metoden avsluttes.
- Jeg endret den silk at den lese id gjennom view, bruker TryParse, og ber modellen fullføre oppdraget med \_board.Complete(id). Deretter viser den en melding basert på om modellen fant oppdraget.
- Den manuelle testen gjorde alt riktig.
- Modelltestene består fortsatt.
- Model eier oppdragene og reglene. View leser input og viser tekst. Controller hånderer menyvalgene, validerer input og kobler View til Model.

### Refleksjon

1. Silk at den samme tavlen beholder oppdragene gjennom hele løkken. Hvis den ble opprettet på nytt hver runde, ville oppdragene forsvinne.

2. TryParse kontrollerer inputen før vi sender IDen til Complete(). Det lar oss håndtere tekst som ugyldig input, i stede for å prøve å bruke den som et heltall.

3. Kontrolleren skal delegere til modellen. MissionBoard eier oppdragslisten og reglene for å fullføre oppdrag. Hvis kontrolleren endret IsComplete direkte, ville ansvarsområdet blandes og logikken dupliseres.

4. Modelltestene tester modelle, ikke hele konsollflyten. De kan derfor bestå selv om menyvalg 3 ikke kaller modellen riktig eller viser feil melding.

5. View leser Iden og viser meldinger. Controller validerer inputen og ber modellen fullføre oppdraget. Model finner oppdraget og endrer tilstanden.
