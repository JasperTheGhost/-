using System;
namespace Projekt_Kukchiev54752
{
    class Program
    {
        static void EKObliczanieZnakowegoZapisu()
        {
            string s = string.Empty;
            int Horner = 0;
            int EKp ;
            Console.WriteLine("Wybrano: \n\tK: Obliczanie(konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym o " +
                                                                               " podanej (przez użytkownika programu) podstawie liczenia (in-line)  ");
            ConsoleKeyInfo EKMenu_1;

            Console.WriteLine("\n\n\tKtóry system ma zostać wykonany");
            Console.WriteLine("\n1.Zapis binarny (2)");
            Console.WriteLine("\n2.Zapis osemkowy (8)");
            Console.WriteLine("\n3.Zapis heksadecymalny (16)");
            Console.WriteLine("\n4.Zapis dziesiątkowy (10)");

            Console.WriteLine("\nWybor: ");
            EKMenu_1 = Console.ReadKey();
            if (EKMenu_1.Key == ConsoleKey.D1)
            {



                Console.WriteLine("\nPodaj stopień wielomioanu: ");
                while (!int.TryParse(Console.ReadLine(), out EKp) && (EKp >= 0))
                {
                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKp == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }


                int[] a = new int[++EKp];

                Console.WriteLine("Podaj wartosc a: ");

                for (int i = 0; i < EKp; i++)
                {
                    while (!int.TryParse(Console.ReadLine(), out a[i]) || ((a[i] != 0) && (a[i] != 1)))
                    {
                        Console.WriteLine("ERROR: w zapisie {0 } -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", i);
                        Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                    }
                    Console.WriteLine($"a [" + i + "] = " + a[i]);
                }

                Horner = a[0];
                for (int i = 1; i < EKp; i++)
                {
                    Horner = Horner * 2 + a[i];
                }
            }
            else if (EKMenu_1.Key == ConsoleKey.D2)
            {



                Console.WriteLine("\nPodaj stopień wielomioanu: ");
                while (!int.TryParse(Console.ReadLine(), out EKp) && (EKp >= 0))
                {
                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKp == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }


                int[] a = new int[++EKp];

                Console.WriteLine("Podaj wartosc a: ");

                for (int i = 0; i < EKp; i++)
                {
                    while (!int.TryParse(Console.ReadLine(), out a[i]) || (a[i] < 0) || (a[i] > 7))
                    {
                        Console.WriteLine("ERROR: w zapisie {0 } -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", i);
                        Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                    }
                    Console.WriteLine($"a [" + i + "] = " + a[i]);

                }


                Horner = a[0];
                for (int i = 1; i < EKp; i++)
                {
                    Horner = Horner * 8 + a[i];
                }

            }
            else if (EKMenu_1.Key == ConsoleKey.D3)
            {
                Console.WriteLine("\nPodaj stopień wielomioanu: ");
                while (!int.TryParse(Console.ReadLine(), out EKp) && (EKp >= 0))
                {
                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKp == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }


                int[] a = new int[++EKp];
                string input;
                Console.WriteLine("Podaj wartosc a: ");

                for (int i = 0; i < EKp; i++)
                {
                    while (!int.TryParse((input = Console.ReadLine()), out a[i]) || (a[i] < 0) || (a[i] > 9))
                    {
                        if (input.Length == 1 && input[0] > 64 && input[0] < 71)
                        {
                            a[i] = input[0] - 65 + 10;
                            break;
                        }
                        Console.WriteLine("ERROR: w zapisie {0 } -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", i);
                        Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                    }
                    Console.WriteLine($"a [" + i + "] = " + a[i]);

                }


                Horner = a[0];
                for (int i = 1; i < EKp; i++)
                {
                    Horner = Horner * 16 + a[i];
                }


            }
            else if (EKMenu_1.Key == ConsoleKey.D4)
            {
                Console.WriteLine("\nPodaj stopień wielomioanu: ");
                while (!int.TryParse(Console.ReadLine(), out EKp) && (EKp >= 0))
                {
                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKp == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }


                int[] a = new int[++EKp];

                Console.WriteLine("Podaj wartosc a: ");

                for (int i = 0; i < EKp; i++)
                {
                    while (!int.TryParse(Console.ReadLine(), out a[i]) || (a[i] < 0) || (a[i] > 9))
                    {
                        Console.WriteLine("ERROR: w zapisie {0 } -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", i);
                        Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                    }
                    Console.WriteLine($"a [" + i + "] = " + a[i]);

                }


                Horner = a[0];
                for (int i = 1; i < EKp; i++)
                {
                    Horner = Horner * 10 + a[i];
                }

            }
            ConsoleKeyInfo EKMenu_2;
            Console.WriteLine("Do jakiego systemu chcesz dokonać przelewu ");
            Console.WriteLine("\n1.Zapis binarny (2)");
            Console.WriteLine("\n2.Zapis osemkowy (8)");
            Console.WriteLine("\n3. Zapis heksadecymalny (16)");
            Console.WriteLine("\n4.Zapis dziesiątkowy (10)");
            Console.WriteLine("\nWybor: ");
            EKMenu_2 = Console.ReadKey();
            if (EKMenu_2.Key == ConsoleKey.D1)
            {
                int x = Horner;
                for (; x > 0;)
                {
                    var tmp = x % 2;
                    s = (tmp == 0 ? "0" : tmp.ToString()) + s;
                    x /= 2;
                }
                Console.WriteLine("=============================================");
                Console.WriteLine($"\nWynik: {s} system liczbowy = dwókowy");
                Console.WriteLine("=============================================");
            }
            else if (EKMenu_2.Key == ConsoleKey.D2)
            {
                int x = Horner;
                for (; x > 0;)
                {
                    var tmp = x % 8;
                    s = (tmp == 0 ? "0" : tmp.ToString()) + s;
                    x /= 8;
                }
                Console.WriteLine("=============================================");
                Console.WriteLine($"\nWynik: {s} system liczbowy = osemkowy");
                Console.WriteLine("=============================================");
            }
            else if (EKMenu_2.Key == ConsoleKey.D3)
            {
                string m = Convert.ToString(Horner, 16);
               
                for (; Horner > 0;)
                {
                    var tmp = Horner % 16;
                    s = (tmp == 0 ? "0" : tmp.ToString()) + s;
                    Horner /= 16;
                }
                Console.WriteLine("=============================================");
                Console.WriteLine($"\nWynik:{m.ToUpper()} system liczbowy = heksadecymalny");
                Console.WriteLine("=============================================");
            }
            else if (EKMenu_2.Key == ConsoleKey.D4)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine($"\nWynik: {Horner} system liczbowy = dziesiątkowy");
                Console.WriteLine("=============================================");
            }
        }
        static void EKŚredniaGeometryczna()
        {
            Console.WriteLine(" Podaj liczność ciągu liczbowego n:");
            ushort EKn;
            do
            {
                while (!ushort.TryParse(Console.ReadLine(), out EKn))
                {

                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKn == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }


            } while (EKn == 0);
            float EKb;
            double EKgeom = 1.0;
            for (int EKi = 1; EKi <= EKn; EKi++)
            {
                Console.WriteLine("\n\tPodaj {0}-ą wartość wyrazu ciągu liczbowego: ", EKi);
                while (!float.TryParse(Console.ReadLine(), out EKb) || EKb < 0)
                {
                    Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", EKi);
                    Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");

                }
                EKgeom = EKgeom * EKb;
            }
            double EKŚredniajaGeometriczna = Math.Pow(EKgeom, (double)1.0 / EKn);
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:F2}", EKn, EKŚredniajaGeometriczna);
            Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:E2}", EKn, EKŚredniajaGeometriczna);
            Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:G}", EKn, EKŚredniajaGeometriczna);
            Console.WriteLine("========================================================================================================================");
        }
        static void EKŚredinaharmoniczna()
        {
            Console.WriteLine(" Podaj liczność ciągu liczbowego n:");
            ushort EKn;
            do
            {
                while (!ushort.TryParse(Console.ReadLine(), out EKn))
                {

                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKn == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }

            } while (EKn == 0);
            float EKa, EKmean;
            EKmean = 0.0F;
            for (int EKi = 1; EKi <= EKn; EKi++)
            {
                Console.WriteLine("\n\tPodaj {0}-ą wartość wyrazu ciągu liczbowego: ", EKi);
                while (!float.TryParse(Console.ReadLine(), out EKa))
                {
                    Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", EKi);
                    Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                }
                EKmean = EKmean + 1 / EKa;
            }
            if (EKmean == 0) // nie może tak być,ponieważ liczba ta jest w mianowniku
            {
                Console.WriteLine("\n\tERROR: liczność  musi być większa od 0, gdyż tego wymaga warunek wejściowy:EKmean > 0!!!!");

            }
            else
            {
                //formuła dla rozwiązanie funkcji końcowa 
                float Średniaharmoniczna = (EKn / EKmean);//odpowiedź na funkcję
                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:F2}", EKn, Średniaharmoniczna);
                Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:E2}", EKn, Średniaharmoniczna);
                Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:G}", EKn, Średniaharmoniczna);
                Console.WriteLine("========================================================================================================================");
            }
        }
        static void EKObliczaniejedonstki()
        {
            bool EKRealizacjaZeŚledzeniem;
            Console.Write("\n\t Jeżeli chcecz,aby program realizował obliczenie ze" +
"śledzeniem to naciśnij klawisz T (lub t) , \n\t a gdy naciśniecz dowolny inny" +
"klawisz,to uznam,żeby rezygnujesz ze śledzenia: ");
            //Realicacja za śledzeniem
            if (Console.ReadKey().Key == ConsoleKey.T)
                EKRealizacjaZeŚledzeniem = true;
            else
                EKRealizacjaZeŚledzeniem = false;
            ushort EKn;
            Console.WriteLine("\n\tPodaj ilość gatunków pszenicy ");
            do
            {
                while (!ushort.TryParse(Console.ReadLine(), out EKn))
                {

                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKn == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }
            } while (EKn == 0);
            float EKa;
            float EKkg;
            double EKmnozenie = 0.0F;
            double EKmassa = 0.0F;
            for (int EKi = 1; EKi <= EKn; EKi++)
            {

                Console.WriteLine("\n\tCena wybranego rodzaju pszenicy: ", EKi);
                while (!float.TryParse(Console.ReadLine(), out EKa))
                {
                    Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", EKi);
                    Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                }
                Console.WriteLine("\n\tMasa wybranego rodzaju pszenicy: ", EKi);
                while (!float.TryParse(Console.ReadLine(), out EKkg) || EKkg < 0 || EKkg == 0)
                {
                    Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", EKi);
                    Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                }

                EKmassa += EKkg;
                if (EKRealizacjaZeŚledzeniem == true)
                    Console.WriteLine("\n\t\t Trace: obliczona  {0}  Massa równa = {1} ", EKi, EKmassa);
                EKmnozenie += EKa * EKkg;
                if (EKRealizacjaZeŚledzeniem == true)
                    Console.WriteLine("\n\t\t Trace: obliczona  {0}  Mnożenie równe = {1} ", EKi, EKmnozenie);

            }
            double EKCena = EKmnozenie / EKmassa;

            Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz.");
            Console.WriteLine("Podaj cenę za kilo: ");
            Console.WriteLine("=============================================|");
            Console.WriteLine("Cena jednostki paszy: " + EKCena + "                      |");
            Console.WriteLine("=============================================|");

        }
        static void EKŚredniakwadratowa()
        {
            Console.WriteLine(" Podaj liczność ciągu liczbowego n:");
            ushort EKn;
            do
            {
                while (!ushort.TryParse(Console.ReadLine(), out EKn))
                {

                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKn == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }
            } while (EKn == 0);
            float EKb;
            double EKkwadrat = 0.0F;
            for (int EKi = 1; EKi <= EKn; EKi++)
            {
                Console.WriteLine("\n\tPodaj {0}-ą wartość wyrazu ciągu liczbowego: ", EKi);
                while (!float.TryParse(Console.ReadLine(), out EKb))
                {
                    Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", EKi);
                    Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                }
                EKkwadrat += EKb * EKb;
            }
            double EKŚredniakwadratowa = Math.Sqrt(EKkwadrat / EKn);
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:F2}", EKn, EKŚredniakwadratowa);
            Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:E2}", EKn, EKŚredniakwadratowa);
            Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:G}", EKn, EKŚredniakwadratowa);
            Console.WriteLine("========================================================================================================================");
        }
        static void EKŚredniapotęgowa()
        {
            Console.WriteLine(" Podaj liczność ciągu liczbowego n:");
            ushort EKn;
            do
            {
                while (!ushort.TryParse(Console.ReadLine(), out EKn))
                {

                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKn == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }
            } while (EKn == 0);
            Console.WriteLine("Podaj stopień k: ");
            ushort EK_k;
            do
            {
                while (!ushort.TryParse(Console.ReadLine(), out EK_k))
                {

                    Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                    Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                    if (EKn == 0)
                        Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                }
            } while (EK_k == 0);
            float EKb;
            double EKpotęgowa = 0.0F;
            for (int EKi = 1; EKi <= EKn; EKi++)
            {
                Console.WriteLine("\n\tPodaj {0}-ą wartość wyrazu ciągu liczbowego: ", EKi);
                while (!float.TryParse(Console.ReadLine(), out EKb) || EK_k % 2 > 0 && EKb < 0)
                {
                    Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak lub litera!!!", EKi);
                    Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                }
                EKpotęgowa += Math.Pow(EKb, EK_k) / EKn;
            }
            double EKŚredniapotęgowa = Math.Pow(EKpotęgowa, 1.0 / EK_k);
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:F2}", EKn, EKŚredniapotęgowa);
            Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:E2}", EKn, EKŚredniapotęgowa);
            Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:G}", EKn, EKŚredniapotęgowa);
            Console.WriteLine("========================================================================================================================");
        }


        static void Main(string[] args)
        {//Inicjalizacja zmiennych
            ushort EKn;
            ConsoleKeyInfo EKmenu;
            bool EKRealizacjaZeŚledzeniem;
            void EKwczytanie_n()//method dla wczytanie n
            {
                do
                {
                    while (!ushort.TryParse(Console.ReadLine(), out EKn))//sprawdzanie, czy nie ma liter
                    {

                        Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                        Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                        if (EKn == 0)//sprawdzanie, czy n != 0
                            Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                    }
                } while (EKn == 0);
            }
         
            Console.WriteLine("\n\n\t\tProgram KalkulatorWielkościMatymatycznych ");
            do
            {//menu
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n\tMENU programu KalkulatorWielościMatymatycznych");
                Console.WriteLine("\n\tA.Obliczanie ceny jednostki  paszy (in-line) ");
                Console.WriteLine("\n\tB.Obliczanie ceny jednostki  paszy (method-call)");
                Console.WriteLine("\n\tC.Obliczanie średniej harmonicznej (in-line)");
                Console.WriteLine("\n\tD.Obliczanie średniej harmonicznej (method-call)");
                Console.WriteLine("\n\tE.Obliczanie średniej geometrycznej (in-line) ");
                Console.WriteLine("\n\tF.Obliczanie średniej geometrycznej (method-call)  ");
                Console.WriteLine("\n\tG.Obliczanie średniej kwadratowej (in-line) ");
                Console.WriteLine("\n\tH.Obliczanie średniej kwadratowej (method-call) ");
                Console.WriteLine("\n\tI.Obliczanie średniej potęgowej < średniej uogólnionej > (in -line) ");
                Console.WriteLine("\n\tJ.Obliczanie średniej potęgowej < średniej uogólnionej > (method-call) ");
                Console.WriteLine("\n\tK:Obliczanie (konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym o ");
                Console.WriteLine("\n\t                                     podanej (przez użytkownika programu) podstawie liczenia (in-line)  ");
                Console.WriteLine("\n\tL: Obliczanie (konwersja) znakowego zapisu liczby calłkowitej w systemie liczbowym o  ");
                Console.WriteLine("\n\t                                     podanej(przez użytkownika programu) podstawie liczenia(method-call)  ");
                Console.WriteLine("\n\tX.Zakończenie (wyjście z) programu");

                Console.WriteLine("\n\tNaciśnięciem odpowiedniego klawisza wybierz jedną z podanych funkcjonalności");
                EKmenu = Console.ReadKey();//odczytuje który klawisz nacisnęliśmy, aby przekazać nam funkcję, którą wybraliśmy
                if (EKmenu.Key == ConsoleKey.A)
                {
                    Console.WriteLine("\n\n Wybrano: A.Obliczanie ceny jednostki  paszy (in-line) ");
                    Console.Write("\n\t Jeżeli chcecz,aby program realizował obliczenie ze" +
    "śledzeniem to naciśnij klawisz T (lub t) , \n\t a gdy naciśniecz dowolny inny" +
    "klawisz,to uznam,żeby rezygnujesz ze śledzenia: ");
                    //Realicacja za śledzeniem
                    if (Console.ReadKey().Key == ConsoleKey.T)
                        EKRealizacjaZeŚledzeniem = true;
                    else
                        EKRealizacjaZeŚledzeniem = false;
                    Console.WriteLine("\t\n\n Podaj ilość gatunków pszenicy ");
                    //Method dla wczytania n
                    EKwczytanie_n();
                    //Inicjalizacja zmiennych
                    float EKa;
                    float EKkg;
                    double EKmnozenie = 0.0F;
                    double EKmassa = 0.0F;
                    for (int EKi = 1; EKi <= EKn; EKi++)
                    {

                        Console.WriteLine("\n\tCena wybranego rodzaju pszenicy: ", EKi);
                        while (!float.TryParse(Console.ReadLine(), out EKa) )
                        {//sprawdzanie, czy nie ma liter
                            Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak lub litera!!!", EKi);
                            Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                        }
                        Console.WriteLine("\n\tMasa wybranego rodzaju pszenicy: ", EKi);
                        while (!float.TryParse(Console.ReadLine(), out EKkg) || EKkg<0 || EKkg == 0) 
                        {//sprawdzanie, czy nie ma liter  i kg > 0
                            Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak lub litera!!!", EKi);
                            Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                        }
                        //formuła dla rozwiązanie funkcji
                        EKmassa += EKkg;
                        //śledzenie
                        if (EKRealizacjaZeŚledzeniem == true)
                            Console.WriteLine("\n\t\t Trace: obliczona  {0}  Massa równa = {1} ", EKi, EKmassa);
                        //formuła dla rozwiązanie funkcji
                        EKmnozenie += EKa * EKkg;
                        if (EKRealizacjaZeŚledzeniem == true)
                            Console.WriteLine("\n\t\t Trace: obliczona  {0}  Mnożenie równe = {1} ", EKi, EKmnozenie);
                    }//główna formuła, która daje efekt końcowy
                    double EKCena = EKmnozenie / EKmassa;
                    Console.WriteLine("To nie jest liczba, podaj wartosc jeszcze raz.");
                    Console.WriteLine("Podaj cenę za kilo: ");//odpowiedź na funkcję
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Cena jednostki paszy: " + EKCena + "      ");
                    Console.WriteLine("=============================================");

                }
                else if (EKmenu.Key == ConsoleKey.B)
                {
                    Console.WriteLine("\n\nWybrano: B.Obliczanie ceny jednostki  paszy (method-call)");
                    //wyjście metody "Obliczanie jednostki" 
                    EKObliczaniejedonstki();
                }
                else if (EKmenu.Key == ConsoleKey.C)
                {
                    Console.WriteLine("\n\nWybrana: C.Obliczanie średniej harmonicznej (in-line) ");
                    Console.WriteLine("");
                    Console.WriteLine(" Podaj liczność ciągu liczbowego n:");
                    //Method dla wczytania n
                    EKwczytanie_n();
                    //Inicjalizacja zmiennych
                    float EKa, EKmean;
                    EKmean = 0.0F;
                    for (int EKi = 1; EKi <= EKn; EKi++)
                    {
                        Console.WriteLine("\n\tPodaj {0}-ą wartość wyrazu ciągu liczbowego: ", EKi);
                        while (!float.TryParse(Console.ReadLine(), out EKa) || EKa == 0)//sprawdzanie, czy nie ma liter i nie równa 0
                        {
                            Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak lub litera!!!", EKi);
                            Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                        }

                        //formuła dla rozwiązanie funkcji
                        EKmean = EKmean + 1 / EKa;
                    }
                    if (EKmean == 0) // nie może tak być,ponieważ liczba ta jest w mianowniku
                    {
                        Console.WriteLine("\n\tERROR: liczność  musi być większa od 0, gdyż tego wymaga warunek wejściowy:EKmean > 0!!!!");

                    }
                    else
                    {
                        //formuła dla rozwiązanie funkcji końcowa 
                        float Średniaharmoniczna = (EKn / EKmean);//odpowiedź na funkcję
                        Console.WriteLine("========================================================================================================================");
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:F2}", EKn, Średniaharmoniczna);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:E2}", EKn, Średniaharmoniczna);
                        Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:G}", EKn, Średniaharmoniczna);
                        Console.WriteLine("========================================================================================================================");
                    }
                }
                else if (EKmenu.Key == ConsoleKey.D)
                {
                    Console.WriteLine("\n\tWybrana: D.Obliczanie średniej harmonicznej (method-call)");
                    EKŚredinaharmoniczna(); //wyjście metody Średniaharmoniczna 
                }
                else if (EKmenu.Key == ConsoleKey.E)
                {
                    Console.WriteLine("\n\nWybrana: E.Obliczanie średniej geometrycznej (in-line)  ");
                    Console.WriteLine("");
                    Console.WriteLine(" Podaj liczność ciągu liczbowego n:");
                    EKwczytanie_n();  //Method dla wczytania n
                    
                    float EKb;        //Inicjalizacja zmiennych
                    double EKgeom = 1.0F;
                    for (int EKi = 1; EKi <= EKn; EKi++)
                    {
                        Console.WriteLine("\n\tPodaj {0}-ą wartość wyrazu ciągu liczbowego: ", EKi);
                        while (!float.TryParse(Console.ReadLine(), out EKb) || EKb < 0)//sprawdzanie, czy nie ma liter i ujemnych liczb
                        {
                            Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak lub litera!!!", EKi);
                            Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                        }//formuła dla rozwiązanie funkcji
                        EKgeom = EKgeom * EKb;
                    }//główna formuła, która daje efekt końcowy
                    double EKŚredniajaGeometriczna = Math.Pow(EKgeom, 1.0 / EKn);//odpowiedź na funkcję
                    Console.WriteLine("========================================================================================================================");
                    Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:F2}", EKn, EKŚredniajaGeometriczna);
                    Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:E2}", EKn, EKŚredniajaGeometriczna);
                    Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:G}", EKn, EKŚredniajaGeometriczna);
                    Console.WriteLine("========================================================================================================================");
                }
                else if (EKmenu.Key == ConsoleKey.F)
                {
                    Console.WriteLine("\n\nWybrano: E.Obliczanie średniej geometrycznej (in-line) ");
                    EKŚredniaGeometryczna();//wyjście metody średniageometryczna
                }
                else if (EKmenu.Key == ConsoleKey.G)
                {
                    Console.WriteLine("\n\nWybrana: E.Obliczanie średniej kwadratowej (in-line)  ");
                    Console.WriteLine("");
                    Console.WriteLine(" Podaj liczność ciągu liczbowego n:");
                    EKwczytanie_n();//Method dla wczytania n

                    float EKb;       //Inicjalizacja zmiennych
                    double EK_kwadrat = 0.0F;
                    for (int i = 1; i <= EKn; i++)
                    {
                        Console.WriteLine("\n\tPodaj {0}-ą wartość wyrazu ciągu liczbowego: ", i);
                        while (!float.TryParse(Console.ReadLine(), out EKb))//sprawdzanie, czy nie ma liter
                        {
                            Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak lub litera!!!", i);
                            Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                        }//formuła dla rozwiązanie funkcji
                        EK_kwadrat += EKb * EKb;
                    }//formuła dla rozwiązanie funkcji końcowa 
                    double EKŚredniakwadratowa = Math.Sqrt(EK_kwadrat / EKn);//odpowiedź na funkcję
                    Console.WriteLine("========================================================================================================================");
                    Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:F2}", EKn, EKŚredniakwadratowa);
                    Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:E2}", EKn, EKŚredniakwadratowa);
                    Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:G}", EKn, EKŚredniakwadratowa);
                    Console.WriteLine("========================================================================================================================");
                }
                else if (EKmenu.Key == ConsoleKey.H)
                {
                    Console.WriteLine("\n\nWybrana: E.Obliczanie średniej kwadratowej (in-line)  ");
                    EKŚredniakwadratowa();//wyjście metody średniakwadratowa 
                }
                else if (EKmenu.Key == ConsoleKey.I)
                {
                    Console.WriteLine("\n\nWybrana: I.Obliczanie średniej potęgowej < średniej uogólnionej > (in -line)  ");
                    Console.WriteLine("");
                    Console.WriteLine(" Podaj liczność ciągu liczbowego n:");
                    EKwczytanie_n();//Method dla wczytania n

                    Console.WriteLine("Podaj stopień k: ");//wczytanie stopnia k
                    ushort EK_k;
                    do
                    {
                        while (!ushort.TryParse(Console.ReadLine(), out EK_k))//sprawdzanie, czy nie ma liter
                        {

                            Console.WriteLine("\n\tERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak lub litera!!!");
                            Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                            if (EKn == 0)
                                Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                        }
                    } while (EK_k == 0);
                    float EKb;//Inicjalizacja zmiennych
                    double EKpotęgowa = 0.0F;
                    for (int EKi = 1; EKi <= EKn; EKi++)
                    {
                        Console.WriteLine("\n\tPodaj {0}-ą wartość wyrazu ciągu liczbowego: ", EKi);
                        while (!float.TryParse(Console.ReadLine(), out EKb) || EK_k % 2 > 0 && EKb < 0)//sprawdzanie, czy nie ma liter i l\ujemnych liczb jeśli k = nieparzysta
                        {
                            Console.WriteLine("ERROR: w zapisie {0} -go wyrazu ciągu liczbowego wystąpił niedozwolony znak lub litera!!!", EKi);
                            Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                        }//formuła dla rozwiązanie funkcji
                        EKpotęgowa += Math.Pow(EKb, EK_k) / EKn;
                    }//formuła dla rozwiązanie funkcji końcowa 
                    double Średniapotęgowa = Math.Pow(EKpotęgowa, 1.0 / EK_k);//odpowiedź na funkcję
                    Console.WriteLine("========================================================================================================================");
                    Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:F2}", EKn, Średniapotęgowa);
                    Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:E2}", EKn, Średniapotęgowa);
                    Console.WriteLine("\n\tWYNIKI OBLICZEŃ: obliczona średnia arytmetyczna wyrazów ciągu o liczności n = {0} jest równa: {1, 8:G}", EKn, Średniapotęgowa);
                    Console.WriteLine("========================================================================================================================");
                }
                else if (EKmenu.Key == ConsoleKey.J)
                {
                    Console.WriteLine("\n\nWybrana: I.Obliczanie średniej potęgowej < średniej uogólnionej > (in -line)  ");
                    //wyjście metody EKśredniapotęgowa
                    EKŚredniapotęgowa();
                }
                else if (EKmenu.Key == ConsoleKey.K)
                {//Inicjalizacja zmiennych
                    string EKs = string.Empty;
                    uint EKHorner = 0;
                    uint EKp;
                    Console.WriteLine("Wybrano: \n\tK: Obliczanie(konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym o " +
                                                                                       " podanej (przez użytkownika programu) podstawie liczenia (in-line)  ");
                    ConsoleKeyInfo EKMenu_1;
                    // menu do wyboru systemu z którego dokonamy konwersji
                    Console.WriteLine("\n\n\tKtóry system ma zostać wykonany");
                    Console.WriteLine("\n1.Zapis binarny (2)");
                    Console.WriteLine("\n2.Zapis osemkowy (8)");
                    Console.WriteLine("\n3.Zapis heksadecymalny (16)");
                    Console.WriteLine("\n4.Zapis dziesiątkowy (10)");

                    Console.WriteLine("\nWybor: ");
                    EKMenu_1 = Console.ReadKey();
                    if (EKMenu_1.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine("\nPodaj stopień wielomioanu: ");//wczytanie stopnia wielomianu
                        while (!uint.TryParse(Console.ReadLine(), out EKp) && (EKp >= 0))//sprawdzanie, czy nie ma liter
                        {
                            Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                            Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                            if (EKp == 0)//sprawdzanie, czy p != 0
                                Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                        }

                        //Inicjalizacja zmiennych
                        uint[] EKliczba = new uint[++EKp];

                        Console.WriteLine("Podaj wartosc a: ");

                        for (int EKi = 0; EKi < EKp; EKi++)
                        {
                            while (!uint.TryParse(Console.ReadLine(), out EKliczba[EKi]) || ((EKliczba[EKi] != 0) && (EKliczba[EKi] != 1)))//sprawdzanie, czy nie ma liter i liczba =0 > liczba < 1
                            {
                                Console.WriteLine("ERROR: w zapisie {0 } -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", EKi);
                                Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                            }
                            Console.WriteLine($"a [" + EKi + "] = " + EKliczba[EKi]);
                        }

                        EKHorner = EKliczba[0];
                        for (int i = 1; i < EKp; i++)//rozwiązanie Hornera, tłumaczenie na system dziesiętny
                        {
                            EKHorner = EKHorner * 2 + EKliczba[i];
                        }
                    }
                    else if (EKMenu_1.Key == ConsoleKey.D2)
                    {

                        Console.WriteLine("\nPodaj stopień wielomioanu: ");//wczytanie stopnia wielomianu
                        while (!uint.TryParse(Console.ReadLine(), out EKp) && (EKp >= 0))//sprawdzanie, czy nie ma liter
                        {
                            Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                            Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                            if (EKp == 0)//sprawdzanie, czy nie p nie równa 0
                                Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                        }

                        //Inicjalizacja zmiennych
                        uint[] EKliczba = new uint[++EKp];

                        Console.WriteLine("Podaj wartosc a: ");

                        for (int EKi = 0; EKi < EKp; EKi++)
                        { //sprawdzanie, czy nie ma liter i 0 > liczba < 8
                            while (!uint.TryParse(Console.ReadLine(), out EKliczba[EKi]) || (EKliczba[EKi] < 0) || (EKliczba[EKi] > 7))
                            {
                                Console.WriteLine("ERROR: w zapisie {0 } -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", EKi);
                                Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                            }
                            Console.WriteLine($"a [" + EKi + "] = " + EKliczba[EKi]);
                        }
                        EKHorner = EKliczba[0];
                        for (int EKi = 1; EKi < EKp; EKi++)//rozwiązanie Hornera, tłumaczenie na system dziesiętny
                        {
                            EKHorner = EKHorner * 8 + EKliczba[EKi];
                        }

                    }
                    else if (EKMenu_1.Key == ConsoleKey.D3)
                    {
                        Console.WriteLine("\nPodaj stopień wielomioanu: ");
                        while (!uint.TryParse(Console.ReadLine(), out EKp) && (EKp >= 0))
                        {
                            Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                            Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                            if (EKp == 0)
                                Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                        }

                        //Inicjalizacja zmiennych
                        uint[] EKliczba = new uint[++EKp];
                        string EKinput;
                        Console.WriteLine("Podaj wartosc a: ");

                        for (int i = 0; i < EKp; i++)
                        {//sprawdzanie, czy nie ma liter i 0 > liczba < 9 i jeśli cyfra jest większa niż 9  będzie litera
                            while (!uint.TryParse((EKinput = Console.ReadLine()), out EKliczba[i]) || (EKliczba[i] < 0) || (EKliczba[i] > 9))
                            {
                                if (EKinput.Length == 1 && EKinput[0] > 64 && EKinput[0] < 71)
                                {
                                    EKliczba[i] = (uint)EKinput[0] - 65 + 10;
                                    break;
                                }
                                Console.WriteLine("ERROR: w zapisie {0 } -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", i);
                                Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                            }
                            Console.WriteLine($"a [" + i + "] = " + EKliczba[i]);

                        }


                        EKHorner = EKliczba[0];
                        for (int i = 1; i < EKp; i++)//rozwiązanie Hornera, tłumaczenie na system dziesiętny
                        {
                            EKHorner = EKHorner * 16 + EKliczba[i];
                        }


                    }
                    else if (EKMenu_1.Key == ConsoleKey.D4)
                    {
                        Console.WriteLine("\nPodaj stopień wielomioanu: ");//wczytanie stopnia wielomianu
                        while (!uint.TryParse(Console.ReadLine(), out EKp) && (EKp >= 0))//sprawdzanie, czy nie ma liter
                        {
                            Console.WriteLine("\n\tERROR: w zapisie liczności ciągu liczbowego wystąpił niedozwolony znak!!!");
                            Console.WriteLine("\n\tPodaj ponownie liczność ciągu liczbowego n: ");
                            if (EKp == 0)
                                Console.WriteLine("\n\tERROR: liczność ciągu liczbowego musi być większa od 0, gdyż tego wymaga warunek wejściowy:n > 0.");
                        }
                        uint[] EKliczba = new uint[++EKp];
                        Console.WriteLine("Podaj wartosc a: ");
                        for (int i = 0; i < EKp; i++)
                        {//sprawdzanie, czy nie ma liter i 0 > liczba < 9
                            while (!uint.TryParse(Console.ReadLine(), out EKliczba[i]) || (EKliczba[i] < 0) || (EKliczba[i] > 9))
                            {
                                Console.WriteLine("ERROR: w zapisie {0 } -go wyrazu ciągu liczbowego wystąpił niedozwolony znak!!!", i);
                                Console.WriteLine("\n\tPodaj ponowanie wartość {0}-go wyrazu ciągu liczbowego: ");
                            }
                            Console.WriteLine($"a [" + i + "] = " + EKliczba[i]);
                        }
                        EKHorner = EKliczba[0];
                        for (int i = 1; i < EKp; i++)//rozwiązanie Hornera, tłumaczenie na system dziesiętny
                        {
                            EKHorner = EKHorner * 10 + EKliczba[i];
                        }

                    }
                    ConsoleKeyInfo EKMenu_2;
                    Console.WriteLine("Do jakiego systemu chcesz dokonać przelewu ");//do jakiego systemu zostanie dokonana konwersja
                    Console.WriteLine("\n1.Zapis binarny (2)");
                    Console.WriteLine("\n2.Zapis osemkowy (8)");
                    Console.WriteLine("\n3. Zapis heksadecymalny (16)");
                    Console.WriteLine("\n4.Zapis dziesiątkowy (10)");
                    Console.WriteLine("\nWybor: ");
                    EKMenu_2 = Console.ReadKey();
                    if (EKMenu_2.Key == ConsoleKey.D1)
                    {
                        for (; EKHorner > 0;) //konwersja na system binarny
                        {
                            var EKtmp = EKHorner % 2;
                            EKs = (EKtmp == 0 ? "0" : EKtmp.ToString()) + EKs;
                            EKHorner /= 2;
                        }
                        Console.WriteLine($"\nWynik: {EKs} system liczbowy = dwókowy");//wynik
                    }
                    else if (EKMenu_2.Key == ConsoleKey.D2)
                    {
                        for (; EKHorner > 0;)//konwersja na system  osemkowy
                        {
                            var tmp = EKHorner % 8;
                            EKs = (tmp == 0 ? "0" : tmp.ToString()) + EKs;
                            EKHorner /= 8;
                        }
                        Console.WriteLine($"\nWynik: {EKs} system liczbowy = osemkowy");//wynik
                    }
                    else if (EKMenu_2.Key == ConsoleKey.D3)
                    {
                        string EKresult = Convert.ToString(EKHorner, 16);

                        for (; EKHorner > 0;)//konwersja na system heksadecymalny
                        {
                            var tmp = EKHorner % 16;
                            EKs = (tmp == 0 ? "0" : tmp.ToString()) + EKs;
                            EKHorner /= 16;
                        }
                        Console.WriteLine($"\nWynik:{EKresult.ToUpper()} system liczbowy = heksadecymalny");//wynik
                    }
                    else if (EKMenu_2.Key == ConsoleKey.D4)
                    {
                        Console.WriteLine($"\nWynik: {EKHorner} system liczbowy = dziesiątkowy");//konwersja na system  dziesiątkowy
                    }
                }
                else if (EKmenu.Key == ConsoleKey.L)
                {
                    Console.WriteLine("\n\tL: Obliczanie (konwersja) znakowego zapisu liczby calłkowitej w systemie liczbowym o  ");
                    Console.WriteLine("\n\t                                     podanej(przez użytkownika programu) podstawie liczenia(method-call)  ");
                    EKObliczanieZnakowegoZapisu();//obliczanie konwersij liczbowej
                }
            } while (EKmenu.Key != ConsoleKey.X);
            Console.WriteLine("\n\n\tAutor programu: Ervin Kukchyiev.");
            Console.WriteLine("\n\n\t Nr Albomu:54752");
            Console.WriteLine("\n\tDzisiejsza data: {0}", DateTime.Now);
            Console.WriteLine("\n\tDla zakończenia działania programu naciśnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}
