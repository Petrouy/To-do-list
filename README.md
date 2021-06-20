# Užitečný software
## Aplikace To-Do list
Petr Barvík
| barvik.petr.2018@---.cz
| 16. 5. 2021

* Úvod
  * Účel dokumentu
    * Účelem je vytvoření WPF aplikace, která bude zobrazovat uživatelem přidané úkoly
  * Kontakty
    * Barvík Petr | barvik.petr.2018@---.cz | tel. 111 111 111
* Celkový popis aplikace
  * Funkce
    * Aplikace bude zapisovat úkoly, které uživatel zadá
    * Aplikace bude tímto připomínat, co by uživatel měl udělat
    * Program bude ukládat data o uživateli
    * Tyto data jsou samotné úkoly, které si uživatel vytvořil
    * Úkoly se budou ukládat do .txt souboru, ze kterého bude program následně číst při novém spuštění programu
  * Uživatelské skupiny
    * Jakýkoliv uživatel PC
  * Omezení návrhu a implementace
    *  Zobrazení úkolů pouze na jednom zařízení
* Požadavky na rozhraní
  * Uživatelské rozhraní
    * Windows Presentation Foundation
  * Softwarová rozhraní
    * Microsoft Windows
* Vlastnosti systému
  * Zapsání úkolu
    * Vstup: Název úkolu a podrobnosti
    * Akce: Přidání úkolu do seznamu všech úkolů
    * Výstup: Zobrazení všech dosud zapsaných aktivních úkolů
  * Označení úkolu, jako dokončený
    * Vstup: Kliknutí na daný button, který se nachází u každého úkolu
    * Akce: Úkol se zapíše do listu dokončených úkolů
    * Výstup: Úkol již nebude viděn v sekci aktuálních úkolů
  * Smazání úkolu
    * Vstup: Označení daného úkolu
    * Akce: Smazání úkolu ze seznamu
    * Výstup: Zobrazení všech dosud zapsaných aktivních úkolů
* Nefunkční požadavky
  * Rozšířenost
    * Data nejsou dostupná na jiných zařízeních, pouze na lokálním zařízení
  * Bezpečnost
    * Aplikace je bezpečná, data se ukládají pouze na lokálním zařízení, aplikace nikam neposílá žádné data o uživateli
  * Spolehlivost
    * Aplikace nepoužívá internet a tudíž je spolehlivost téměř 100%


## Funkční specifikace
Verze 1.0.0

* Úvod
  * Účel dokumentu
    * Účelem je vytvoření WPF aplikace, která bude zobrazovat uživatelem přidané úkoly
  * Kontakty
    * Barvík Petr | barvik.petr.2018@---.cz | tel. 111 111 111
* Scénáře
  * Způsoby použití
    * Uživatel má možnost uložit si úkoly, které si sám vytvoří, podle své potřeby
    * Následně tyto úkoly může označit jako dokončené, či smazat úplně
  * Typy uživatelských rolí - Personas
    * Jakýkoli uživatel má stejné práva, jako ostatní
  * Příklad
    * Uživatel spustí program a vytvoří úkol, následně úkol označí jako dokončený, či samotný úkol smaže
  * Vymezení rozsahu
    * Program nebude posílat žádné data na internet, ani do cloudového úložiště
    * Tím se myslí, že všechna data jsou uložena pouze na lokálním zařízení
* Celková hrubá architektura
  * Pracovní tok
    * Uživatel spustí program
    * Vytvoří požadovaný počet úkolů
    * Uživatel může a nemusí zavřít program, data se budou ukládat do .txt souboru
    * Následně uživatel může označit úkoly jako dokončené
    * Uživatel může úkoly smazat úplně
  * Všechny detaily
    * Program se bude skládat z jednoho hlavního okna a jednoho vedlejšího okna ve WPF
    * Při přidávání nového úkolu se zobrazí vedlejší okno
      * Label uprostřed nahoře - Nápis "Přidat nový úkol"
      * Zadávání různého textu bude přes textboxy
    * Výpis úkolů
      * Label uprostřed nahoře - Nápis "úkoly To-Do"
      * Okno rozděleno do 3 částí (viz. Obrázek):
        * Vlevo sloupec všech aktivních úkolů
        * Vpravo podrobnosti o vybraném úkolu
          * Největší část
        * V dolní části okna bude sloupec hotových úkolů
      * Výpis aktivních úkolů přes labely
        * Záleží kolik bude mít uživatel aktivních úkolů
    * Odstranění úkolů bude přes Buttony v hlavním okně u každého okna
    * Při špatném zadání nového úkolu se zobrazí messagebox s nápisem Error

![image](https://user-images.githubusercontent.com/75619714/120157645-85be7f80-c1f3-11eb-9b8c-713edcc05f66.png)


