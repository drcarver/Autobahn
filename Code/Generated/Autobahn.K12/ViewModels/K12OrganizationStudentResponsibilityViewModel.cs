//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12OrganizationStudentResponsibilityViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12OrganizationStudentResponsibility View Model
     /// </summary>
    public partial class K12OrganizationStudentResponsibilityViewModel : ViewModelBase, Interfaces.IK12OrganizationStudentResponsibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12OrganizationStudentResponsibility";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefK12ResponsibilityTypeId -- (backing property for Responsible District Type)
        private Guid _RefK12ResponsibilityTypeId;

        // RefStudentSchoolAffiliationStateDefinedStatusId -- (backing property for Student School Affiliation State Defined Status)
        private Guid? _RefStudentSchoolAffiliationStateDefinedStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Responsible District Type
        /// <para>
        /// The type of responsibility the district has for the student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19587">Responsible District Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefK12ResponsibilityTypeId { get => _RefK12ResponsibilityTypeId; set => SetProperty(ref _RefK12ResponsibilityTypeId, value); }

        /// <summary>
        /// Student School Affiliation State Defined Status
        /// <para>
        /// An indication of the nature of a student's affiliation, as defined by the state, with a public school and used generally, but not exclusively, for the purpose of determining residency, funding, or accountability.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20968">Student School Affiliation State Defined Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get => _RefStudentSchoolAffiliationStateDefinedStatusId; set => SetProperty(ref _RefStudentSchoolAffiliationStateDefinedStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12OrganizationStudentResponsibility model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefK12ResponsibilityTypeId = model.RefK12ResponsibilityTypeId; // Responsible District Type
            RefStudentSchoolAffiliationStateDefinedStatusId = model.RefStudentSchoolAffiliationStateDefinedStatusId; // Student School Affiliation State Defined Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefK12ResponsibilityType List
        /// <summary>
        /// The complete <see cref="RefK12ResponsibilityType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefK12ResponsibilityTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("dad597ea-1dfc-4007-bad5-059dc60e7ae5"), Code="Accountability", Description="Accountability", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for student learning under Federal ESEA and State accountability plans.  (e.g. for AYP reporting)", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("8db60cdb-44b6-40c0-95be-032708935e36"), Code="Attendance", Description="Attendance", Definition="The role/relationship assigned to an organization, institution, or agency operating the physical or virtual site in which delivery of educational services take place.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("92dd6e1d-0ebf-48e8-bb4c-fcd71d7bbbd2"), Code="Funding", Description="Funding", Definition="The role/relationship assigned to an organization, institution, or agency responsible for funding related to a student enrollment.  ", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("b1b33579-cbbc-4ea9-ac0c-8f27ce60bda1"), Code="Graduation", Description="Graduation", Definition="The role/relationship assigned to an organization, institution, or agency responsible for issuing/awarding diplomas.  (e.g. for graduation-rate reporting)", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("d7772b5b-7be7-4e33-99c3-fa3b6be2a12f"), Code="IndividualizedEducationProgram", Description="Individualized education program (IEP)", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for creating and maintaining the student's IEP, a written instructional plan for students with disabilities designated as special education students under the Individuals with Disabilities Education Act (IDEA-Part B) which includes: 1) a statement of present levels of educational performance of a child; 2) a statement of annual goals including short-term instructional objectives; 3) a statement of specific education and related services to be provided and the extent to which the child will be able to participate in regular educational programs; 4) a projected date for initiation and anticipated duration of services; and 5) appropriate objectives, criteria and evaluation procedures and schedules for determining, on at least an annual basis, whether instructional objectives are being achieved.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("718bd092-c288-4c17-b370-415be2c12a33"), Code="Transportation", Description="Transportation", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for transporting the student to the physical location of the school or facility in which educational services are delivered.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("2dad7752-a416-4a3d-b3b2-26b754a115b5"), Code="IEPServiceProvider", Description="Individualized education program service provider", Definition="The role/relationship type assigned to an organization, institution, or agency responsible for providing services to meet the requirements of the student's Individualized Education Program (IEP).", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion

        #region RefStudentSchoolAffiliationStateDefinedStatus List
        /// <summary>
        /// The complete <see cref="RefStudentSchoolAffiliationStateDefinedStatus"> List
        /// </summary>
        private static List<ReferenceModelBase> RefStudentSchoolAffiliationStateDefinedStatusList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("fb439993-6348-4654-b48c-b8fdf9464547"), Code="Other", Description="Other", Definition="The option is not yet defined in CEDS", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
