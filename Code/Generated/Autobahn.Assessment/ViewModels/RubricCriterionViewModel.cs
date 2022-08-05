//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
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

        // member variable for the Title property
        private System.String _Title;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Weight property
        private System.Decimal? _Weight;

        // member variable for the Position property
        private System.Int32? _Position;

        // member variable for the RubricId property
        private Guid _RubricId;

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
        /// The title of the RubricCriterionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Category  { get => _Category; set => SetProperty(ref _Category, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.Decimal? Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        public System.Int32? Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricId"/> model
        /// </summary>
        public Guid RubricId { get => _RubricId; set => SetProperty(ref _RubricId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubricCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            Category = model.Category;
            Title = model.Title;
            Description = model.Description;
            Weight = model.Weight;
            Position = model.Position;
            RubricId = model.RubricId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
