using CajeroMenuC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    internal interface CuentaInterfaz
    {
        public void nuevaCuenta(List<CuentaDto> listaAntigua);

    }
}
