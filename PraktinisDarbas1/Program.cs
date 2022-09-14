//Susklaiciuoti zemes rutulio plota. 6371km S = 4 π * R^2

double plotas = 4 * 3.14 * 6371 * 6371;
Console.WriteLine($"Plotas : {plotas} kv. km");

/*apskaičiuoti žemės rutulio tūrį*/

double volume = 4 / 3 * 3.14 * 6371 * 6371 * 6371;
Console.WriteLine($"tūris: {volume}");

//3a uzduotis

int statinis1 = 10;
int statinis2 = 15;
double izambine = Math.Sqrt(Math.Pow(statinis1, 2) + Math.Pow(statinis2, 2));

Console.WriteLine("**********************************");
Console.WriteLine("Viso kintamuju : 3");
Console.WriteLine($"Kintamasis1 : {plotas}");
Console.WriteLine($"Kintamasis2 : {izambine}");
Console.WriteLine($"Kintamasis3 : {volume}");
double suma = plotas + izambine + volume;
Console.WriteLine($"Suma : {suma}");
Console.WriteLine($"Vidurkis : {suma / 3}");
Console.WriteLine("**********************************");