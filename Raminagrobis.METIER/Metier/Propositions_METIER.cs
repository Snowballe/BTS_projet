using Raminagrobis.DAL.DAL;
using Raminagrobis.DAL.Depot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raminagrobis.METIER.Metier
{
    public class Propositions_METIER
    {
        public int Prix { get; set; }
        public int ID_ligne_global { get; set; }
        public int ID_fournisseur { get; set; }
        public int ID_produit { get; set; }

        public int ID { get; set; }

        public Propositions_METIER(int prix) => Prix = prix;
        public Propositions_METIER(int id, int prix) => (ID, Prix) = (id, prix);

        public Propositions_METIER(int id_ligne_global, int id_fournisseur, int prix) => (ID_ligne_global, ID_fournisseur, Prix) = (id_ligne_global, id_fournisseur, prix);
        public Propositions_METIER(int id, int id_ligne_global, int id_fournisseur, int prix) => (ID, ID_ligne_global, ID_fournisseur, Prix) = (id,id_ligne_global, id_fournisseur, prix);
        public Propositions_METIER(int id,int id_produit, int id_ligne_global, int id_fournisseur, int prix) => (ID,ID_produit,ID_ligne_global, ID_fournisseur, Prix) = (id,id_ligne_global, id_fournisseur, prix);

        #region Insert
        public void Insert()
        {
            Propositions_DAL Propositions = new Propositions_DAL(ID_ligne_global, ID_fournisseur, Prix);
            var depotProposition = new PropositionsDepot_DAL();

            depotProposition.Insert(Propositions);
        }
        #endregion

        #region Delete
        public void Delete()
        {
            var depotProposition = new PropositionsDepot_DAL();
            Propositions_DAL prod = new Propositions_DAL(ID, ID_ligne_global, ID_fournisseur, Prix);

            depotProposition.Delete(prod);
        }
        #endregion

        #region Update
        public void Update()
        {
            Propositions_DAL Propositions = new Propositions_DAL(ID_ligne_global, ID_fournisseur, Prix);
            var depotProposition = new PropositionsDepot_DAL();
            depotProposition.Update(Propositions);
        }
        #endregion
    }
}
