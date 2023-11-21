using CajeroMenuC.Dtos;

namespace CajeroMenuC.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua){
            
            ClienteDto cliente = crearNuevoCliente();
            
            listaAntigua.Add(cliente);
        }

        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca el id: ");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el dni: ");
            nuevoCliente.DniCliente = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de nacimiento: ");
            nuevoCliente.FchNacimientoCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el número de teléfono: ");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevoCliente.FchAltaCliente = Console.ReadLine();

            return nuevoCliente;
        }
        /*long idCliente; //PK

        string nombreCliente = "aaaaa";

        string apellidosCliente = "aaaaa";

        string dniCliente = "aaaaa";

        string fchNacimientoCliente = "9999/12/31";

        string emailCliente = "aaaaa";

        int tlfCliente = 111111111;

        string fchAltaCliente = "9999/12/31";

        string fchBajaCliente = "9999/12/31";*/
    }
}
