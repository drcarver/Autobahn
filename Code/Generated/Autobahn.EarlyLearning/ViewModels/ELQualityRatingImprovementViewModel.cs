//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityRatingImprovementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the RefQrisParticipationId property
        private Guid? _RefQrisParticipationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELQualityRatingImprovementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefQrisParticipation"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19356">Quality Rating and Improvement System Participation</a>
        /// </para>
        /// </summary>
        [DisplayName("Quality Rating and Improvement System Participation")]
        public Guid? RefQrisParticipationId { get => _RefQrisParticipationId; set => SetProperty(ref _RefQrisParticipationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELQualityRatingImprovement model)
        {
            IsBusy = true;
            Id = model.Id;
            RefQrisParticipationId = model.RefQrisParticipationId; // Quality Rating and Improvement System Participation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
