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
            new ReferenceModelBase { Id=Guid.Parse("a46681fb-c557-4c18-9f69-c330ec741956"), Code="HighSchoolDiploma", Description="Graduated with regular high school diploma", Definition="Graduated with regular high school diploma is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("0ad741bb-7fb6-4489-bb10-8716eb50a077"), Code="ReceivedCertificate", Description="Received a certificate", Definition="Received a certificate is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("1c8e67b4-f1c1-4b88-b2b2-b42a847afc53"), Code="ReachedMaximumAge", Description="Reached maximum age", Definition="Reached maximum age is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("e8e77e48-b9ff-4f42-8bd0-314efa6b3ab1"), Code="Died", Description="Died", Definition="Died is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("183caf23-19fa-4591-a943-e33e7e58dba0"), Code="MovedAndContinuing", Description="Moved, known to be continuing", Definition="Moved, known to be continuing is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("55ff2394-cf2a-4e93-96f8-664a8990d488"), Code="DroppedOut", Description="Dropped out", Definition="Dropped out is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("e1c28c09-d843-4f37-bc4b-12b36f386b33"), Code="Transferred", Description="Transferred to regular education", Definition="Transferred to regular education is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("3f67bb33-0f45-463b-a003-0de67d553e55"), Code="PartCNoLongerEligible", Description="No longer eligible for Part C prior to reaching age three.", Definition="No longer eligible for Part C prior to reaching age three  is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("848ae514-12fa-4453-8a04-e4dd86b77e85"), Code="PartBEligibleExitingPartC", Description="Part B eligible, exiting Part C.", Definition="Part B eligible, exiting Part C is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("322a2052-4c93-42e4-a24b-ef1e404f1f9e"), Code="PartBEligibleContinuingPartC", Description="Part B eligible, continuing in Part C.", Definition="Part B eligible, continuing in Part C is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("0b3f9642-9036-4aaa-bfea-e682356ca014"), Code="NotPartBEligibleExitingPartCWithReferrrals", Description="Not eligible for Part B, exit with referrals to other programs.", Definition="Not eligible for Part B, exit with referrals to other programs is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("d33ef643-6be1-4b3e-b779-73984d0b0a7e"), Code="NotPartBEligibleExitingPartCWithoutReferrrals", Description="Not eligible for Part B, exit with no referrals.", Definition="Not eligible for Part B, exit with no referrals is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("03b7b856-4752-4dd9-a5a4-f11fc03a1efc"), Code="PartBEligibilityNotDeterminedExitingPartC", Description="Part B eligibility not determined.", Definition="Part B eligibility not determined is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("eaeccaa8-24a7-4602-ae7a-c79990fba9bd"), Code="WithdrawalByParent", Description="Withdrawal by parent (or guardian).", Definition="Withdrawal by parent (or guardian) is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("0f139eef-c2be-4e7c-b6b7-4b88d1be5e76"), Code="MovedOutOfState", Description="Moved out of State", Definition="Moved out of State is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("7517bfd6-c207-4907-9c8f-a69f561b2800"), Code="Unreachable", Description="Attempts to contact the parent and/or child were unsuccessful.", Definition="Attempts to contact the parent and/or child were unsuccessful is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("ce703fcd-4577-4e69-833b-d6237f407aee"), Code="GraduatedAlternateDiploma", Description="Graduated with an alternate diploma", Definition="Graduated with an alternate diploma is the reason the child who was in special education at the start of the reporting period was not in special education at the end of the reporting period.", SortOrder=Convert.ToDecimal("26.00") },
        };
        #endregion
    }
}
