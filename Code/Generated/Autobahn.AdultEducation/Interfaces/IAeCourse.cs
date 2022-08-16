//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeCourse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeCourse Interface
     /// </summary>
    public partial interface IAeCourse : IAutobahnBase
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
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseLevelTypeId { get; set; }

    }
}
