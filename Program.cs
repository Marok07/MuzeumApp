using MuzeumApp;

List<Mutargy> mutargyak = new List<Mutargy>();
var file = File.ReadAllLines("mutargyak.txt").Skip(1);
int hibasSorokSzama = 0;
foreach(var line in file)
{
    if (string.IsNullOrWhiteSpace(line)) { hibasSorokSzama++; continue; }
    string[] data = line.Split('|');
    if(data.Length != 4) { hibasSorokSzama++; continue; }
    if (data[0] != "F" && data[0] != "M" || string.IsNullOrWhiteSpace(data[1])) { hibasSorokSzama++; continue; }
    if (!int.TryParse(data[2], out int becsultErtek) || !int.TryParse(data[3], out int korEvekben)) { hibasSorokSzama++; continue; }
    if (data[0] == "M")
    {
        Mutargy mutargy = new Mutargy(data[1], int.Parse(data[2]));
        mutargyak.Add(mutargy);
    }
    else
    {
        Festmeny mutargy = new Festmeny(data[1], int.Parse(data[2]), int.Parse(data[3]));
        mutargyak.Add(mutargy);
    }
}

Console.WriteLine($"Sikeresen beolvasott műtárgyak száma: {mutargyak.Count} db\nKiszűrtz hibás sorok száma: {hibasSorokSzama} db");
Console.WriteLine("Beolvasott műtárgyak listája:");
foreach(var mutargy in mutargyak)
{
    Console.WriteLine(mutargy);
}

Console.WriteLine("LINQ Statisztikák:");

