using System.Text.RegularExpressions;

void MainMenu()
{
    Console.Clear();
    Console.WriteLine("Skriv tallet for den opgave du vil åbne");
    Console.WriteLine("1. A Begynder Opgaver");
    Console.WriteLine("2. B Rutinerede Opgaver");
    Console.WriteLine("3. C Rutinerede Opgaver");
    Console.WriteLine("4. Luk programmet");
}

void AMenu()
{
    Console.Clear();
    Console.WriteLine("Skriv tallet for den opgave du vil åbne");
    Console.WriteLine("1. Hej Verden");
    Console.WriteLine("2. Simpel Variabel");
    Console.WriteLine("3. Grundlæggende Matematiske Operationer");
    Console.WriteLine("4. If-else struktur med alder");
    Console.WriteLine("5. Grader Fahrenheit til Celsius");
    Console.WriteLine("6. Lommeregner");
    Console.WriteLine("7. Brugerdefinerede metoder");
    Console.WriteLine("8. Loop eksempel - for løkke");
    Console.WriteLine("9. simple arrays");
    Console.WriteLine("10. multi-dimensionelle arrays");
    Console.WriteLine("11. konstanter");
    Console.WriteLine("12. e-mail validering");
    Console.WriteLine("13. fejlretning");
    Console.WriteLine("14. opretning og brug af kommentarer");
    Console.WriteLine("15. tal rækkefølge");
    Console.WriteLine("16. grundlæggende BMI-beregner");
    Console.WriteLine("17. string formattering");
    Console.WriteLine("18. talgenkendelse med løkke");
    Console.WriteLine("19. grunding af versionsstyring");
    Console.WriteLine("20. basis login system");
    Console.WriteLine("21. Tilbage til hovedmenu");
}

void BMenu()
{
    Console.Clear();
    Console.WriteLine("Skriv tallet for den opgave du vil åbne");
    Console.WriteLine("1. Avanceret lommeregner");
    Console.WriteLine("2. List sortering");
    Console.WriteLine("3. palindrome checker");
    Console.WriteLine("4. valutakonvertering");
    Console.WriteLine("5. gæt-nummer.spil med tilbagekobling");
    Console.WriteLine("6. pagination af kontakter");
    Console.WriteLine("7. brugerdefinerede fejlmeddelelser");
    Console.WriteLine("8. matematiske ligninger");
    Console.WriteLine("9. bankkonto-simulator");
    Console.WriteLine("10. opretning af diagrammer for et program");
    Console.WriteLine("11. logik-baseret login");
    Console.WriteLine("12. analysering ad tekstfiler");
    Console.WriteLine("13. versionering af programændringer");
    Console.WriteLine("14. geometriske beregninger");
    Console.WriteLine("15. udvidet månedsbudget");
    Console.WriteLine("16. filter for tal rækkefølge");
    Console.WriteLine("17. sorter kontakter alfabetisk");
    Console.WriteLine("18. e-mail validering med regex");
    Console.WriteLine("19. fibonacci sekvens");
    Console.WriteLine("20. opgavekommentarer og dokumentation");
    Console.WriteLine("21. Tilbage til hovedmenu");
}

void CMenu()
{
    Console.Clear();
    Console.WriteLine("1. avanceret telefonbog med søge- sorterings- og filtereringsfunktioner");
    Console.WriteLine("2. personalehåndtering og lønberegner");
    Console.WriteLine("3. avanceret budgetplanløgger og udgiftssporing");
    Console.WriteLine("4. biblioteksstyring med ud- og indlånsfunktionalitet");
    Console.WriteLine("5. krydsord generator");
    Console.WriteLine("6. Tilbage til hovedmenu");
}

