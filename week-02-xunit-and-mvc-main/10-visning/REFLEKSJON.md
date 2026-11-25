# Arbeidslogg – Visningen: vis data uten å endre dem

## Før koding

Min forventning og begrunnelse:

## Forsøk

| Handling / testnavn | Forventet | Faktisk | Hva lærte jeg? |
| ------------------- | --------- | ------- | -------------- |

## Etterpå

Hvilke filer endret jeg, og hvorfor?
MissionView.cs for å implimentere ShowTasks().

Svar på refleksjonsspørsmålene:

### 7.

- En utskrifta av Tasks.
- Med å sjekke om tasks.count er 0
- Med å skrive en linje med [Fullført] der tasks.IsComplete er true. og [Venter] ellers.
- De ga forventet resultat.
- Koden endrer aldri verdi i ShowTasks() bare viser verdiene.

### Refleksjon

1. Fordi du kan vise andre verdier enn intensjonen. Mens testene sørger for at logikken fungerer som den skal.

2. ShowTasks() skal presentere eksisterende informasjon, ikke endre den. Det er modellen som har ansvaret for.

3. Listen som argument lar ShowTasks() vise oppdragene den får uten å opprette eller eie en egen tavle.

4. View oversetter oppdragets status til tekst brukeren forstår. Å fullføre et oppdrag endrer tilstanden og det er ansvaret til modellen.
