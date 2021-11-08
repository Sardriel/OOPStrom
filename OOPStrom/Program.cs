using System.Linq;
using System;

namespace OOPStrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojuhelnik trojuhelnikJedna = new Trojuhelnik(15, 15, 25, "zelená");
            Trojuhelnik trojuhelnikDva = new Trojuhelnik(15, 15, 25, "zelená");
            Trojuhelnik trojuhelnikTri = new Trojuhelnik(15, 15, 25, "zelená");
            Trojuhelnik trojuhelnikCtyri = new Trojuhelnik(15, 15, 25, "zelená");
            Obdelnik obdelnik = new Obdelnik(3, 26, "hnědá");
            double obsahStromu = trojuhelnikJedna.VypocitejObsahTrojuhelniku() + trojuhelnikDva.VypocitejObsahTrojuhelniku() + trojuhelnikTri.VypocitejObsahTrojuhelniku() + trojuhelnikCtyri.VypocitejObsahTrojuhelniku() + obdelnik.VypocitejObsahObdelniku();
            Console.WriteLine("Obsah stromu je {0} cm^2", obsahStromu);
            Console.ReadKey();
        }
    }
}
