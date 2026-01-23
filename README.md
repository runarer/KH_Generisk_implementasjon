# KH_Generisk_implementasjon

## Oppgave uke 1

### Del 1 - Generisk klasse

Klassene er laget etter testene fra oppgave 2.

Implementert en Comparer<T> som krever en type av IComparable.

Container<T> implementerer interfacet fra del 2, lagrer verdier sekvensielt og
kan slettes med index.

### Del 2 - Interface

ISafeAccess er et interface for en klasser med lagring der det å hente ut verdier gjøres med
Try methoder som returnerer true/false istedenfor å kaste exception.

Et interface kan gi mer fleksivbel kode fordi der man kan forandre implementasjonen uten å
endre andre deler av koden. Tester trenger heller ikke endres.

## Oppgave uke 2

Under '/tests'
