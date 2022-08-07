//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentFinancialAidViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentFinancialAidViewModel
     /// </summary>
    public partial class PsStudentFinancialAidViewModel : ViewModelBase, Interfaces.IPsStudentFinancialAidViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentFinancialAid";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the FinancialAidApplicant property
        private System.Boolean? _FinancialAidApplicant;

        // member variable for the FinancialNeed property
        private System.Decimal? _FinancialNeed;

        // member variable for the TitleIVParticipantAndRecipient property
        private System.Boolean? _TitleIVParticipantAndRecipient;

        // member variable for the FinancialAidIncomeLevel property
        private System.Decimal? _FinancialAidIncomeLevel;

        // member variable for the RefNeedDeterminationMethodId property
        private Guid? _RefNeedDeterminationMethodId;

        // member variable for the RefFinancialAidVeteransBenefitStatusId property
        private Guid? _RefFinancialAidVeteransBenefitStatusId;

        // member variable for the RefFinancialAidVeteransBenefitTypeId property
        private Guid? _RefFinancialAidVeteransBenefitTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentFinancialAidViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Boolean? FinancialAidApplicant { get => _FinancialAidApplicant; set => SetProperty(ref _FinancialAidApplicant, value); }

        public System.Decimal? FinancialNeed { get => _FinancialNeed; set => SetProperty(ref _FinancialNeed, value); }

        public System.Boolean? TitleIVParticipantAndRecipient { get => _TitleIVParticipantAndRecipient; set => SetProperty(ref _TitleIVParticipantAndRecipient, value); }

        public System.Decimal? FinancialAidIncomeLevel { get => _FinancialAidIncomeLevel; set => SetProperty(ref _FinancialAidIncomeLevel, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeedDeterminationMethodId"/> model
        /// </summary>
        public Guid? RefNeedDeterminationMethodId { get => _RefNeedDeterminationMethodId; set => SetProperty(ref _RefNeedDeterminationMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitStatusId"/> model
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitStatusId { get => _RefFinancialAidVeteransBenefitStatusId; set => SetProperty(ref _RefFinancialAidVeteransBenefitStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitTypeId"/> model
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitTypeId { get => _RefFinancialAidVeteransBenefitTypeId; set => SetProperty(ref _RefFinancialAidVeteransBenefitTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentFinancialAid model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            FinancialAidApplicant = model.FinancialAidApplicant;
            FinancialNeed = model.FinancialNeed;
            TitleIVParticipantAndRecipient = model.TitleIVParticipantAndRecipient;
            FinancialAidIncomeLevel = model.FinancialAidIncomeLevel;
            RefNeedDeterminationMethodId = model.RefNeedDeterminationMethodId;
            RefFinancialAidVeteransBenefitStatusId = model.RefFinancialAidVeteransBenefitStatusId;
            RefFinancialAidVeteransBenefitTypeId = model.RefFinancialAidVeteransBenefitTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
