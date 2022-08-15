//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   DataCollectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The DataCollection Model
     /// </summary>
    public partial class DataCollectionModel : AutobahnBase, Interfaces.IDataCollection
    {
        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String DataCollectionAcademicSchoolYear { get; set; }

    }
}
