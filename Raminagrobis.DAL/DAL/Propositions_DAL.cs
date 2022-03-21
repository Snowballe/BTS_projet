using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raminagrobis.DAL.DAL
{
    public class Propositions_DAL
    {
        public int Prix { get; set; }
        public int ID_ligne_global { get; set; }
        public int ID_fournisseur { get; set; }
        public int ID_produit { get; set; }

        public int ID { get; set; }

        public Propositions_DAL(int prix) => Prix = prix;
        public Propositions_DAL(int id, int prix) => (ID, Prix) = (id,prix);

        public Propositions_DAL(int id_ligne_global, int id_fournisseur, int prix) => (ID_ligne_global, ID_fournisseur, Prix) = (id_ligne_global, id_fournisseur, prix);
        public Propositions_DAL(int id, int id_ligne_global, int id_fournisseur, int prix) => (ID, ID_ligne_global, ID_fournisseur, Prix) = (id,id_ligne_global, id_fournisseur, prix);
        public Propositions_DAL(int id, int id_produit,int id_ligne_global, int id_fournisseur, int prix) => (ID,ID_produit ,ID_ligne_global, ID_fournisseur, Prix) = (id, id_produit, id_ligne_global, id_fournisseur, prix);
    }
}