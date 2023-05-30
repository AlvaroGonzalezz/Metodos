using System;

namespace POOU3_A3_Alvaro
{
     class Program
    {
        static void Main(string[] args)
        {
            // Nombre de la practica: VACUTEC
            // Tema de referencia: Vacunación COVID-19
            // Objetivo: Desarrollar una aplicación en console (.net framework), que implemente el paradigma
            // de programación orientada a objetos, en donde mediante un objeto por paciente se pueda agendar
            // la fecha de vacunación contra covid-19 de un determinado paciente.
            // Materia: Programacion Orientada a Objetosw
            // Alumno: Alvaro Sanchez Gonzalez

            // Creamos una instancia de la clase Alumno
            Paciente paciente1 = new Paciente();
            // Instanciamos el objeto pero con características inicializadas
            Paciente paciente2 = new Paciente("Alvaro", "Sánchez", "González");
            Paciente paciente3 = new Paciente("Ovidio", "Guzmán", "López", 25);
            // Mandamos a llamar el método para la apariencia de la consola
            paciente1.PersonalizarConsola();

            // Mandamos a llamar los métodos
            // Dentro de este método se manda a llamar el método para mostrar la edad
            paciente1.MostrarInformacionPaciente(); 
            // Mandamos a llamar el método para saber si esta vacunado o no 
            paciente1.MostrarEstadoVacunaPaciente();

            // Para no cerrar la consola:
            Console.ReadKey();
        }
    }
}
