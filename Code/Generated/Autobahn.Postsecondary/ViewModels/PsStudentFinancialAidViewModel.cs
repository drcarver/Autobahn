//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentFinancialAid View Model
     /// </summary>
    public partial class PsStudentFinancialAidViewModel : ViewModelBase, Interfaces.IPsStudentFinancialAid
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentFinancialAid";

        // FinancialAidApplicant -- (backing property for Financial Aid Applicant)
        private System.Boolean? _FinancialAidApplicant;

        // FinancialAidIncomeLevel -- (backing property for Financial Aid Income Level)
        private System.Decimal? _FinancialAidIncomeLevel;

        // FinancialNeed -- (backing property for Financial Need)
        private System.Decimal? _FinancialNeed;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefFinancialAidVeteransBenefitStatusId -- (backing property for Financial Aid Veteran's Benefit Status)
        private Guid? _RefFinancialAidVeteransBenefitStatusId;

        // RefFinancialAidVeteransBenefitTypeId -- (backing property for Financial Aid Veteran's Benefit Type)
        private Guid? _RefFinancialAidVeteransBenefitTypeId;

        // RefNeedDeterminationMethodId -- (backing property for Financial Need Determination Methodology)
        private Guid? _RefNeedDeterminationMethodId;

        // TitleIVParticipantAndRecipient -- (backing property for Title IV Participant and Recipient)
        private System.Boolean? _TitleIVParticipantAndRecipient;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Financial Aid Applicant
        /// <para>
        /// Any applicant who submits any one of the institutionally required financial aid applications/forms, such as the  Free Application for Federal Student Aid (FAFSA).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19745">Financial Aid Applicant</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? FinancialAidApplicant { get => _FinancialAidApplicant; set => SetProperty(ref _FinancialAidApplicant, value); }

        /// <summary>
        /// Financial Aid Income Level
        /// <para>
        /// The income level of an individual that is used by an institution's financial aid office to determine an individual's Expected Family Contribution (EFC).  For dependent students this will include the parents' adjusted gross income and the student's adjusted gross income.  For independent students this will include the student's adjusted gross income.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20319">Financial Aid Income Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FinancialAidIncomeLevel { get => _FinancialAidIncomeLevel; set => SetProperty(ref _FinancialAidIncomeLevel, value); }

        /// <summary>
        /// Financial Need
        /// <para>
        /// The amount of financial need as determined by an institution using the federal methodology and/or your institution's own standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19747">Financial Need</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FinancialNeed { get => _FinancialNeed; set => SetProperty(ref _FinancialNeed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Financial Aid Veteran's Benefit Status
        /// <para>
        /// An indication of whether a person is receiving Veteran's benefits.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20588">Financial Aid Veteran's Benefit Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitStatusId { get => _RefFinancialAidVeteransBenefitStatusId; set => SetProperty(ref _RefFinancialAidVeteransBenefitStatusId, value); }

        /// <summary>
        /// Financial Aid Veteran's Benefit Type
        /// <para>
        /// The type of Veteran's benefits a person is receiving.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20589">Financial Aid Veteran's Benefit Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitTypeId { get => _RefFinancialAidVeteransBenefitTypeId; set => SetProperty(ref _RefFinancialAidVeteransBenefitTypeId, value); }

        /// <summary>
        /// Financial Need Determination Methodology
        /// <para>
        /// The methodology used to determine an individual's financial need.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20188">Financial Need Determination Methodology</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefNeedDeterminationMethodId { get => _RefNeedDeterminationMethodId; set => SetProperty(ref _RefNeedDeterminationMethodId, value); }

        /// <summary>
        /// Title IV Participant and Recipient
        /// <para>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19292">Title IV Participant and Recipient</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? TitleIVParticipantAndRecipient { get => _TitleIVParticipantAndRecipient; set => SetProperty(ref _TitleIVParticipantAndRecipient, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentFinancialAid model)
        {
            IsBusy = true;
            Id = model.Id;
            FinancialAidApplicant = model.FinancialAidApplicant; // Financial Aid Applicant
            FinancialAidIncomeLevel = model.FinancialAidIncomeLevel; // Financial Aid Income Level
            FinancialNeed = model.FinancialNeed; // Financial Need
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefFinancialAidVeteransBenefitStatusId = model.RefFinancialAidVeteransBenefitStatusId; // Financial Aid Veteran's Benefit Status
            RefFinancialAidVeteransBenefitTypeId = model.RefFinancialAidVeteransBenefitTypeId; // Financial Aid Veteran's Benefit Type
            RefNeedDeterminationMethodId = model.RefNeedDeterminationMethodId; // Financial Need Determination Methodology
            TitleIVParticipantAndRecipient = model.TitleIVParticipantAndRecipient; // Title IV Participant and Recipient
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefNeedDeterminationMethod List
        /// <summary>
        /// The complete <see cref="RefNeedDeterminationMethod"> List
        /// </summary>
        private static List<ReferenceModelBase> RefNeedDeterminationMethodList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ed05614e-bfb4-4aab-ab39-54d1fb9f023f"), Code="Federal", Description="Federal", Definition="Federal", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("109c49e7-c6b9-4adc-a70a-934b6d8bc70f"), Code="Institutional", Description="Institutional", Definition="Institutional", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion
    }
}
