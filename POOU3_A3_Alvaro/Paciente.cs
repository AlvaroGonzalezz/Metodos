using System;

namespace POOU3_A3_Alvaro
{
     class Paciente
    {
        #region Campos
        // Miembros de tipo Campo
        // Para registrarse (datos generales)
        string nombrePaciente, primerApellidoPaciente, segundoApellidoPaciente, callePaciente, numCasaPaciente,
            coloniaPaciente, ciudadPaciente, numeroTelefonoPaciente;
        int edadPaciente;

        #endregion


        #region Constructores

        /// <summary>
        /// Constructor Vacio (Sin parámetros) 
        /// </summary>
        public Paciente()
        {
            // Personalizamos la consola
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "VACUTEC";
            Console.Clear();

            // Pedimos los datos generales al alumno
            Console.WriteLine("\t\t\t-------Bienvenido a Sistemas de Vacunas COVID-19---------");
            Console.WriteLine("\n-------------Registro---------------");
            Console.WriteLine("Registra su nombre: ");
            nombrePaciente = Console.ReadLine();
            Console.WriteLine("Registra tu primer apellido: ");
            primerApellidoPaciente = Console.ReadLine();
            Console.WriteLine("Registra tu segundo apellido: ");
            segundoApellidoPaciente = Console.ReadLine();
            Console.WriteLine("Registra tu edad: (ej: 19)");
            edadPaciente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Registra tu calle: ");
            callePaciente = Console.ReadLine();
            Console.WriteLine("Registra tu número de casa / habitación: ");
            numCasaPaciente = Console.ReadLine();
            Console.WriteLine("Registra tu colonia: ");
            coloniaPaciente = Console.ReadLine();
            Console.WriteLine("Registra tu ciudad: ");
            ciudadPaciente = Console.ReadLine();
            Console.WriteLine("Registra tu número de teléfono: ");
            numeroTelefonoPaciente = Console.ReadLine();
     
        }
        /// <summary>
        /// Constructor con 3 parámetros
        /// </summary>
        /// <param name="nombrePaciente">Nombre del paciente</param>
        /// <param name="primerApellidoPaciente">Primer apellido del paciente</param>
        /// <param name="segundoApellidoPaciente">Segundo apellido del paciente</param>
        public Paciente(string nombrePaciente, string primerApellidoPaciente, string segundoApellidoPaciente)
        {
            this.nombrePaciente = nombrePaciente;
            this.primerApellidoPaciente = primerApellidoPaciente;
            this.segundoApellidoPaciente = segundoApellidoPaciente;
        }
        /// <summary>
        /// Constructor con 4 parámetros
        /// </summary>
        /// <param name="nombrePaciente">Nombre del paciente</param>
        /// <param name="primerApellidoPaciente">Primer apellido del paciente</param>
        /// <param name="segundoApellidoPaciente">Segundo apellido del paciente</param>
        /// <param name="edadPaciente">Edad del paciente</param>

        public Paciente(string nombrePaciente, string primerApellidoPaciente, string segundoApellidoPaciente, int edadPaciente )
        {
            this.nombrePaciente = nombrePaciente;
            this.primerApellidoPaciente = primerApellidoPaciente;
            this.segundoApellidoPaciente = segundoApellidoPaciente;
            this.edadPaciente = edadPaciente;
        }
        #endregion

        #region Metodos

        // Método para mostrar la información general del paciente a vacunar
        /// <summary>
        /// Método para mostrar información cliente
        /// </summary>
        public void MostrarInformacionPaciente()
        {
            Console.WriteLine("-------INFORMACIÓN DEL PACIENTE A VACUNAR--------");
            Console.WriteLine("\nNombre: {0} {1} {2}", nombrePaciente, primerApellidoPaciente, segundoApellidoPaciente);
            Console.WriteLine("Número de Seguro: {0}", GenerarNumeroSeguro());
            Console.WriteLine("Dirección -> Calle: {0}| N° Casa/Habitación: {1} | Colonia: {2} | Ciudad: {3}| ", callePaciente, numCasaPaciente,
                coloniaPaciente, ciudadPaciente);
            Console.WriteLine("Edad: {0} años.", MostrarEdadPaciente());
            Console.WriteLine("Número de teléfoo: {0}", numeroTelefonoPaciente);
        }

