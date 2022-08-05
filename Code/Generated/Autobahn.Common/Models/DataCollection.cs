//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   DataCollection.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The DataCollection
     /// </summary>
    public partial class DataCollection : AutobahnBase, Interfaces.IDataCollection
    {
        /// <summary>
        /// Defines the DataCollection.DataCollectionAcademicSchoolYear non nullable property
        /// </summary>
        public System.String DataCollectionAcademicSchoolYear { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionCloseDate nullable property
        /// </summary>
        public System.DateTime? DataCollectionCloseDate { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionDescription non nullable property
        /// </summary>
        public System.String DataCollectionDescription { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionName non nullable property
        /// </summary>
        public System.String DataCollectionName { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionSchoolYear non nullable property
        /// </summary>
        public System.String DataCollectionSchoolYear { get; set; }

        /// <summary>
        /// Defines the DataCollection.SourceSystemDataCollectionIdentifier non nullable property
        /// </summary>
        public System.String SourceSystemDataCollectionIdentifier { get; set; }

        /// <summary>
        /// Defines the DataCollection.SourceSystemName non nullable property
        /// </summary>
        public System.String SourceSystemName { get; set; }

        /// <summary>
        /// Defines the DataCollection.DataCollectionOpenDate nullable property
        /// </summary>
        public System.DateTime? DataCollectionOpenDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDataCollectionStatus"/> model
        /// </summary>
        public Guid? RefDataCollectionStatusId { get; set; }

    }
}
