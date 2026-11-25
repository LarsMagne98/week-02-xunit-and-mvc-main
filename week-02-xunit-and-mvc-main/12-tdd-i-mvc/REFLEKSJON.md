# Arbeidslogg – Nytt behov: vis bare ufullførte oppdrag

## Før koding

Min forventning og begrunnelse:

## Forsøk

| Handling / testnavn                               | Forventet | Faktisk | Hva lærte jeg?                                           |
| ------------------------------------------------- | --------- | ------- | -------------------------------------------------------- |
| GetPending_MixedBoard_ReturnsOnlyIncompleteTask() | Ingenting | Failed  | Har ikke implimentert GetPending() så den bør feile her. |
|                                                   |           |         |                                                          |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

Svar på refleksjonsspørsmålene:

### 10.

- Red: De testene som prøvde å bruke GetPending til noe annet enn en tom liste, før den gjorde noe annet enn å returnere en ny liste feilet.
- Green: Jeg la barre inn et LINQ uttrykk som parameter i listen som blir returnert : (\_tasks.Where(task => task.IsCompleted == false));
- Refactor: Gjorde ingen endringer.
- MVC: Model: fikset GetPending. View: Oppdaterte menyteksten til å inkludere valg 4. Controller: La til case "4".
- Manuell kontroll: Alt funket slik intensjonen var.

### Refleksjon

1. MissionBoard har ansvaret for data og forretningslogikk, og filtreringen kan testes direkte med xUnit. Mens MissionView har ansvar for å vise data.
2. For å ikke ødelegge dataene for GetAll() f.eks.
3. Den returnerte en tom liste fra begynnelsen av.
4. ShowTasks() tar imot hvilken som helst liste med MissionTask objekter og skriver den ut.
5. Med å sørge for at Add, Complete, GetAll og Count fremdeles fungerte etter endringen i GetPending.
