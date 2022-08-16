//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAccountViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The FinancialAccountViewModel
     /// </summary>
    public partial class FinancialAccountViewModel : ViewModelBase, Interfaces.IFinancialAccount
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAccount";

        // member variable for the AccountNumber property
        private  _AccountNumber;

        // member variable for the Description property
        private  _Description;

        // member variable for the FinancialAccountNumber property
        private  _FinancialAccountNumber;

        // member variable for the FinancialExpenditureProjectReportingCode property
        private  _FinancialExpenditureProjectReportingCode;

        // member variable for the Name property
        private  _Name;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFinancialAccountBalanceSheetCodeId property
        private  _RefFinancialAccountBalanceSheetCodeId;

        // member variable for the RefFinancialAccountCategoryId property
        private Guid? _RefFinancialAccountCategoryId;

        // member variable for the RefFinancialAccountFundClassificationId property
        private  _RefFinancialAccountFundClassificationId;

        // member variable for the RefFinancialAccountProgramCodeId property
        private  _RefFinancialAccountProgramCodeId;

        // member variable for the RefFinancialAccountRevenueCodeId property
        private  _RefFinancialAccountRevenueCodeId;

        // member variable for the RefFinancialExpenditureFunctionCodeId property
        private  _RefFinancialExpenditureFunctionCodeId;

        // member variable for the RefFinancialExpenditureLevelOfInstructionCodeId property
        private  _RefFinancialExpenditureLevelOfInstructionCodeId;

        // member variable for the RefFinancialExpenditureObjectCodeId property
        private  _RefFinancialExpenditureObjectCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AccountNumber { get => _AccountNumber; set => SetProperty(ref _AccountNumber, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  FinancialAccountNumber { get => _FinancialAccountNumber; set => SetProperty(ref _FinancialAccountNumber, value); }

        /// <summary>
        /// </summary>
        public  FinancialExpenditureProjectReportingCode { get => _FinancialExpenditureProjectReportingCode; set => SetProperty(ref _FinancialExpenditureProjectReportingCode, value); }

        /// <summary>
        /// </summary>
        public  Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountBalanceSheetCode"/> model
        /// </summary>
        public  RefFinancialAccountBalanceSheetCodeId { get => _RefFinancialAccountBalanceSheetCodeId; set => SetProperty(ref _RefFinancialAccountBalanceSheetCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountCategory"/> model
        /// </summary>
        public Guid? RefFinancialAccountCategoryId { get => _RefFinancialAccountCategoryId; set => SetProperty(ref _RefFinancialAccountCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountFundClassification"/> model
        /// </summary>
        public  RefFinancialAccountFundClassificationId { get => _RefFinancialAccountFundClassificationId; set => SetProperty(ref _RefFinancialAccountFundClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountProgramCode"/> model
        /// </summary>
        public  RefFinancialAccountProgramCodeId { get => _RefFinancialAccountProgramCodeId; set => SetProperty(ref _RefFinancialAccountProgramCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAccountRevenueCode"/> model
        /// </summary>
        public  RefFinancialAccountRevenueCodeId { get => _RefFinancialAccountRevenueCodeId; set => SetProperty(ref _RefFinancialAccountRevenueCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureFunctionCode"/> model
        /// </summary>
        public  RefFinancialExpenditureFunctionCodeId { get => _RefFinancialExpenditureFunctionCodeId; set => SetProperty(ref _RefFinancialExpenditureFunctionCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureLevelOfInstructionCode"/> model
        /// </summary>
        public  RefFinancialExpenditureLevelOfInstructionCodeId { get => _RefFinancialExpenditureLevelOfInstructionCodeId; set => SetProperty(ref _RefFinancialExpenditureLevelOfInstructionCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialExpenditureObjectCode"/> model
        /// </summary>
        public  RefFinancialExpenditureObjectCodeId { get => _RefFinancialExpenditureObjectCodeId; set => SetProperty(ref _RefFinancialExpenditureObjectCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAccount model)
        {
            IsBusy = true;
            Id = model.Id;
            AccountNumber = model.AccountNumber; // 
            Description = model.Description; // 
            FinancialAccountNumber = model.FinancialAccountNumber; // 
            FinancialExpenditureProjectReportingCode = model.FinancialExpenditureProjectReportingCode; // 
            Name = model.Name; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFinancialAccountBalanceSheetCodeId = model.RefFinancialAccountBalanceSheetCodeId; // 
            RefFinancialAccountCategoryId = model.RefFinancialAccountCategoryId; // 
            RefFinancialAccountFundClassificationId = model.RefFinancialAccountFundClassificationId; // 
            RefFinancialAccountProgramCodeId = model.RefFinancialAccountProgramCodeId; // 
            RefFinancialAccountRevenueCodeId = model.RefFinancialAccountRevenueCodeId; // 
            RefFinancialExpenditureFunctionCodeId = model.RefFinancialExpenditureFunctionCodeId; // 
            RefFinancialExpenditureLevelOfInstructionCodeId = model.RefFinancialExpenditureLevelOfInstructionCodeId; // 
            RefFinancialExpenditureObjectCodeId = model.RefFinancialExpenditureObjectCodeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
