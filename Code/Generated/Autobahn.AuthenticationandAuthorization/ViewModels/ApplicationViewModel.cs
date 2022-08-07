//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   ApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.AuthenticationandAuthorization.ViewModels
{
     /// <summary>
     /// The ApplicationViewModel
     /// </summary>
    public partial class ApplicationViewModel : ViewModelBase, Interfaces.IApplicationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Application";

        // member variable for the Name property
        private System.String _Name;

        // member variable for the Uri property
        private System.String _Uri;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.String Uri  { get => _Uri; set => SetProperty(ref _Uri, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name;
            Uri = model.Uri;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
