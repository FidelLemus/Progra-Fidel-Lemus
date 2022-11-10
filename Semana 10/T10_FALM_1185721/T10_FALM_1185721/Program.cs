static void Main(string[] args)
{
    TrianguloRectangulo triangulo = new TrianguloRectangulo();


    Console.WriteLine("Ingrese el Catetto A");
    triangulo.catetoA = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el angulo opuesto A");
    triangulo.anguloOpustoA = double.Parse(Console.ReadLine());

    Console.WriteLine("cateto B: " + triangulo.ObtenerCatetoB());
    Console.WriteLine("Hipotenusa " + triangulo.ObtenerHipotenusa());
    Console.WriteLine("Angulo opuesto B " + triangulo.ObtenerAnguloOpuestoB());
    Console.WriteLine("Area del triangulo " + triangulo.ObtenerArea());

}