//**********************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentActivityViewModel.cs
//* Name:       Professional Development Activity Code
//* Definition: A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
     /// </summary>
    public partial class ProfessionalDevelopmentActivityViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentActivity";

        // ActivityCode -- (backing property for Professional Development Activity Code)
        private System.String _ActivityCode;

        // ActivityIdentifier -- (backing property for Professional Development Activity Identifier)
        private System.String _ActivityIdentifier;

        // ApprovalCode -- (backing property for Professional Development Activity Approval Code)
        private System.String _ApprovalCode;

        // Cost -- (backing property for Professional Development Activity Cost)
        private System.Decimal? _Cost;

        // member variable for the CourseId property
        private Guid? _CourseId;

        // Credits -- (backing property for Professional Development Activity Credits)
        private System.Decimal? _Credits;

        // Objective -- (backing property for Professional Development Activity Objective)
        private System.String _Objective;

        // ProfessionalDevelopmentActivityStateApprovedStatus -- (backing property for Professional Development Activity State Approved Status)
        private System.Boolean? _ProfessionalDevelopmentActivityStateApprovedStatus;

        // member variable for the ProfessionalDevelopmentRequirementId property
        private Guid _ProfessionalDevelopmentRequirementId;

        // PublishIndicator -- (backing property for Professional Development Publish Activity Indicator)
        private System.Boolean? _PublishIndicator;

        // RefCourseCreditUnitId -- (backing property for Course Credit Units)
        private Guid? _RefCourseCreditUnitId;

        // RefPDActivityApprovedPurposeId -- (backing property for Professional Development Activity Approved Purpose)
        private Guid? _RefPDActivityApprovedPurposeId;

        // RefPDActivityCreditTypeId -- (backing property for Professional Development Activity Credit Type)
        private Guid? _RefPDActivityCreditTypeId;

        // RefPDActivityLevelId -- (backing property for Professional Development Activity Level)
        private Guid? _RefPDActivityLevelId;

        // RefPDActivityTypeId -- (backing property for Professional Development Activity Type)
        private Guid? _RefPDActivityTypeId;

        // RefPDAudienceTypeId -- (backing property for Professional Development Audience Type)
        private Guid? _RefPDAudienceTypeId;

        // RefProfessionalDevelopmentFinancialSupportId -- (backing property for Professional Development Financial Support Type)
        private Guid? _RefProfessionalDevelopmentFinancialSupportId;

        // ScholarshipStatus -- (backing property for Professional Development Scholarship Status)
        private System.Boolean? _ScholarshipStatus;

        // Title -- (backing property for Professional Development Activity Title)
        private System.String _Title;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Professional Development Activity Code
        /// <para>
        /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20404">Professional Development Activity Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ActivityCode { get => _ActivityCode; set => SetProperty(ref _ActivityCode, value); }

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
        /// Professional Development Activity Approval Code
        /// <para>
        /// A code given to an activity by an approval organization to designate it as an approved activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20402">Professional Development Activity Approval Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ApprovalCode { get => _ApprovalCode; set => SetProperty(ref _ApprovalCode, value); }

        /// <summary>
        /// Professional Development Activity Cost
        /// <para>
        /// The cost for an attendee to participate in a professional development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20405">Professional Development Activity Cost</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? Cost { get => _Cost; set => SetProperty(ref _Cost, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourse"/> model
        /// </summary>
        public Guid? CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        /// <summary>
        /// Professional Development Activity Credits
        /// <para>
        /// The number of credits a professional development activity provides.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20407">Professional Development Activity Credits</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? Credits { get => _Credits; set => SetProperty(ref _Credits, value); }

        /// <summary>
        /// Professional Development Activity Objective
        /// <para>
        /// The expected outcomes of a participant in an activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20410">Professional Development Activity Objective</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Objective { get => _Objective; set => SetProperty(ref _Objective, value); }

        /// <summary>
        /// Professional Development Activity State Approved Status
        /// <para>
        /// An indication of whether a training activity has been approved through a state process.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20598">Professional Development Activity State Approved Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get => _ProfessionalDevelopmentActivityStateApprovedStatus; set => SetProperty(ref _ProfessionalDevelopmentActivityStateApprovedStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentRequirementId { get => _ProfessionalDevelopmentRequirementId; set => SetProperty(ref _ProfessionalDevelopmentRequirementId, value); }

        /// <summary>
        /// Professional Development Publish Activity Indicator
        /// <para>
        /// An indicator of whether the professional development activity should be published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20415">Professional Development Publish Activity Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? PublishIndicator { get => _PublishIndicator; set => SetProperty(ref _PublishIndicator, value); }

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
        /// Professional Development Activity Approved Purpose
        /// <para>
        /// The purposes for which an activity is approved.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20403">Professional Development Activity Approved Purpose</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPDActivityApprovedPurposeId { get => _RefPDActivityApprovedPurposeId; set => SetProperty(ref _RefPDActivityApprovedPurposeId, value); }

        /// <summary>
        /// Professional Development Activity Credit Type
        /// <para>
        /// The type of credit awarded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20406">Professional Development Activity Credit Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPDActivityCreditTypeId { get => _RefPDActivityCreditTypeId; set => SetProperty(ref _RefPDActivityCreditTypeId, value); }

        /// <summary>
        /// Professional Development Activity Level
        /// <para>
        /// An indicator of the level of a professional development activity on the beginner to advanced continuum.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20409">Professional Development Activity Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPDActivityLevelId { get => _RefPDActivityLevelId; set => SetProperty(ref _RefPDActivityLevelId, value); }

        /// <summary>
        /// Professional Development Activity Type
        /// <para>
        /// The indication of the type of professional development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20412">Professional Development Activity Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPDActivityTypeId { get => _RefPDActivityTypeId; set => SetProperty(ref _RefPDActivityTypeId, value); }

        /// <summary>
        /// Professional Development Audience Type
        /// <para>
        /// The type of audience for the professional development activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20399">Professional Development Audience Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPDAudienceTypeId { get => _RefPDAudienceTypeId; set => SetProperty(ref _RefPDAudienceTypeId, value); }

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
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityCode = model.ActivityCode; // Professional Development Activity Code
            ActivityIdentifier = model.ActivityIdentifier; // Professional Development Activity Identifier
            ApprovalCode = model.ApprovalCode; // Professional Development Activity Approval Code
            Cost = model.Cost; // Professional Development Activity Cost
            CourseId = model.CourseId; // 
            Credits = model.Credits; // Professional Development Activity Credits
            Objective = model.Objective; // Professional Development Activity Objective
            ProfessionalDevelopmentActivityStateApprovedStatus = model.ProfessionalDevelopmentActivityStateApprovedStatus; // Professional Development Activity State Approved Status
            ProfessionalDevelopmentRequirementId = model.ProfessionalDevelopmentRequirementId; // 
            PublishIndicator = model.PublishIndicator; // Professional Development Publish Activity Indicator
            RefCourseCreditUnitId = model.RefCourseCreditUnitId; // Course Credit Units
            RefPDActivityApprovedPurposeId = model.RefPDActivityApprovedPurposeId; // Professional Development Activity Approved Purpose
            RefPDActivityCreditTypeId = model.RefPDActivityCreditTypeId; // Professional Development Activity Credit Type
            RefPDActivityLevelId = model.RefPDActivityLevelId; // Professional Development Activity Level
            RefPDActivityTypeId = model.RefPDActivityTypeId; // Professional Development Activity Type
            RefPDAudienceTypeId = model.RefPDAudienceTypeId; // Professional Development Audience Type
            RefProfessionalDevelopmentFinancialSupportId = model.RefProfessionalDevelopmentFinancialSupportId; // Professional Development Financial Support Type
            ScholarshipStatus = model.ScholarshipStatus; // Professional Development Scholarship Status
            Title = model.Title; // Professional Development Activity Title
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPDActivityApprovedPurpose List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefPDActivityApprovedPurposeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("49eeab10-5260-4535-8928-9afa4fd64377"), Code="QRIS", Description="Quality Rating and Improvement System", Definition="Quality Rating and Improvement System is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("8a48981d-06a8-490e-aa30-32a42adcbdda"), Code="Licensing", Description="Licensing", Definition="Licensing is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("db153473-005c-4760-810d-2028ecc7ff75"), Code="StateStandard", Description="State standard", Definition="State standard is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("e2b07457-67a0-426d-aa9b-a2fd8164d981"), Code="Other", Description="Other", Definition="The purposes for which the professional development activity was approved is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefPDActivityCreditType List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefPDActivityCreditTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0e214b5b-125c-4ebe-b4db-6cd48c66fcaf"), Code="Hours", Description="Hours", Definition="Hours is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("c91c1b59-dbc5-4233-be9b-00539d477844"), Code="CEUs", Description="Continuing Education Units", Definition="Continuing Education Units is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("a6a78d08-e800-4b02-b676-c12715354c72"), Code="QuarterCredits", Description="Quarter credits", Definition="Quarter credits is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("03ca31df-3375-4d12-b587-7c484a0eb8f5"), Code="SemesterCredits", Description="Semester credits", Definition="Semester credits is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefPDActivityLevel List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefPDActivityLevelList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("063025e2-2226-4f0b-8544-fa9c52050ea4"), Code="Beginner", Description="Beginner", Definition="The level of expertise for the professional development activity is beginner.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("7ff567dc-5ab0-4f4b-b8ef-19e50c4c064a"), Code="Intermediate", Description="Intermediate", Definition="The level of expertise for the professional development activity is intermediate.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("2eabb513-ccd8-4b94-8afb-25c8394e1899"), Code="Advanced", Description="Advanced", Definition="The level of expertise for the professional development activity is advanced.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefPDActivityType List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefPDActivityTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("6efb189c-9f39-48c0-88df-8019e580daf9"), Code="CollegeCourse", Description="College Course", Definition="The type of professional development activity is a College Course.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("cdd7aef1-4a95-46b9-bd87-4bdc15c39d4a"), Code="Coaching", Description="Coaching", Definition="The type of professional development activity is Coaching.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("675e7373-fc34-4a22-8286-11a6fb3cbbad"), Code="Mentoring", Description="Mentoring", Definition="The type of professional development activity is Mentoring.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("8112d78c-c4da-4593-96d5-88140523701e"), Code="Consultation", Description="Consultation", Definition="The type of professional development activity is Consultation.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("1ecbdbb3-bd8c-495b-a6e3-fe75a0089160"), Code="P2P", Description="Person-to-Person", Definition="The type of professional development activity is Person-to-Person.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("e842fc52-c274-48da-8b35-2a492f999bc1"), Code="TechnicalAssistance", Description="Technical Assistance", Definition="The type of professional development activity is Technical Assistance.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("824618d1-82b8-456e-9169-19017af6d592"), Code="Advisement", Description="Advisement", Definition="The type of professional development activity is Advisement.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("227a7853-6d0f-4b31-8969-7bdd6630ac25"), Code="OneTimeWorkshopTraining", Description="One-time Workshop Training", Definition="The type of professional development activity is One-time Workshop Training.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("0b3177cd-8a8e-4f4b-9842-b754644b314d"), Code="SeriesOfWorkshopsTraining", Description="Series of Workshops Training", Definition="The type of professional development activity is Series of Workshops Training.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("adeda421-74c3-4f61-9d7e-c5eb295dd9f3"), Code="Other", Description="Other", Definition="The type of professional development activity is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };
        #endregion

        #region RefPDAudienceType List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefPDAudienceTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3d2a3517-d061-44b6-a229-4f5c189ede6f"), Code="Individual", Description="Individual", Definition="The professional development activity is intended for delivery to an individual.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c9ea4c34-fcec-49f2-91ee-7bdcb920b666"), Code="Group", Description="Group", Definition="The professional development activity is intended for delivery to a group.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefProfessionalDevelopmentFinancialSupport List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefProfessionalDevelopmentFinancialSupportList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ed52923a-58dc-4735-a3e6-c97c5ee5c51c"), Code="01", Description="One time non-credit", Definition="One time financial assistance received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("ec64edb0-b3c3-47af-9c8f-0af24a681cf7"), Code="02", Description="One time credit paid", Definition="One time credit paid in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("6c3efefd-ce01-4f4b-afdf-d10f1ca3b57b"), Code="03", Description="On-going non-credit paid", Definition="On-going non-credit paid in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("0e4e133a-e40a-46b8-a338-62a2c53c6858"), Code="04", Description="On-going credit paid", Definition="On-going credit paid in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d30132f-95a3-4acd-a830-075b3c4f065d"), Code="05", Description="Salary bonus", Definition="Salary bonus received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("1ccf5d39-4556-4df6-a76c-e2268a231a51"), Code="06", Description="Wage enhancement", Definition="Wage enhancement received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("a2a8492c-b1e7-4274-aea4-8cc3fc08d31b"), Code="07", Description="Tuition reimbursement", Definition="Tuition reimbursement received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("d2e34532-011a-4dae-8feb-4d7f6e4f279a"), Code="08", Description="Travel child care", Definition="Travel child care received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("e09d38a0-142e-4595-b20f-6dce8a6c9ad1"), Code="09", Description="Release time", Definition="Release time received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("ec94155d-d7c3-4661-9c47-96e6b910b2d8"), Code="10", Description="Scholarship", Definition="Scholarship received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("cc0282b6-ef9b-47cc-9cf5-de30dd8c5d8c"), Code="11", Description="Loan", Definition="Loan received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("11.00") },
        };
        #endregion
    }
}
