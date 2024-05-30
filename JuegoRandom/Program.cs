//Es una colección de clases e interfaces fundamentales en C#
using System;

//Clase para crear objetos y definir el tipo de datos y las operaciones disponibles
class JuegoRandom
{
    //Static void es un método que no devuelve ningún valor, Main es el punto de entrada del programa 
    static void Main()
    {
        //Creamos una igualda de la clase Random. Esta clase se utiliza para generar números aleatorios.
        Random random = new Random();

        //Declaramos la variable NumeroPrograma y  asignamos un número aleatorio entre 1 y 100 generado por el objeto random.
        int NumeroPrograma = random.Next(1, 101);

        //Declaramos la variable Try para almacenar los intentos del usuario y se inicializa en 0
        int Try = 0;

        //Declaramos na variable booleana PlayAgain para controlar el ciclo del juego y se inicializa en false
        bool PlayAgain = false;

        //El programa nos imprime un mensaje en la consola indicando que ya geneó un número random entre 1 y 100
        Console.WriteLine("He generado un número aleatorio entre 1 y 100. ¡Intenta adivinarlo!");

        //Iniciamos un bucle while que continuará ejecutándose mientras PlayAgain sea false
        while (!PlayAgain)
        {
            //Se imprime en pantalla una orden al usuario para ingresar un número para adivinar el verdadero
            Console.Write("Intenta adivinar ingresa un múmero : ");

            //Se lee la entrada del usuario desde la consola, se convierte a un entero y se almacena en la variable Try
            Try = Convert.ToInt32(Console.ReadLine());

            //Verifica si el intento del usuario es menor que el número generado por el programa
            if (Try < NumeroPrograma)
            {
                //Imprime en la consola un mensaje indicando que el número ingresado es menor
                Console.WriteLine("Cerca pero sigues debajo del número correcto, intenta de nuevo.");
            }
            ////Verifica si el intento del usuario es mayor que el número generado por el programa
            else if (Try > NumeroPrograma)
            {
                //Verifica si el intento del usuario es mayor que el número generado por el programa
                Console.WriteLine("Cerca pero sigues encima del número correcto, intenta de nuevo.");
            }
            else
            {
                //Verifica si el intento del usuario es igual que el número generado por el programa
                PlayAgain = true;

                //Verifica si el intento del usuario es igual que el número generado por el programa
                Console.WriteLine("¡Correcto! ¡Has adivinado el número!");
            }
        }
    }
}