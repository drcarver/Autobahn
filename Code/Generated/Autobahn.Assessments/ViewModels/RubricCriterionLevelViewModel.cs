//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricCriterionLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The RubricCriterionLevelViewModel
     /// </summary>
    public partial class RubricCriterionLevelViewModel : ViewModelBase, Interfaces.IRubricCriterionLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RubricCriterionLevel";

        // member variable for the Feedback property
        private System.String _Feedback;

        // member variable for the Position property
        private System.Int32? _Position;

        // member variable for the Quality property
        private System.String _Quality;

        // member variable for the RubricCriterionId property
        private Guid _RubricCriterionId;

        // member variable for the Score property
        private System.Decimal? _Score;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RubricCriterionLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        public System.String Feedback { get => _Feedback; set => SetProperty(ref _Feedback, value); }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        public System.Int32? Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        public System.String Quality { get => _Quality; set => SetProperty(ref _Quality, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RubricCriterion"/> model
        /// </summary>
        public Guid RubricCriterionId { get => _RubricCriterionId; set => SetProperty(ref _RubricCriterionId, value); }

        /// <summary>
        /// Text describing  one or more benchmarks that must be met to achieve a degree of achievement on a product, process, or performance task.
        /// </summary>
        public System.Decimal? Score { get => _Score; set => SetProperty(ref _Score, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubricCriterionLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            Feedback = model.Feedback;
            Position = model.Position;
            Quality = model.Quality;
            RubricCriterionId = model.RubricCriterionId;
            Score = model.Score;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
