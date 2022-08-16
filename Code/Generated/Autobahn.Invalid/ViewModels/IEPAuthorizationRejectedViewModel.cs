//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPAuthorizationRejectedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IEPAuthorizationRejectedViewModel
     /// </summary>
    public partial class IEPAuthorizationRejectedViewModel : ViewModelBase, Interfaces.IIEPAuthorizationRejected
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPAuthorizationRejected";

        // member variable for the PortionDescription property
        private Guid? _PortionDescription;

        // member variable for the PortionExplanation property
        private  _PortionExplanation;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? PortionDescription { get => _PortionDescription; set => SetProperty(ref _PortionDescription, value); }

        /// <summary>
        /// </summary>
        public  PortionExplanation { get => _PortionExplanation; set => SetProperty(ref _PortionExplanation, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPAuthorizationRejected model)
        {
            IsBusy = true;
            Id = model.Id;
            PortionDescription = model.PortionDescription; // 
            PortionExplanation = model.PortionExplanation; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
