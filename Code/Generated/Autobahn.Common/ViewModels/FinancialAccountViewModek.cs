//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccountViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAccountViewModel
     /// </summary>
    public partial class FinancialAccountViewModel : BindableBase, IFinancialAccount
    {
#region "Backing Fields"
        // member variable for the Name property
        private System.String _Name;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the AccountNumber property
        private System.String _AccountNumber;

        // member variable for the FinancialAccountNumber property
        private System.String _FinancialAccountNumber;

        // member variable for the FinancialExpenditureProjectReportingCode property
        private System.Decimal? _FinancialExpenditureProjectReportingCode;

        // member variable for the FederalProgramCode property
        private System.String _FederalProgramCode;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String AccountNumber  { get => _AccountNumber; set => SetProperty(ref _AccountNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountCategoryId"/> model
        /// </summary>
        public Guid? RefFinancialAccountCategoryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountFundClassificationId"/> model
        /// </summary>
        public Guid? RefFinancialAccountFundClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountProgramCodeId"/> model
        /// </summary>
        public Guid? RefFinancialAccountProgramCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountBalanceSheetCodeId"/> model
        /// </summary>
        public Guid? RefFinancialAccountBalanceSheetCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureFunctionCodeId"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureFunctionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureObjectCodeId"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureObjectCodeId { get; set; }

        public System.String FinancialAccountNumber  { get => _FinancialAccountNumber; set => SetProperty(ref _FinancialAccountNumber, value); }

        public System.Decimal? FinancialExpenditureProjectReportingCode { get => _FinancialExpenditureProjectReportingCode; set => SetProperty(ref _FinancialExpenditureProjectReportingCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureLevelOfInstructionCodeId"/> model
        /// </summary>
        public Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountRevenueCodeId"/> model
        /// </summary>
        public Guid? RefFinancialAccountRevenueCodeId { get; set; }

        public System.String FederalProgramCode  { get => _FederalProgramCode; set => SetProperty(ref _FederalProgramCode, value); }

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
        public void Load(IFinancialAccount model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name;
            Description = model.Description;
            AccountNumber = model.AccountNumber;
            RefFinancialAccountCategoryId = model.RefFinancialAccountCategoryId;
            RefFinancialAccountFundClassificationId = model.RefFinancialAccountFundClassificationId;
            RefFinancialAccountProgramCodeId = model.RefFinancialAccountProgramCodeId;
            RefFinancialAccountBalanceSheetCodeId = model.RefFinancialAccountBalanceSheetCodeId;
            RefFinancialExpenditureFunctionCodeId = model.RefFinancialExpenditureFunctionCodeId;
            RefFinancialExpenditureObjectCodeId = model.RefFinancialExpenditureObjectCodeId;
            FinancialAccountNumber = model.FinancialAccountNumber;
            FinancialExpenditureProjectReportingCode = model.FinancialExpenditureProjectReportingCode;
            RefFinancialExpenditureLevelOfInstructionCodeId = model.RefFinancialExpenditureLevelOfInstructionCodeId;
            RefFinancialAccountRevenueCodeId = model.RefFinancialAccountRevenueCodeId;
            FederalProgramCode = model.FederalProgramCode;
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
