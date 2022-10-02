using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    delegate void PassageEnNegatifDelegate(Compte c);
    abstract class Compte : IBanker, ICustomer
    {
        #region Champs - Variables Membres
        private Personne _titulaire;
        private string _numero;
        private double _solde;

        public event PassageEnNegatifDelegate PassageEnNegatifEvent;
        #endregion
        #region Propriétés + Indexeurs
        public string Numero
        {
            get { return _numero; }
            private set {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException($"Le numéro ne peut contenir : {value}");
                _numero = value; 
            }
        }
        public Personne Titulaire
        {
            get { return _titulaire; }
            private set {
                if (value is null) throw new ArgumentNullException("Le titulaire ne peut être 'null'");
                _titulaire = value; }
        }
        public double Solde
        {
            get { return _solde; }
        }
        #endregion
        #region Constructeur
        public Compte(string numero, Personne titulaire)
        {
            this.Numero = numero;
            this.Titulaire = titulaire;
        }

        public Compte(string numero, Personne titulaire, double solde) :this (numero, titulaire)
        {
            _solde = solde;
        }
        #endregion
        #region Méthodes + Opérateurs
        protected abstract double CalculInteret();
        public void AppliquerInteret()
        {
            _solde += CalculInteret();
        }

        public void Depot(double montant)
        {
            if (montant < 0) throw new ArgumentOutOfRangeException();
            _solde += montant;
        }

        protected void Retrait(double montant, double limite)
        {
            if (montant < 0) throw new ArgumentOutOfRangeException();
            if (Solde + limite < montant) throw new SoldeInsuffisantException();
            //if (Solde + limite < montant) throw new SoldeInsuffisantException(montant,Solde,limite);
            _solde -= montant;
        }

        public virtual void Retrait(double montant)
        {
            this.Retrait(montant, 0);
        }

        protected void ActivatePassageEnNegatif(Compte c)
        {
            PassageEnNegatifEvent?.Invoke(c);
        }

        public static double operator +(Compte left, Compte right)
        {
            /*
            double left_solde = 0, right_solde = 0;
            if (left != null && left.Solde > 0) left_solde = left.Solde;
            if (right !=null && right.Solde > 0) right_solde = right.Solde;
            */

            double left_solde = (left != null && left.Solde > 0) ? left.Solde : 0;
            double right_solde = (right != null && right.Solde > 0) ? right.Solde : 0;
            return left_solde + right_solde;
        }

        public static double operator +(double left, Compte right)
        {
            /*
            double left_solde = 0, right_solde = 0;
            if (left > 0) left_solde = left;
            if (right !=null && right.Solde > 0) right_solde = right.Solde;
            */

            double left_solde = (left > 0) ? left : 0;
            double right_solde = (right != null && right.Solde > 0) ? right.Solde : 0;
            return left_solde + right_solde;
        }
        #endregion
    }
}
