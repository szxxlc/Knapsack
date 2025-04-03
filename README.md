# Problem plecakowy
 
 ## Wstęp
 Projekt zawiera implementację aplikacji rozwiązującej problem plecakowy. Należało stworzyć aplikację, która umożliwia użytkownikowi rozwiązanie problemu plecakowego wraz z graficznym interfejsem użytkownika. Należało także zaimplementować testy jednostkowe sprawdzające poprawność działania aplikacji. Projekt powstał na potrzeby kursu Platformy Programistyczne .NET i Java na Politechnice Wrocławskiej.

 ## Opis problemu
 Danymi wejściowymi są:
 - liczba przedmiotów
 - seed (ziarno) do generowania przedmiotów
 - pojemność plecaka

 Każdy z przedmiotów posiada wartość i wagę. Celem jest wybranie takich przedmiotów, aby ich sumaryczna waga nie przekraczała pojemności plecaka, a sumaryczna wartość była jak największa. Problem ten jest NP-trudny - w projekcie został zaimplementowany algorytm zachłanny.

 ## Aplikacja konsolowa .NET
 Ta część projektu składa się z:
 - **Przedmiot.cs** - klasa reprezentująca przedmiot, przechowująca jego wartość i wagę
 - **Problem.cs** - klasa służąca do generowania instancji problemu oraz rozwiązania problemu
 - **Result.cs** - klasa reprezentująca wynik działania algorytmu, zwracająca wybrane przedmioty, ich sumaryczną wartość oraz wagę
 - **Program.cs** - klasa służąca do pobierania danych wejściowych od użytkownika oraz wyświetlania wyników
 
 ## Testy jednostkowe
 Projekt zawiera zestaw testów jednostkowych, które weryfikują poprawność:
 - generowania przedmiotów
 - rozwiązywania problemów, w zależności od spełnienia ograniczeń przez przedmioty (pojemność plecaka)
 - poprawność wyników zwracanych przez algorytm
 
Znajdują się one w klasie **ProblemTests.cs**.
 
 ## GUI
 Aplikacja posiada również interfejs graficzny w formie aplikacji okienkowej. Posiada on obsługę błędów i walidację danych. Pobiera od użytkownika dane wejściowe i zwraca zestaw wygenerowanych przedmiotów oraz wynik. 

 Znajduje się ona w klasie **Form1.cs**.

 ## Wykorzystane technologie
 - .NET 8.0
 - C#
 - MSTest (Testy jednostkowe)
 - Windows Forms (GUI)
