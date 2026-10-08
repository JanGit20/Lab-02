// 1 zadanie
// Console.WriteLine("Podaj imię bohatera:");
// string imie = Console.ReadLine();
// Console.Clear();
// Console.WriteLine("Podaj symbol bohatera:");
// string symbol = Console.ReadLine();
// Console.Clear();
// Console.WriteLine("Podaj poziom bohatera:");
// string poziom = Console.ReadLine();
// Console.Clear();
// Console.WriteLine("Podaj ilość złota bohatera:");
// string zloto = Console.ReadLine();
// Console.Clear();
// Console.WriteLine("Podaj wagę plecaka bohatera:");
// string waga = Console.ReadLine();
// Console.Clear();
// Console.WriteLine("Czy bohater ma mapę? (tak/nie):");
// string mapa = Console.ReadLine();
// Console.Clear();

// Console.WriteLine("=== Ekwipunek bohatera ===");
// Console.WriteLine($"Imię bohatera: {imie}");
// Console.WriteLine($"Symbol bohatera: {symbol}");
// Console.WriteLine($"Poziom bohatera: {poziom}");
// Console.WriteLine($"Ilość złota: {zloto}");
// Console.WriteLine($"Waga plecaka: {waga}");
// Console.WriteLine($"Ma mapę: {mapa}");



// 2 zadanie
// Console.Write("Podaj punkty doświadczenia bohatera:");
// int poziom = int.Parse(Console.ReadLine());
// int trening = 1;
// Console.Clear();
// Console.Write("Podaj ilość złota bohatera:");
// int zloto = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.Write("Dostajesz 25 punktów doświadczenia i tracisz 8 złota.");

// poziom += 25;
// zloto -= 8;
// poziom *= 2;
// zloto += 15;
// trening += 1;
// Console.Clear();
// Console.WriteLine($"Masz teraz {poziom} punktów doświadczenia.");
// Console.WriteLine($"Masz teraz {zloto} złota.");
// Console.WriteLine($"Twój poziom treningu wynosi {trening}.");



// 3 zadanie
// Console.WriteLine("Podaj liczbę racji żywności:");
// int racje = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj liczbę członków drużyny:");
// int czlonkowie = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj liczbę dni wyprawy:");
// double dni = double.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine($"Każdy członek drużyny otrzyma {racje/czlonkowie} racji żywności.");
// Console.WriteLine($"Po równym podziale, każdemu członkowi drużyny zostanie {racje%czlonkowie} racji żywności.");
// Console.WriteLine($"Każdy członek drużyny otrzyma {racje/czlonkowie/dni} racji żywności na dzień.");
// Console.WriteLine($"Po równym podziale, każdemu członkowi drużyny zostanie {racje%czlonkowie/dni} racji żywności na dzień.");



// 4 zadanie
// Console.WriteLine("Podaj liczbę punktów życia:");
// int zycie = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj liczbę mikstur:");
// int mikstury = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Czy Bohater ma klucz? (true/false):");
// bool klucz = bool.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Czy Bohater ma mapę? (true/false):");
// bool mapa = bool.Parse(Console.ReadLine());
// Console.Clear();
// bool czyZyje = zycie != 0;
// Console.WriteLine($"Bohater żyje: {czyZyje}");
// bool czyMaPelneZdrowie = zycie == 100; 
// Console.WriteLine($"Bohater ma pełne zdrowie: {czyMaPelneZdrowie}");
// bool czyMaMikstury = mikstury > 0;
// Console.WriteLine($"Bohater ma mikstury: {czyMaMikstury}");
// bool zaopatrzenie = klucz || mapa;
// Console.WriteLine($"Bohater ma zaopatrzenie: {zaopatrzenie}");
// bool czygotowy = czyZyje && czyMaPelneZdrowie && czyMaMikstury && zaopatrzenie;
// Console.WriteLine($"Bohater jest gotowy do wyprawy: {czygotowy}");



