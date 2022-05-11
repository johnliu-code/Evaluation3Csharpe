using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3_Yongjiang
{
    class Voiture : Vehicule
    {
        private string nomModele;
        private DateTime dateInspection;


        public Voiture() { }
        public Voiture(string marque) { this.marque = marque;  }

        public Voiture(string marque, string matricule, string prix, double acceleration)
        {
            this.marque = marque;
            this.matricule = matricule;
            this.prix = prix;
            this.acceleration = acceleration;
        }

        public Voiture(string marque, string matricule, string prix, double acceleration, string nomModele, DateTime dateInspection)
        {
            this.marque = marque;
            this.matricule = matricule;
            this.prix = prix;
            this.acceleration = acceleration;
            this.nomModele = nomModele;
            this.dateInspection = dateInspection;
        }

    }
}
