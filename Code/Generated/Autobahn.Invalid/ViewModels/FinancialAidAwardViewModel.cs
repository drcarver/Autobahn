//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAidAwardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The FinancialAidAwardViewModel
     /// </summary>
    public partial class FinancialAidAwardViewModel : ViewModelBase, Interfaces.IFinancialAidAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAidAward";

        // member variable for the FinancialAidAwardAmount property
        private Guid? _FinancialAidAwardAmount;

        // member variable for the FinancialAidYearDesignator property
        private  _FinancialAidYearDesignator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFinancialAidAwardTypeId property
        private  _RefFinancialAidAwardTypeId;

        // member variable for the RefFinancialAidStatusId property
        private  _RefFinancialAidStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? FinancialAidAwardAmount { get => _FinancialAidAwardAmount; set => SetProperty(ref _FinancialAidAwardAmount, value); }

        /// <summary>
        /// </summary>
        public  FinancialAidYearDesignator { get => _FinancialAidYearDesignator; set => SetProperty(ref _FinancialAidYearDesignator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidAwardType"/> model
        /// </summary>
        public  RefFinancialAidAwardTypeId { get => _RefFinancialAidAwardTypeId; set => SetProperty(ref _RefFinancialAidAwardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidStatus"/> model
        /// </summary>
        public  RefFinancialAidStatusId { get => _RefFinancialAidStatusId; set => SetProperty(ref _RefFinancialAidStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAidAward model)
        {
            IsBusy = true;
            Id = model.Id;
            FinancialAidAwardAmount = model.FinancialAidAwardAmount; // 
            FinancialAidYearDesignator = model.FinancialAidYearDesignator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFinancialAidAwardTypeId = model.RefFinancialAidAwardTypeId; // 
            RefFinancialAidStatusId = model.RefFinancialAidStatusId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
