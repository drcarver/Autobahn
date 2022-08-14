//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IAutobahn.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IAutobahn Interface
     /// </summary>
    public partial interface IAutobahn : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.Data.Entity.Database Database { get; set; }

    }
}
