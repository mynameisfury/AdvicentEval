namespace AdvicentEval.Migrations
{
    using AdvicentEval.Models;
    using CsvHelper;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<AdvicentEval.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AdvicentEval.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "AdvicentEval.college_costs.csv";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    CsvReader csvReader = new CsvReader(reader);
                    csvReader.Configuration.MissingFieldFound = null;
                    csvReader.Configuration.HeaderValidated = null;
                    var colleges = csvReader.GetRecords<College>().ToArray();
                    context.Colleges.AddOrUpdate(c => c.CollegeName, colleges);
                }
            }
            
        }
    }
}
