//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaGradeLevelsApprovedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaGradeLevelsApprovedViewModel
     /// </summary>
    public partial class K12LeaGradeLevelsApprovedViewModel : ViewModelBase, Interfaces.IK12LeaGradeLevelsApproved
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaGradeLevelsApproved";

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // member variable for the RefGradeLevelId property
        private Guid _RefGradeLevelId;

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
        /// The title of the K12LeaGradeLevelsApprovedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LeaId"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevelId"/> model
        /// </summary>
        public Guid RefGradeLevelId { get => _RefGradeLevelId; set => SetProperty(ref _RefGradeLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaGradeLevelsApproved model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LeaId = model.K12LeaId;
            RefGradeLevelId = model.RefGradeLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
