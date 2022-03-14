//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Raminagrobis.METIER.Services;
//using Raminagrobis.DTO.DTO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Raminagrobis.API.Controllers
//{
//	[ApiController]
//	[Route("[controller]")]
//	public class Enchere_Controller : ControllerBase
//	{
//		private Fournisseurs_Services fournisseurService;
//		private Paniers_Services panierService;

//		public Enchere_Controller(Fournisseurs_Services fournisseur_srv, Paniers_Services panier_srv)
//		{
//			fournisseurService = fournisseur_srv;
//			panierService = panier_srv;
//		}

//		#region GetAllPaniers
//		[HttpGet]
//		public IEnumerable<Paniers_DTO> GetAllPaniers()
//		{
//			return panierService.GetAll().Select(item => new Paniers_DTO()
//			{
//				ID = item.ID,
//				Libelle = item.Libelle,
//			}); ;
//		}
//		#endregion

//		#region GetPanierByID
//		[HttpGet("{id}")]
//		public Paniers_DTO GetPanierByID(int id)
//		{
//			var item = panierService.GetByID(id);
//			return new Paniers_DTO()
//			{
//				ID = item.ID,
//				Libelle = item.Libelle,
//			};
//		}
//		#endregion

//		#region UpdatePanier
//		[HttpPut("{id}")]
//		public void UpdatePanier(int id, [FromBody] Paniers_DTO item)
//		{
//			panierService.Update(id, item);
//		}
//		#endregion

//		#region GetAllFournisseurs
//		[HttpGet]
//		public IEnumerable<Fournisseur_DTO> GetAllFournisseurs()
//		{
//			return fournisseurService.GetAll().Select(item => new Fournisseur_DTO()
//			{
//				ID = item.ID,
//				Societe = item.Societe,
//				Civilite = item.Civilite,
//				Nom = item.Nom,
//				Prenom = item.Prenom,
//				Email = item.Email,
//				Adresse = item.Adresse,
//				Actif = item.Actif,
//			});
//		}
//		#endregion

//		#region GetFournisseurByID
//		[HttpGet("{id}")]
//		public Fournisseur_DTO GetFournisseurByID(int id)
//		{
//			var item = fournisseurService.GetByID(id);
//			return new Fournisseur_DTO()
//			{
//				ID = item.ID,
//				Societe = item.Societe,
//				Civilite = item.Civilite,
//				Nom = item.Nom,
//				Prenom = item.Prenom,
//				Email = item.Email,
//				Adresse = item.Adresse,
//				Actif = item.Actif,
//			};
//		}
//		#endregion
//	}
//}
