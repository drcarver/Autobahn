//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentApplication.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentApplication Interface
     /// </summary>
    public partial interface IPsStudentApplication : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         GradePointAverageCumulative { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HighSchoolGraduatingClassSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HighSchoolPercentile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PostsecondaryApplicant { get; set; }

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
         RefAdmittedStudentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefGradePointAverageDomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         WaitListedStudent { get; set; }

    }
}
