//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IDataCollection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IDataCollection Interface
     /// </summary>
    public partial interface IDataCollection : IAutobahnBase
    {
        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        System.String DataCollectionAcademicSchoolYear { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        System.DateTime? DataCollectionCloseDate { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        System.String DataCollectionDescription { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        System.String DataCollectionName { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        System.DateTime? DataCollectionOpenDate { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        System.String DataCollectionSchoolYear { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        Guid? RefDataCollectionStatusId { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        System.String SourceSystemDataCollectionIdentifier { get; set; }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        System.String SourceSystemName { get; set; }

    }
}
