using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Courant : Compte
    {
        #region Variables membres - Champs
        private double _ligneDeCredit;

        #endregion

        #region Propriétés
        public double LigneDeCredit {
            get { return _ligneDeCredit; }
            private set {
                if (value < 0 || value < -Solde) throw new InvalidOperationException();
                _ligneDeCredit = value; 
            }
        }
        #endregion
        #region Constructeurs + Destructeur
        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }
        public Courant(string numero, Personne titulaire, double ligneDeCredit) : base(numero, titulaire)
        {
            this.LigneDeCredit = ligneDeCredit;
        }
        public Courant(string numero, Personne titulaire, double ligneDeCredit, double solde) : base(numero, titulaire, solde)
        {
            this.LigneDeCredit = ligneDeCredit;
        }
        #endregion

        #region Méthodes + opérateurs
        public override void Retrait(double montant) {
            double ancienSolde = this.Solde;
            base.Retrait(montant, LigneDeCredit);
            if (ancienSolde >= 0 && this.Solde < 0) ActivatePassageEnNegatif(this);
        }

        protected override double CalculInteret()
        {
            if (Solde >= 0) return Solde * 0.03;
            return Solde * 0.0975;
        }


        #endregion
    }
}
