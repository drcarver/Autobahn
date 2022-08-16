//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IDataCollection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IDataCollection Interface
     /// </summary>
    public partial interface IDataCollection : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? DataCollectionAcademicSchoolYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DataCollectionCloseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DataCollectionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DataCollectionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DataCollectionOpenDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DataCollectionSchoolYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDataCollectionStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SourceSystemDataCollectionIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SourceSystemName { get; set; }

    }
}
