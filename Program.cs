using System.ComponentModel;
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
                break;
            case 10:
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
            case 14:
                break;
            case 15:
                break;
            case 16:
                break;
            case 17:
                break;
            case 18:
                break;
            case 19:
                break;
            case 20:
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

main();