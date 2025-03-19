using ProblemPlecakowy;

namespace TestProject
{
    [TestClass]
    public sealed class UnitTest
    {
        // sprawdzenie czy jeśli co najmniej jeden przedmiot spełnia ograniczenia, to zwrócono co najmniej jeden element
        // sprawdzenie czy jeśli żaden przedmiot nie spełnia ograniczeń, to zwrócono puste rozwiązanie

        [TestMethod]
        public void TestMethodCheckElementsInBackpackAndCapacity()
        {
            List<int> capacity = new List<int>() { 0, 1, 5};
            foreach (int c in capacity)
            {
                Problem problem = new Problem(10);
                Result result = new Result();
                result = problem.Solve(c);

                List<int> emptyList = new List<int>();
                
                int itemsThatCouldFit = 0;

                foreach (Przedmiot x in problem.GetPrzedmioty())
                {
                    if (x.GetWaga() <= c)
                    {
                        itemsThatCouldFit++;
                    }
                }
                if (itemsThatCouldFit != 0)
                {
                    CollectionAssert.AreNotEqual(result.GetPrzedmioty(), emptyList);
                    Assert.AreNotEqual(result.GetSumarycznaWaga(), 0);
                    Assert.AreNotEqual(result.GetSumarycznaWartosc(), 0);
                }
                else
                {
                    CollectionAssert.AreEqual(result.GetPrzedmioty(), emptyList);
                    Assert.AreEqual(result.GetSumarycznaWaga(), 0);
                    Assert.AreEqual(result.GetSumarycznaWartosc(), 0);
                }
            }
        }

        // sprawdzenie poprawności wyniku dla konkretnej instancji

        [TestMethod]
        public void TestMethodIsResultCorrect()
        {
            int capacity = 20;
            int seed = 123456789;
            int n = 10;

            List<int> correctItems = new List<int> { 9, 1, 7, 8, 2 };
            int correctValue = 42;
            int correctWeight = 19;

            Problem problem = new Problem(n, seed);

            Result result = new Result();
            result = problem.Solve(capacity);

            CollectionAssert.AreEqual(result.GetPrzedmioty(), correctItems);
            Assert.AreEqual(result.GetSumarycznaWartosc(), correctValue);
            Assert.AreEqual(result.GetSumarycznaWaga(), correctWeight);
        }

        // sprawdzenie czy liczba wygenerowanych przedmiotow zgadza sie z podana

        [TestMethod]
        public void TestMethodCountElements()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
            {
                Problem problem = new Problem(n);
                Assert.AreEqual(n, problem.GetPrzedmioty().Count);
            }
        }

        // sprawdzenie czy zaden item nie ma wartosci ujemnej lub niebedacej w ustalonym zakresie

        [TestMethod]
        public void TestMethodCheckElementsValues()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
            {
                Problem problem = new Problem(n);
                List<Przedmiot> przedmioty = problem.GetPrzedmioty();
                foreach (Przedmiot p in przedmioty)
                {
                    Assert.IsTrue(p.GetWartosc() > 0 && p.GetWartosc() <= 10);
                }
            }
        }

        // sprawdzenie czy przedmioty w wyniku sa podzbiorem wygenerowanych przedmiotow

        [TestMethod]
        public void TestMethodCheckElementsInBackpackAndOriginalElements()
        {
            int capacity = 20;
            List<int> nValues = new List<int>() { 10, 20, 30 };

            foreach (int n in nValues)
            {
                Problem problem = new Problem(n);
                Result result = new Result();
                result = problem.Solve(capacity);

                foreach (int i in result.GetPrzedmioty())
                {
                    Assert.IsTrue(i >= 1 && i <= n);
                }

            }
        }
    }
}
