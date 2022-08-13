//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   DataCollectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
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

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.DateTime? DataCollectionCloseDate { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String DataCollectionDescription { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String DataCollectionName { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.DateTime? DataCollectionOpenDate { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String DataCollectionSchoolYear { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public Guid? RefDataCollectionStatusId { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String SourceSystemDataCollectionIdentifier { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String SourceSystemName { get; set; }

    }
}
