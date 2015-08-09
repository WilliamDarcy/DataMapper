using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adherent2_DataLayer
{
    //Pour cette classe on utilise les propriétés get/set version Microsoft.

    public class TypeAdhesion
    {
        public int idTypeAdhesion { get; set; }
        public string Libelle { get; set; }
        public int Tarif { get; set; }

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="leType">type d'ahésion</param>
        /// <param name="leLibelle">le libellé</param>
        /// <param name="leTarif">le tarif</param>
        public TypeAdhesion(int leType, string leLibelle, int leTarif)
        {
            idTypeAdhesion = leType;
            Libelle = leLibelle;
            Tarif = leTarif;
        }

      


    }
}
