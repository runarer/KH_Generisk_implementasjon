# KH_Generisk_implementasjon

## Refleksjon etc.
### Interface
Med et interface som IStorable så kan man lage en ny klasse med en 
annen måte å lagre informasjonen på og samtidig bruke testene om igjen
siden grensesnittet er det samme.

## Tester
Kjøres med `dotnet test`

StorageContractTests tester metodene som defineres i IStorable og kan derfor brukers
for andre klasses som implementerer IStorable.

ContainerTests tester Container, metodene og properites som ikke defineres i IStorable.

Testene er hentet fra oppgaven.