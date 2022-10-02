using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Epargne : Compte
    {
        #region Variables membres - Champs
        #endregion
        #region Propriétés + Indexeur
        public DateTime DateDernierRetrait { get; private set; }
        #endregion
        #region Constructeur
        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        }

        #endregion
        #region Méthodes + Opérateurs
        public override void Retrait(double montant) {
            double oldSolde = Solde;
            base.Retrait(montant);
            if(oldSolde > Solde) DateDernierRetrait = DateTime.Now;
        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }
        #endregion
    }
}
