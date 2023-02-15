class Sub{
    public static void Gestionar()
    {
        Console.Clear();
        bool continuar = true;
        List<Personajes> Personaje = new List<Personajes>();
        var jso = System.IO.File.ReadAllText("Personajes.json");
        Personaje=Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personajes>>(jso);
       
        var archivo= "Personajes.json";
    
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine(@"
            Gestionar Personaje
            A-Agregar.
            B-Modificar.
            C-Eliminar.
            R-Regresar.");
            Console.Write("Que desea realizar: ");

            var op=Console.ReadLine();
            switch(op)
            {
                case "A":
                Console.Clear();
               
                var p=new Personajes();
              
                p.Sexo="indefinido";
            
                try
                {
                Console.WriteLine(@"Inserte el nombre del personaje");
                p.Nombre=Console.ReadLine()??"";
                Console.WriteLine(@"Inserta el apellido del personaje");
                p.Apellido=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte el link de la foto del personaje");
                p.Foto=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte como se pronuncia el nombre del personaje");
                p.Pronunciacion=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte de que serie es el personaje");
                p.Serie=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte el poder o habilidad del personaje");
                p.Poder=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la fecha de nacimeinto con el siguiente formato(MM/DD/YYYY) del personaje");
                p.FechaNacimiento=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la frase del personaje");
                p.Frase=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte como es la vestimenta del personaje");
                p.Vestimenta=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la altura del personaje");
                p.Altura=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte el sexo del personaje");
               p.Sexo=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte el estado del personaje");
                p.Estado=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la direccion del personaje");
                p.Direccion=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la latitud del personaje");
                p.Latitud=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la longitud del personaje");
                p.Longitud=Console.ReadLine()??"";
                Console.Clear();
                Console.WriteLine("Guardado Exitoso");
                Console.ReadKey();
                Console.Clear();

                }
            catch
            {
                Console.Clear();
                Console.WriteLine(@"Formato incorrecto
                Pulse para continuar...");
                Console.ReadKey();
            }
              Personaje.Add(p);
              var json= Newtonsoft.Json.JsonConvert.SerializeObject(Personaje);
              File.WriteAllText(archivo,json);
                break;

                case "B":
               
                var pe=new Personajes();
              
                pe.Sexo="indefinido";
                Console.Clear();
                Console.WriteLine(@"Modificar Personaje");
                var n=0;
                foreach (var it in Personaje)
                {
                    Console.Clear();
                    Console.WriteLine(@$"
                    Id:{n}
                    Nombre:{it.Nombre}
                    Apellido:{it.Apellido}
                    Foto:{it.Foto}
                    Pronunciacion:{it.Pronunciacion}
                    Serie:{it.Serie}
                    Poder:{it.Poder}
                    FechaNacimiento:{it.FechaNacimiento}
                    Frase:{it.Frase}
                    Vestimenta:{it.Vestimenta}
                    Altura:{it.Altura}
                    Sexo:{it.Sexo}
                    Estado:{it.Estado}
                    Direccion:{it.Direccion}
                    Latitud:{it.Latitud}
                    Longitud:{it.Longitud}
                    ");
                    n++;
                }
                Console.Write("Ingrese el numero del personaje que desea editar: ");
                n=int.Parse(Console.ReadLine()??"");
                if(Personaje[n] !=null)
                {
                var it=Personaje[n];
                Console.WriteLine(@"Inserte el nombre del personaje");
                it.Nombre=Console.ReadLine()??"";
                Console.WriteLine(@"Inserta el apellido del personaje");
                it.Apellido=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte el link de la foto del personaje");
                it.Foto=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte como se pronuncia el nombre del personaje");
                it.Pronunciacion=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte de que serie es el personaje");
                it.Serie=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte el poder o habilidad del personaje");
                it.Poder=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la fecha de nacimiento del personaje");
                it.FechaNacimiento=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la frase del personaje");
                it.Frase=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte como es la vestimenta del personaje");
                it.Vestimenta=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la altura del personaje");
                it.Altura=Console.ReadLine()??"";
                  Console.WriteLine(@"Inserte el sexo del personaje");
                it.Sexo=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte el estado del personaje");
                it.Estado=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la direccion del personaje");
                it.Direccion=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la latitud del personaje");
                it.Latitud=Console.ReadLine()??"";
                Console.WriteLine(@"Inserte la longitud del personaje");
                it.Longitud=Console.ReadLine()??"";
                Personaje[n]=it;
                Personaje.Add(it);
                Console.Clear();
                Console.WriteLine(@"Personaje editado con exito");
                Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine(@"No se encontro el ataque");
                    Console.ReadKey();
                    Console.Clear();
                }
                
                break;

                case "C":
                        Console.Clear();
                        Console.WriteLine("Eliminar Ataque");
                        var id=0;
                        foreach (var per in Personaje)
                        {
                        Console.WriteLine(@$"
                                Id:{id}
                                Nombre:{per.Nombre}
                                Apellido:{per.Apellido}
                                Foto:{per.Foto}
                                Pronunciacion:{per.Pronunciacion}
                                Serie:{per.Serie}
                                Poder:{per.Poder}
                                FechaNacimiento:{per.FechaNacimiento}
                                Frase:{per.Frase}
                                Vestimenta:{per.Vestimenta}
                                Altura:{per.Altura}
                                Sexo:{per.Sexo}
                                Estado:{per.Estado}
                                Direccion:{per.Direccion}
                                Latitud:{per.Latitud}
                                Longitud:{per.Longitud}
                                ");
                                id++;
                        }
                        Console.Write("Elige el id del ataque que desea eliminar:");
                        var eleccion=int.Parse(Console.ReadLine()??"");
                        if(eleccion >=0 && eleccion < Personaje.Count)
                        {
                        Personaje.RemoveAt(eleccion);
                        Console.WriteLine("Ataque eliminado");
                        var jsonn= Newtonsoft.Json.JsonConvert.SerializeObject(Personaje);
                        File.WriteAllText(archivo,jsonn);
                        }
                        Console.Clear();
                        Console.WriteLine("Ataque eliminado");
                        Console.ReadKey();
                        Console.Clear();
                    break;
                    
                    case "R":
                    Console.Clear();
                    Program.Main();
                    
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

        Console.Clear();
    }
    public static void Reportes()
    {
       Console.Clear();
       List<Personajes> Personaje = new List<Personajes>();
        var jso = System.IO.File.ReadAllText("Personajes.json");
        Personaje=Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personajes>>(jso);
       var ul = new Personajes();
        var archivo= "Personajes.json";
       Console.WriteLine("Reportes");
       bool continuar=true;

       while(continuar)
       {
        Console.WriteLine(@"
        1-Listado de Personajes.
        2-Mapa de los Personajes.
        3-Exportar HTML.
        4-Regresar.");
        Console.Write("Que desea realizar: ");
        var op=Console.ReadLine();
        switch(op)
        {
            case "1":
            Console.Clear();
        Console.WriteLine("Listado de Personajes");
            var n=0;
            
            foreach (var it in Personaje)
                {
                    
                    Console.WriteLine(@$"
                    Id:{n}
                    Nombre:{it.Nombre}
                    Apellido:{it.Apellido}
                    Serie:{it.Serie}
                    FechaNacimiento:{it.FechaNacimiento}
                    Sexo:{it.Sexo}
                    Estado:{it.Estado}
                    ");
                     n++;
                }
               

            Console.ReadKey();
            Console.Clear();

            break;

            case "2":
            Console.Clear();
            Console.WriteLine("Mapa de los Personajes");
            
         
            
            break;

            case "3":
          
            Console.WriteLine("Exportar HTML");
            
            var nu=0;
                foreach (var it in Personaje)
                {
                    
                    Console.WriteLine(@$"
                    Id:{nu}
                    Nombre:{it.Nombre}
                    Apellido:{it.Apellido}
                    Foto:{it.Foto}
                    Pronunciacion:{it.Pronunciacion}
                    Serie:{it.Serie}
                    Poder:{it.Poder}
                    FechaNacimiento:{it.FechaNacimiento}
                    Frase:{it.Frase}
                    Vestimenta:{it.Vestimenta}
                    Altura:{it.Altura}
                    Sexo:{it.Sexo}
                    Estado:{it.Estado}
                    Direccion:{it.Direccion}
                    Latitud:{it.Latitud}
                    Longitud:{it.Longitud}
                    ");
                
                    nu++;
                
             
                    Console.Write("Cual desea exportar: ");
                    Console.ReadLine();
                    string html=@$"
                    <html>
                    <head>
                    <title>Personaje</title>
                    </head>
                    <body>
                    <img src='{it.Foto}'>
                    <p>Nombre:{it.Nombre}</p>
                    <p>Apellido:{it.Apellido}</p>
                    <p>Pronunciacion:{it.Pronunciacion}</p>
                    <p>Serie:{it.Serie}</p>
                    <p>Poder:{it.Poder}</p>
                    <p>FechaNacimiento:{it.FechaNacimiento}</p>
                    <p>Frase:{it.Frase}</p>
                    <p>Vestimenta:{it.Vestimenta}</p>
                    <p>Altura:{it.Altura}</p>
                    <p>Sexo:{it.Sexo}</p>
                    <p>Estado:{it.Estado}</p>
                    <p>Direccion:{it.Direccion}</p>
                    <p>Latitud:{it.Latitud}</p>
                    <p>Longitud:{it.Longitud}</p>
                    <p></body>
                    ";

                        System.IO.File.WriteAllText("exportar.html",html);
                        var proceso= new System.Diagnostics.ProcessStartInfo();
                        proceso.UseShellExecute=true;
                        proceso.FileName="exportar.html";
                        System.Diagnostics.Process.Start(proceso);
                        Console.Clear();
                        Console.WriteLine("Abriendo pestaña en el navegador...");
                        Console.Clear();
                }
            Console.ReadKey();
            Console.Clear();

            break;

            case "4":
            Console.Clear();
            Program.Main();
            break;

            default:
            Console.Clear();
            Console.WriteLine(@"Opcion invalida
            Pulse una tecla para regresar...");
            Console.ReadKey();
            Console.Clear();
            break;
        }
       }
    }

    public static void AcercaDe()
    {
        Console.Clear();
        Console.WriteLine("Abriendo video en el navegador....");
        var url="Link-Video";
        var psi=new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute=true;
        psi.FileName=url;
        System.Diagnostics.Process.Start(psi);
        Console.ReadKey();
        Console.Clear();
    }
}