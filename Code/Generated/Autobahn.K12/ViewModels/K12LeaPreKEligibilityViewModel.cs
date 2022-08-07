//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaPreKEligibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaPreKEligibilityViewModel
     /// </summary>
    public partial class K12LeaPreKEligibilityViewModel : ViewModelBase, Interfaces.IK12LeaPreKEligibilityViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaPreKEligibility";

        // member variable for the K12LEAPreKEligibilityId property
        private Guid _K12LEAPreKEligibilityId;

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // member variable for the RefPrekindergartenEligibilityId property
        private Guid _RefPrekindergartenEligibilityId;

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
        /// The title of the K12LeaPreKEligibilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEAPreKEligibilityId"/> model
        /// </summary>
        public Guid K12LEAPreKEligibilityId { get => _K12LEAPreKEligibilityId; set => SetProperty(ref _K12LEAPreKEligibilityId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LeaId"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPrekindergartenEligibilityId"/> model
        /// </summary>
        public Guid RefPrekindergartenEligibilityId { get => _RefPrekindergartenEligibilityId; set => SetProperty(ref _RefPrekindergartenEligibilityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaPreKEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LEAPreKEligibilityId = model.K12LEAPreKEligibilityId;
            K12LeaId = model.K12LeaId;
            RefPrekindergartenEligibilityId = model.RefPrekindergartenEligibilityId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
