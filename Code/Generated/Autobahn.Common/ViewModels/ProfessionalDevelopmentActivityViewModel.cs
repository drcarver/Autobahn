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
            new ReferenceModelBase { Id=Guid.Parse("1f03caf3-a496-4c28-a703-4341fc889726"), Code="QRIS", Description="Quality Rating and Improvement System", Definition="Quality Rating and Improvement System is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d81640b-d03e-4c56-8bce-8310dd805f4b"), Code="Licensing", Description="Licensing", Definition="Licensing is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("3dbf6862-0331-438a-be46-3b4a6fe103c8"), Code="StateStandard", Description="State standard", Definition="State standard is the purposes for which the professional development activity was approved.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("06218722-1c6d-4b0d-833c-a84744aaf72a"), Code="Other", Description="Other", Definition="The purposes for which the professional development activity was approved is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefPDActivityCreditType List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefPDActivityCreditTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("76d93009-78fb-4adf-ab86-055f4882ec2d"), Code="Hours", Description="Hours", Definition="Hours is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e0278616-f5fa-48e8-8d64-d3e23c8b8464"), Code="CEUs", Description="Continuing Education Units", Definition="Continuing Education Units is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("97d3c9b6-3cb9-4726-a429-dc21dfea981d"), Code="QuarterCredits", Description="Quarter credits", Definition="Quarter credits is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("0b9f5f37-30c9-4b24-a816-0edf4e39a826"), Code="SemesterCredits", Description="Semester credits", Definition="Semester credits is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("8.00") },
        };
        #endregion

        #region RefPDActivityLevel List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefPDActivityLevelList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("d4bd3d16-a394-4bd7-a23a-dd0cb219b636"), Code="Beginner", Description="Beginner", Definition="The level of expertise for the professional development activity is beginner.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("046ce15b-6dca-42ff-92ae-b9f7684e4d3a"), Code="Intermediate", Description="Intermediate", Definition="The level of expertise for the professional development activity is intermediate.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("cdba3b5f-509c-45ca-8250-9487350244be"), Code="Advanced", Description="Advanced", Definition="The level of expertise for the professional development activity is advanced.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefPDActivityType List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefPDActivityTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("7b657018-3e82-4854-ad58-a2de008f970b"), Code="CollegeCourse", Description="College Course", Definition="The type of professional development activity is a College Course.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("436f772c-dfdf-4f2b-b806-3a638f4258e3"), Code="Coaching", Description="Coaching", Definition="The type of professional development activity is Coaching.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("d9ce2ff9-44be-4f01-a3e2-1c407475d8a6"), Code="Mentoring", Description="Mentoring", Definition="The type of professional development activity is Mentoring.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("f0a4d990-45a9-41c7-ba5f-7342623634b2"), Code="Consultation", Description="Consultation", Definition="The type of professional development activity is Consultation.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("5a54bc16-3994-47fe-aff0-aeb2e0fafdc0"), Code="P2P", Description="Person-to-Person", Definition="The type of professional development activity is Person-to-Person.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("d6210b82-ac44-46b5-be34-02359963e346"), Code="TechnicalAssistance", Description="Technical Assistance", Definition="The type of professional development activity is Technical Assistance.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("39b97ef3-ff7c-435a-ad87-2e985dd4d6d8"), Code="Advisement", Description="Advisement", Definition="The type of professional development activity is Advisement.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("fd139228-7fef-463a-87f3-7c51a2bfa811"), Code="OneTimeWorkshopTraining", Description="One-time Workshop Training", Definition="The type of professional development activity is One-time Workshop Training.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("b2c00856-ed1b-420c-b2ba-d640abda1ca9"), Code="SeriesOfWorkshopsTraining", Description="Series of Workshops Training", Definition="The type of professional development activity is Series of Workshops Training.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("d7722edd-1b21-4c42-8578-0817d8446a4e"), Code="Other", Description="Other", Definition="The type of professional development activity is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };
        #endregion

        #region RefPDAudienceType List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefPDAudienceTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("c253a1c2-c4ba-4a53-b43d-466d5851be84"), Code="Individual", Description="Individual", Definition="The professional development activity is intended for delivery to an individual.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("3783917f-6cc8-4c62-b4b6-3f70ca9b8af0"), Code="Group", Description="Group", Definition="The professional development activity is intended for delivery to a group.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefProfessionalDevelopmentFinancialSupport List
        /// <summary>
        /// The complete Professional Development Activity Code List
        /// </summary>
        private static List<ReferenceModelBase> RefProfessionalDevelopmentFinancialSupportList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("969be26d-3571-40c9-a785-ad7a9ff5ed97"), Code="01", Description="One time non-credit", Definition="One time financial assistance received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("6f535842-ddea-4552-a03a-90963bc46d95"), Code="02", Description="One time credit paid", Definition="One time credit paid in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("27a4b191-7aab-4c67-b947-73a91a637bab"), Code="03", Description="On-going non-credit paid", Definition="On-going non-credit paid in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("918989ca-d0a7-4b73-a378-85f595fdd515"), Code="04", Description="On-going credit paid", Definition="On-going credit paid in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("5eea0935-7c36-42c1-bc55-43bf288d145f"), Code="05", Description="Salary bonus", Definition="Salary bonus received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("4b4c4fa5-3910-4979-8851-4e94c6071981"), Code="06", Description="Wage enhancement", Definition="Wage enhancement received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("1cc9f0a4-a2fc-47a4-bc43-0227c9014cd8"), Code="07", Description="Tuition reimbursement", Definition="Tuition reimbursement received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("55fd0eb6-2b81-49ba-a234-a84ca7b2b24a"), Code="08", Description="Travel child care", Definition="Travel child care received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("8f6bb3ce-f802-4e5b-b0a3-c4b3db59feb1"), Code="09", Description="Release time", Definition="Release time received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("d00daff9-bd9f-485c-8534-6fec9c9bce01"), Code="10", Description="Scholarship", Definition="Scholarship received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("12ecda2f-3b61-405c-b2b8-1a364b7966bb"), Code="11", Description="Loan", Definition="Loan received in support of the non-credit professional development activity.", SortOrder=Convert.ToDecimal("11.00") },
        };
        #endregion
    }
}
