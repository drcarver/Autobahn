//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAidApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The FinancialAidApplicationViewModel
     /// </summary>
    public partial class FinancialAidApplicationViewModel : ViewModelBase, Interfaces.IFinancialAidApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAidApplication";

        // member variable for the FinancialAidYearDesignator property
        private  _FinancialAidYearDesignator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefFinancialAidApplicationTypeId property
        private Guid? _RefFinancialAidApplicationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

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
        /// Reference to an optional instance of the <see cref="RefFinancialAidApplicationType"/> model
        /// </summary>
        public Guid? RefFinancialAidApplicationTypeId { get => _RefFinancialAidApplicationTypeId; set => SetProperty(ref _RefFinancialAidApplicationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAidApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            FinancialAidYearDesignator = model.FinancialAidYearDesignator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefFinancialAidApplicationTypeId = model.RefFinancialAidApplicationTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
