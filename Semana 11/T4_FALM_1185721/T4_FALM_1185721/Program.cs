int[] Billetes = new int[6];


Billetes[0] = 100;
Billetes[1] = 50;
Billetes[2] = 20;
Billetes[3] = 10;
Billetes[4] = 5;
Billetes[5] = 1;

Console.WriteLine("Ingrese una cantidad: Q");
int cantidad = int.Parse(Console.ReadLine());

for (int i = 0; i < Billetes.Length; i++)
{
    int x = cantidad / Billetes[i];
    cantidad = cantidad % Billetes[i];  
    Console.WriteLine("Q" + Billetes[i] + "=" + x);
}