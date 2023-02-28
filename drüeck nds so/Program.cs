while (true)
{
    try
    {
        Console.WriteLine($"Menu\n________________________");
        Console.WriteLine($"1 Quadrat\n2 Rechteck\n3 Dreieck\n4 kreis\n5 Gleichschenkliges Trapez\n6 Abbrechen");
        Console.Write($"________________________\nAuswählen: ");
        double eingabe = Convert.ToDouble(Console.ReadLine());

        if (eingabe <=0 || eingabe > 6)
        {
            Console.Clear();
            Console.WriteLine($"________________________\nFalsche eingabe\n________________________");
            Console.ReadKey();
            Console.Clear();
            continue;
        }
        if (eingabe == 6)
        {
            break;
        }
        while (eingabe >= 1 || eingabe <= 5)
        {
            //Quadrat und Rechteck berechnen
            if (eingabe == 1 || eingabe == 2)
            {
                Console.Clear();
                Console.Write($"Geben sie a ein: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Geben sie b ein: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{quadrat(a, b)}");
                Console.ReadKey();
                Console.Clear();

                static double quadrat(double a, double b)
                {
                    return a * b;
                }
                break;
            }

            // Dreieck berechnen
            if (eingabe == 3)
            {
                Console.Clear();
                Console.Write($"Geben sie grundseite ein: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Geben sie höhe ein: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{quadrat(a, b)}");
                Console.ReadKey();
                Console.Clear();


                static double quadrat(double a, double b)
                {
                    return (a * b) / 2;
                }
                break;
            }

            // kreis berechnen
            if (eingabe == 4)
            {
                Console.Clear();
                Console.Write($"Geben sie den radius ein: ");
                double a = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine($"{quadrat(a)}");
                Console.ReadKey();
                Console.Clear();


                static double quadrat(double a)
                {
                    return (a * a) * 3.1415926535897931;
                }
                break;
            }

            // Trapetz berechnen
            if (eingabe == 5)
            {
                Console.Clear();
                Console.Write($"Geben sie a ein: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Geben sie c ein: ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Geben sie h ein: ");
                double h = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{quadrat(a, c, h)}");
                Console.ReadKey();
                Console.Clear();


                static double quadrat(double a, double c, double h)
                {
                    return ((a + c) / 2) * h;
                }
                break;
            }

        }



    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}