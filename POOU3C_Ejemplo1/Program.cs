using System;

namespace POOU3C_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar la clase
            Cuentas cuenta1 = new Cuentas();
            //Cuentas cuenta2 = new Cuentas("Juan", "Hernandez", "Castro", "8721312412", "JASF1231231");

            // Le asignamos el metodo para personalizar consola que nosotros creamos
            cuenta1.PersonalizarConsola();


            // Llamar metodo Agregar Cuenta
            //bool resultado3 = cuenta1.AgregarCuenta();

            if (cuenta1.LogIn())
            {

               
                cuenta1.AgregarCuenta();

                // PRACTICA
                // Console.WriteLine("Su numero de cuenta es: {0}", cuenta1.GenerarNumeroCuenta());
                // cuenta1.LogIn1();

            }
            else 
            {
                Console.WriteLine("NO se inicio sesion :(");
            }









            //// PRACTICA
            //cuenta2.RegistrarCliente();
            //cuenta2.AgregarCuenta2();


            #region LlamarMiembrosPrueba

            //// Mandar llamar los mienbros
            //int resultado = cuenta1.CalcularCosto();
            //double resultado1 = cuenta1.CalcularCosto1(10, 14.5);
            //string resultado2 = cuenta1.CalcularCosto2("Goicochea", 20, 200);
            //Console.WriteLine(resultado);
            //Console.WriteLine(resultado1);
            //Console.WriteLine(resultado2);
            ////Mandar llamar el metodo de tipó void
            //cuenta1.CalcularCosto3("Marcador TOP", 3, 20.99);

            #endregion


            Console.ReadKey();
        }
    }
}