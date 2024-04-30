int opcion;
Superheroe superheroe1 = new Superheroe();
Superheroe superheroe2 = new Superheroe();

do{
Console.WriteLine();
Console.WriteLine("Ingrese la opcion elegida");
Console.WriteLine("1. Cargar Datos Superhéroe 1");
Console.WriteLine("2. Cargar Datos Superhéroe 2");
Console.WriteLine("3. Competir!");
Console.WriteLine("4. Salir");
do
{
    opcion = int.Parse(Console.ReadLine());
}while(opcion < 1 && opcion > 4);

switch(opcion)
{
    case 1:
    superheroe1 = ObtenerSuperheroe();
    Console.WriteLine("Se ha creado el superheroe " + superheroe1.Nombre);
    break;

    case 2:
    superheroe2 = ObtenerSuperheroe();
    Console.WriteLine("Se ha creado el superheroe " + superheroe2.Nombre);
    break;
    case 3:
if(superheroe1.Nombre != "" && superheroe2.Nombre != "")
{
    double diferencia = 0;

    if(superheroe1.Skill > superheroe2.Skill)
    {
        diferencia = superheroe1.Skill - superheroe2.Skill;
        if(diferencia >= 30)
        {
            Console.WriteLine("Gano " + superheroe1.Nombre + " por una amplia diferencia");
        }
        else if(diferencia > 9)
        {
            Console.WriteLine("Gano " + superheroe1.Nombre + ". ¡Fue muy parejo!");
        }
        else 
        Console.WriteLine("Gano " + superheroe1.Nombre + ". ¡No le sobro nada!");
    }
    else if(superheroe2.Skill > superheroe1.Skill)
    {
        diferencia = superheroe2.Skill - superheroe1.Skill;
        if(diferencia >= 30)
        {
            Console.WriteLine("Gano " + superheroe2.Nombre + " por una amplia diferencia");
        }
        else if(diferencia > 9)
        {
            Console.WriteLine("Gano " + superheroe2.Nombre + ". ¡Fue muy parejo!");
        }
        else 
        Console.WriteLine("Gano " + superheroe2.Nombre + ". ¡No le sobro nada!");
    }
    else
    Console.WriteLine("¡Hubo un empate!");
}
else 
Console.WriteLine("No se crearon ambos superheroes");
    break;
}
}while(opcion != 4);

static double IngresarNumero(string mensaje)
{
    double r;
    do{
    Console.WriteLine(mensaje);
    r = int.Parse(Console.ReadLine());
    }while(r < 0);
    return r;
}
static string IngresarTexto(string mensaje)
{
    string r;
    do{
    Console.WriteLine(mensaje);
    r = Console.ReadLine();
    }while(r == "");
    return r;
}
static Superheroe ObtenerSuperheroe()
{
    Superheroe superheroe = new Superheroe();

    superheroe.Nombre = IngresarTexto("Ingrese el nombre del superheroe");
    superheroe.Ciudad = IngresarTexto("Ingrese la ciudad de donde proviene el superheroe");
    superheroe.Peso = IngresarNumero("Ingrese el peso del superheroe (kg)");
    do{
    superheroe.Fuerza = IngresarNumero("Ingrese la fuerza del superheroe (Entre 1 y 100)");
    }while(superheroe.Fuerza < 1 || superheroe.Fuerza > 100);
    do{
    superheroe.Velocidad = IngresarNumero("Ingrese la velocidad del superheroe (Entre 1 y 100)");
    }while(superheroe.Velocidad < 1 || superheroe.Velocidad > 100);
    return superheroe;
}
