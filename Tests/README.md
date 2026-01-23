## Oppgave uke 2

## Tester

Kjøres med `dotnet test`, eller i vscode.

ISafeAccessContractTests tester metodene som defineres i ISafeAccess og kan derfor brukes
for andre klasses som implementerer ISafeAccess.

"Happy path" testes ved å legge til verdier for så å hente dem ut og sjekke at riktig verdi
gies tilbake. Så testes det for feilhåndtering som gjøres med retur av false.

ContainerTests tester Container for det som ikke testes i ISafeAccessContractTests.
Det er å legge til og fjerne verdier og at forsøk på å fjerne verider som ikke finnes
resulterer i riktig Exception.

Jeg føler at disse testene dekker grunnfunskjonaliteten og gir form for dokumentasjon
på funksjonaliten som klassen implementerer og andre vil kunne hvordan de brukes.
