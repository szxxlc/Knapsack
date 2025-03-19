# Problem plecakowy
 
 ## Wst�p
 Projekt zawiera implementacj� aplikacji rozwi�zuj�cej problem plecakowy. Nale�a�o stworzy� aplikacj�, kt�ra umo�liwia u�ytkownikowi rozwi�zanie problemu plecakowego wraz z graficznym interfejsem u�ytkownika. Nale�a�o tak�e zaimplementowa� testy jednostkowe sprawdzaj�ce poprawno�� dzia�ania aplikacji. Projekt powsta� na potrzeby kursu Platformy Programistyczne .NET i Java na Politechnice Wroc�awskiej.

 ## Opis problemu
 Danymi wej�ciowymi s�:
 - liczba przedmiot�w
 - seed (ziarno) do generowania przedmiot�w
 - pojemno�� plecaka

 Ka�dy z przedmiot�w posiada warto�� i wag�. Celem jest wybranie takich przedmiot�w, aby ich sumaryczna waga nie przekracza�a pojemno�ci plecaka, a sumaryczna warto�� by�a jak najwi�ksza. Problem ten jest NP-trudny - w projekcie zosta� zaimplementowany algorytm zach�anny.

 ## Aplikacja konsolowa .NET
 Ta cz�� projektu sk�ada si� z:
 - **Przedmiot.cs** - klasa reprezentuj�ca przedmiot, przechowuj�ca jego warto�� i wag�
 - **Problem.cs** - klasa s�u��ca do generowania instancji problemu oraz rozwi�zania problemu
 - **Result.cs** - klasa reprezentuj�ca wynik dzia�ania algorytmu, zwracaj�ca wybrane przedmioty, ich sumaryczn� warto�� oraz wag�
 - **Problem.cs** - klasa s�u��ca do pobierania danych wej�ciowych od u�ytkownika oraz wy�wietlania wynik�w
 
 ## Testy jednostkowe
 Projekt zawiera zestaw test�w jednostkowych, kt�re weryfikuj� poprawno��:
 - generowania przedmiot�w
 - rozwi�zywania problem�w, w zale�no�ci od spe�nienia ogranicze� przez przedmioty (pojemno�� plecaka)
 - poprawno�� wynik�w zwracanych przez algorytm
 
Znajduj� si� one w klasie **ProblemTests.cs**.
 
 ## GUI
 Aplikacja posiada r�wnie� interfejs graficzny w formie aplikacji okienkowej. Posiada on obs�ug� b��d�w i walidacj� danych. Pobiera od u�ytkownika dane wej�ciowe i zwraca zestaw wygenerowanych przedmiot�w oraz wynik. 

 Znajduje si� ona w klasie **Form1.cs**.

 ## Wykorzystane technologie
 - .NET 8.0
 - C#
 - MSTest (Testy jednostkowe)
 - Windows Forms (GUI)