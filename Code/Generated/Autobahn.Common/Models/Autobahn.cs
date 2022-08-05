//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Autobahn.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Autobahn
     /// </summary>
    public partial class Autobahn : AutobahnBase, Interfaces.IAutobahn
    {
        /// <summary>
        /// Defines the Autobahn.Database non nullable property
        /// </summary>
        public System.Data.Entity.Database Database { get; set; }

        /// <summary>
        /// Defines the Autobahn.ChangeTracker non nullable property
        /// </summary>
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; set; }

        /// <summary>
        /// Defines the Autobahn.Configuration non nullable property
        /// </summary>
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; set; }

    }
}
