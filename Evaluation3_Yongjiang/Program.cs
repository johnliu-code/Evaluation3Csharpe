using System;
using System.Collections.Generic;

namespace Evaluation3_Yongjiang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluation3_Yongjiang Liu!");

            DateTime starttime;
            DateTime endtime;
            double speed;
            double condureDistance;
            double totalnumberVehicule;

            List<Vehicule> listVehicules = new List<Vehicule>();


            //Instance de voiture
            Vehicule q1 = new QuatreRouesMotrioes("Marque A");
            starttime = q1.Demarrer(new DateTime(2022, 05, 10, 10, 30, 0));
            speed = q1.Accelerer(150);
            endtime = q1.Arreter(new DateTime(2022, 05, 10, 12, 30, 0));

            condureDistance = q1.Condure(starttime, endtime, speed);
            q1.GetKilometage(condureDistance);


            Console.WriteLine($"Condure KM:  {condureDistance}");
            Console.WriteLine($"Total KM:  {q1.Kilometage}");
            Console.WriteLine($"Marque:  {q1.GetMarque()}");
            listVehicules.Add(q1);


            Console.ReadLine();

            //Instance de velo de ville
            Vehicule veloVille1 = new VeloDeVille("Marque B");

            starttime = veloVille1.Demarrer(new DateTime(2022, 05, 10, 10, 30, 0));
            speed = veloVille1.Accelerer(100);
            endtime = veloVille1.Arreter(new DateTime(2022, 05, 10, 12, 30, 0));

            condureDistance = veloVille1.Condure(starttime, endtime, speed);
            veloVille1.GetKilometage(condureDistance);

            starttime = veloVille1.Demarrer(new DateTime(2022, 05, 10, 14, 30, 0));
            speed = veloVille1.Accelerer(120);
            endtime = veloVille1.Arreter(new DateTime(2022, 05, 10, 16, 30, 0));
            condureDistance = veloVille1.Condure(starttime, endtime, speed);

            veloVille1.GetKilometage(condureDistance);

            Console.WriteLine($"Condure KM:  {condureDistance}");
            Console.WriteLine($"Total KM:  {veloVille1.Kilometage}");
            Console.WriteLine($"Marque:  {veloVille1.GetMarque()}");

            listVehicules.Add(veloVille1);

            Console.ReadLine();

            //Instance de velo Tout Terrain
            Vehicule velot1 = new VeloToutTerrain("Marque C");

            starttime = velot1.Demarrer(new DateTime(2022, 05, 10, 10, 30, 0));
            speed = velot1.Accelerer(50);
            endtime = velot1.Arreter(new DateTime(2022, 05, 10, 12, 30, 0));

            condureDistance = velot1.Condure(starttime, endtime, speed);
            velot1.GetKilometage(condureDistance);

            Console.WriteLine($"Distance de condure:  {condureDistance}");
            Console.WriteLine($"Total KM:  {velot1.Kilometage}");
            Console.WriteLine($"Marque :  {velot1.GetMarque()}");

            listVehicules.Add(velot1);

            Console.ReadLine();



            // DISPLAY LIST
            totalnumberVehicule = listVehicules.Count;
            Console.WriteLine($"Total number of vehicule : {totalnumberVehicule}");

            foreach(var vehicule in listVehicules)
            {
                Console.WriteLine($"Vehicule Marque: {vehicule.GetMarque()}; Vehicule Acceleration: {vehicule.Acceleration()}");
            }

        }
    }
}