// 5 zadanie
// Console.WriteLine("Podaj nazwę bohatera:");
// String nazwa = Console.ReadLine();
// Console.Clear();
// Console.WriteLine("Maksymalne zdrowie wynosi: 100 ");
// Console.WriteLine("Podaj maskymalne zdrowie:");
// int maxZdrowie = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj aktualne zdrowie:");
// int aktualneZdrowie = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj podstawową ilość obrażeń:");
// int obrazenia = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj premię do siły:");
// int sila = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj mnożnik ataku:");
// double mnoznik = double.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj ilość wykonanych ataków:");
// int ataki = int.Parse(Console.ReadLine());
// Console.Clear();
// int zdrowiePrzeciwnika = 100;
// int obrazeniaPrzeciwnika = 50;
// Console.WriteLine($"Bohater {nazwa} rozpoczyna wakę");
// int obrazeniaZadane = (int)(obrazenia + sila);
// Console.WriteLine($"Zwykły atak zadaje {obrazeniaZadane} obrażeń przeciwnikowi.");
// int atakspecjalny = (int)(obrazeniaZadane * mnoznik);
// Console.WriteLine($"Atak specjalny zadaje {atakspecjalny} obrażeń przeciwnikowi.");
// Console.WriteLine($"Łącznie bohater zadał {(obrazeniaZadane + atakspecjalny)*ataki} obrażeń przeciwnikowi.");
// Console.WriteLine($"Bohaterowi zostaje {aktualneZdrowie - obrazeniaPrzeciwnika} punktów zdrowia po ataku przeciwnika.");
// bool czyBohaterZyje = aktualneZdrowie - obrazeniaPrzeciwnika > 0;
// Console.WriteLine($"Bohater {nazwa} żyje: {czyBohaterZyje}");
// bool czymapelnezdrowie = aktualneZdrowie == maxZdrowie;
// Console.WriteLine($"Bohater {nazwa} ma pełne zdrowie: {czymapelnezdrowie}");



// 6 zadanie
// const int maxZdrowie = 100;
// Console.WriteLine("Podaj imię bohatera:");
// string imie = Console.ReadLine();
// Console.Clear();
// Console.WriteLine($" Max zdrowie bohatera: {maxZdrowie}");
// Console.WriteLine("Podaj zdrowie bohatera:");
// double zdrowie = double.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Czy Bohater ma tarczę? (true/false):");
// bool tarcza = bool.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Czy Bohater ma miecz? (true/false):");
// bool miecz = bool.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj moc ataku bohatera:");
// int mocAtaku = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj ilość złota bohatera:");
// int zloto = int.Parse(Console.ReadLine());
// Console.Clear();
// bool czymaszanse = tarcza || miecz;
// bool czymamaxsile = mocAtaku > 50;
// Console.WriteLine("======== Wyniki bohatera ========");
// Console.WriteLine($"Bohater {imie} ma szanse na przeżycie: {czymaszanse}");
// Console.WriteLine($"Bohater {imie} ma pełne zdrowie: {zdrowie == maxZdrowie}");
// Console.WriteLine($"Bohater {imie} ma tarczę: {tarcza}");
// Console.WriteLine($"Bohater {imie} ma wysoką siłę: {czymamaxsile}");
// Console.WriteLine($"Pełne obrażenia bohatera wynoszą: {mocAtaku + (miecz ? 20 : 0) + (tarcza ? 10 : 0)}");
// Console.WriteLine($"Bohater {imie} ma {((double)zdrowie / maxZdrowie) * 100}% życia.");
// Console.WriteLine($"Czy Bohater {imie} jest gotowy do walki: {zdrowie > 0 && czymamaxsile}");
// Console.WriteLine($"Bohaterowi {imie} zostanie {zloto/2} i {zloto%2} złota po walce.");
// Console.WriteLine("================================");