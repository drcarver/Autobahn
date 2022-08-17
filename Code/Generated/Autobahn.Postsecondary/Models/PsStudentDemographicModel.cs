//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicModel.cs
//* Name:       Children of Fallen Heroes Indicator
//* Definition: Pell-eligible students whose parent or guardian was a member of the U.S. armed forces and died as a result of military service performed in Iraq or Afghanistan after the events of 9/11 or a public safety officer and died as a result of active service in the line of duty. At the time of the parent's or guardian's death, the student must be less than 24 years of age or enrolled in college or career school at least part-time.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// Pell-eligible students whose parent or guardian was a member of the U.S. armed forces and died as a result of military service performed in Iraq or Afghanistan after the events of 9/11 or a public safety officer and died as a result of active service in the line of duty. At the time of the parent's or guardian's death, the student must be less than 24 years of age or enrolled in college or career school at least part-time.
     /// </summary>
    public partial class PsStudentDemographicModel : AutobahnBase, Interfaces.IPsStudentDemographic
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
        public System.Boolean? ChildrenOfFallenHeroesIndicator { get; set; }

        /// <summary>
        /// Emancipated Minor
        /// <para>
        /// A minor student under the age of 18 who has been granted by legal action to have the power and capacity of an adult.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20931">Emancipated Minor</a>
        /// </para>
        /// </summary>
        public System.Boolean? EmancipatedMinor { get; set; }

        /// <summary>
        /// First Generation College Student
        /// <para>
        /// The term First Generation College Student means an individual both of whose parents did not complete a baccalaureate degree or in the case of any individual who regularly resided with and received support from only one parent, an individual whose only such parent did not complete a baccalaureate degree.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20933">First Generation College Student</a>
        /// </para>
        /// </summary>
        public System.Boolean? FirstGenerationCollegeStudent { get; set; }

        /// <summary>
        /// Number of Dependents
        /// <para>
        /// The number of dependents who live with the student and receive more than half their support from them.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20384">Number of Dependents</a>
        /// </para>
        /// </summary>
        public System.Int32? NumberOfDependents { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCampusResidencyType"/> model
        /// </summary>
        public Guid? RefCampusResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCohortExclusion"/> model
        /// </summary>
        public Guid? RefCohortExclusionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDependencyStatus"/> model
        /// </summary>
        public Guid? RefDependencyStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMaternalEducationLevel"/> model
        /// </summary>
        public Guid? RefMaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefNumberOfDependentsType"/> model
        /// </summary>
        public Guid? RefNumberOfDependentsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPaternalEducationLevel"/> model
        /// </summary>
        public Guid? RefPaternalEducationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPsLepType"/> model
        /// </summary>
        public Guid? RefPsLepTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTuitionResidencyType"/> model
        /// </summary>
        public Guid? RefTuitionResidencyTypeId { get; set; }

    }
}
