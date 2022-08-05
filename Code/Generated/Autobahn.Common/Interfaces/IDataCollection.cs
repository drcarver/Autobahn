//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IDataCollection.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IDataCollection
     /// </summary>
    public partial interface IDataCollection : IAutobahnBase
    {
        /// <summary>
        /// Defines the DataCollection.DataCollectionAcademicSchoolYear non nullable property
        /// </summary>
        System.String DataCollectionAcademicSchoolYear { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionCloseDate nullable property
        /// </summary>
        System.DateTime? DataCollectionCloseDate { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionDescription non nullable property
        /// </summary>
        System.String DataCollectionDescription { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionName non nullable property
        /// </summary>
        System.String DataCollectionName { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionSchoolYear non nullable property
        /// </summary>
        System.String DataCollectionSchoolYear { get; set; }

        /// <summary>
        /// Defines the DataCollection.SourceSystemDataCollectionIdentifier non nullable property
        /// </summary>
        System.String SourceSystemDataCollectionIdentifier { get; set; }

        /// <summary>
        /// Defines the DataCollection.SourceSystemName non nullable property
        /// </summary>
        System.String SourceSystemName { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionOpenDate nullable property
        /// </summary>
        System.DateTime? DataCollectionOpenDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDataCollectionStatus"/> model
        /// </summary>
        Guid? RefDataCollectionStatusId { get; set; }

    }
}
