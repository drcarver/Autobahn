//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeProvider.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeProvider Interface
     /// </summary>
    public partial interface IAeProvider : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefLevelOfInstitutionId { get; set; }

    }
}
