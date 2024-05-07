namespace TP_2_Bis_Superheroes_Rasumoff_Sfintzi;
using System;

class Superheroe
{
    public string Nombre { get; set; }
    public string Ciudad { get; set; }
    public double Peso { get; set; }
    public double Fuerza { get; set; }
    public double Velocidad { get; set; }

    public Superheroe(string nombre, string ciudad, double peso, double fuerza, double velocidad)
    {
        Nombre = nombre;
        Ciudad = ciudad;
        Peso = peso;
        Fuerza = fuerza;
        Velocidad = velocidad;
    }

    public double ObtenerSkill()
    {
        Random rnd = new Random();
        return Velocidad * 0.6 + Fuerza * 0.8 + rnd.Next(1, 11);
    }
}