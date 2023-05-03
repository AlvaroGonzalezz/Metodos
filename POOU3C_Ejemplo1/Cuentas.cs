using System;
using System.Collections.Specialized;
using System.Threading;
using System.Speech.Synthesis;

namespace POOU3C_Ejemplo1
{
    class Cuentas
    {
        // ¿Qué contiene una clase?
        // Miembros: Campos, Métodos, Contructores, Propiedades, Destrctores

        #region Campos
        //Miembros de tipo de Campo
        string numeroCuentaCliente, nombreCliente,
            primerApellidoCliente, segundoApellidoCliente;
        string nipCliente, curpCliente = "SAGA2131241" , rfcCliente, descripcionAccion;
        double saldoActualCliente, saldoAneriorCliente;
        string direccionFiscalBanco, numeroTelefonoCliente, emailCliente;
        string tipoDivisaCuenta;
        DateTime fechaNaciminetoCliente;

        #endregion

        #region Constructores

        public Cuentas() { }
        public Cuentas(string nombreCliente,
            string primerApellidoCliente,
            string segundoApellidoCliente,
            string numeroTelefonoCliente,
            string curpCliente)
        {
            this.nombreCliente = nombreCliente;
            this.primerApellidoCliente = primerApellidoCliente;
            this.segundoApellidoCliente = segundoApellidoCliente;
            this.numeroTelefonoCliente = numeroTelefonoCliente;
            this.curpCliente = curpCliente;
        }
        #endregion

        #region Metodos

        //Método para crear una cuenta
        public bool AgregarCuenta()
        {
            bool valorRetorno;
            ConsoleKeyInfo keyInfo;
            Console.WriteLine("Módulo de administración de cuentas bancarias \n");
            if (string.IsNullOrEmpty(curpCliente))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No se a asignado un cliente.");
                valorRetorno = false;
            }
            else
            {
                Console.WriteLine("Elije una de las siguientes opciones: \n");
                Console.WriteLine("\t 1. Agregar una cuenta. \n");
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("\n Da de alta la cuenta del cliente con CURP: {0}", curpCliente);
                    numeroCuentaCliente = Console.ReadLine();
                    valorRetorno = true;
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Selecciona una opcion valida");
                    valorRetorno = false;

                }
            }


