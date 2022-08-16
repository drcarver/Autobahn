//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentDemographic.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentDemographic Interface
     /// </summary>
    public partial interface IPsStudentDemographic : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ChildrenOfFallenHeroesIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EmancipatedMinor { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FirstGenerationCollegeStudent { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfDependents { get; set; }

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
        Guid? RefCampusResidencyTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCohortExclusionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDependencyStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMaternalEducationLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefNumberOfDependentsTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPaternalEducationLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPsLepTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTuitionResidencyTypeId { get; set; }

    }
}
