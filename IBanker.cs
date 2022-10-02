using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3WAD22_OO_Exo_banque
{
    interface IBanker : ICustomer
    {
        Personne Titulaire { get; }
        string Numero { get; }
        void AppliquerInteret();
    }
}
