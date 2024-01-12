using zahlenliste;

List<int> Zahl = new List<int>(5);

Zahl.Add(1);
Zahl.Add(2);
Zahl.Add(3);
Zahl.Add(4);
Zahl.Add(5);

int summe = Zahl[0] + Zahl[1] + Zahl[2] + Zahl[3] + Zahl[4];

Console.WriteLine($"Die Summe beträgt: {summe}");
