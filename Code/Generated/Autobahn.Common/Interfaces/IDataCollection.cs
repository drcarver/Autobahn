//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IDataCollection.cs
//* Name:       Data Collection Academic School Year
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IDataCollection : IAutobahnBase
    {
        /// <summary>
        /// Data Collection Academic School Year
        /// <para>
        /// The year for a reported school session for which the data is applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20920">Data Collection Academic School Year</a>
        /// </para>
        /// </summary>
        System.String DataCollectionAcademicSchoolYear { get; set; }

        /// <summary>
        /// Data Collection Close Date
        /// <para>
        /// The date the data collection closes or ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20921">Data Collection Close Date</a>
        /// </para>
        /// </summary>
        System.DateTime? DataCollectionCloseDate { get; set; }

        /// <summary>
        /// Data Collection Description
        /// <para>
        /// The description of what is included in the data within the context of the data collection based on the source system and collection period as defined by the Data Collection Open Date and Data Collection Close Date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20922">Data Collection Description</a>
        /// </para>
        /// </summary>
        System.String DataCollectionDescription { get; set; }

        /// <summary>
        /// Data Collection Name
        /// <para>
        /// A human readable name used to identify the data within the collection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20923">Data Collection Name</a>
        /// </para>
        /// </summary>
        System.String DataCollectionName { get; set; }

        /// <summary>
        /// Data Collection Open Date
        /// <para>
        /// The date the data collection opens or commences.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20924">Data Collection Open Date</a>
        /// </para>
        /// </summary>
        System.DateTime? DataCollectionOpenDate { get; set; }

        /// <summary>
        /// Data Collection School Year
        /// <para>
        /// The year for a reported school session in which the data collection occurs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20925">Data Collection School Year</a>
        /// </para>
        /// </summary>
        System.String DataCollectionSchoolYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDataCollectionStatus"/> model
        /// </summary>
        Guid? RefDataCollectionStatusId { get; set; }

        /// <summary>
        /// Source System Data Collection Identifier
        /// <para>
        /// The identifier specified by the source system that uniquely identifies the data collection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20960">Source System Data Collection Identifier</a>
        /// </para>
        /// </summary>
        System.String SourceSystemDataCollectionIdentifier { get; set; }

        /// <summary>
        /// Source System Name
        /// <para>
        /// The name of the source system that provided the data within the collection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20961">Source System Name</a>
        /// </para>
        /// </summary>
        System.String SourceSystemName { get; set; }

    }
}
