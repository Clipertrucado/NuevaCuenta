using CajeroMenuC.Servicios;
using CajeroMenuC.Dtos;

namespace CajeroMenuC.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 250923 - rfg
    /// </summary>
    class Program
    {
       
        /// <summary>
        /// Método de entrada de la aplicación
        /// 250923 - rfg
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<CuentaDto> listaCuenta = new List<CuentaDto>();

            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            CuentaInterfaz cu = new CuentaImplementacion();

            //variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
            //contener la opción del usuario
            int opcionSeleccionada;

            //desde la primera iteración debe cumplirse la condición
            while (!cerrarMenu)
            {
                
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:                        
                        Console.WriteLine("[INFO] - ALTA NUEVO CLIENTE");
                        ci.darAltaCliente(listaClientes);
                        //Pruebas
                        /*foreach (ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }*/
                        break;
                    case 2:


                        Console.WriteLine("[INFO] - Se ejecuta caso 2");
                        cu.nuevaCuenta(listaCuenta);
                        foreach (var item in listaCuenta) { 
                            Console.WriteLine(item.ToString()); 
                        }
                        break;
                    case 3:
                        
                        Console.WriteLine("[INFO] - Se ejecuta caso 3");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta caso 4");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta caso 5");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;               
                }

            }
        }

    }

}