        // Método para mostrar la edad 
        /// <summary>
        /// Mostrar la edad
        /// </summary>
        /// <returns></returns>
        private int MostrarEdadPaciente()
        {
            return edadPaciente;   
        }

        // Método bool para saber si ya fue vacunado
        /// <summary>
        /// Mostrar estado de la vacuna
        /// </summary>
        public bool MostrarEstadoVacunaPaciente()
        {
            bool retorno; // Declaramos una variable para hacer el return
            Console.WriteLine("------ VACUNACIÓN-----");
            Console.WriteLine("¿El paciente {0} {1} {2} ya fue vacunado con segunda dosis?", nombrePaciente
                , primerApellidoPaciente, segundoApellidoPaciente);
            Console.WriteLine("Para indicar que ya fue vacunado presiona la tecla -> S ");
            Console.WriteLine("De no ser así, presiona cualquier otra tecla.");
            ConsoleKeyInfo teclaPresionada = Console.ReadKey();
            if (teclaPresionada.Key == ConsoleKey.S) // Evaluamos la tecla que guarda la respuesta paciente
            {
                Console.WriteLine("\n\nEl paciente {0} {1} {2} ya ha sido vacunado con segunda dosis.", nombrePaciente, primerApellidoPaciente,
                    segundoApellidoPaciente);
                retorno = true; // Regresamos un true, ya que resulto verdadera la condicion
            }
            else
            {
                Console.WriteLine("\nEl paciente no ha sido vacunado, se procederá a abrir el menú de fecha para su vacunación");
                AgendarFechaVacunacion();
                 retorno = false; 
            }
            return retorno;
        }
        /// <summary>
        /// Método para generar el número de seguro.
        /// </summary>
        private int GenerarNumeroSeguro()
        {
            // Instanciamos un objeto de tipo Random
            Random random = new Random();
            // Guardamos el número random en una variable
            int numeroSeguro = random.Next(999999999);
            return numeroSeguro;
        }
        /// <summary>
        /// Método para generar una fecha de vacunación
        /// </summary>
        private void AgendarFechaVacunacion()
        {
            Console.WriteLine("\t\t---------FECHA PARA VACUNACIÓN SEGUNDA DOSIS-------"); // Letrero
            // Solicitamos una respuesta al usuario
            Console.WriteLine("\n¿Desea generar una fecha para su vacunación?"); 
            Console.WriteLine("Para generar fecha de vacunación, presione la tecla -> S");
            Console.WriteLine("De no ser así, presione cualquier otra tecla.");
            ConsoleKeyInfo respuestaUsuario = Console.ReadKey(); // Guardamos su respuesta en una estructura para teclas
            if (respuestaUsuario.Key == ConsoleKey.S) // Evaluamos lo que tenga contenida
            {
                // De ser verdadera, mandamos a pantalla los detalles de la fecha
                Console.WriteLine("\n\nA continuación se muestra los detalles: ");
                Console.WriteLine("Paciente: {0} {1} {2}", nombrePaciente, primerApellidoPaciente,
                    segundoApellidoPaciente);
                Console.WriteLine("Fecha para su vacunación: {0} (Formato: Año/Mes/Día)", GenerarFechaVacunacion());
                Console.WriteLine("Asistir a tu centro de salud más cercano.");
            }
            else
            {
                // Si presiona otra tecla que no sea S se mandara:
                Console.WriteLine("\nSeleccionaste no generar tu fecha de vacunación");
            }
        }
        /// <summary>
        /// Método para generar una fecha de vacunación
        /// </summary>
        private DateTime GenerarFechaVacunacion()
        {
            // Instanciamos un objeto de tipo Random para generar los números aleatorios
            Random random = new Random();
            // Generamos variables con números aleatorios (año, mes, dia)
            int año = random.Next(2023, 2024); // Número random para año
            int mes = random.Next(5, 12); // Número random para mes
            int dia = random.Next(1, 30); // Número random para día

            // Usamos las variables para generar la fecha random
            DateTime fechaGenerada = new DateTime(año, mes, dia);
            return fechaGenerada; // Regresamos dicha fecha
        }
        /// <summary>
        /// Método para personalizar la consola
        /// </summary>
        public void PersonalizarConsola()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "VACUTEC";
            Console.Clear();
        }
        #endregion

    }
}
