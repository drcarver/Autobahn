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
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        System.String DataCollectionAcademicSchoolYear { get; set; }

    }
}
