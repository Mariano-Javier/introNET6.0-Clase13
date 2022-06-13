using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introNET6._0_Clase13.Modelo
{
    internal class Billetera
    {
        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }


        public decimal TotalEnBilletera()
        {
           return BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500 + BilletesDe1000 * 1000;
        }

        public decimal TotalEnBilletera(int billetesDe10, int billetesDe20, int billetesDe50, int billetesDe100, int billetesDe200, int billetesDe500, int billetesDe1000)
        {
            return billetesDe10 * 10 + billetesDe20 * 20 + billetesDe50 * 50 + billetesDe100 * 100 + billetesDe200 * 200 + billetesDe500 * 500 + billetesDe1000 * 1000;
        }

        public Billetera CombinarBilleteras(Billetera otraBilletera)
        {
            var billeteraNueva = new Billetera()
            {
                BilletesDe10 = BilletesDe10 + otraBilletera.BilletesDe10,
                BilletesDe20 = BilletesDe20 + otraBilletera.BilletesDe20,
                BilletesDe50 = BilletesDe50 + otraBilletera.BilletesDe50,
                BilletesDe100 = BilletesDe100 + otraBilletera.BilletesDe100,
                BilletesDe200 = BilletesDe200 + otraBilletera.BilletesDe200,
                BilletesDe500 = BilletesDe500 + otraBilletera.BilletesDe500,
                BilletesDe1000 = BilletesDe1000 + otraBilletera.BilletesDe1000,
            };
            return billeteraNueva;
        }

        public void LimpiarBilletera()
        {
            BilletesDe10 = 0;
            BilletesDe20 = 0;
            BilletesDe50 = 0;
            BilletesDe100 = 0;
            BilletesDe200 = 0;
            BilletesDe500 = 0;
            BilletesDe1000 = 0;
        }
    }        
}
