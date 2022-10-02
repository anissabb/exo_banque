using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class SoldeInsuffisantException : Exception
    {
        public double SoldeActuel { get; private set; }
        public double MontantDemande { get; private set; }
        public double Limite { get; private set; }
        public SoldeInsuffisantException() : base("Votre solde est insuffisant...")
        {

        }
        public SoldeInsuffisantException(string message) : base(message)
        {

        }
        public SoldeInsuffisantException(double montant, double solde, double limite) : this()
        {
            SoldeActuel = solde;
            MontantDemande = montant;
            Limite = limite;
        }
    }
}
