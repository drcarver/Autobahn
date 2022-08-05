//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolCorrectiveActionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolCorrectiveActionViewModel
     /// </summary>
    public partial class K12SchoolCorrectiveActionViewModel : ViewModelBase, Interfaces.IK12SchoolCorrectiveAction
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolCorrectiveAction";

        // member variable for the K12SchoolId property
        private Guid _K12SchoolId;

        // member variable for the RefCorrectiveActionTypeId property
        private Guid _RefCorrectiveActionTypeId;

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
        /// The title of the K12SchoolCorrectiveActionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12SchoolId"/> model
        /// </summary>
        public Guid K12SchoolId { get => _K12SchoolId; set => SetProperty(ref _K12SchoolId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCorrectiveActionTypeId"/> model
        /// </summary>
        public Guid RefCorrectiveActionTypeId { get => _RefCorrectiveActionTypeId; set => SetProperty(ref _RefCorrectiveActionTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolCorrectiveAction model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId;
            RefCorrectiveActionTypeId = model.RefCorrectiveActionTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