            return valorRetorno;
        }
        
        public bool LogIn()
        {
            string user, password;
            string user1 = "Gusoft", password1 = "Music";
            bool valorRetorno;
            Console.WriteLine("Teclea tu usuario: ");
            user = Console.ReadLine();
            Console.WriteLine("Teclea tu contraseña: ");
            password = Console.ReadLine();

            if (user1 == user && password1 == password)
            {
                Console.WriteLine("Logueando...");
                Thread.Sleep(1000);
                Console.WriteLine("Logueando...");
                Thread.Sleep(1000);
                // Crear objeto de tipo synteshis
                SpeechSynthesizer speech = new SpeechSynthesizer();
                speech.Speak("Bienvenidos al sistema, HIJOS DE PERRAAAAA, KENIA OS TU PATRONE Y SOPORTA PINCHE PERRA MALNACIDA HIJA DE BITCHSpeechSynthesizer speech = new SpeechSynthesizer();\r\n                speech.Speak(\"Bienvenidos al sistema\"); alvaro t extraño bb vuelve conmigo atentamente visual, tu patrone bbbbbbbbbbbbbbbbbbbbbbbb bbbbbbbbbbbbbbbbbb");

                valorRetorno = true;
            } 
            else
            {
                valorRetorno = false;
            }

            return valorRetorno;
        }


        public void Opciones()
        {
            // Declaramos la variables para guardar su respuesta
            string opcionSeleccionada;
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Speak("Escribe el digito de la opciones");
            Console.WriteLine("---------Módulo de administración bancaria-----------");
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Ver Información del Cliente \n2. Ver Información de la cuenta \n3. Agregar cuenta \n4.Eliminar cuenta \n5.Salir");
            opcionSeleccionada = Console.ReadLine();







        }


        #region PRACTICA
        // METODOS DE PRACTICA

        //public void RegistrarCliente()
        //{
        //    Console.WriteLine("-----REGISTRO DE CLIENTE--------");
        //    Console.WriteLine("\nIntroduce tu nombre: ");
        //    nombreCliente = Console.ReadLine();
        //    Console.WriteLine("Introduce tu primer apellido: ");
        //    primerApellidoCliente = Console.ReadLine();
        //    Console.WriteLine("Introduce tu segundo apellido: ");
        //    segundoApellidoCliente = Console.ReadLine();
        //    Console.WriteLine("Introduce tu número de télefono: ");
        //    numeroTelefonoCliente = Console.ReadLine();
        //    Console.WriteLine("Introduce tu CURP: ");
        //    curpCliente = Console.ReadLine();

        //}

        //public void AgregarCuenta2()
        //{
        //    Console.WriteLine("-----CREACIÓN DE CUENTA-----"); 
        //    Console.WriteLine("Nombre: {0} {1} {2}", nombreCliente, primerApellidoCliente, segundoApellidoCliente);
        //    Console.WriteLine("Télefono: {0}", numeroTelefonoCliente);
        //    Console.WriteLine("CURP: {0}", curpCliente);
        //    Console.WriteLine("\nCompleta los siguientes datos. \n");
        //    Console.WriteLine("Introduce tu RFC: ");
        //    rfcCliente = Console.ReadLine();
        //    Console.WriteLine("Introduce tu correo electrónico: ");
        //    emailCliente = Console.ReadLine();
        //    Console.WriteLine("Crea tu NIP (ej. 2142)");
        //    nipCliente = Console.ReadLine();
        //    Console.WriteLine("Creando cuenta....");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("Creando cuenta....");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("\n¡Cuenta creada con éxito!\n");
        //    Console.WriteLine("Número de cuenta: {0}", GenerarNumeroCuenta());
        //    Console.WriteLine("NIP: {0}", nipCliente);
        //}


        //// Metodo para generar numero de cuenta

        //public string GenerarNumeroCuenta()
        //{
        //    // Por variable
        //    // int numeroGenerado = random.Next(1000000000, 2009999999);

        //    // Por partes
        //    Console.WriteLine("----------GENERACIÓN DE NÚMERO DE CUENTA-----------");
        //    Console.WriteLine("\nIntroduce el codigo de la sucursal (3 dígitos)");
        //    string codigoSucursalBanco = Console.ReadLine();

        //    Console.WriteLine("Generando número de cuenta...");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("Generando número de cuenta...");
        //    Thread.Sleep(1000);

        //    // Generamos los ultimos 7 digitos aleatoriamente
        //    // Instanciamos la clase Random
        //    Random random = new Random();

        //    int sieteDigitosCuentaBanco = random.Next(9999999);

        //    // Concatenamos las dos partes

        //    string numeroCuenta =  codigoSucursalBanco + "-" + sieteDigitosCuentaBanco;


        //    return numeroCuenta;

        //}

        // Metodo para LogIn
        //public bool LogIn1 ()
        //{
        //    Console.Clear();
        //    string user, password;
        //    string user1 = "Gusoft", password1 = "Music";
        //    bool valorRetorno;

        //    Console.WriteLine("------------INICIO DE SESIÓN-----------");
        //    Console.WriteLine("\nTeclea tu usuario: ");
        //    user = Console.ReadLine();
        //    Console.WriteLine("Teclea tu contraseña: ");
        //    password = Console.ReadLine();

        //    if (user1 == user && password1 == password)
        //    {
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.WriteLine("Iniciaste sesión con exito.");
        //        valorRetorno = true;
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Usuario o Contraseña estan incorrectos, por favor vuelve a intentarlo");
        //        valorRetorno = false;
        //    }

        //    return valorRetorno;
            
        
        //}


        #endregion


        #region MetodosPrueba

        //Métodos
        public int CalcularCosto()
        {
            return 10 + 10;
        }
        public double CalcularCosto1(int cantidad, double precio)
        {
            return cantidad * precio;
        }

        public string CalcularCosto2(string nombreArticulo, int cantidad, double precio)
        {
            double total = cantidad * precio;
            return "Producto: " + nombreArticulo + " Total de venta: $" + total;
        }
        public void CalcularCosto3(string nombreArticulo, int cantidad, double precio)
        {
            double total = cantidad * precio;
            string resultado = "Producto: " + nombreArticulo + " Total de venta: $" + total;
            Console.WriteLine(resultado);
        }

        #endregion 



        public void PersonalizarConsola()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Title = "BancoTec";
            Console.WindowHeight = 20;
            Console.WindowWidth = 100;
            Console.Clear();
        }






        #endregion

    }

}