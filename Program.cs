class Program 
{
    public static void Main()
    {
        bool continuar=true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine(@"
            A-Gestionar Personaje.
            B-Reportes.
            C-Acerca De.
            D-Salir
            ");
            Console.Write("Que desea realizar: ");


            var op=Console.ReadLine();
            switch (op)
            {
                case "A":
                Sub.Gestionar();
                break;
                case "B":
                Sub.Reportes();
                break;
              
                case "C":
                Sub.AcercaDe();
                break;
                case "D":
                Console.Clear();
                Console.ReadKey();
                continuar=false;
                Console.Clear();
                break;

                default:
                Console.Clear();
                Console.WriteLine(@"Opcion invalida
                Pulse una tecla para continuar........");
                Console.ReadKey();
                Console.Clear();
                break;

            }
        }
    }
}