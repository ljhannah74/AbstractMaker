namespace AbstractMaker.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AbstractMaker.Model.AbstractMakerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AbstractMaker.Model.AbstractMakerContext context)
        {
        //    context.Clients.Add(new Client { ClientName = "First Client" });
        //    context.TitleAbstracts.Add(new TitleAbstract { OrderNo = "EMD21-12345", ClientRefNo = "21NNTMD65536", SearchDate = DateTime.Parse("10/6/2021"), EffectiveDate = DateTime.Parse("9/6/2021") });
        }
    }
}
