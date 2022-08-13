//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityRatingImprovementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELQualityRatingImprovementViewModel
     /// </summary>
    public partial class ELQualityRatingImprovementViewModel : ViewModelBase, Interfaces.IELQualityRatingImprovement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELQualityRatingImprovement";

        // member variable for the NumberQrisLevels property
        private System.Int32? _NumberQrisLevels;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the QrisAwardDate property
        private System.DateTime? _QrisAwardDate;

        // member variable for the QRISExpirationDate property
        private System.DateTime? _QRISExpirationDate;

        // member variable for the QrisScore property
        private System.String _QrisScore;

        // member variable for the RefQrisParticipationId property
        private Guid? _RefQrisParticipationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELQualityRatingImprovementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        public System.Int32? NumberQrisLevels { get => _NumberQrisLevels; set => SetProperty(ref _NumberQrisLevels, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        public System.DateTime? QrisAwardDate { get => _QrisAwardDate; set => SetProperty(ref _QrisAwardDate, value); }

        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        public System.DateTime? QRISExpirationDate { get => _QRISExpirationDate; set => SetProperty(ref _QRISExpirationDate, value); }

        /// <summary>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </summary>
        public System.String QrisScore { get => _QrisScore; set => SetProperty(ref _QrisScore, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQrisParticipation"/> model
        /// </summary>
        public Guid? RefQrisParticipationId { get => _RefQrisParticipationId; set => SetProperty(ref _RefQrisParticipationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELQualityRatingImprovement model)
        {
            IsBusy = true;
            Id = model.Id;
            NumberQrisLevels = model.NumberQrisLevels;
            OrganizationId = model.OrganizationId;
            QrisAwardDate = model.QrisAwardDate;
            QRISExpirationDate = model.QRISExpirationDate;
            QrisScore = model.QrisScore;
            RefQrisParticipationId = model.RefQrisParticipationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
