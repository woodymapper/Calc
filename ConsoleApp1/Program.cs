
menu();
int main()
{

    int liczba = 0; //liczba początkowa
    Console.WriteLine("Podaj początkową liczbę: "); //zapytaj użytkownika o liczbę

    liczba = int.Parse(Console.ReadLine() ?? "0"); //przeczytaj liczbę od użytkownika
                                                   // jeśli readline zwróci null to przekaż "0"
    Console.WriteLine("Jaką liczbę wykorzystać jako dzielnik:");
    int dzielnik = int.Parse(Console.ReadLine() ?? "1");//pobierz dzielnik od użytkownika

    Console.WriteLine("Ile kolejnych liczb chcesz otrzymać?");
    int ileLiczb = int.Parse(Console.ReadLine() ?? "1");

    int iloscLiczb = 0;


    int[] tablicaLiczb = new int[ileLiczb];
    while (iloscLiczb < ileLiczb)
    {
        liczba++;
        if (liczba % dzielnik == 0)
        {

            tablicaLiczb[iloscLiczb] = liczba;
            iloscLiczb++;
        }
    }
    string znalezioneLiczby = string.Join(", ", tablicaLiczb);

    Console.WriteLine("Liczby: " + znalezioneLiczby);
    return 0;
}



void menu()
{
  
    
    Console.WriteLine("Menu");
    Console.WriteLine("1. Dzielniki");
    Console.WriteLine("2. LP");
    Console.WriteLine("3. PP");
    Console.WriteLine("4. Wyjście");
    int opcja;
    bool sex = int.TryParse(Console.ReadLine(), out opcja);


    switch (opcja)
    {
        case 1:
            main();
            break;

        case 2:
            pierwsze();
            break;
        case 4:
            Console.WriteLine("Żegnam"); ;
            break;
        case 3:
            Console.WriteLine("A:"); ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;
            float a = float.Parse(Console.ReadLine() ?? "1");
            Console.WriteLine("B:"); ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;
            float b = float.Parse(Console.ReadLine() ?? "1");
           float c = pitaogóras(a, b);
            loading();
            Console.WriteLine(c);
            break;


        default:
            Console.Clear(); loading(); menu(); 
            break;
    }
}


void pierwsze()
{

    int n, i, m = 0, flag = 0;
    Console.Write("Liczba do sprawdzenia: ");
    n = int.Parse(Console.ReadLine());
    m = n / 2;
    for (i = 2; i <= m; i++)
    {
        if (n % i == 0)
        {
            Console.Write("Liczba nie jest LP+");
            flag = 1;
            break;
        }
    }
    if (flag == 0)
        Console.Write("Liczba jest LP");
}

void loading()
{

    Thread.Sleep(500); Console.Write("|"); Console.Clear(); Thread.Sleep(500); Console.Write("/"); Console.Clear(); Thread.Sleep(500); Console.Clear(); Console.Write("-"); Thread.Sleep(500); Console.Clear(); Console.Write("/"); Thread.Sleep(500); Console.Clear(); Console.Write("-"); Console.Clear(); Thread.Sleep(500); Console.Write("|"); Console.Clear();
    



}





float pitaogóras(float a, float b)
{
    double c = Math.Sqrt((double)(Math.Pow(a, 2) + Math.Pow(b, 2)));




    return (float)c ;
}




