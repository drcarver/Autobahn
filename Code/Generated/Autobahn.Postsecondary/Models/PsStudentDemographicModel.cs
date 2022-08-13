//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentDemographic Model
     /// </summary>
    public partial class PsStudentDemographicModel : AutobahnBase, Interfaces.IPsStudentDemographic
    {
        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public System.Boolean? ChildrenOfFallenHeroesIndicator { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public System.Boolean? EmancipatedMinor { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public System.Boolean? FirstGenerationCollegeStudent { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public System.Int32? NumberOfDependents { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid? RefCampusResidencyTypeId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid? RefCohortExclusionId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid? RefDependencyStatusId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid? RefMaternalEducationLevelId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid? RefNumberOfDependentsTypeId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid? RefPaternalEducationLevelId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid? RefPsLepTypeId { get; set; }

        /// <summary>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </summary>
        public Guid? RefTuitionResidencyTypeId { get; set; }

    }
}
