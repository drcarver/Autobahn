//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceProvidedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ServiceProvidedViewModel
     /// </summary>
    public partial class ServiceProvidedViewModel : ViewModelBase, Interfaces.IServiceProvided
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceProvided";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefServicesId property
        private  _RefServicesId;

        // member variable for the RefStudentSupportServiceTypeId property
        private Guid? _RefStudentSupportServiceTypeId;

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
        /// Reference to an optional instance of the <see cref="RefServices"/> model
        /// </summary>
        public  RefServicesId { get => _RefServicesId; set => SetProperty(ref _RefServicesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceProvided model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefServicesId = model.RefServicesId; // 
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
