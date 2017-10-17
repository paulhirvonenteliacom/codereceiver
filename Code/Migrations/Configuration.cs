namespace Code.Migrations
{
    using Code.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Code.App_Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Code.App_Data.Context";
        }

        protected override void Seed(Code.App_Data.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.PersonInformations.AddOrUpdate(
                p => p.Id, new PersonInformation
                {
                    Id = 1,
                    PFirstName = "Sten",
                    PLastName = "Bergman",
                    PStreetAddress = "Hamngatan 52",
                    PPostalCode = "156 64",
                    PCity = "Stockholm",
                    PPersonalNumber = "20020325-3621",
                    PPhoneNumberHome = "08-562 2381",
                    PPhoneNumberWork = "08-410 1252",
                    PPhoneNumberMobile = "073-815 5243",
                    PEmail = "sten.bergman@telia.com",
                    SFirstName = "Annika",
                    SLastName = "Liljegren",
                    SStreetAddress = "Danmarksgatan 10",
                    SPostalCode = "166 80",
                    SCity = "Stockholm",
                    SOrganisationNumber = "550819-2468",
                    SPhoneNumber = "08-332 4455",
                    SEmail = "annika.liljegren@logoped.com"
                });

            context.SaveChanges();
        }
    }
}
