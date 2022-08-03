//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentFinancialAidViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentFinancialAidViewModel
     /// </summary>
    public partial class PsStudentFinancialAidViewModel : BindableBase, IPsStudentFinancialAid
    {
#region "Backing Fields"
        // member variable for the FinancialAidApplicant property
        private System.Boolean? _FinancialAidApplicant;

        // member variable for the FinancialNeed property
        private System.Decimal? _FinancialNeed;

        // member variable for the TitleIVParticipantAndRecipient property
        private System.Boolean? _TitleIVParticipantAndRecipient;

        // member variable for the FinancialAidIncomeLevel property
        private System.Decimal? _FinancialAidIncomeLevel;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.Boolean? FinancialAidApplicant { get => _FinancialAidApplicant; set => SetProperty(ref _FinancialAidApplicant, value); }

        public System.Decimal? FinancialNeed { get => _FinancialNeed; set => SetProperty(ref _FinancialNeed, value); }

        public System.Boolean? TitleIVParticipantAndRecipient { get => _TitleIVParticipantAndRecipient; set => SetProperty(ref _TitleIVParticipantAndRecipient, value); }

        public System.Decimal? FinancialAidIncomeLevel { get => _FinancialAidIncomeLevel; set => SetProperty(ref _FinancialAidIncomeLevel, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeedDeterminationMethodId"/> model
        /// </summary>
        public Guid? RefNeedDeterminationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitStatusId"/> model
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitTypeId"/> model
        /// </summary>
        public Guid? RefFinancialAidVeteransBenefitTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IPsStudentFinancialAid model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
