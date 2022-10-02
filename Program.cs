using System;

namespace I3WAD22_OO_Exo_banque
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tests avant opérateurs
            /*
                Personne titulaire1 = new Personne();
                titulaire1.Nom = "Legrain";
                titulaire1.Prenom = "Samuel";
                titulaire1.DateNaissance = new DateTime(1987,9,27);

                Personne titulaire2 = new Personne();
                titulaire2.Nom = "Willis";
                titulaire2.Prenom = "Bruce";
                titulaire2.DateNaissance = new DateTime(1987, 9, 27);

                Courant c1_sam = new Courant();
                c1_sam.Titulaire = titulaire1;
                c1_sam.Numero = "BE55 3820 1900 7412";
                c1_sam.LigneDeCredit = 200;


                Console.WriteLine($"Le compte bancaire de {c1_sam.Titulaire.Nom} {c1_sam.Titulaire.Prenom}, né le {c1_sam.Titulaire.DateNaissance.ToShortDateString()}, ayant pour numéro {c1_sam.Numero}, a pour solde {c1_sam.Solde}. Il peut atteindre {c1_sam.LigneDeCredit} en dessous de 0.");

                c1_sam.Depot(1_000_000);

                Console.WriteLine($"Le compte bancaire de {c1_sam.Titulaire.Nom} {c1_sam.Titulaire.Prenom}, né le {c1_sam.Titulaire.DateNaissance.ToShortDateString()}, ayant pour numéro {c1_sam.Numero}, a pour solde {c1_sam.Solde}. Il peut atteindre {c1_sam.LigneDeCredit} en dessous de 0.");

                c1_sam.Retrait(500_000);

                Console.WriteLine($"Le compte bancaire de {c1_sam.Titulaire.Nom} {c1_sam.Titulaire.Prenom}, né le {c1_sam.Titulaire.DateNaissance.ToShortDateString()}, ayant pour numéro {c1_sam.Numero}, a pour solde {c1_sam.Solde}. Il peut atteindre {c1_sam.LigneDeCredit} en dessous de 0.");

                Courant c1_bruce = new Courant();
                c1_bruce.Titulaire = titulaire2;
                c1_bruce.Numero = "BE00 0000 0000 0001";

                Console.WriteLine($"Le compte bancaire de {c1_bruce.Titulaire.Nom} {c1_bruce.Titulaire.Prenom}, né le {c1_bruce.Titulaire.DateNaissance}, ayant pour numéro {c1_bruce.Numero}, a pour solde {c1_bruce.Solde}. Il peut atteindre {c1_bruce.LigneDeCredit} en dessous de 0.");

                c1_bruce.Retrait(1);
                Console.WriteLine($"Le compte bancaire de {c1_bruce.Titulaire.Nom} {c1_bruce.Titulaire.Prenom}, né le {c1_bruce.Titulaire.DateNaissance}, ayant pour numéro {c1_bruce.Numero}, a pour solde {c1_bruce.Solde}. Il peut atteindre {c1_bruce.LigneDeCredit} en dessous de 0.");

                c1_bruce.LigneDeCredit = 500;

                c1_bruce.Retrait(1);
                Console.WriteLine($"Le compte bancaire de {c1_bruce.Titulaire.Nom} {c1_bruce.Titulaire.Prenom}, né le {c1_bruce.Titulaire.DateNaissance}, ayant pour numéro {c1_bruce.Numero}, a pour solde {c1_bruce.Solde}. Il peut atteindre {c1_bruce.LigneDeCredit} en dessous de 0.");

                c1_bruce.LigneDeCredit = 1;
                Console.WriteLine($"Le compte bancaire de {c1_bruce.Titulaire.Nom} {c1_bruce.Titulaire.Prenom}, né le {c1_bruce.Titulaire.DateNaissance}, ayant pour numéro {c1_bruce.Numero}, a pour solde {c1_bruce.Solde}. Il peut atteindre {c1_bruce.LigneDeCredit} en dessous de 0.");

                Banque abb = new Banque();
                abb.Nom = "Aux bons bénéfices";
                abb.Ajouter(c1_sam);
                abb.Ajouter(c1_bruce);

                Courant compte_client = (Courant)abb["BE00 0000 0000 0001"];
                if (compte_client != null)
                {
                    compte_client.Depot(5000);
                    Console.WriteLine($"Le compte bancaire de {compte_client.Titulaire.Nom} {compte_client.Titulaire.Prenom}, né le {compte_client.Titulaire.DateNaissance}, ayant pour numéro {compte_client.Numero}, a pour solde {compte_client.Solde}. Il peut atteindre {compte_client.LigneDeCredit} en dessous de 0.");
                }
                Console.WriteLine($"Le compte bancaire de {c1_bruce.Titulaire.Nom} {c1_bruce.Titulaire.Prenom}, né le {c1_bruce.Titulaire.DateNaissance}, ayant pour numéro {c1_bruce.Numero}, a pour solde {c1_bruce.Solde}. Il peut atteindre {c1_bruce.LigneDeCredit} en dessous de 0.");

                abb.Supprimer(c1_bruce.Numero);

                compte_client = (Courant)abb["BE00 0000 0000 0001"];
                if (compte_client != null)
                {
                    compte_client.Depot(5000);
                    Console.WriteLine($"Le compte bancaire de {compte_client.Titulaire.Nom} {compte_client.Titulaire.Prenom}, né le {compte_client.Titulaire.DateNaissance}, ayant pour numéro {compte_client.Numero}, a pour solde {compte_client.Solde}. Il peut atteindre {compte_client.LigneDeCredit} en dessous de 0.");
                }

                Console.WriteLine($"Le compte bancaire de {c1_bruce.Titulaire.Nom} {c1_bruce.Titulaire.Prenom}, né le {c1_bruce.Titulaire.DateNaissance}, ayant pour numéro {c1_bruce.Numero}, a pour solde {c1_bruce.Solde}. Il peut atteindre {c1_bruce.LigneDeCredit} en dessous de 0.");

                compte_client = (Courant)abb[c1_sam.Numero];
                c1_sam = null;
                if (compte_client != null)
                {
                    compte_client.Depot(5000);
                    Console.WriteLine($"Le compte bancaire de {compte_client.Titulaire.Nom} {compte_client.Titulaire.Prenom}, né le {compte_client.Titulaire.DateNaissance}, ayant pour numéro {compte_client.Numero}, a pour solde {compte_client.Solde}. Il peut atteindre {compte_client.LigneDeCredit} en dessous de 0.");
                }
                c1_sam = compte_client;
                */
            #endregion

            #region Avant Constructeurs
            //Personne titulaire1 = new Personne();
            //titulaire1.Nom = "Legrain";
            //titulaire1.Prenom = "Samuel";
            //titulaire1.DateNaissance = new DateTime(1987, 9, 27);

            //Personne titulaire2 = new Personne();
            //titulaire2.Nom = "Willis";
            //titulaire2.Prenom = "Bruce";
            //titulaire2.DateNaissance = new DateTime(1987, 9, 27);

            //Courant c1_sam = new Courant();
            //c1_sam.Titulaire = titulaire1;
            //c1_sam.Numero = "BE55 3820 1900 7412";
            //c1_sam.LigneDeCredit = 200;
            //c1_sam.Depot(50_000);

            //Courant c1_bruce = new Courant();
            //c1_bruce.Titulaire = titulaire2;
            //c1_bruce.Numero = "BE00 0000 0000 0001";
            //c1_bruce.LigneDeCredit = 500;
            //c1_bruce.Depot(50);

            //Courant c2_bruce = new Courant();
            //c2_bruce.Titulaire = titulaire2;
            //c2_bruce.Numero = "BE00 0000 0000 0002";
            //c2_bruce.LigneDeCredit = 50;
            //c2_bruce.Retrait(50);

            //Courant c3_bruce = new Courant();
            //c3_bruce.Titulaire = titulaire2;
            //c3_bruce.Numero = "BE00 0000 0000 0003";
            //c3_bruce.LigneDeCredit = 5;
            //c3_bruce.Depot(500);

            //Courant c4_bruce = new Courant();
            //c4_bruce.Titulaire = titulaire2;
            //c4_bruce.Numero = "BE00 0000 0000 0004";
            //c4_bruce.LigneDeCredit = 0;
            //c4_bruce.Depot(5);
            
            //Epargne e1_sam = new Epargne();
            //e1_sam.Titulaire = titulaire1;
            //e1_sam.Numero = "BE10 0000 0000 0001";
            //e1_sam.Depot(5);
            #endregion

            Personne titulaire1 = new Personne("Legrain", "Samuel", new DateTime(1987, 9, 27));
            Personne titulaire2 = new Personne("Willis", "Bruce", new DateTime(1987, 9, 27));
            Courant c1_sam = new Courant("BE55 3820 1900 7412", titulaire1, 200, 50_000);
            Courant c1_bruce = new Courant("BE00 0000 0000 0001", titulaire2, 500, 50);
            Courant c2_bruce = new Courant("BE00 0000 0000 0002", titulaire2, 50, -50);
            Courant c3_bruce = new Courant("BE00 0000 0000 0003", titulaire2, 5, 500);
            Courant c4_bruce = new Courant("BE00 0000 0000 0004", titulaire2, 0, 5);


            Epargne e1_sam = new Epargne("BE10 0000 0000 0001", titulaire1,5);

            //Console.WriteLine($"Le compte épargne {e1_sam.Numero}, a pour solde : {e1_sam.Solde}, avec pour dernier retrait {e1_sam.DateDernierRetrait}");
            //e1_sam.Retrait(50);
            Console.WriteLine($"Le compte épargne {e1_sam.Numero}, a pour solde : {e1_sam.Solde}, avec pour dernier retrait {e1_sam.DateDernierRetrait}");
            e1_sam.Retrait(0.5);
            Console.WriteLine($"Le compte épargne {e1_sam.Numero}, a pour solde : {e1_sam.Solde}, avec pour dernier retrait {e1_sam.DateDernierRetrait}");

            Banque abb = new Banque("Aux bons bénéfices");
            abb.Ajouter(c1_sam);
            abb.Ajouter(c1_bruce);
            abb.Ajouter(c2_bruce);
            abb.Ajouter(c3_bruce);
            abb.Ajouter(c4_bruce);
            abb.Ajouter(e1_sam);

            //Console.WriteLine($"Les avoirs de {titulaire1.Nom} {titulaire1.Prenom} sont de {abb.AvoirsDesComptes(titulaire1)} Euro!");
            //Console.WriteLine($"Les avoirs de {titulaire2.Nom} {titulaire2.Prenom} sont de {abb.AvoirsDesComptes(titulaire2)} Euro!");

            /*Console.WriteLine("Veuillez indiquer le nom :");
            string tit_nom = Console.ReadLine();

            Console.WriteLine("Veuillez indiquer le prénom :");
            string tit_prenom = Console.ReadLine();

            Console.WriteLine("Veuillez indiquer la date de naissance :");
            DateTime tit_dateNaissance = DateTime.Parse(Console.ReadLine());
            Personne titulaire = new Personne(tit_nom, tit_prenom, tit_dateNaissance);

            Console.WriteLine($"Les avoirs de {titulaire.Nom} {titulaire.Prenom} sont de {abb.AvoirsDesComptes(titulaire)} Euro!");

            c1_sam.AppliquerInteret();
            e1_sam.AppliquerInteret();
            c1_bruce.AppliquerInteret();
            c2_bruce.AppliquerInteret();
            c3_bruce.AppliquerInteret();
            c4_bruce.AppliquerInteret();

            Console.WriteLine($"Les avoirs de {titulaire.Nom} {titulaire.Prenom} sont de {abb.AvoirsDesComptes(titulaire)} Euro!");*/

            ICustomer client_sam = c1_sam;
            Console.WriteLine($"Le client n'a accès qu'aux fonctions de Depot(), Retrait() et son Solde ({client_sam.Solde})");
            client_sam.Depot(500);
            Console.WriteLine($"Le client n'a accès qu'aux fonctions de Depot(), Retrait() et son Solde ({client_sam.Solde})");
            client_sam.Retrait(500);
            Console.WriteLine($"Le client n'a accès qu'aux fonctions de Depot(), Retrait() et son Solde ({client_sam.Solde})");

            IBanker banquier_sam = e1_sam;
            Console.WriteLine($"Le Banquier a accès aux fonctions de Depot(), Retrait() et son Solde ({banquier_sam.Solde}) comme le client...");
            Console.WriteLine($"Mais aussi aux informations du titulaire ({banquier_sam.Titulaire.Nom}) et du Numéro de compte ({banquier_sam.Numero})");
            banquier_sam.AppliquerInteret();
            Console.WriteLine($"Le banquier peut aussi appliquer les intérêts (le solde a changé : {banquier_sam.Solde})");

            try
            {
                Courant c_test = new Courant("Test", titulaire1, 50, 500);
                c_test.Depot(-551);
                Console.WriteLine($"Le compte '{c_test.Numero}' a comme Solde : {c_test.Solde} €.");
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.GetType());
                Console.WriteLine(aoore.Message);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.GetType());
                Console.WriteLine(ioe.Message);
            }
            catch(SoldeInsuffisantException sie)
            {
                Console.WriteLine(sie.GetType());
                Console.WriteLine(sie.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }
            abb.Supprimer(c1_sam.Numero);

            c1_sam.Retrait(c1_sam.Solde + 1);

        }
    }
}
