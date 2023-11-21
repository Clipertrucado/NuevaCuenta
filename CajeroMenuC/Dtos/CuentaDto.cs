using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Dtos
{
    internal class CuentaDto
    {
        long idCuenta; //PK

        string isban = "aaaaa";

        string codigoSwitch = "aaaaa";

        long identCliente=111111111;

        string fchAltaCliente = "9999/12/31";

        string fchBajaCliente = "9999/12/31";

        
        public long IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string ISBAN { get => isban; set => isban = value; }
        public string CodigoSwitch { get => codigoSwitch; set => codigoSwitch = value; }
        public long IdentCliente { get => identCliente; set => identCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }

        
        public CuentaDto(long idCuenta, string isban, string codigoSwitch, long IdentCliente, string fchAltaCliente)
        {
            this.idCuenta = idCuenta;
            this.isban = isban;
            this.codigoSwitch = codigoSwitch;
            this.IdentCliente = IdentCliente;
            this.fchAltaCliente = fchAltaCliente;
         
        }
        public CuentaDto()
        {
        }

       
        override
        public string ToString()
        {
            string cuentaString = "ID de la cuenta: " + this.idCuenta +
                " ISBAN: " + this.isban +
                " Codigo switch: " + this.codigoSwitch +
                " Identificador del usuario: " + this.IdentCliente +
                " Fecha Alta: " + this.fchAltaCliente +
                " Fecha Baja: " + this.fchBajaCliente;

            return cuentaString;
        }
    }
}
