//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   LearningResourcePeerRatingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResource.ViewModels
{
     /// <summary>
     /// The LearningResourcePeerRatingViewModel
     /// </summary>
    public partial class LearningResourcePeerRatingViewModel : ViewModelBase, Interfaces.ILearningResourcePeerRatingViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourcePeerRating";

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PeerRatingSystemId property
        private Guid _PeerRatingSystemId;

        // member variable for the Value property
        private System.Decimal? _Value;

        // member variable for the Date property
        private System.DateTime? _Date;

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
        /// The title of the LearningResourcePeerRatingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PeerRatingSystemId"/> model
        /// </summary>
        public Guid PeerRatingSystemId { get => _PeerRatingSystemId; set => SetProperty(ref _PeerRatingSystemId, value); }

        public System.Decimal? Value { get => _Value; set => SetProperty(ref _Value, value); }

        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourcePeerRating model)
        {
            IsBusy = true;
            Id = model.Id;
            LearningResourceId = model.LearningResourceId;
            PersonId = model.PersonId;
            PeerRatingSystemId = model.PeerRatingSystemId;
            Value = model.Value;
            Date = model.Date;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
