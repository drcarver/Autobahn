//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePeerRatingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourcePeerRatingViewModel
     /// </summary>
    public partial class LearningResourcePeerRatingViewModel : ViewModelBase, Interfaces.ILearningResourcePeerRating
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourcePeerRating";

        // member variable for the Date property
        private System.DateTime? _Date;

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // member variable for the PeerRatingSystemId property
        private Guid _PeerRatingSystemId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the Value property
        private System.Decimal? _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourcePeerRatingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PeerRatingSystem"/> model
        /// </summary>
        public Guid PeerRatingSystemId { get => _PeerRatingSystemId; set => SetProperty(ref _PeerRatingSystemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </summary>
        public System.Decimal? Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourcePeerRating model)
        {
            IsBusy = true;
            Id = model.Id;
            Date = model.Date;
            LearningResourceId = model.LearningResourceId;
            PeerRatingSystemId = model.PeerRatingSystemId;
            PersonId = model.PersonId;
            Value = model.Value;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
