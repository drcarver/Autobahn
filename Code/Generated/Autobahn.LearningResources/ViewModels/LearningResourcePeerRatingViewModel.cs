//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePeerRatingViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourcePeerRating View Model
     /// </summary>
    public partial class LearningResourcePeerRatingViewModel : ViewModelBase, Interfaces.ILearningResourcePeerRating
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourcePeerRating";

        // Date -- (backing property for Peer Rating Date)
        private System.DateTime? _Date;

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // member variable for the PeerRatingSystemId property
        private Guid _PeerRatingSystemId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // Value -- (backing property for Learning Resource Peer Rating Value)
        private System.Decimal? _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Peer Rating Date
        /// <para>
        /// The date on which the Peer Rating was entered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20171">Peer Rating Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? Date { get => _Date; set => SetProperty(ref _Date, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPeerRatingSystem"/> model
        /// </summary>
        public Guid PeerRatingSystemId { get => _PeerRatingSystemId; set => SetProperty(ref _PeerRatingSystemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Learning Resource Peer Rating Value
        /// <para>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20161">Learning Resource Peer Rating Value</a>
        /// </para>
        /// </summary>
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
            Date = model.Date; // Peer Rating Date
            LearningResourceId = model.LearningResourceId; // 
            PeerRatingSystemId = model.PeerRatingSystemId; // 
            PersonId = model.PersonId; // 
            Value = model.Value; // Learning Resource Peer Rating Value
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
