//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentFinancialAidViewModel
     /// </summary>
    public partial class PsStudentFinancialAidViewModel : ViewModelBase, Interfaces.IPsStudentFinancialAid
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentFinancialAid";

        // member variable for the FinancialAidApplicant property
        private System.Boolean? _FinancialAidApplicant;

        // member variable for the FinancialAidIncomeLevel property
        private System.Decimal? _FinancialAidIncomeLevel;

        // member variable for the FinancialNeed property
        private System.Decimal? _FinancialNeed;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefFinancialAidVeteransBenefitStatusId property
        private Guid? _RefFinancialAidVeteransBenefitStatusId;

        // member variable for the RefFinancialAidVeteransBenefitTypeId property
        private Guid? _RefFinancialAidVeteransBenefitTypeId;

        // member variable for the RefNeedDeterminationMethodId property
        private Guid? _RefNeedDeterminationMethodId;

        // member variable for the TitleIVParticipantAndRecipient property
        private System.Boolean? _TitleIVParticipantAndRecipient;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentFinancialAidViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public System.Boolean? FinancialAidApplicant { get => _FinancialAidApplicant; set => SetProperty(ref _FinancialAidApplicant, value); }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public System.Decimal? FinancialAidIncomeLevel { get => _FinancialAidIncomeLevel; set => SetProperty(ref _FinancialAidIncomeLevel, value); }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// </summary>
        public System.Decimal? FinancialNeed { get => _FinancialNeed; set => SetProperty(ref _FinancialNeed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitStatus"/> model
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitStatusId { get => _RefFinancialAidVeteransBenefitStatusId; set => SetProperty(ref _RefFinancialAidVeteransBenefitStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitType"/> model
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitTypeId { get => _RefFinancialAidVeteransBenefitTypeId; set => SetProperty(ref _RefFinancialAidVeteransBenefitTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeedDeterminationMethod"/> model
        /// </summary>
        public Guid? RefNeedDeterminationMethodId { get => _RefNeedDeterminationMethodId; set => SetProperty(ref _RefNeedDeterminationMethodId, value); }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
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
            FinancialAidApplicant = model.FinancialAidApplicant;
            FinancialAidIncomeLevel = model.FinancialAidIncomeLevel;
            FinancialNeed = model.FinancialNeed;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefFinancialAidVeteransBenefitStatusId = model.RefFinancialAidVeteransBenefitStatusId;
            RefFinancialAidVeteransBenefitTypeId = model.RefFinancialAidVeteransBenefitTypeId;
            RefNeedDeterminationMethodId = model.RefNeedDeterminationMethodId;
            TitleIVParticipantAndRecipient = model.TitleIVParticipantAndRecipient;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
