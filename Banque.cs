using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    class Banque
    {
        private Dictionary<string, Compte> _comptes;
        public string Nom { get; set; }

        public Compte this[string numero]
        {
            get {
                //Compte c = null;
                _comptes.TryGetValue(numero, out Compte c);
                return c;
            }
            /*A éviter: moins clair et plus compliquer qu'une méthode*/
            /*
             * set {
                if (value != null && !_comptes.ContainsKey(numero) && numero == value.Numero) _comptes.Add(numero, value);
            }*/
        }

        public Banque(string nom)
        {
            this.Nom = nom;
            _comptes = new Dictionary<string, Compte>();
        }

        public Banque(string nom, Compte[] comptes) : this(nom)
        {
            foreach (Compte c in comptes)
            {
                this.Ajouter(c);
            }
        }

        public void Ajouter(Compte compte) {
            if (compte != null && !_comptes.ContainsKey(compte.Numero))
            {
                _comptes.Add(compte.Numero, compte);
                compte.PassageEnNegatifEvent += PassageEnNegatifAction;
            }
        }
        public void Supprimer(string numero) {
            if (!string.IsNullOrWhiteSpace(numero) && _comptes.ContainsKey(numero))
            {
                _comptes[numero].PassageEnNegatifEvent -= PassageEnNegatifAction;
                _comptes.Remove(numero);
            }
        }

        public double AvoirsDesComptes(Personne titulaire)
        {
            double somme = 0;
            foreach (KeyValuePair<string, Compte> kvp in _comptes)
            {
                Compte compte = kvp.Value;
                if(titulaire == compte.Titulaire)
                {
                    somme += compte;
                }
            }
            return somme;
        }

        public void PassageEnNegatifAction(Compte c)
        {
            Console.WriteLine($"Le compte {c.Numero} est passé en négatif!");
        }
    }
}
