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
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        System.Boolean? ChildrenOfFallenHeroesIndicator { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        System.Boolean? EmancipatedMinor { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        System.Boolean? FirstGenerationCollegeStudent { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        System.Int32? NumberOfDependents { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid? RefCampusResidencyTypeId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid? RefCohortExclusionId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid? RefDependencyStatusId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid? RefMaternalEducationLevelId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid? RefNumberOfDependentsTypeId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid? RefPaternalEducationLevelId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid? RefPsLepTypeId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        Guid? RefTuitionResidencyTypeId { get; set; }

    }
}
