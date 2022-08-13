//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildOutcomeSummaryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildOutcomeSummaryViewModel
     /// </summary>
    public partial class ELChildOutcomeSummaryViewModel : ViewModelBase, Interfaces.IELChildOutcomeSummary
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildOutcomeSummary";

        // member variable for the COSProgressAIndicator property
        private System.Boolean? _COSProgressAIndicator;

        // member variable for the COSProgressBIndicator property
        private System.Boolean? _COSProgressBIndicator;

        // member variable for the COSProgressCIndicator property
        private System.Boolean? _COSProgressCIndicator;

        // member variable for the COSRatingAId property
        private Guid? _COSRatingAId;

        // member variable for the COSRatingBId property
        private Guid? _COSRatingBId;

        // member variable for the COSRatingCId property
        private Guid? _COSRatingCId;

        // member variable for the PersonId property
        private Guid _PersonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildOutcomeSummaryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public System.Boolean? COSProgressAIndicator { get => _COSProgressAIndicator; set => SetProperty(ref _COSProgressAIndicator, value); }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public System.Boolean? COSProgressBIndicator { get => _COSProgressBIndicator; set => SetProperty(ref _COSProgressBIndicator, value); }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public System.Boolean? COSProgressCIndicator { get => _COSProgressCIndicator; set => SetProperty(ref _COSProgressCIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="COSRatingA"/> model
        /// </summary>
        public Guid? COSRatingAId { get => _COSRatingAId; set => SetProperty(ref _COSRatingAId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="COSRatingB"/> model
        /// </summary>
        public Guid? COSRatingBId { get => _COSRatingBId; set => SetProperty(ref _COSRatingBId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="COSRatingC"/> model
        /// </summary>
        public Guid? COSRatingCId { get => _COSRatingCId; set => SetProperty(ref _COSRatingCId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildOutcomeSummary model)
        {
            IsBusy = true;
            Id = model.Id;
            COSProgressAIndicator = model.COSProgressAIndicator;
            COSProgressBIndicator = model.COSProgressBIndicator;
            COSProgressCIndicator = model.COSProgressCIndicator;
            COSRatingAId = model.COSRatingAId;
            COSRatingBId = model.COSRatingBId;
            COSRatingCId = model.COSRatingCId;
            PersonId = model.PersonId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