void main()
{
    string? result;
    uint menuValg;
    bool shouldExit = false;

    // hovedmenu loop
    while (!shouldExit)
    {
        MainMenu(); //viser hovedmenuen
        result = Console.ReadLine(); // læser brugerens input

        //håndterer null input
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
            Console.WriteLine("null");
            Console.ReadKey();
            continue;
        }

        //forsøger at konvertere input til et positivt heltal
        if (!uint.TryParse(result, out menuValg))
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
            Console.WriteLine(result);
            Console.ReadKey();
            continue;
        }
        // Switch-case til håndtering af brugerens menuvalg
        switch (menuValg)
        {
            case 1:
                A(); // Kalder funktion A
                break;
            case 2:
                B(); // Kalder funktion B
                break;
            case 3:
                C(); // Kalder funktion C
                break;
            case 4:
                shouldExit = true; // Afslutter programmet
                break;
            default:
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at gå tilbage til menuen");
                Console.ReadKey();
                continue;
        }
    }
}

// Funktion for menu A
void A()
{
    string? result;
    uint menuValg;
    bool shouldExit = false;

    while (!shouldExit)
    {
        AMenu(); // Viser menuen for A
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!uint.TryParse(result, out menuValg))
        {
            Console.WriteLine("Inputtet skal være et positivet heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        switch (menuValg)
        {
            case 1:
                A1();
                break;
            case 2:
                A2();
                break;
            case 3:
                A3();
                break;
            case 4:
                A4();
                break;
            case 5:
                A5();
                break;
            case 6:
                A6();
                break;
            case 7:
                A7();
                break;
            case 8:
                A8();
                break;
            case 9:
                A9();
                break;
            case 10:
                A10();
                break;
            case 11:
                A11();
                break;
            case 12:
                A12();
                break;
            case 13:
                A13();
                break;
            case 14:
                A14();
                break;
            case 15:
                A15();
                break;
            case 16:
                A16();
                break;
            case 17:
                A17();
                break;
            case 18:
                A18();
                break;
            case 19:
                A19();
                break;
            case 20:
                A20();
                break;
            case 21:
                shouldExit = true; // Afslutter menu A
                break;
            default:
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at gå tilbage til menuen");
                Console.ReadKey();
                continue;
        }
    }
}

// Funktion for menu B
void B()
{
    string? result;
    uint menuValg;
    bool shouldExit = false;

    while (!shouldExit)
    {
        BMenu(); // Viser menuen for B
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!uint.TryParse(result, out menuValg))
        {
            Console.WriteLine("Inputtet skal være et positivet heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        switch (menuValg)
        {
            case 1:
                B1();
                break;
            case 2:
                B2();
                break;
            case 3:
                B3();
                break;
            case 4:
                B4();
                break;
            case 5:
                B5();
                break;
            case 6:
                B6();
                break;
            case 7:
                B7();
                break;
            case 8:
                B8();
                break;
            case 9:
                B9();
                break;
            case 10:
                B10();
                break;
            case 11:
                B11();
                break;
            case 12:
                B12();
                break;
            case 13:
                B13();
                break;
            case 14:
                B14();
                break;
            case 15:
                B15();
                break;
            case 16:
                B16();
                break;
            case 17:
                B17();
                break;
            case 18:
                B18();
                break;
            case 19:
                B19();
                break;
            case 20:
                B20();
                break;
            case 21:
                shouldExit = true; // Afslutter menu B
                break;
            default:
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at gå tilbage til menuen");
                Console.ReadKey();
                continue;
        }
    }
}

void C() { }

// Funktion der udskriver "Hej Verden"
void A1()
{
    Console.Clear();
    Console.WriteLine("Hej Verden");
    Console.ReadKey();
}

// Funktion der udskriver en foruddefineret streng
void A2()
{
    Console.Clear();
    string navn = "Nicolai Nelbom";
    Console.WriteLine(navn);
    Console.ReadKey();
}

// Funktion der tager to heltal fra brugeren og udfører matematiske operationer
void A3()
{
    string? result;
    int first;
    int second;

    // Indtastning og validering af første tal
    while (true)
    {
        Console.WriteLine("Indtast det første tal");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!int.TryParse(result, out first))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Indtastning og validering af andet tal
    while (true)
    {
        Console.WriteLine("Indtast det andet tal");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!int.TryParse(result, out second))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    Console.Clear();
    Console.WriteLine($"Addition: {first + second}");
    Console.WriteLine($"subtraktion: {first - second}");
    Console.WriteLine($"multiplikation: {first * second}");

    if (second == 0)
    {
        Console.WriteLine("Kan ikke vise division fordi det andet tal er 0");
    }
    else
    {
        Console.WriteLine($"division: {first / second}");
    }
    Console.ReadKey();
}

// Funktion der tjekker om brugeren er myndig baseret på alder
void A4()
{
    string? result;
    uint alder;

    while (true)
    {
        Console.WriteLine("Indtast din alder");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!uint.TryParse(result, out alder))
        {
            Console.WriteLine("Inputtet skal være et positivet heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    if (alder >= 18)
    {
        Console.WriteLine("Du er myndig");
    }
    else
    {
        Console.WriteLine("Du er ikke myndig");
    }
    Console.ReadKey();
}

// Funktion der konverterer temperatur fra Fahrenheit til Celsius
void A5()
{
    string? result;
    int fahrenheit;

    while (true)
    {
        Console.WriteLine("Indtast temperaturen i fahrenheit");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!int.TryParse(result, out fahrenheit))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }
    // Udregn temperaturen i celcius og udskriv
    Console.WriteLine($"{fahrenheit} i fahrenheit er det samme som {(fahrenheit - 32) / 1.8} i celsius");
    Console.ReadKey();
}

// Funktion til at udføre en simpel lommeregner
void A6()
{
    string? result;
    uint operation;
    int first;
    int second;

    // Brugeren vælger en matematisk operation
    while (true)
    {
        Console.Clear();
        Console.WriteLine("skriv tallet for den operation du vil udføre");
        Console.WriteLine("1. addition");
        Console.WriteLine("2. subtraktion");
        Console.WriteLine("3. multiplikation");
        Console.WriteLine("4. division");
        result = Console.ReadLine();

        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!uint.TryParse(result, out operation))
        {
            Console.WriteLine("Inputtet skal være et positibt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (operation == 0 || operation > 4)
        {
            Console.WriteLine("du skal vælge et tal mellem 1 og 4. tryk enter for at prøve igen");
            Console.ReadKey();
            continue;
        }
        break;

    }

    // Brugeren indtaster to tal
    while (true)
    {
        Console.WriteLine("Indtast det første tal");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!int.TryParse(result, out first))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }
    while (true)
    {
        Console.WriteLine("Indtast det andet tal");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!int.TryParse(result, out second))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Udfører den valgte operation
    switch (operation)
    {
        case 1:
            Console.WriteLine($"Addition: {first + second}");
            break;
        case 2:
            Console.WriteLine($"subtraktion: {first - second}");
            break;
        case 3:
            Console.WriteLine($"multiplikation: {first * second}");
            break;
        case 4:
            if (second == 0)
            {
                Console.WriteLine("Kan ikke vise division fordi det andet tal er 0");
            }
            else
            {
                Console.WriteLine($"division: {first / second}");
            }
            break;
    }
    Console.ReadKey();
}

// Funktion til at vise en simpel velkomstbesked
void A7()
{
    void velkommen()
    {
        Console.WriteLine("Velkommen til min metode");
    }
    velkommen();
    Console.ReadKey();
}

// Funktion til at tælle fra 1 til 10
void A8()
{
    Console.Clear();
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
    Console.ReadKey();
}

// Funktion til at udskrive en liste af frugter
void A9()
{
    Console.Clear();
    string[] fruits = ["æble", "banan", "appelsin", "pære"];
    foreach (string fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
    Console.ReadKey();
}

// Funktion til at udskrive et 2D-array af tal
void A10()
{
    Console.Clear();
    int[][] tal =
    [
        [1,2,3,4],
        [2,4,5,6],
        [3,5,6,7],
        [4,6,7,8]
    ];
    foreach (int[] tal1 in tal)
    {
        foreach (int tal2 in tal1)
        {
            Console.Write(tal2 + " ");
        }
        Console.Write("\n");
    }
    Console.ReadKey();
}


void A11()
{
    Console.Clear();
    const double moms = 0.25; // Moms-sats på 25%
    int pris = 100; // Grundpris
    // Beregn moms og totalpris og vis det i konsollen
    Console.WriteLine($"Med en pris på {pris} kr. er der {pris * moms} kr. moms, hvilket giver en total pris på {pris + pris * moms} kr.");
    Console.ReadKey();
}

void A12()
{
    Console.Clear();
    string? result;

    while (true)
    {
        Console.WriteLine("Indtast din e-mail");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Du skal give et input. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Tjekker om e-mailen indeholder '@' og '.'
    if (result.Contains("@") && result.Contains("."))
    {
        Console.WriteLine("E-mailen indeholder både '@' og '.'");
    }
    else
    {
        Console.WriteLine("E-mailen indeholder ikke både '@' og '.'");
    }
    Console.ReadKey();
}

void A13()
{
    // Ingen kode at rette
}

void A14()
{
    // Ingen kode at kommentere
}

void A15()
{
    string? result;
    int[] tal = [0, 0, 0]; // Opretter et array til at gemme tre tal

    Console.Clear();

    // Indhenter det første tal
    while (true)
    {
        Console.WriteLine("Indtast det første tal");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!int.TryParse(result, out tal[0]))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Indhenter det andet tal
    while (true)
    {
        Console.WriteLine("Indtast det andet tal");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!int.TryParse(result, out tal[1]))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Indhenter det tredje tal
    while (true)
    {
        Console.WriteLine("Indtast det tredje tal");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!int.TryParse(result, out tal[2]))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Sorterer tallene i stigende rækkefølge
    Array.Sort(tal);

    Console.WriteLine("");

    // Udskriver de sorterede tal
    foreach (int t in tal)
    {
        Console.WriteLine(t + "");
    }
    Console.ReadKey();
}


void A16()
{
    string? result;
    uint højde, vægt;

    Console.Clear();

    // Indhenter højde
    while (true)
    {
        Console.WriteLine("Indtast din højde i cm");
        result = Console.ReadLine();
        if (result == null || !uint.TryParse(result, out højde))
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Indhenter vægt
    while (true)
    {
        Console.WriteLine("Indtast din vægt i kg");
        result = Console.ReadLine();
        if (result == null || !uint.TryParse(result, out vægt))
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Beregner og viser BMI
    Console.WriteLine($"du har en bmi på {vægt / Math.Pow(højde / 100.0, 2)}");
    Console.ReadKey();
}

void A17()
{
    string? result;
    string navn;
    uint alder;

    Console.Clear();

    // Indhenter navn
    while (true)
    {
        Console.WriteLine("Indtast dit navn");
        result = Console.ReadLine();
        if (result == null)
        {
            Console.WriteLine("Du skal give et input. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        navn = result;
        break;
    }

    // Indhenter alder
    while (true)
    {
        Console.WriteLine("Indtast din alder");
        result = Console.ReadLine();
        if (result == null || !uint.TryParse(result, out alder))
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Udskriver navn og alder
    Console.WriteLine($"Du hedder {navn} og du er {alder} år gammel.");
    Console.ReadKey();
}

void A18()
{
    int secret = 7;
    string? result;
    uint gæt;

    Console.Clear();

    // Gætter på et tal
    while (true)
    {
        Console.WriteLine("Gæt et tal mellem 1 og 10");
        result = Console.ReadLine();
        if (result == null || !uint.TryParse(result, out gæt) || gæt < 1 || gæt > 10)
        {
            Console.WriteLine("Du skal skrive et tal mellem 1 og 10");
            continue;
        }
        if (gæt != secret)
        {
            Console.WriteLine("Det er ikke rigtig prøv igen");
            continue;
        }
        Console.WriteLine("Du gættede rigtigt!");
        break;
    }
    Console.ReadKey();
}

void A19()
{
    // Ufuldstændig opgave
}

void A20()
{
    string brugernavn = "nelbom1";
    string adgangskode = "Tec123";
    string? result;
    bool korrekt = true;

    Console.Clear();

    // Indhenter brugernavn
    while (true)
    {
        Console.WriteLine("Indtast brugernavn");
        result = Console.ReadLine();
        if (result == null || result.ToLower() != brugernavn)
        {
            korrekt = false;
        }
        break;
    }

    // Indhenter adgangskode
    while (true)
    {
        Console.WriteLine("Indtast adgangskode");
        result = Console.ReadLine();
        if (result == null || result != adgangskode)
        {
            korrekt = false;
        }
        break;
    }

    // Tjekker login-oplysninger
    if (korrekt)
    {
        Console.WriteLine("Du er blevet logget ind");
    }
    else
    {
        Console.WriteLine("Din login information var ikke korrekt");
    }
    Console.ReadKey();
}

void B1()
{
    string? result;
    uint operation;
    int first, second;

    Console.Clear();

    // Vælger operation
    while (true)
    {
        Console.WriteLine("skriv tallet for den operation du vil udføre");
        Console.WriteLine("1. addition");
        Console.WriteLine("2. subtraktion");
        Console.WriteLine("3. multiplikation");
        Console.WriteLine("4. division");
        Console.WriteLine("5. modulus");
        Console.WriteLine("6. exponentiering");
        result = Console.ReadLine();

        if (result == null || !uint.TryParse(result, out operation) || operation == 0 || operation > 6)
        {
            Console.WriteLine("Vælg et tal mellem 1 og 6. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Indhenter første tal
    while (true)
    {
        Console.WriteLine("Indtast det første tal");
        result = Console.ReadLine();
        if (result == null || !int.TryParse(result, out first))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Indhenter andet tal
    while (true)
    {
        Console.WriteLine("Indtast det andet tal");
        result = Console.ReadLine();
        if (result == null || !int.TryParse(result, out second))
        {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    // Udfører den valgte operation
    switch (operation)
    {
        case 1:
            Console.WriteLine($"Addition: {first + second}");
            break;
        case 2:
            Console.WriteLine($"Subtraktion: {first - second}");
            break;
        case 3:
            Console.WriteLine($"Multiplikation: {first * second}");
            break;
        case 4:
            if (second == 0)
            {
                Console.WriteLine("Kan ikke vise division, fordi det andet tal er 0");
            }
            else
            {
                Console.WriteLine($"Division: {first / second}");
            }
            break;
        case 5:
            Console.WriteLine($"Modulus: {first % second}");
            break;
        case 6:
            Console.WriteLine($"Exponentiering: {Math.Pow(first, second)}");
            break;
    }
    Console.ReadKey();
}

void B2()
{
    Console.Clear();

    // Opretter og fylder array med tilfældige tal
    Random r = new Random();
    int[] arr = new int[10];
    for (int i = 0; i < 10; i++)
    {
        arr[i] = r.Next(0, 100);
    }

    // Udskriver array før og efter sortering
    Console.Write($"Tilfældig array: ");
    foreach (int i in arr) Console.Write(i + " ");
    Console.WriteLine("");

    Array.Sort(arr);

    Console.Write($"Sorteret array: ");
    foreach (int i in arr) Console.Write(i + " ");
    Console.WriteLine("");
    Console.ReadKey();
}

void B3()
{
    Console.Clear();
    Console.WriteLine("Indtast en tekst:");
    string input = Console.ReadLine();

    // Tjekker om teksten er et palindrom
    if (IsPalindrome(input))
    {
        Console.WriteLine("Teksten er et palindrom.");
    }
    else
    {
        Console.WriteLine("Teksten er ikke et palindrom.");
    }
    Console.ReadKey();

    // Funktion til at tjekke om en tekst er et palindrom
    bool IsPalindrome(string text)
    {
        string texter = text.ToLower();
        string checker = "abcdefghijklmnopqrstuvwxyzæøå";
        string trimmed = "";

        // Filtrerer kun bogstaver
        foreach (char c in texter)
        {
            if (checker.Contains(c))
            {
                trimmed += c;
            }
        }

        // Tjekker om den trimmede tekst er et palindrom
        int len = trimmed.Length;
        string first = trimmed.Substring(0, len / 2);
        string second = trimmed.Substring(len - len / 2, len / 2);

        char[] charArray = second.ToCharArray();
        Array.Reverse(charArray);
        second = new string(charArray);

        return first == second;
    }
}

void B4()
{
    Console.Clear();
    int beløb = 100; // DKK
    double sats = 7.5; // konvertering til EUR

    // Funktion til konvertering fra DKK til EUR
    double konverter(int beløb, double sats)
    {
        return beløb / sats;
    }

    Console.WriteLine($"{beløb} DKK = {konverter(beløb, sats)} EUR");
    Console.ReadKey();
}


void B5()
{
    Console.Clear();
    int secret = 7; // Hemmelig tal, som brugeren skal gætte
    string? result;
    uint gæt;

    // Brugeren bliver ved med at gætte, indtil de gætter korrekt
    while (true)
    {
        Console.WriteLine("Gæt et tal mellem 1 og 10");
        result = Console.ReadLine();
        if (result == null || !uint.TryParse(result, out gæt) || gæt == 0 || gæt > 10)
        {
            Console.WriteLine("Du skal skrive et tal mellem 1 og 10");
            continue;
        }
        // Hvis gættet er korrekt, afsluttes loopet
        if (gæt == secret)
        {
            Console.WriteLine("Du gættede rigtigt!");
            break;
        }
        // Hvis gættet er forkert, gives feedback på om det skal være højere eller lavere
        if (secret > gæt)
        {
            Console.WriteLine("højere");
        }
        else
        {
            Console.WriteLine("lavere");
        }
    }
    Console.ReadKey();
}

void B6()
{
    // Liste over kontakter
    string[] kontakter = [
        "john", "oliver", "lui", "rasmus", "christian", "nicolai", "sebastian", "jørgen", "bo",
        "jens", "jesper", "asger", "nicholas", "allan", "kasper", "simon", "daniel", "mathias",
        "patrick", "iben", "lone", "eyup", "louis"
    ];

    // Beregner antal sider for at vise kontakter 10 ad gangen
    int sider = (int)Math.Ceiling(kontakter.Length / 10.0);

    // Viser kontakter side for side
    for (int i = 0; i < sider; i++)
    {
        Console.Clear();
        for (int j = 10 * i; j < (10 * (i + 1) < kontakter.Length ? 10 * (i + 1) : kontakter.Length); j++)
        {
            Console.WriteLine(kontakter[j]);
        }
        Console.WriteLine($"Side {i + 1} af {sider}. Tryk enter for at gå til næste side");
        Console.ReadKey();
    }
}

void B7()
{
    // Mangler materiale til denne opgave
}

void B8()
{
    // Beregner løsningerne af en andengradsligning
    void quadratic(int a, int b, int c)
    {
        double first = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2.0 * a);
        double second = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2.0 * a);
        Console.WriteLine($"Første løsning: {first}");
        Console.WriteLine($"Anden løsning: {second}");
    }

    // Løser ligningen 1x^2 + 5x + 6 = 0
    quadratic(1, 5, 6);
    Console.ReadKey();
}

void B9()
{
    int saldo = 1000; // Start saldo
    string? result;
    uint menuValg;
    bool shouldExit = false;

    // Menu til at vælge handlinger som hævning, indsættelse og afslutning
    while (!shouldExit)
    {
        Console.Clear();
        Console.WriteLine($"Din saldo er {saldo} kr.");
        Menu();
        result = Console.ReadLine();
        if (result == null || !uint.TryParse(result, out menuValg))
        {
            Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }

        // Håndterer de forskellige menumuligheder
        switch (menuValg)
        {
            case 1:
                Hæv();
                break;
            case 2:
                indsæt();
                break;
            case 3:
                shouldExit = true;
                break;
        }
    }

    // Menu funktion
    void Menu()
    {
        Console.WriteLine("Skriv tallet for den handling du vil udføre");
        Console.WriteLine("1. Hæv penge");
        Console.WriteLine("2. Indsæt penge");
        Console.WriteLine("3. Forlad banken");
    }

    // Hæv penge fra saldoen
    void Hæv()
    {
        uint mængde;
        while (true)
        {
            Console.WriteLine("Hvor meget vil du hæve");
            result = Console.ReadLine();
            if (result == null || !uint.TryParse(result, out mængde))
            {
                Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
            }
            if (mængde > saldo)
            {
                Console.WriteLine("Du kan ikke hæve mere end du har på kontoen");
                continue;
            }
            saldo -= (int)mængde;
            break;
        }
    }

    // Indsæt penge på kontoen
    void indsæt()
    {
        uint mængde;
        while (true)
        {
            Console.WriteLine("Hvor meget vil du indsætte");
            result = Console.ReadLine();
            if (result == null || !uint.TryParse(result, out mængde))
            {
                Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
            }
            saldo += (int)mængde;
            break;
        }
    }
}

void B10()
{
    // Mangler materiale fra lærer til denne opgave
}


void B11()
{
    Console.Clear();
    string brugernavn = "nelbom1";
    string adgangskode = "Tec123";
    string? result;
    bool korrekt = true; // Indikerer, om login er korrekt

    // Brugeren har 3 forsøg til at logge ind
    for (int i = 0; i < 3; i++)
    {
        // Brugernavn input
        while (true)
        {
            Console.WriteLine("Indtast brugernavn");
            result = Console.ReadLine();

            // Tjekker om brugernavn er korrekt
            if (result == null)
            {
                Console.WriteLine("Du skal give et input. Prøv igen.");
                continue;
            }
            if (result.ToLower() != brugernavn)
            {
                korrekt = false;
            }
            break;
        }

        // Adgangskode input
        while (true)
        {
            Console.WriteLine("Indtast adgangskode");
            result = Console.ReadLine();

            // Tjekker om adgangskode er korrekt
            if (result == null)
            {
                Console.WriteLine("Du skal give et input. Prøv igen.");
                continue;
            }
            if (result != adgangskode)
            {
                korrekt = false;
            }
            break;
        }

        // Hvis login er korrekt, afsluttes funktionen
        if (korrekt)
        {
            Console.WriteLine("Du er blevet logget ind");
            Console.ReadKey();
            return;
        }
        else
        {
            // Hvis login ikke er korrekt, gives besked om antal forsøg tilbage
            Console.WriteLine($"Din logininformation var ikke korrekt. Du har {2 - i} forsøg tilbage.");
            Console.ReadKey();
        }
    }
}

void B12()
{
    // Læser tekst fra filen "test.txt"
    string text = File.ReadAllText("./test.txt");

    // Tæller ord i filen ved at splitte teksten på mellemrum
    Console.WriteLine($"Der er {text.Split(" ").Length} ord i filen");
    Console.ReadKey();
}

void B13()
{
    // Udfordringen er ikke angivet, så denne funktion er tom
}

void B14()
{
    int a = 5;
    int b = 8;

    // Kalder funktioner for at beregne arealer og omkredse for forskellige former
    Firkant(a, b);
    Trekant(a, b);
    cirkel(a);
    Console.ReadKey();

    // Beregner areal og omkreds af en firkant
    void Firkant(int højde, int bredde)
    {
        Console.WriteLine($"Firkant: areal: {højde * bredde}, omkreds: {2 * højde + 2 * bredde}");
    }

    // Beregner areal og omkreds af en trekant
    void Trekant(int højde, int grundlinje)
    {
        Console.WriteLine($"Trekant: Areal: {0.5 * højde * grundlinje}, omkreds: {3 * grundlinje}");
    }

    // Beregner areal og omkreds af en cirkel
    void cirkel(int radius)
    {
        Console.WriteLine($"Cirkel: Areal: {Math.PI * Math.Pow(radius, 2)}, omkreds: {2 * Math.PI * radius}");
    }
}

void B15()
{
    // Budget for hver måned
    int[] budget = [1000, 500, 720, 1200, 850, 1100, 1400, 980, 940, 830, 1240, 1060];
    int sum = 0;

    // Udskriver budgettet for hver måned
    Console.Write("Budget: ");
    foreach (int tal in budget)
    {
        Console.Write(tal + " ");
        sum += tal;
    }

    Console.WriteLine();
    // Udskriver gennemsnittet af budgettet
    Console.WriteLine($"Gennemsnit: {sum / 12.0}");
    Console.ReadKey();
}

void B16()
{
    string? result;
    int[] tal; // Array til at opbevare de indtastede tal

    Console.Clear();

    // Brugeren bliver bedt om at indtaste en række tal
    while (true)
    {
        Console.WriteLine("Indtast en serie af tal med mellemrum imellem");
        result = Console.ReadLine();

        // Tjekker om der er givet input
        if (result == null)
        {
            Console.WriteLine("Du skal give et input. Tryk enter for at prøve igen");
            Console.ReadKey();
            continue;
        }

        // Deler inputtet op i et array af strenge, og forsøger at konvertere til int
        string[] input = result.Split(" ");
        tal = new int[input.Length];

        try
        {
            for (int i = 0; i < input.Length; i++)
            {
                tal[i] = int.Parse(input[i]); // Konverterer hver del af inputtet til et heltal
            }
        }
        catch
        {
            // Hvis inputtet ikke er et tal, gives besked og løkken fortsætter
            Console.WriteLine("Du må kun skrive tal");
            continue;
        }

        // Sorterer arrayet i faldende orden
        Array.Sort(tal);
        Array.Reverse(tal);
        break; // Afslutter løkken, når input er korrekt
    }

    // Udskriver de sorterede tal
    foreach (int t in tal)
    {
        Console.WriteLine(t);
    }
    Console.ReadKey();
}

void B17()
{
    string[] kontakter = [
        "john",
        "oliver",
        "lui",
        "rasmus",
        "christian",
        "nicolai",
        "sebastian",
        "jørgen",
        "bo",
        "jens",
        "jesper",
        "asger",
        "nicholas",
        "allan",
        "kasper",
        "simon",
        "daniel",
        "mathias",
        "patrick",
        "iben",
        "lone",
        "eyup",
        "louis"
    ];

    // Sorterer kontaktlisten alfabetisk
    Array.Sort(kontakter);

    // Udskriver de sorterede kontakter
    foreach (string kontakt in kontakter)
    {
        Console.WriteLine(kontakt);
    }
    Console.ReadLine();
}

void B18()
{
    // Regular expression (regex) til at validere email
    string regex = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
    string email = "nine4@elev.tec.dk";

    // Tjekker om emailen matcher regex
    if (Regex.Match(email, regex).Success)
    {
        Console.WriteLine("Det er en gyldig email");
    }
    else
    {
        Console.WriteLine("Det er ikke en gyldig email");
    }
    Console.ReadKey();
}

void B19()
{
    // Kalder Fibonacci-funktionen for at vise tal op til 100
    fib(100);

    // Fibonacci-funktion
    void fib(int maks)
    {
        int a = 1;
        int b = 1;
        int c = a + b;
        Console.WriteLine(a);
        Console.WriteLine(b);

        // Udskriver Fibonacci-sekvensen indtil det givne maks
        while (c <= maks)
        {
            Console.WriteLine(c);
            int temp = c;
            c = b + c;
            b = temp;
        }
        Console.ReadKey();
    }
}

void B20()
{
    // Ingen opgave er angivet for B20, så den er tom
}

main();