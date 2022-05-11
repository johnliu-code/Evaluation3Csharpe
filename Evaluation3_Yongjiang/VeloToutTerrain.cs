using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3_Yongjiang
{
    class VeloToutTerrain : Velo
    {
        private DateTime dateVerification;
        private string type;

        public VeloToutTerrain() { }
        public VeloToutTerrain(string marque) { this.marque = marque; }
        public VeloToutTerrain(string marque, string matricule, string prix, double acceleration)
        {
            this.marque = marque;
            this.matricule = matricule;
            this.prix = prix;
            this.acceleration = acceleration;
        }

        public VeloToutTerrain(string marque, string matricule, string prix, double acceleration, DateTime dateVerification, string type)
        {
            this.marque = marque;
            this.matricule = matricule;
            this.prix = prix;
            this.acceleration = acceleration;
        }
    }
}
