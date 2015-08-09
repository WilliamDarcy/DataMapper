using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adherent2_DataLayer
{
    public class Adherent
    {
        private int Id;
        private string Nom;
        private string Prenom;
        private string CodePostal;
        private string Ville;
        private DateTime AnneeNaissance;
        private TypeAdhesion TypeAdhesion;


        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="leNom">le nom</param>
        /// <param name="lePrenom">le prénom</param>
        /// <param name="leCodePostal">le code postal</param>
        /// <param name="laVille">la ville</param>
        /// <param name="lAnneeDeNaissance">la date de naissance</param>
        /// <param name="leType">le type de l'adhésion</param>
        public Adherent(string leNom, string lePrenom, string leCodePostal, string laVille, DateTime lAnneeDeNaisance, TypeAdhesion leType)
        {
            Id = -1;
            Nom = leNom;
            Prenom = lePrenom;
            CodePostal = leCodePostal;
            Ville = laVille;
            AnneeNaissance = lAnneeDeNaisance;
            TypeAdhesion = leType;
        }


        /// <summary>
        /// Constructeur avec un id
        /// </summary>
        /// <param name="lId">id de l'adhérent</param>
        /// <param name="leNom">le nom</param>
        /// <param name="lePrenom">le prénom</param>
        /// <param name="leCodePostal">le code postal</param>
        /// <param name="laVille">la ville</param>
        /// <param name="lAnneeDeNaissance">la date de naissance</param>
        /// <param name="leType">le type de l'adhésion</param>
        public Adherent(int id, string leNom, string lePrenom, string leCodePostal, string laVille, DateTime lAnneeDeNaisance, TypeAdhesion leType) :this(leNom, lePrenom, leCodePostal, laVille, lAnneeDeNaisance, leType)
        {
            Id = id;
        }





        /// <summary>
        /// Getter pour l'id
        /// </summary>
        /// <returns>l'id</returns>
        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Getter pour le nom
        /// </summary>
        /// <returns>le nom</returns>
        public string GetNom()
        {
            return Nom;
        }

        /// <summary>
        /// Getter pour le prénom
        /// </summary>
        /// <returns>le nom</returns>
        public string GetPrenom()
        {
            return Prenom;
        }


        /// <summary>
        /// Getter pour  le code postal
        /// </summary>
        /// <returns>le CP de l'adhérent</returns>
        public string GetCodePostal()
        {
            return CodePostal;
        }

        /// <summary>
        /// Getter pour  la ville
        /// </summary>
        /// <returns>la ville de l'adhérent</returns>
        public string GetVille()
        {
            return Ville;
        }

        /// <summary>
        /// Getter pour  la date de naissance
        /// </summary>
        /// <returns>l'année de naissance</returns>
        public DateTime GetDateDeNaissance()
        {
            return AnneeNaissance;
        }

        /// <summary>
        /// Getter pour  le type d'adhesion
        /// </summary>
        /// <returns>le type de l'adhésion</returns>
        public TypeAdhesion GetTypeAdherent()
        {
            return TypeAdhesion;
        }




        /// <summary>
        /// Setter pour l'id
        /// </summary>
        public void SetId(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Setter pour le nom
        /// </summary>
      
        public void SetNom(string nom)
        {
           Nom = nom;
        }

        /// <summary>
        /// Setter pour le prénom
        /// </summary>
        public void SetPrenom(string prenom)
        {
            Prenom = prenom;
        }


        /// <summary>
        /// Setter pour  le code postal
        /// </summary>
        public void SetCodePostal(string codePostal)
        {
            CodePostal = codePostal;
        }

        /// <summary>
        /// setter pour  la ville
        /// </summary>
        public void SetVille(string ville)
        {
            Ville = ville;
        }

        /// <summary>
        /// setter pour  la date de naissance
        /// </summary>
        public void GetDateDeNaissance(DateTime dateNaissance)
        {
            AnneeNaissance = dateNaissance;
        }

        /// <summary>
        /// Setter pour  le type d'adhesion
        /// </summary>
        public void GetTypeAdherent(TypeAdhesion type )
        {
            TypeAdhesion = type;
        }
    }
}
