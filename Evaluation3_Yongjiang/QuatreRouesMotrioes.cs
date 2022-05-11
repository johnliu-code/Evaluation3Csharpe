using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3_Yongjiang
{
    class QuatreRouesMotrioes : Voiture
    {
        private string memberNom;
        private string memberPrenom;


        public QuatreRouesMotrioes() { }

        public QuatreRouesMotrioes(string marque) { this.marque = marque; }
        public QuatreRouesMotrioes(string marque, string matricule, string prix, double acceleration)
        {
            this.marque = marque;
            this.matricule = matricule;
            this.prix = prix;
            this.acceleration = acceleration;
        }

        public QuatreRouesMotrioes(string marque, string matricule, string prix, double acceleration, string memberNom, string memberPrenom)
        {
            this.marque = marque;
            this.matricule = matricule;
            this.prix = prix;
            this.acceleration = acceleration;
            this.memberNom = memberNom;
            this.memberPrenom = memberPrenom;
        }
    }
}
