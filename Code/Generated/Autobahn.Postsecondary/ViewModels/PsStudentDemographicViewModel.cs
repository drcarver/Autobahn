//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicViewModel.cs
//* Name:       Children of Fallen Heroes Indicator
//* Definition: Pell-eligible students whose parent or guardian was a member of the U.S. armed forces and died as a result of military service performed in Iraq or Afghanistan after the events of 9/11 or a public safety officer and died as a result of active service in the line of duty. At the time of the parent's or guardian's death, the student must be less than 24 years of age or enrolled in college or career school at least part-time.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// Pell-eligible students whose parent or guardian was a member of the U.S. armed forces and died as a result of military service performed in Iraq or Afghanistan after the events of 9/11 or a public safety officer and died as a result of active service in the line of duty. At the time of the parent's or guardian's death, the student must be less than 24 years of age or enrolled in college or career school at least part-time.
     /// </summary>
    public partial class PsStudentDemographicViewModel : ViewModelBase, Interfaces.IPsStudentDemographic
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentDemographic";

        // ChildrenOfFallenHeroesIndicator -- (backing property for Children of Fallen Heroes Indicator)
        private System.Boolean? _ChildrenOfFallenHeroesIndicator;

        // EmancipatedMinor -- (backing property for Emancipated Minor)
        private System.Boolean? _EmancipatedMinor;

        // FirstGenerationCollegeStudent -- (backing property for First Generation College Student)
        private System.Boolean? _FirstGenerationCollegeStudent;

        // NumberOfDependents -- (backing property for Number of Dependents)
        private System.Int32? _NumberOfDependents;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefCampusResidencyTypeId -- (backing property for Campus Residency Type)
        private Guid? _RefCampusResidencyTypeId;

        // RefCohortExclusionId -- (backing property for Cohort Exclusion)
        private Guid? _RefCohortExclusionId;

        // RefDependencyStatusId -- (backing property for Dependency Status)
        private Guid? _RefDependencyStatusId;

        // RefMaternalEducationLevelId -- (backing property for Maternal Guardian Education)
        private Guid? _RefMaternalEducationLevelId;

        // RefNumberOfDependentsTypeId -- (backing property for Number of Dependents Type)
        private Guid? _RefNumberOfDependentsTypeId;

        // RefPaternalEducationLevelId -- (backing property for Paternal Guardian Education)
        private Guid? _RefPaternalEducationLevelId;

        // RefPsLepTypeId -- (backing property for Limited English Proficiency - Postsecondary)
        private Guid? _RefPsLepTypeId;

        // RefTuitionResidencyTypeId -- (backing property for Tuition Residency Type)
        private Guid? _RefTuitionResidencyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Children of Fallen Heroes Indicator
        /// <para>
        /// Pell-eligible students whose parent or guardian was a member of the U.S. armed forces and died as a result of military service performed in Iraq or Afghanistan after the events of 9/11 or a public safety officer and died as a result of active service in the line of duty. At the time of the parent's or guardian's death, the student must be less than 24 years of age or enrolled in college or career school at least part-time.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20917">Children of Fallen Heroes Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ChildrenOfFallenHeroesIndicator { get => _ChildrenOfFallenHeroesIndicator; set => SetProperty(ref _ChildrenOfFallenHeroesIndicator, value); }

        /// <summary>
        /// Emancipated Minor
        /// <para>
        /// A minor student under the age of 18 who has been granted by legal action to have the power and capacity of an adult.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20931">Emancipated Minor</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? EmancipatedMinor { get => _EmancipatedMinor; set => SetProperty(ref _EmancipatedMinor, value); }

        /// <summary>
        /// First Generation College Student
        /// <para>
        /// The term First Generation College Student means an individual both of whose parents did not complete a baccalaureate degree or in the case of any individual who regularly resided with and received support from only one parent, an individual whose only such parent did not complete a baccalaureate degree.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20933">First Generation College Student</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? FirstGenerationCollegeStudent { get => _FirstGenerationCollegeStudent; set => SetProperty(ref _FirstGenerationCollegeStudent, value); }

        /// <summary>
        /// Number of Dependents
        /// <para>
        /// The number of dependents who live with the student and receive more than half their support from them.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20384">Number of Dependents</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NumberOfDependents { get => _NumberOfDependents; set => SetProperty(ref _NumberOfDependents, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Campus Residency Type
        /// <para>
        /// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19035">Campus Residency Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCampusResidencyTypeId { get => _RefCampusResidencyTypeId; set => SetProperty(ref _RefCampusResidencyTypeId, value); }

        /// <summary>
        /// Cohort Exclusion
        /// <para>
        /// Those persons who may be removed (deleted) from a cohort (or subcohort). For the Graduation Rates and Fall Enrollment retention rate reporting, persons may be removed from a cohort if they left the institution for one of the following reasons: death or total and permanent disability; service in the armed forces (including those called to active duty); service with a foreign aid service of the federal government, such as the Peace Corps; or service on official church missions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19106">Cohort Exclusion</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCohortExclusionId { get => _RefCohortExclusionId; set => SetProperty(ref _RefCohortExclusionId, value); }

        /// <summary>
        /// Dependency Status
        /// <para>
        /// A person's classification as dependent or independent with regards to eligibility for Title IV Federal Student aid.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19079">Dependency Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDependencyStatusId { get => _RefDependencyStatusId; set => SetProperty(ref _RefDependencyStatusId, value); }

        /// <summary>
        /// Maternal Guardian Education
        /// <para>
        /// The highest level of education attained by a person's mother or maternal guardian
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20194">Maternal Guardian Education</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMaternalEducationLevelId { get => _RefMaternalEducationLevelId; set => SetProperty(ref _RefMaternalEducationLevelId, value); }

        /// <summary>
        /// Number of Dependents Type
        /// <para>
        /// The student's relationship to the dependents who live with the student or receive more than half of the student's support
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20949">Number of Dependents Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefNumberOfDependentsTypeId { get => _RefNumberOfDependentsTypeId; set => SetProperty(ref _RefNumberOfDependentsTypeId, value); }

        /// <summary>
        /// Paternal Guardian Education
        /// <para>
        /// The highest level of education attained by a person's father or paternal guardian
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20195">Paternal Guardian Education</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPaternalEducationLevelId { get => _RefPaternalEducationLevelId; set => SetProperty(ref _RefPaternalEducationLevelId, value); }

        /// <summary>
        /// Limited English Proficiency - Postsecondary
        /// <para>
        /// The term "individual with limited English proficiency" means a secondary school student, an adult, or an out-of-school youth, who has limited ability in speaking, reading, writing, or understanding the English language AND whose native language is a language other than English; OR who lives in a family or community environment in which a language other than English is the dominant language. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19179">Limited English Proficiency - Postsecondary</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPsLepTypeId { get => _RefPsLepTypeId; set => SetProperty(ref _RefPsLepTypeId, value); }

        /// <summary>
        /// Tuition Residency Type
        /// <para>
        /// A person's residency status for tuition purposes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19297">Tuition Residency Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTuitionResidencyTypeId { get => _RefTuitionResidencyTypeId; set => SetProperty(ref _RefTuitionResidencyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentDemographic model)
        {
            IsBusy = true;
            Id = model.Id;
            ChildrenOfFallenHeroesIndicator = model.ChildrenOfFallenHeroesIndicator; // Children of Fallen Heroes Indicator
            EmancipatedMinor = model.EmancipatedMinor; // Emancipated Minor
            FirstGenerationCollegeStudent = model.FirstGenerationCollegeStudent; // First Generation College Student
            NumberOfDependents = model.NumberOfDependents; // Number of Dependents
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefCampusResidencyTypeId = model.RefCampusResidencyTypeId; // Campus Residency Type
            RefCohortExclusionId = model.RefCohortExclusionId; // Cohort Exclusion
            RefDependencyStatusId = model.RefDependencyStatusId; // Dependency Status
            RefMaternalEducationLevelId = model.RefMaternalEducationLevelId; // Maternal Guardian Education
            RefNumberOfDependentsTypeId = model.RefNumberOfDependentsTypeId; // Number of Dependents Type
            RefPaternalEducationLevelId = model.RefPaternalEducationLevelId; // Paternal Guardian Education
            RefPsLepTypeId = model.RefPsLepTypeId; // Limited English Proficiency - Postsecondary
            RefTuitionResidencyTypeId = model.RefTuitionResidencyTypeId; // Tuition Residency Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefMaternalEducationLevel List
        /// <summary>
        /// The complete Children of Fallen Heroes Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefMaternalEducationLevelList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefNumberOfDependentsType List
        /// <summary>
        /// The complete Children of Fallen Heroes Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefNumberOfDependentsTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("496a8f11-af9f-4b10-ac6e-63c65c83c1cb"), Code="All", Description="All", Definition="The dependents are the person's children, spouse, and person other than the children or spouse", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("eefc8139-5e65-4297-be96-010d6f37f93d"), Code="Children", Description="Children", Definition="The dependents are the person's children.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("c0386d46-d9c4-4d09-8c35-7cb3126bb4ef"), Code="PersonOtherThanChildrenOrSpouse", Description="Person other than children or spouse", Definition="The dependent is a person other than the person's children or spouse", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d1c222e-41f5-43a3-852d-dcb8679c5ef7"), Code="Spouse", Description="Spouse", Definition="The dependent is the person's spouse.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefPaternalEducationLevel List
        /// <summary>
        /// The complete Children of Fallen Heroes Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefPaternalEducationLevelList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefPsLepType List
        /// <summary>
        /// The complete Children of Fallen Heroes Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefPsLepTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3118dfad-8c41-4724-92f0-7512b7bf8bdf"), Code="Yes", Description="Currently meets standard for limited English proficiency", Definition="The person currently meets the standard for limited English proficiency.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("b018c5aa-fa9c-480b-80e3-d504ecaa552d"), Code="No", Description="Currently does not meet standard for limited English proficiency", Definition="The person currently does not meet the standard for limited English proficiency.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f9d1a3fb-9c62-45d8-9a6d-bcdf6a717f51"), Code="Ever", Description="Ever met standard for limited English proficiency", Definition="The person currently does not meet the standard for limited English proficiency, but previously did meet the standard for limited English proficiency.", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefTuitionResidencyType List
        /// <summary>
        /// The complete Children of Fallen Heroes Indicator List
        /// </summary>
        private static List<ReferenceModelBase> RefTuitionResidencyTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("169b67ea-38e8-4c5f-b92b-8b22b4a64bdc"), Code="InDistrict", Description="In-district", Definition="The person's residency status for tuition purposes is: In-district.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("bcadb0b2-52c3-47cf-b822-d3a1eab3a264"), Code="InState", Description="In-state", Definition="The person's residency status for tuition purposes is: In-state.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("9cb15288-472e-40b1-bca9-946c9f3392b6"), Code="OutOfState", Description="Out-of-state", Definition="The person's residency status for tuition purposes is: Out-of-state.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("18488356-6305-4954-a671-1c7f1e2ffcd6"), Code="NoDifferential", Description="No differential tuition based on residency", Definition="No differential tuition based on residency is provided.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}
