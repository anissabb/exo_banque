using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Personne
    {

        #region Champs - Variables membres
        private string _nom;
        private string _prenom;


        //private DateTime _dateNaissance;
        #endregion

        #region Propriétés
        public string Nom
        {
            get { return _nom; }
            private set {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException($"Le nom d'une personne ne peut être : '{value}'");
                _nom = value.Trim();
            }
        }

        public string Prenom
        {
            get { return _prenom; }
            private set {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException($"Le prénom d'une personne ne peut être : '{value}'");
                _prenom = value.Trim();
            }
        }

        //public DateTime DateNaissance {
        //    get { return _dateNaissance; }
        //    set { _dateNaissance = value; }
        //}

        public DateTime DateNaissance { get; private set; }
        #endregion

        #region Constructeurs & destructeur
        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        #endregion

        #region Méthodes et opérateurs
        public static bool operator ==(Personne left, Personne right)
        {
            if (left is null && right is null) return true;
            if (left is null || right is null) return false;
            if (left.Nom.ToUpper() == right.Nom.ToUpper() && left.Prenom.ToLower() == right.Prenom.ToLower() && left.DateNaissance == right.DateNaissance) return true;
            return false;
        }

        public static bool operator !=(Personne left, Personne right) {
            return !(left == right);
        }
        #endregion
    }
}
