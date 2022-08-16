//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeStaff.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStaff Interface
     /// </summary>
    public partial interface IAeStaff : IAutobahnBase
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
        Guid? RefAeStaffClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAeStaffEmploymentStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         YearsOfPriorAeTeachingExperience { get; set; }

    }
}
