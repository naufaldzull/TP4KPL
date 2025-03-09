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
