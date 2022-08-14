//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The RubricCriterionViewModel
     /// </summary>
    public partial class RubricCriterionViewModel : ViewModelBase, Interfaces.IRubricCriterion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RubricCriterion";

        // member variable for the Category property
        private System.String _Category;

        // member variable for the Position property
        private System.Int32? _Position;

        // member variable for the RubricId property
        private Guid _RubricId;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the Weight property
        private System.Decimal? _Weight;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RubricCriterionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        public System.String Category { get => _Category; set => SetProperty(ref _Category, value); }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        public System.Int32? Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Rubric"/> model
        /// </summary>
        public Guid RubricId { get => _RubricId; set => SetProperty(ref _RubricId, value); }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </summary>
        public System.Decimal? Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubricCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            Category = model.Category;
            Position = model.Position;
            RubricId = model.RubricId;
            Title = model.Title;
            Weight = model.Weight;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
