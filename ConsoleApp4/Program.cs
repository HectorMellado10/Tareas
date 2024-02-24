using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1 { }
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mayor = Math.Max(num1, Math.Max(num2, num3));

            Console.WriteLine($"El número mayor es: {mayor}");

            Console.WriteLine("Ingrese su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al club.");
            }
            else
            {
                Console.WriteLine("Lo siento, debes ser mayor de 18 años para ingresar al club.");
            }
            Console.WriteLine("Ingrese el precio original del producto:");
            double precioOriginal = Convert.ToDouble(Console.ReadLine());

            if (precioOriginal > 100)
            {
                double descuento = precioOriginal * 0.10;
                double precioFinal = precioOriginal - descuento;
                Console.WriteLine($"Precio final con descuento: {precioFinal}");
            }
            else
            {
                Console.WriteLine($"El precio final es: {precioOriginal}");
            }
            Console.WriteLine("Ingrese nombre de usuario:");
            string usuario = Console.ReadLine();

            Console.WriteLine("Ingrese contraseña:");
            string contraseña = Console.ReadLine();

            if (usuario == "usuario" && contraseña == "contraseña")
            {
                Console.WriteLine("Acceso permitido.");
            }
            else
            {
                Console.WriteLine("Credenciales incorrectas. Acceso denegado.");
            }

            Console.WriteLine("Ingrese un número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }

            Console.WriteLine("Ingrese el monto del préstamo:");
            double montoPrestamo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su edad:");
            int edadUsuario = Convert.ToInt32(Console.ReadLine());

            if (montoPrestamo < 5000 || edadUsuario > 60)
            {
                Console.WriteLine("Préstamo aprobado.");
            }
            else
            {
                Console.WriteLine("Préstamo rechazado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        {
            Console.WriteLine("Ingrese el tipo de figura geométrica (triángulo, cuadrado o círculo):");
            string tipoFigura = Console.ReadLine().ToLower();

            double area = 0;

            switch (tipoFigura)
            {
                case "triangulo":
                    Console.WriteLine("Ingrese la base del triángulo:");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura del triángulo:");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                    area = 0.5 * baseTriangulo * alturaTriangulo;
                    break;

                case "cuadrado":
                    Console.WriteLine("Ingrese el lado del cuadrado:");
                    double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

                    area = ladoCuadrado * ladoCuadrado;
                    break;

                case "circulo":
                    Console.WriteLine("Ingrese el radio del círculo:");
                    double radioCirculo = Convert.ToDouble(Console.ReadLine());

                    area = Math.PI * radioCirculo * radioCirculo;
                    break;

                default:
                    Console.WriteLine("Tipo de figura no reconocido.");
                    break;
            }

            Console.WriteLine($"El área de la figura es: {area}");

            

            Console.WriteLine("Ingrese un número del 1 al 5 en letra:");
            string numeroLetra = Console.ReadLine().ToLower();

            int numeroDigit = 0;

            switch (numeroLetra)
            {
                case "uno":
                    numeroDigit = 1;
                    break;

                case "dos":
                    numeroDigit = 2;
                    break;

                case "tres":
                    numeroDigit = 3;
                    break;

                case "cuatro":
                    numeroDigit = 4;
                    break;

                case "cinco":
                    numeroDigit = 5;
                    break;

                default:
                    Console.WriteLine("Número no reconocido.");
                    break;
            }

            Console.WriteLine($"El número en dígito es: {numeroDigit}");

        }

        Console.WriteLine("Ingrese un número del 1 al 7:");
        int numeroDia = Convert.ToInt32(Console.ReadLine());

        string diaSemana = "";

        switch (numeroDia)
        {
            case 1:
                diaSemana = "Lunes";
                break;

            case 2:
                diaSemana = "Martes";
                break;

            case 3:
                diaSemana = "Miércoles";
                break;

            case 4:
                diaSemana = "Jueves";
                break;

            case 5:
                diaSemana = "Viernes";
                break;

            case 6:
                diaSemana = "Sábado";
                break;

            case 7:
                diaSemana = "Domingo";
                break;

            default:
                Console.WriteLine("Número no válido para un día de la semana.");
                break;
        }

        Console.WriteLine($"El día de la semana es: {diaSemana}");

        Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
        string tipoServicio = Console.ReadLine().ToLower();

        double costoServicio = 0;

        switch (tipoServicio)
        {
            case "lavado de auto":
                costoServicio = 15.00;
                break;

            case "cambio de aceite":
                costoServicio = 30.00;
                break;

            case "revisión mecánica":
                costoServicio = 50.00;
                break;

            default:
                Console.WriteLine("Tipo de servicio no reconocido.");
                break;
        }

        Console.WriteLine($"El importe a pagar por el servicio es: {costoServicio}");
        Console.WriteLine("Ingrese el idioma de su preferencia (español, inglés, francés):");
        string idioma = Console.ReadLine().ToLower();

        string mensajeBienvenida = "";

        switch (idioma)
        {
            case "español":
                mensajeBienvenida = "¡Bienvenido!";
                break;

            case "inglés":
                mensajeBienvenida = "Welcome!";
                break;

            case "francés":
                mensajeBienvenida = "Bienvenue!";
                break;

            default:
                Console.WriteLine("Idioma no reconocido.");
                break;
        }

        Console.WriteLine(mensajeBienvenida);

        Console.WriteLine("Ingrese la calificación del examen:");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        string desempenio = "";

        if (calificacion >= 90 && calificacion <= 100)
        {
            desempenio = "Sobresaliente";
        }
        else if (calificacion >= 80 && calificacion <= 89)
        {
            desempenio = "Notable";
        }
        else if (calificacion >= 70 && calificacion <= 79)
        {
            desempenio = "Aprobatoria";
        }
        else if (calificacion >= 60 && calificacion <= 69)
        {
            desempenio = "No aprobatoria";
        }
        else
        {
            Console.WriteLine("Calificación no válida.");
        }

        if (!string.IsNullOrEmpty(desempenio))
        {
            Console.WriteLine($"Desempeño en el examen: {desempenio}");
        }
    }
}
