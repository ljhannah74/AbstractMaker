using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMaker.Model
{
	public class BusinessAPICalls
	{
		public TitleAbstract GetAbstractByID(int titleAbstractID)
		{
			AbstractMakerContext ctx = new AbstractMakerContext();
			TitleAbstract titleAbstract = ctx.TitleAbstracts
				.Include(t => t.Client)
				.Include(t => t.Property)
				.Include(t => t.ProductType)
				.FirstOrDefault(t => t.TitleAbstractID == titleAbstractID);

            return titleAbstract;
		}

		public void SaveTitleAbstract(TitleAbstract titleAbstract)
		{
			AbstractMakerContext ctx = new AbstractMakerContext();
			ctx.TitleAbstracts.AddOrUpdate<TitleAbstract>(titleAbstract);
			ctx.SaveChanges();
		}

		public List<TitleAbstract> GetAllAbstracts()
		{
			AbstractMakerContext ctx = new AbstractMakerContext();
			List<TitleAbstract> titleAbstracts = ctx.TitleAbstracts
				.Include(t => t.Client)
				.Include(t => t.Property)
				.Include(t => t.ProductType)
				.ToList();
			
			return titleAbstracts;
		}

		public List<ProductType> GetAllProductTypes()
		{
			AbstractMakerContext ctx = new AbstractMakerContext();
			List<ProductType> productTypes = ctx.ProductTypes.ToList();
			return productTypes;
        }

		public List<Client> GetAllClients()
		{
			AbstractMakerContext ctx = new AbstractMakerContext();
			List<Client> clients = ctx.Clients.ToList();
			return clients;
        }

		public List<Deed> GetDeedsForAbstract(int titleAbstractID)
		{
			AbstractMakerContext ctx = new AbstractMakerContext();
			List<Deed> deeds = ctx.Deeds
				.Where(d => d.TitleAbstractID == titleAbstractID)
				.ToList();
			return deeds;
        }

		public void SaveDeedsForAbstract(int titleAbstractID, List<Deed> deeds)
		{
            using (var ctx = new AbstractMakerContext())
            {
                // Remove existing deeds for this abstract
                var existingDeeds = ctx.Deeds.Where(d => d.TitleAbstractID == titleAbstractID).ToList();
                if (existingDeeds.Any())
                {
                    ctx.Deeds.RemoveRange(existingDeeds);
                }

                // Add new deeds, ensuring TitleAbstractID is set
                foreach (var deed in deeds)
                {
                    deed.TitleAbstractID = titleAbstractID;
                    ctx.Deeds.Add(deed);
                }

                ctx.SaveChanges();
            }
        }

		public Legal_Description GetAbstractLegalDescription(int titleAbstractID)
		{
			AbstractMakerContext ctx = new AbstractMakerContext();
			Legal_Description legalDescription = ctx.Legal_Descriptions.Find(titleAbstractID);
            return legalDescription;
		}

		public void SaveAbstractLegalDescription(Legal_Description legal_Description, int titleAbstractID)
		{
			AbstractMakerContext ctx = new AbstractMakerContext();
			legal_Description.TitleAbstractID = titleAbstractID;
			ctx.Legal_Descriptions.AddOrUpdate<Legal_Description>(legal_Description);
			ctx.SaveChanges();
        }
    }
}
