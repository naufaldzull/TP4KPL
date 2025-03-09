// See https://aka.ms/new-console-template for more information

using TP4;

Console.Write("Masukan nama kelurahan: ");
string inputkelurahan = Console.ReadLine();

if (Enum.TryParse(inputkelurahan, out KodePos.kelurahan daerah))
{
    string kodePos = KodePos.GetKodePos(daerah);
    Console.WriteLine($"Kode Pos {inputkelurahan} : {kodePos}");
} 
else
{
    Console.WriteLine($"Kode Pos {inputkelurahan} : tidak ditemukan");
}

Console.WriteLine("\n");

DoorMachine pintu = new DoorMachine();

while (true)
{
    Console.Write("Masukkan perintah (buka/kunci/keluar): ");
    string perintah = Console.ReadLine().ToLower();

    if (perintah == "buka")
    {
        pintu.BukaPintu();
    }
    else if (perintah == "kunci")
    {
        pintu.KunciPintu();
    }
    else if (perintah == "keluar")
    {
        break;
    }
    else
    {
        Console.WriteLine("Perintah tidak dikenal. Gunakan 'buka', 'kunci', atau 'keluar'");
    }
}
