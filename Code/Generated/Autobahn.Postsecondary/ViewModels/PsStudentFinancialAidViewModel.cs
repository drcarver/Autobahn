//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _FinancialAidApplicant;

        // member variable for the FinancialAidIncomeLevel property
        private  _FinancialAidIncomeLevel;

        // member variable for the FinancialNeed property
        private  _FinancialNeed;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFinancialAidVeteransBenefitStatusId property
        private  _RefFinancialAidVeteransBenefitStatusId;

        // member variable for the RefFinancialAidVeteransBenefitTypeId property
        private  _RefFinancialAidVeteransBenefitTypeId;

        // member variable for the RefNeedDeterminationMethodId property
        private  _RefNeedDeterminationMethodId;

        // member variable for the TitleIVParticipantAndRecipient property
        private Guid? _TitleIVParticipantAndRecipient;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FinancialAidApplicant { get => _FinancialAidApplicant; set => SetProperty(ref _FinancialAidApplicant, value); }

        /// <summary>
        /// </summary>
        public  FinancialAidIncomeLevel { get => _FinancialAidIncomeLevel; set => SetProperty(ref _FinancialAidIncomeLevel, value); }

        /// <summary>
        /// </summary>
        public  FinancialNeed { get => _FinancialNeed; set => SetProperty(ref _FinancialNeed, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitStatus"/> model
        /// </summary>
        public  RefFinancialAidVeteransBenefitStatusId { get => _RefFinancialAidVeteransBenefitStatusId; set => SetProperty(ref _RefFinancialAidVeteransBenefitStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidVeteransBenefitType"/> model
        /// </summary>
        public  RefFinancialAidVeteransBenefitTypeId { get => _RefFinancialAidVeteransBenefitTypeId; set => SetProperty(ref _RefFinancialAidVeteransBenefitTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeedDeterminationMethod"/> model
        /// </summary>
        public  RefNeedDeterminationMethodId { get => _RefNeedDeterminationMethodId; set => SetProperty(ref _RefNeedDeterminationMethodId, value); }

        /// <summary>
        /// </summary>
        public Guid? TitleIVParticipantAndRecipient { get => _TitleIVParticipantAndRecipient; set => SetProperty(ref _TitleIVParticipantAndRecipient, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentFinancialAid model)
        {
            IsBusy = true;
            Id = model.Id;
            FinancialAidApplicant = model.FinancialAidApplicant; // 
            FinancialAidIncomeLevel = model.FinancialAidIncomeLevel; // 
            FinancialNeed = model.FinancialNeed; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFinancialAidVeteransBenefitStatusId = model.RefFinancialAidVeteransBenefitStatusId; // 
            RefFinancialAidVeteransBenefitTypeId = model.RefFinancialAidVeteransBenefitTypeId; // 
            RefNeedDeterminationMethodId = model.RefNeedDeterminationMethodId; // 
            TitleIVParticipantAndRecipient = model.TitleIVParticipantAndRecipient; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
