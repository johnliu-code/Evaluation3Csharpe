using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3_Yongjiang
{
    class Vehicule : IVehicule, IComportement
    {
        protected string marque;
        protected string matricule;
        protected string prix;

        protected double acceleration;
        protected double condureDistance;
        protected double kilometage;
        protected DateTime startime;
        protected DateTime endime;

        public string GetMarque() { return marque; }
        public string GetMatricule() { return matricule; }
        public string GetPrix() { return prix; }
        public double Kilometage { get; set; }
        public double Acceleration() { return acceleration; }


        public Vehicule() { }
        public Vehicule(string marque) { this.marque = marque; }
        public Vehicule(string marque, string matricule, string prix, double acceleration)
        {
            this.marque = marque;
            this.matricule = matricule;
            this.prix = prix;
            this.acceleration = acceleration;
        }


        public double Accelerer(double vitesse)
        {
            acceleration = vitesse;
            Console.WriteLine($"La Vitesse est {acceleration}km/h maintenent");
            return acceleration;
        }

        public DateTime Arreter(DateTime _endtime)
        {
            // endime = DateTime.Now;               //This is the normal way
            endime = _endtime;                      //This is for testing
            Console.WriteLine($"Arreter a {endime}");
            return endime;
        }

        public DateTime Demarrer(DateTime _startime)
        {
            // startime = DateTime.Now;             //This is the normal way
            startime = _startime;
            Console.WriteLine($"Commence a {startime}");
            return startime;
        }

        public double Condure(DateTime startime, DateTime endime, double _acceleration)
        {
            double timedeCondure = (endime - startime).TotalHours;
            condureDistance = _acceleration * timedeCondure;
            return condureDistance;
        }

        public double GetKilometage(double _condureDistance)
        {
            Kilometage += _condureDistance;
            return kilometage;
        }

    }
}
