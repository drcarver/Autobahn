//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentAcademicAward.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentAcademicAward Interface
     /// </summary>
    public partial interface IPsStudentAcademicAward : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AcademicAwardDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         AcademicAwardTitle { get; set; }

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
         RefAcademicAwardLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAcademicAwardPrerequisiteTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPESCAwardLevelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RequirementsURL { get; set; }

    }
}
