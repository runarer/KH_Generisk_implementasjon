# KH_Generisk_implementasjon

Oppgave 1 og 2 for Backend Modul 2. Tester i oppgave 2 laget først og implementasjon av
oppgave 1 deretter.

## Oppgave 1

### Del 1 - Generisk klasse

Klassene er laget etter testene fra oppgave 2.
Implementert en Comparer<T> som krever en type av IComparable.
Container<T> implementerer Interfacet fra del 2, lagrer verdier sekvensielt og
kan hentes ut eller slettes med index.

### Del 2 - Interface

## Refleksjon etc.

### Interface

Med et interface som IStorable så kan man lage en ny klasse med en
annen måte å lagre informasjonen på og samtidig bruke testene om igjen
siden grensesnittet er det samme.

## Tester

Kjøres med `dotnet test`, eller i vscode.

StorageContractTests tester metodene som defineres i IStorable og kan derfor brukers
for andre klasses som implementerer IStorable.

ContainerTests tester Container, metodene og properites som ikke defineres i IStorable.
