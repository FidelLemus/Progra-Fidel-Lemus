   class Equipo
    {
        public string nombre;
       static int CEquipos = 8;
       static Equipo[] equipos = new Equipo[CEquipos];
        static Random random = new Random();

        static void MostrarEquipos() 
        {
            int i = 0, j = CEquipos - 1; 

            while (i < CEquipos / 2)
            {
                Console.WriteLine(equipos[i].nombre + "Vs" + equipos[j].nombre);
                i++;
                j--;
            }
        }

        static void Sortear()
        {
        for (int i = 0; i < CEquipos; i++)
            {
                int x = random.Next(0, CEquipos);
                Equipo aux = equipos[i];
               equipos[i]= equipos[x];
                equipos[x]= aux;
            }
        static int Sganador(int i, int j)
        {
            int x = random.Next(0, 100);

            if (x > 50)
            {
                return j;

            }
            return i;
        }
        void simulacion()
        {
            while (CEquipos > 1)
                MostrarEquipos();
            Console.WriteLine("============");
            int i = 0, j = CEquipos - 1;
            while (i < CEquipos / 2)
            {
                Console.WriteLine(equipos[i].nombre + "VS" + equipos[j].nombre);
                int x = Sganador(i, j);
                Equipo aux = equipos[i];
                equipos[i]= equipos[x];
                equipos [x]= aux;

                Console.WriteLine("Gano" + equipos[i].nombre);

                i++;
                j--;
                
            }

        }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < CEquipos; i++)
            {
                equipos[i] = new Equipo();
                equipos[i].nombre = "equipo" + i;
            }
        }
    }

