//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationSpecialEducationViewModel.cs
//* Name:       Awaiting Initial IDEA Evaluation Status
//* Definition: Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
     /// </summary>
    public partial class ProgramParticipationSpecialEducationViewModel : ViewModelBase, Interfaces.IProgramParticipationSpecialEducation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationSpecialEducation";

        // AwaitingInitialIDEAEvaluationStatus -- (backing property for Awaiting Initial IDEA Evaluation Status)
        private System.Boolean? _AwaitingInitialIDEAEvaluationStatus;

        // IDEAPlacementRationale -- (backing property for IDEA Placement Rationale)
        private System.String _IDEAPlacementRationale;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // RefIDEAEducationalEnvironmentECId -- (backing property for IDEA Educational Environment for Early Childhood)
        private Guid? _RefIDEAEducationalEnvironmentECId;

        // RefIDEAEducationalEnvironmentSchoolAgeId -- (backing property for IDEA Educational Environment for School Age)
        private Guid? _RefIDEAEducationalEnvironmentSchoolAgeId;

        // RefSpecialEducationExitReasonId -- (backing property for Special Education Exit Reason)
        private Guid? _RefSpecialEducationExitReasonId;

        // SpecialEducationFTE -- (backing property for Special Education Full Time Equivalency)
        private System.Decimal? _SpecialEducationFTE;

        // SpecialEducationServicesExitDate -- (backing property for Special Education Services Exit Date)
        private System.DateTime? _SpecialEducationServicesExitDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Awaiting Initial IDEA Evaluation Status
        /// <para>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19031">Awaiting Initial IDEA Evaluation Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AwaitingInitialIDEAEvaluationStatus { get => _AwaitingInitialIDEAEvaluationStatus; set => SetProperty(ref _AwaitingInitialIDEAEvaluationStatus, value); }

        /// <summary>
        /// IDEA Placement Rationale
        /// <para>
        /// The rationale for the placement decision and if applicable, an explanation of the extent, if any, to which the child will not participate with nondisabled children in the regular class and in the activities described in paragraph (a)(4) of CFR. 300.320.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20685">IDEA Placement Rationale</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String IDEAPlacementRationale { get => _IDEAPlacementRationale; set => SetProperty(ref _IDEAPlacementRationale, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// IDEA Educational Environment for Early Childhood
        /// <para>
        /// The program in which children ages 3 through 5 attend and in which these children receive special education and related services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19550">IDEA Educational Environment for Early Childhood</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentECId { get => _RefIDEAEducationalEnvironmentECId; set => SetProperty(ref _RefIDEAEducationalEnvironmentECId, value); }

        /// <summary>
        /// IDEA Educational Environment for School Age
        /// <para>
        /// The setting in which children ages 6 through 21, receive special education and related services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19526">IDEA Educational Environment for School Age</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIDEAEducationalEnvironmentSchoolAgeId { get => _RefIDEAEducationalEnvironmentSchoolAgeId; set => SetProperty(ref _RefIDEAEducationalEnvironmentSchoolAgeId, value); }

        /// <summary>
        /// Special Education Exit Reason
        /// <para>
        /// The reason children who were in special education at the start of the reporting period were not in special education at the end of the reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19260">Special Education Exit Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefSpecialEducationExitReasonId { get => _RefSpecialEducationExitReasonId; set => SetProperty(ref _RefSpecialEducationExitReasonId, value); }

        /// <summary>
        /// Special Education Full Time Equivalency
        /// <para>
        /// Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20208">Special Education Full Time Equivalency</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? SpecialEducationFTE { get => _SpecialEducationFTE; set => SetProperty(ref _SpecialEducationFTE, value); }

        /// <summary>
        /// Special Education Services Exit Date
        /// <para>
        /// The year, month and day a child with disabilities (IDEA) ages 14 through 21 exited special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19263">Special Education Services Exit Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? SpecialEducationServicesExitDate { get => _SpecialEducationServicesExitDate; set => SetProperty(ref _SpecialEducationServicesExitDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationSpecialEducation model)
        {
            IsBusy = true;
            Id = model.Id;
            AwaitingInitialIDEAEvaluationStatus = model.AwaitingInitialIDEAEvaluationStatus; // Awaiting Initial IDEA Evaluation Status
            IDEAPlacementRationale = model.IDEAPlacementRationale; // IDEA Placement Rationale
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            RefIDEAEducationalEnvironmentECId = model.RefIDEAEducationalEnvironmentECId; // IDEA Educational Environment for Early Childhood
            RefIDEAEducationalEnvironmentSchoolAgeId = model.RefIDEAEducationalEnvironmentSchoolAgeId; // IDEA Educational Environment for School Age
            RefSpecialEducationExitReasonId = model.RefSpecialEducationExitReasonId; // Special Education Exit Reason
            SpecialEducationFTE = model.SpecialEducationFTE; // Special Education Full Time Equivalency
            SpecialEducationServicesExitDate = model.SpecialEducationServicesExitDate; // Special Education Services Exit Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefSpecialEducationExitReason List
        /// <summary>
        /// The complete Awaiting Initial IDEA Evaluation Status List
        /// </summary>
        private static List<ReferenceModelBase> RefSpecialEducationExitReasonList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("d8a61e4d-5aad-4fe3-bd06-22dd50399253"), Code="HighSchoolDiploma", Description="Graduated with regular high school diploma", Definition="Graduated with regular high school diploma is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("f3a4f2dc-2a41-47b2-ba9a-273a68c23346"), Code="ReceivedCertificate", Description="Received a certificate", Definition="Received a certificate is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("9b78c971-78df-4e64-b77f-083424148796"), Code="ReachedMaximumAge", Description="Reached maximum age", Definition="Reached maximum age is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("8599a88b-ad8c-4bc7-9653-42827fba03d1"), Code="Died", Description="Died", Definition="Died is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("049d8e95-877f-4503-aba0-cabd8cd721cf"), Code="MovedAndContinuing", Description="Moved, known to be continuing", Definition="Moved, known to be continuing is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("051da343-667a-4315-b3b1-baf8ddbd13c5"), Code="DroppedOut", Description="Dropped out", Definition="Dropped out is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("095e9fd7-b880-43ba-8cce-0cde66c4d745"), Code="Transferred", Description="Transferred to regular education", Definition="Transferred to regular education is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("3314ad80-a3c6-4680-ae9a-6f55e4d3c283"), Code="PartCNoLongerEligible", Description="No longer eligible for Part C prior to reaching age three.", Definition="No longer eligible for Part C prior to reaching age three  is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("960cd3b0-3138-4a38-bbdb-ee8f2525838d"), Code="PartBEligibleExitingPartC", Description="Part B eligible, exiting Part C.", Definition="Part B eligible, exiting Part C is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("67823060-8065-4b52-a2b9-dd4aff6a9e78"), Code="PartBEligibleContinuingPartC", Description="Part B eligible, continuing in Part C.", Definition="Part B eligible, continuing in Part C is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("64a1e7aa-06b5-4581-9d68-7b7fbbc353b9"), Code="NotPartBEligibleExitingPartCWithReferrrals", Description="Not eligible for Part B, exit with referrals to other programs.", Definition="Not eligible for Part B, exit with referrals to other programs is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("9ce659b5-dda8-408a-b542-453b63903af0"), Code="NotPartBEligibleExitingPartCWithoutReferrrals", Description="Not eligible for Part B, exit with no referrals.", Definition="Not eligible for Part B, exit with no referrals is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("13315672-4afc-4159-8fd9-04b76526b684"), Code="PartBEligibilityNotDeterminedExitingPartC", Description="Part B eligibility not determined.", Definition="Part B eligibility not determined is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("610c42dc-b264-486a-ac00-9fbd195b1963"), Code="WithdrawalByParent", Description="Withdrawal by parent (or guardian).", Definition="Withdrawal by parent (or guardian) is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d1e6382-a148-4c24-9e8c-45c9ec70df14"), Code="MovedOutOfState", Description="Moved out of State", Definition="Moved out of State is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("3b1a7e23-56d7-4832-9754-15bc7721966c"), Code="Unreachable", Description="Attempts to contact the parent and/or child were unsuccessful.", Definition="Attempts to contact the parent and/or child were unsuccessful is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("c3f26cbe-9ce6-42eb-b845-6e25dda7aab3"), Code="GraduatedAlternateDiploma", Description="Graduated with an alternate diploma", Definition="Graduated with an alternate diploma is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("26.00") },
        };
        #endregion
    }
}
