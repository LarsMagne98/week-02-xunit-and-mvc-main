# Arbeidslogg – Oppdragstavlen: test modellen før menyen

## Før koding

Min forventning og begrunnelse:
Jeg forventet at testen for å fullføre et oppdrag skulle feile, fordi MissionBoard.Complete() ikke fant oppdraget og fullførte det ennå.

## Forsøk

| Handling / testnavn                                               | Forventet                          | Faktisk                                        | Hva lærte jeg? |
| ----------------------------------------------------------------- | ---------------------------------- | ---------------------------------------------- | -------------- |
| `Complete_KnownId_CompletesOnlySelectedTask` før implementasjonen | `true`, og riktig oppdrag fullført | Testen feilet; `Complete()` returnerte `false` |                |
| Alle tester etter implementasjonen                                | Alle 8 består                      | 8 bestått, 0 feilet                            |                |

## Etterpå

Hvilke filer endret jeg, og hvorfor?
MissionBoard.cs for å finne oppdraget med riktig ID, kalle MissionTask.Complete() og returnere true eller false. ExerciseTests.cs for å legge til tester for tom tavle, gjentatt fullføring, uavhengige tavler og at listekopien inneholder de samme oppdragsobjektene.

## Refleksjon

### 1.

MissionBoard har ansvar for å finne oppdraget ut fra ID-en, mens MissionTask har ansvar for sin egen fullførte tilstand. Ved å kalle MissionTask.Complete() unngår vi å duplisere regelen for hvordan et oppdrag fullføres.

### 2.

Listekopien beskytter tavlens interne liste mot endringer i listen som GetAll() returnerer. For eksempel vil det å tømme kopien ikke fjerne oppdragene fra tavlen. Den kopierer ikke selve oppdragsobjektene, så endringer på et objekt i kopien påvirker det samme objektet tavlen refererer til.

### 3.

Assert.Equal() kontrollerer at verdiene er like. Assert.Same() kontrollerer at to referanser peker til nøyaktig det samme objektet. Derfor bruker jeg Assert.Same(item, copy[0]) for å sjekke at oppdraget i den returnerte listen er det samme objektet som Add() returnerte.

### 4.

Hver test får da sin egen, forutsigbare tilstand og blir uavhengig av rekkefølgen testene kjøres i. Endringer i én test kan ikke påvirke resultatet av en annen test.
