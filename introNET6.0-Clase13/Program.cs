using introNET6._0_Clase13.Modelo;

var billetera1 = new Billetera()
{
    BilletesDe10 = 10,
    BilletesDe20 = 5,
    BilletesDe50 = 2,
    BilletesDe100 = 2,
    BilletesDe200 = 3,
    BilletesDe500 = 1,
    BilletesDe1000 = 1,
};

var billetera2 = new Billetera()
{
    BilletesDe10 = 20,
    BilletesDe20 = 10,
    BilletesDe50 = 4,
    BilletesDe100 = 1,
    BilletesDe200 = 1,
    BilletesDe500 = 2,
    BilletesDe1000 = 3,
};

Console.WriteLine("--------Valores iniciales de las billeteras--------");

//Usando los datos de billetera1.
Console.WriteLine($"En la billetera 1 hay: {billetera1.TotalEnBilletera()} pesos");

//Usando los datos de billetera2.
Console.WriteLine($"En la billetera 2 hay: {billetera2.TotalEnBilletera()} pesos");

var billetera3 = billetera1.CombinarBilleteras(billetera2);

billetera1.LimpiarBilletera();
billetera2.LimpiarBilletera();

Console.WriteLine("");
Console.WriteLine("--------Después de limpiar las billeteras--------");

//valores finales de la billetera1.
Console.WriteLine($"En la billetera 1 hay: {billetera1.TotalEnBilletera()} pesos");

//valores finales de la billetera2.
Console.WriteLine($"En la billetera 2 hay: {billetera2.TotalEnBilletera()} pesos");

//Valores combinados de ambas billeteras en la billetera3.
Console.WriteLine($"En la billetera 3 hay: {billetera3.TotalEnBilletera()} pesos");
