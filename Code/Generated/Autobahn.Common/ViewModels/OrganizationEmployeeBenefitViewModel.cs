//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmployeeBenefitViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmployeeBenefitViewModel
     /// </summary>
    public partial class OrganizationEmployeeBenefitViewModel : ViewModelBase, Interfaces.IOrganizationEmployeeBenefit
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationEmployeeBenefit";

        // member variable for the FullTimeBenefitIndicator property
        private Guid? _FullTimeBenefitIndicator;

        // member variable for the PartTimeBenefitIndicator property
        private  _PartTimeBenefitIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefEmployeeBenefitId property
        private  _RefEmployeeBenefitId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? FullTimeBenefitIndicator { get => _FullTimeBenefitIndicator; set => SetProperty(ref _FullTimeBenefitIndicator, value); }

        /// <summary>
        /// </summary>
        public  PartTimeBenefitIndicator { get => _PartTimeBenefitIndicator; set => SetProperty(ref _PartTimeBenefitIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployeeBenefit"/> model
        /// </summary>
        public  RefEmployeeBenefitId { get => _RefEmployeeBenefitId; set => SetProperty(ref _RefEmployeeBenefitId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationEmployeeBenefit model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeBenefitIndicator = model.FullTimeBenefitIndicator; // 
            PartTimeBenefitIndicator = model.PartTimeBenefitIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEmployeeBenefitId = model.RefEmployeeBenefitId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
