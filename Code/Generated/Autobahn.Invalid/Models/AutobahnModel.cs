//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The Autobahn Model
     /// </summary>
    public partial class AutobahnModel : AutobahnBase, Interfaces.IAutobahn
    {
        /// <summary>
        /// 
        /// </summary>
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.Data.Entity.Database Database { get; set; }

    }
}
