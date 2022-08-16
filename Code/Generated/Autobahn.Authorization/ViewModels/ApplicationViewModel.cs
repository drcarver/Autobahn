//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ApplicationViewModel
     /// </summary>
    public partial class ApplicationViewModel : ViewModelBase, Interfaces.IApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Application";

        // member variable for the Name property
        private Guid? _Name;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the Uri property
        private  _Uri;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  Uri { get => _Uri; set => SetProperty(ref _Uri, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            Uri = model.Uri; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
