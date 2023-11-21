using CajeroMenuC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    internal class CuentaImplementacion : CuentaInterfaz
    {
        public void nuevaCuenta(List<CuentaDto> listaAntigua)
        {

            CuentaDto cuenta = crearNuevaCuenta();

            listaAntigua.Add(cuenta);
        }


        private CuentaDto crearNuevaCuenta()
        {
            CuentaDto nuevaCuenta = new CuentaDto();

            Console.WriteLine("Introduzca el id: ");
            nuevaCuenta.IdCuenta = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el ISBAN: ");
            nuevaCuenta.ISBAN = Console.ReadLine();

            Console.WriteLine("Introduzca el codigo switch: ");
            nuevaCuenta.CodigoSwitch = Console.ReadLine();

            Console.WriteLine("Introduzca identificador de usuario: ");
            nuevaCuenta.IdentCliente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevaCuenta.FchAltaCliente = Console.ReadLine();

            return nuevaCuenta;
        }
    }
}
