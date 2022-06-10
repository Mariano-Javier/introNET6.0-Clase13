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

static Billetera combinar(Billetera billetera01, Billetera billetera02)
{
    var billeteraNueva = new Billetera()
    {
        BilletesDe10 = billetera01.BilletesDe10 + billetera02.BilletesDe10,
        BilletesDe20 = billetera01.BilletesDe20 + billetera02.BilletesDe20,
        BilletesDe50 = billetera01.BilletesDe50 + billetera02.BilletesDe50,
        BilletesDe100 = billetera01.BilletesDe100 + billetera02.BilletesDe100,
        BilletesDe200 = billetera01.BilletesDe200 + billetera02.BilletesDe200,
        BilletesDe500 = billetera01.BilletesDe500 + billetera02.BilletesDe500,
        BilletesDe1000 = billetera01.BilletesDe1000 + billetera02.BilletesDe1000,
    };
    return billeteraNueva;
}

var billetera3 = combinar(billetera1, billetera2);

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
