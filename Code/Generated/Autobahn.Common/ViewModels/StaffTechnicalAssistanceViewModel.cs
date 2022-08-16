//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffTechnicalAssistanceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffTechnicalAssistanceViewModel
     /// </summary>
    public partial class StaffTechnicalAssistanceViewModel : ViewModelBase, Interfaces.IStaffTechnicalAssistance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffTechnicalAssistance";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefTechnicalAssistanceDeliveryTypeId property
        private  _RefTechnicalAssistanceDeliveryTypeId;

        // member variable for the RefTechnicalAssistanceTypeId property
        private  _RefTechnicalAssistanceTypeId;

        // member variable for the TechnicalAssistanceApprovedInd property
        private Guid? _TechnicalAssistanceApprovedInd;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceDeliveryType"/> model
        /// </summary>
        public  RefTechnicalAssistanceDeliveryTypeId { get => _RefTechnicalAssistanceDeliveryTypeId; set => SetProperty(ref _RefTechnicalAssistanceDeliveryTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceType"/> model
        /// </summary>
        public  RefTechnicalAssistanceTypeId { get => _RefTechnicalAssistanceTypeId; set => SetProperty(ref _RefTechnicalAssistanceTypeId, value); }

        /// <summary>
        /// </summary>
        public Guid? TechnicalAssistanceApprovedInd { get => _TechnicalAssistanceApprovedInd; set => SetProperty(ref _TechnicalAssistanceApprovedInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffTechnicalAssistance model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefTechnicalAssistanceDeliveryTypeId = model.RefTechnicalAssistanceDeliveryTypeId; // 
            RefTechnicalAssistanceTypeId = model.RefTechnicalAssistanceTypeId; // 
            TechnicalAssistanceApprovedInd = model.TechnicalAssistanceApprovedInd; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
