using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adherent2_DataLayer
{
    class TypeAdhesionDB
    {
        public TypeAdhesion GetTypeAdhesion(int id)
        {
            string connectionString = Initialisation.InitialiserConnexion();
            TypeAdhesion leTypeAdhesion = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT idTypeAdhesion, libelle, tarif from typeadhesion WHERE idTypeAdhesion = @id; ";

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@id", id);

                //Crée un data reader et exécute la commande
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {

                    //Lit les données 
                    while (dataReader.Read())
                    {

                        int idType = Convert.ToInt32(dataReader["idTypeAdhesion"]);
                        string nom = dataReader["Libelle"].ToString();
                        int tarif = Convert.ToInt32(dataReader["Tarif"]);
                        leTypeAdhesion = new TypeAdhesion(idType, nom, tarif);


                    }
                }
            }


            return leTypeAdhesion;
        }

        
        
        
        //public static List<TypeAdhesion> GetAlltypeAdhesion()
        //public void Save()
        //public void Delete(int id)
    }
}
