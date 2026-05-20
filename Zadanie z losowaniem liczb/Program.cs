class Program
{
    static void Main(string[] args)
    {
        int grupa;
        int parzystosc;
        int reszta;
        int dzielenie = 0;
        int los = 0;
        
        for (int i = 1; i<=1; i++)
        {
            Console.WriteLine($"Seria {i}: ");
            for (int j = 1; j <= 5; j++)
            {
                Random losowa = new Random();
                los = losowa.Next(1, 21);
                /* Console.WriteLine( $"Liczba:  { los}"); */
                dzielenie = los % 3;
                switch (dzielenie)
                {
                    case 0:
                        Console.WriteLine($"Liczba: {los} ");
                        if (los % 2 == 0)
                        {
                            Console.WriteLine("-> Parzysta");
                        }
                        else
                        {
                            Console.WriteLine("-> Nieparzysta");
                        }
                        Console.WriteLine($"-> Grupa: A \t (reszta: {dzielenie})");
                        Console.WriteLine("---------");
                        break;
                    case 1:
                        Console.WriteLine($"Liczba: {los} ");
                        if (los % 2 == 0)
                        {
                            Console.WriteLine("-> Parzysta");
                        }
                        else
                        {
                            Console.WriteLine("-> Nieparzysta");
                        }
                        Console.WriteLine($"-> Grupa: B \t (reszta: {dzielenie})");
                        Console.WriteLine("---------");
                        break;
                    case 2:
                        Console.WriteLine($"Liczba: {los} ");
                        if (los % 2 == 0)
                        {
                            Console.WriteLine("-> Parzysta");
                        }
                        else
                        {
                            Console.WriteLine("-> Nieparzysta");
                        }
                        Console.WriteLine($"-> Grupa: C \t (reszta: {dzielenie})");
                        Console.WriteLine("-------------");
                        break;
                }
            }

            for(int g = 1; g <= 1; g++)
            {
                Console.WriteLine("Seria 2: ");
                for (int j = 1; j <= 5; j++)
                {
                    Random losowa = new Random();
                    los = losowa.Next(1, 21);
                    /* Console.WriteLine( $"Liczba:  { los}"); */
                    dzielenie = los % 3;
                    switch (dzielenie)
                    {
                        case 0:
                            Console.WriteLine($"Liczba: {los} ");
                            if (los % 2 == 0)
                            {
                                Console.WriteLine("-> Parzysta");
                            }
                            else
                            {
                                Console.WriteLine("-> Nieparzysta");
                            }
                            Console.WriteLine($"-> Grupa: A \t (reszta: {dzielenie})");
                            Console.WriteLine("---------");
                            break;
                        case 1:
                            Console.WriteLine($"Liczba: {los} ");
                            if (los % 2 == 0)
                            {
                                Console.WriteLine("-> Parzysta");
                            }
                            else
                            {
                                Console.WriteLine("-> Nieparzysta");
                            }
                            Console.WriteLine($"-> Grupa: B \t (reszta: {dzielenie})");
                            Console.WriteLine("---------");
                            break;
                        case 2:
                            Console.WriteLine($"Liczba: {los} ");
                            if (los % 2 == 0)
                            {
                                Console.WriteLine("-> Parzysta");
                            }
                            else
                            {
                                Console.WriteLine("-> Nieparzysta");
                            }
                            Console.WriteLine($"-> Grupa: C \t (reszta: {dzielenie})");
                            Console.WriteLine("---------");
                            break;
                    }
                }

            }


        }
        









    }









}