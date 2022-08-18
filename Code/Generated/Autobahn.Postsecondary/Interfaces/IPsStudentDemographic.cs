//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentDemographic.cs
//* Name:       Children of Fallen Heroes Indicator
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IPsStudentDemographic : IAutobahnBase
    {
        /// <summary>
        /// Children of Fallen Heroes Indicator
        /// <para>
        /// Pell-eligible students whose parent or guardian was a member of the U.S. armed forces and died as a result of military service performed in Iraq or Afghanistan after the events of 9/11 or a public safety officer and died as a result of active service in the line of duty. At the time of the parent's or guardian's death, the student must be less than 24 years of age or enrolled in college or career school at least part-time.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20917">Children of Fallen Heroes Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? ChildrenOfFallenHeroesIndicator { get; set; }

        /// <summary>
        /// Emancipated Minor
        /// <para>
        /// A minor student under the age of 18 who has been granted by legal action to have the power and capacity of an adult.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20931">Emancipated Minor</a>
        /// </para>
        /// </summary>
        System.Boolean? EmancipatedMinor { get; set; }

        /// <summary>
        /// First Generation College Student
        /// <para>
        /// The term First Generation College Student means an individual both of whose parents did not complete a baccalaureate degree or in the case of any individual who regularly resided with and received support from only one parent, an individual whose only such parent did not complete a baccalaureate degree.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20933">First Generation College Student</a>
        /// </para>
        /// </summary>
        System.Boolean? FirstGenerationCollegeStudent { get; set; }

        /// <summary>
        /// Number of Dependents
        /// <para>
        /// The number of dependents who live with the student and receive more than half their support from them.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20384">Number of Dependents</a>
        /// </para>
        /// </summary>
        System.Int32? NumberOfDependents { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusResidencyType"/> model
        /// </summary>
        Guid? RefCampusResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCohortExclusion"/> model
        /// </summary>
        Guid? RefCohortExclusionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDependencyStatus"/> model
        /// </summary>
        Guid? RefDependencyStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMaternalEducationLevel"/> model
        /// </summary>
        Guid? RefMaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNumberOfDependentsType"/> model
        /// </summary>
        Guid? RefNumberOfDependentsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPaternalEducationLevel"/> model
        /// </summary>
        Guid? RefPaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPsLepType"/> model
        /// </summary>
        Guid? RefPsLepTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionResidencyType"/> model
        /// </summary>
        Guid? RefTuitionResidencyTypeId { get; set; }

    }
}
