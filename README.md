# Problem plecakowy
 
 ## Wstêp
 Projekt zawiera implementacjê aplikacji rozwi¹zuj¹cej problem plecakowy. Nale¿a³o stworzyæ aplikacjê, która umo¿liwia u¿ytkownikowi rozwi¹zanie problemu plecakowego wraz z graficznym interfejsem u¿ytkownika. Nale¿a³o tak¿e zaimplementowaæ testy jednostkowe sprawdzaj¹ce poprawnoœæ dzia³ania aplikacji. Projekt powsta³ na potrzeby kursu Platformy Programistyczne .NET i Java na Politechnice Wroc³awskiej.

 ## Opis problemu
 Danymi wejœciowymi s¹:
 - liczba przedmiotów
 - seed (ziarno) do generowania przedmiotów
 - pojemnoœæ plecaka

 Ka¿dy z przedmiotów posiada wartoœæ i wagê. Celem jest wybranie takich przedmiotów, aby ich sumaryczna waga nie przekracza³a pojemnoœci plecaka, a sumaryczna wartoœæ by³a jak najwiêksza. Problem ten jest NP-trudny - w projekcie zosta³ zaimplementowany algorytm zach³anny.

 ## Aplikacja konsolowa .NET
 Ta czêœæ projektu sk³ada siê z:
 - **Przedmiot.cs** - klasa reprezentuj¹ca przedmiot, przechowuj¹ca jego wartoœæ i wagê
 - **Problem.cs** - klasa s³u¿¹ca do generowania instancji problemu oraz rozwi¹zania problemu
 - **Result.cs** - klasa reprezentuj¹ca wynik dzia³ania algorytmu, zwracaj¹ca wybrane przedmioty, ich sumaryczn¹ wartoœæ oraz wagê
 - **Problem.cs** - klasa s³u¿¹ca do pobierania danych wejœciowych od u¿ytkownika oraz wyœwietlania wyników
 
 ## Testy jednostkowe
 Projekt zawiera zestaw testów jednostkowych, które weryfikuj¹ poprawnoœæ:
 - generowania przedmiotów
 - rozwi¹zywania problemów, w zale¿noœci od spe³nienia ograniczeñ przez przedmioty (pojemnoœæ plecaka)
 - poprawnoœæ wyników zwracanych przez algorytm
 
Znajduj¹ siê one w klasie **ProblemTests.cs**.
 
 ## GUI
 Aplikacja posiada równie¿ interfejs graficzny w formie aplikacji okienkowej. Posiada on obs³ugê b³êdów i walidacjê danych. Pobiera od u¿ytkownika dane wejœciowe i zwraca zestaw wygenerowanych przedmiotów oraz wynik. 

 Znajduje siê ona w klasie **Form1.cs**.

 ## Wykorzystane technologie
 - .NET 8.0
 - C#
 - MSTest (Testy jednostkowe)
 - Windows Forms (GUI)