//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityViewModel.cs
//* Name:       Staff Professional Development Activity Completion Date
//* Definition: The year, month and day on which an individual completed a course, an education program or a staff development activity.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The year, month and day on which an individual completed a course, an education program or a staff development activity.
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivityViewModel : ViewModelBase, Interfaces.IStaffProfessionalDevelopmentActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffProfessionalDevelopmentActivity";

        // ActivityCompletionDate -- (backing property for Staff Professional Development Activity Completion Date)
        private System.DateTime? _ActivityCompletionDate;

        // ActivityIdentifier -- (backing property for Professional Development Activity Identifier)
        private System.String _ActivityIdentifier;

        // ActivityStartDate -- (backing property for Staff Professional Development Activity Start Date)
        private System.DateTime? _ActivityStartDate;

        // ActivityTitle -- (backing property for Professional Development Activity Title)
        private System.String _ActivityTitle;

        // NumberOfCreditsEarned -- (backing property for Number of Credits Earned)
        private System.Decimal? _NumberOfCreditsEarned;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // member variable for the ProfessionalDevelopmentRequirementId property
        private Guid _ProfessionalDevelopmentRequirementId;

        // member variable for the ProfessionalDevelopmentSessionId property
        private Guid _ProfessionalDevelopmentSessionId;

        // RefCourseCreditUnitId -- (backing property for Course Credit Units)
        private Guid? _RefCourseCreditUnitId;

        // RefProfessionalDevelopmentFinancialSupportId -- (backing property for Professional Development Financial Support Type)
        private Guid? _RefProfessionalDevelopmentFinancialSupportId;

        // ScholarshipStatus -- (backing property for Professional Development Scholarship Status)
        private System.Boolean? _ScholarshipStatus;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Staff Professional Development Activity Completion Date
        /// <para>
        /// The year, month and day on which an individual completed a course, an education program or a staff development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20068">Staff Professional Development Activity Completion Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ActivityCompletionDate { get => _ActivityCompletionDate; set => SetProperty(ref _ActivityCompletionDate, value); }

        /// <summary>
        /// Professional Development Activity Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to the Professional Development Activity as assigned by the organization offering the training.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19808">Professional Development Activity Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ActivityIdentifier { get => _ActivityIdentifier; set => SetProperty(ref _ActivityIdentifier, value); }

        /// <summary>
        /// Staff Professional Development Activity Start Date
        /// <para>
        /// The year, month and day on which an individual begins a course, an education program or a staff development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20067">Staff Professional Development Activity Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ActivityStartDate { get => _ActivityStartDate; set => SetProperty(ref _ActivityStartDate, value); }

        /// <summary>
        /// Professional Development Activity Title
        /// <para>
        /// The title of an activity designed for the purpose of developing someone professionally.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19809">Professional Development Activity Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ActivityTitle { get => _ActivityTitle; set => SetProperty(ref _ActivityTitle, value); }

        /// <summary>
        /// Number of Credits Earned
        /// <para>
        /// The number of credits an individual earns by the successful completion of a course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NumberOfCreditsEarned { get => _NumberOfCreditsEarned; set => SetProperty(ref _NumberOfCreditsEarned, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get => _ProfessionalDevelopmentRequirementId; set => SetProperty(ref _ProfessionalDevelopmentRequirementId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentSession"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentSessionId { get => _ProfessionalDevelopmentSessionId; set => SetProperty(ref _ProfessionalDevelopmentSessionId, value); }

        /// <summary>
        /// Course Credit Units
        /// <para>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        /// <summary>
        /// Professional Development Financial Support Type
        /// <para>
        /// The type of financial assistance received in support of non-credit professional development activities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19811">Professional Development Financial Support Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProfessionalDevelopmentFinancialSupportId { get => _RefProfessionalDevelopmentFinancialSupportId; set => SetProperty(ref _RefProfessionalDevelopmentFinancialSupportId, value); }

        /// <summary>
        /// Professional Development Scholarship Status
        /// <para>
        /// An indication of whether a scholarship was received for the person to participate in the professional development.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19810">Professional Development Scholarship Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ScholarshipStatus { get => _ScholarshipStatus; set => SetProperty(ref _ScholarshipStatus, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffProfessionalDevelopmentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityCompletionDate = model.ActivityCompletionDate; // Staff Professional Development Activity Completion Date
            ActivityIdentifier = model.ActivityIdentifier; // Professional Development Activity Identifier
            ActivityStartDate = model.ActivityStartDate; // Staff Professional Development Activity Start Date
            ActivityTitle = model.ActivityTitle; // Professional Development Activity Title
            NumberOfCreditsEarned = model.NumberOfCreditsEarned; // Number of Credits Earned
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId; // 
            ProfessionalDevelopmentRequirementId = model.ProfessionalDevelopmentRequirementId; // 
            ProfessionalDevelopmentSessionId = model.ProfessionalDevelopmentSessionId; // 
            RefCourseCreditUnitId = model.RefCourseCreditUnitId; // Course Credit Units
            RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId; // Professional Development Financial Support Type
            ScholarshipStatus = model.ScholarshipStatus; // Professional Development Scholarship Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
