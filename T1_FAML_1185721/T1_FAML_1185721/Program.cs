class program
{
    static void Main()
    {
        string nombre, edad, carrera, carne;

        Console.WriteLine("Mi segundo programa");

        Console.WriteLine("Ingrese su nombre");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su edad");
        edad = Console.ReadLine();

        Console.WriteLine("Ingrese su carrera");
        carrera = Console.ReadLine();

        Console.WriteLine("Ingrese su carné");
        carne = Console.ReadLine();


        Console.WriteLine("Nombre: "+ nombre);
        Console.WriteLine("Edad: " +edad );
        Console.WriteLine("Carrera: " + carrera);
        Console.WriteLine("Carné: " + carne);

        Console.WriteLine("Soy " + nombre + " tengo " + edad + " años y estudio la carrera de "+ carrera + ". " + " Mi numero de carné es "+ carne );

        Console.ReadKey();

    }
}
