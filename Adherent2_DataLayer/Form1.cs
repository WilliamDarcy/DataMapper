using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adherent2_DataLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdherentDB adhDB = new AdherentDB();
            List<Adherent> lesAdherents = adhDB.GetAllAdherent();

            foreach (var item in lesAdherents)
            {
             
                ListViewItem listItem = new ListViewItem(item.GetNom());
                listItem.SubItems.Add(item.GetPrenom());
                listItem.SubItems.Add(item.GetVille());
                listItem.SubItems.Add(item.GetCodePostal());
                listItem.SubItems.Add(item.GetDateDeNaissance().ToShortDateString());
                listItem.SubItems.Add(item.GetTypeAdherent().Libelle);
           

                listViewAdherents.Items.Add(listItem);

            }

            TypeAdhesionDB typeDB = new TypeAdhesionDB();
            TypeAdhesion t = typeDB.GetTypeAdhesion(1);
            Adherent a = new Adherent("tom", "tim", "445", "Paris", new DateTime(1980, 5, 6), t);
            adhDB.Save(a);
            Adherent a1 = adhDB.GetAdherent(14);
            a1.SetVille("NY");
            adhDB.Save(a1);

        }
    }
}
