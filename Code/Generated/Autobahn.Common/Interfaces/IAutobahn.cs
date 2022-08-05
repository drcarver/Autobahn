//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IAutobahn.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IAutobahn
     /// </summary>
    public partial interface IAutobahn : IAutobahnBase
    {
        /// <summary>
        /// Defines the Autobahn.Database non nullable property
        /// </summary>
        System.Data.Entity.Database Database { get; set; }

        /// <summary>
        /// Defines the Autobahn.ChangeTracker non nullable property
        /// </summary>
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; set; }

        /// <summary>
        /// Defines the Autobahn.Configuration non nullable property
        /// </summary>
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; set; }

    }
}
