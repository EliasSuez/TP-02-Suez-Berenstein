using System.Runtime.Intrinsics.Arm;

class Superheroe
{
    public string Nombre {get; set;}
    public string Ciudad {get; set;}
    public double Peso{get; set;}
    public double Fuerza{get; set;}
    public double Velocidad {get; set;}
    public double Skill {get; set;}
    public Superheroe()
    {
        Nombre = "";
        Ciudad = "";
        Peso = 0;
        Velocidad = 0;
        Fuerza = 0;
    }
    public Superheroe(string nombre, string ciudad, double peso, double fuerza, double velocidad)
    {
        Nombre = nombre;
        Ciudad = ciudad;
        Peso = peso;
        Fuerza = fuerza; 
        Velocidad = velocidad;
        Skill = ObtenerSkill(Fuerza, Velocidad);
    }
    static public double ObtenerSkill(double Fuerza, double Velocidad)
    {
    double skill;
    Random PuntosExtra = new Random();
    PuntosExtra.Next(1, 11);
    skill = (Velocidad * 0.6) + (Fuerza * 0.8) + PuntosExtra.NextDouble();
    return skill;
    }
}