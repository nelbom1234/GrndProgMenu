using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

void MainMenu() {
    Console.Clear();
    Console.WriteLine("Skriv tallet for den opgave du vil åbne");
    Console.WriteLine("1. A Begynder Opgaver");
    Console.WriteLine("2. B Rutinerede Opgaver");
    Console.WriteLine("3. C Rutinerede Opgaver");
    Console.WriteLine("4. Luk programmet");
}

void AMenu() {
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

void BMenu() {
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

void CMenu() {
    Console.Clear();
    Console.WriteLine("1. avanceret telefonbog med søge- sorterings- og filtereringsfunktioner");
    Console.WriteLine("2. personalehåndtering og lønberegner");
    Console.WriteLine("3. avanceret budgetplanløgger og udgiftssporing");
    Console.WriteLine("4. biblioteksstyring med ud- og indlånsfunktionalitet");
    Console.WriteLine("5. krydsord generator");
    Console.WriteLine("6. Tilbage til hovedmenu");
}

void main() {
    string? result;
    uint menuValg;
    bool shouldExit = false;

    while (!shouldExit) {
        MainMenu();
        result = Console.ReadLine();
        if (result == null) {
            Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
            Console.WriteLine("null");
            Console.ReadKey();
            continue;
        }
        if (!uint.TryParse(result, out menuValg)) {
            Console.WriteLine("Inputtet skal være et positivet heltal. Tryk enter for at prøve igen.");
            Console.WriteLine(result);
            Console.ReadKey();
            continue;
        }
        switch(menuValg) {
            case 1:
                A();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                shouldExit = true;
                break;
            default:
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at gå tilbage til menuen");
                Console.ReadKey();
                continue;
        }
    }
}

void A() {
    string? result;
    uint menuValg;
    bool shouldExit = false;

    while (!shouldExit) {
        AMenu();
        result = Console.ReadLine();
        if (result == null) {
            Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (!uint.TryParse(result, out menuValg)) {
            Console.WriteLine("Inputtet skal være et positivet heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        switch(menuValg) {
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
                shouldExit = true;
                break;
            default:
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at gå tilbage til menuen");
                Console.ReadKey();
                continue;
        }
    }
}

void A1() {
    Console.Clear();
    Console.WriteLine("Hej Verden");
    Console.ReadKey();
}

void A2() {
    Console.Clear();
    string navn = "Nicolai Nelbom";
    Console.WriteLine(navn);
    Console.ReadKey();
}

void A3() {
    string? result;
    int first;
    int second;


    while (true) {
        Console.WriteLine("Indtast det første tal");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!int.TryParse(result, out first)) {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }
    while (true) {
        Console.WriteLine("Indtast det andet tal");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!int.TryParse(result, out second)) {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    Console.Clear();
    Console.WriteLine($"Addition: {first+second}");
    Console.WriteLine($"subtraktion: {first-second}");
    Console.WriteLine($"multiplikation: {first*second}");
    if (second == 0) {
        Console.WriteLine("Kan ikke vise division fordi det andet tal er 0");
    }
    else {
        Console.WriteLine($"division: {first/second}");
    }
    Console.ReadKey();
}

void A4() {
    string? result;
    uint alder;

    while (true) {
        Console.WriteLine("Indtast din alder");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!uint.TryParse(result, out alder)) {
            Console.WriteLine("Inputtet skal være et positivet heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    if (alder >= 18) {
        Console.WriteLine("Du er myndig");
    }
    else {
        Console.WriteLine("Du er ikke myndig");
    }
    Console.ReadKey();
}

void A5() {
    string? result;
    int fahrenheit;

    while (true) {
        Console.WriteLine("Indtast temperaturen i fahrenheit");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!int.TryParse(result, out fahrenheit)) {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    Console.WriteLine($"{fahrenheit} i fahrenheit er det samme som {(fahrenheit-32)/1.8} i celsius");
    Console.ReadKey();
}

void A6() {
    string? result;
    uint operation;
    int first;
    int second;


    while (true) {
        Console.Clear();
        Console.WriteLine("skriv tallet for den operation du vil udføre");
        Console.WriteLine("1. addition");
        Console.WriteLine("2. subtraktion");
        Console.WriteLine("3. multiplikation");
        Console.WriteLine("4. division");
        result = Console.ReadLine();

        if (result == null) {
                Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!uint.TryParse(result, out operation)) {
            Console.WriteLine("Inputtet skal være et positibt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        if (operation == 0 || operation > 4) {
            Console.WriteLine("du skal vælge et tal mellem 1 og 4. tryk enter for at prøve igen");
            Console.ReadKey();
            continue;
        }
        break;

    }

    while (true) {
        Console.WriteLine("Indtast det første tal");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!int.TryParse(result, out first)) {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }
    while (true) {
        Console.WriteLine("Indtast det andet tal");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!int.TryParse(result, out second)) {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    switch(operation) {
        case 1:
            Console.WriteLine($"Addition: {first+second}");
            break;
        case 2:
            Console.WriteLine($"subtraktion: {first-second}");
            break;
        case 3:
            Console.WriteLine($"multiplikation: {first*second}");
            break;
        case 4:
            if (second == 0) {
                Console.WriteLine("Kan ikke vise division fordi det andet tal er 0");
            }
            else {
                Console.WriteLine($"division: {first/second}");
            }
            break;
    }
    Console.ReadKey();
}

void A7() {
    void velkommen() {
        Console.WriteLine("Velkommen til min metode");
    }
    velkommen();
    Console.ReadKey();
}

void A8() {
    Console.Clear();
    for (int i = 1; i <= 10; i++) {
        Console.WriteLine(i);
    }
    Console.ReadKey();
}

void A9() {
    Console.Clear();
    string[] fruits = ["æble", "banan", "appelsin", "pære"];
    foreach (string fruit in fruits) {
        Console.WriteLine(fruit);
    }
    Console.ReadKey();
}

void A10() {
    Console.Clear();
    int[][] tal = 
    [
        [1,2,3,4],
        [2,4,5,6],
        [3,5,6,7],
        [4,6,7,8]
    ];
    foreach (int[] tal1 in tal) {
        foreach (int tal2 in tal1) {
            Console.Write(tal2 + " ");
        }
        Console.Write("\n");
    }
    Console.ReadKey();
}

void A11() {
    Console.Clear();
    const double moms = 0.25;
    int pris = 100;
    Console.WriteLine($"Med en pris på {pris} kr. er der {pris*moms} kr. moms, hvilket giver en total pris på {pris + pris*moms} kr.");
    Console.ReadKey();
}

void A12() {
    Console.Clear();
    string? result;

    while (true) {
        Console.WriteLine("indtast din e-mail");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Du skal give et input. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        break;
    }

    if (result.Contains("@") && result.Contains(".")) {
        Console.WriteLine("e-mailen indeholder både '@' og '.'");
    }
    else {
        Console.WriteLine("e-mailen indeholder ikke både '@' og '.'");
    }
    Console.ReadKey();

}

void A13() {
    //ingen kode at rette
}

void A14() {
    //ingen kode at kommentere
}

void A15() {
    string? result;
    int[] tal = [0,0,0];

    Console.Clear();

    while (true) {
        Console.WriteLine("Indtast det første tal");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!int.TryParse(result, out tal[0])) {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    while (true) {
        Console.WriteLine("Indtast det andet tal");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!int.TryParse(result, out tal[1])) {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    while (true) {
        Console.WriteLine("Indtast det tredje tal");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!int.TryParse(result, out tal[2])) {
            Console.WriteLine("Inputtet skal være et heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    Array.Sort(tal);

    Console.WriteLine("");

    foreach (int t in tal) {
        Console.WriteLine(t + "");
    }
    Console.ReadKey();
}

void A16() {
    Console.Clear();
    string? result;
    uint højde;
    uint vægt;

    while (true) {
        Console.WriteLine("Indtast din højde i cm");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!uint.TryParse(result, out højde)) {
            Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    while (true) {
        Console.WriteLine("Indtast din vægt i kg");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!uint.TryParse(result, out vægt)) {
            Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    Console.WriteLine($"du har en bmi på {vægt/Math.Pow(højde/100.0, 2)}");
    Console.ReadKey();

}

void A17() {
    Console.Clear();
    string? result;
    string navn;
    uint alder;

    while (true) {
        Console.WriteLine("Indtast dit navn");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Du skal give et input. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        navn = result;
        break;
    }

    while (true) {
        Console.WriteLine("Indtast din alder");
        result = Console.ReadLine();
        if (result == null) {
                Console.WriteLine("Inputtet skal være et positivt heltal. tryk enter for at prøve igen.");
                Console.ReadKey();
                continue;
        }
        if (!uint.TryParse(result, out alder)) {
            Console.WriteLine("Inputtet skal være et positivt heltal. Tryk enter for at prøve igen.");
            Console.ReadKey();
            continue;
        }
        break;
    }

    Console.WriteLine($"Du hedder {navn} og du er {alder} år gammel.");
    Console.ReadKey();
}

void A18() {
    Console.Clear();
    int secret = 7;
    string? result;
    uint gæt;

    while (true) {
        Console.WriteLine("Gæt et tal mellem 1 og 10");
        result = Console.ReadLine();
        if (result == null) {
            Console.WriteLine("Du skal skrive et tal mellem 1 og 10");
            continue;
        }
        if (!uint.TryParse(result, out gæt)) {
            Console.WriteLine("du skal skrive et tal mellem 1 og 10");
            continue;
        }
        if (gæt == 0 || gæt > 10) {
            Console.WriteLine("Du skal skrive et tal mellem 1 og 10");
            continue;
        }
        if (gæt != secret) {
            Console.WriteLine("Det er ikke rigtig prøv igen");
            continue;
        }
        else {
            Console.WriteLine("Du gættede rigtigt!");
            break;
        }
    }
    Console.ReadKey();

}

void A19() {
    //ved ikke rigtig hvad den vil have mig til her uden noget materiale
}

void A20() {
    Console.Clear();
    string brugernavn = "nelbom1";
    string adgangskode = "Tec123";
    string? result;
    bool korrekt = true;

    while (true) {
        Console.WriteLine("Indtast brugernavn");
        result = Console.ReadLine();

        if (result == null) {
            Console.WriteLine("Du skal give et input. prøv igen");
            continue;
        }
        if (result.ToLower() != brugernavn) {
            korrekt = false;
        }
        break;
    }

    while (true) {
        Console.WriteLine("Indtast adgangskode");
        result = Console.ReadLine();

        if (result == null) {
            Console.WriteLine("Du skal give et input. prøv igen");
            continue;
        }
        if (result != adgangskode) {
            korrekt = false;
        }
        break;
    }

    if (korrekt) {
        Console.WriteLine("Du er blevet logget ind");
    }
    else {
        Console.WriteLine("Din login information var ikke korrekt");
    }
    Console.ReadKey();

}

main();