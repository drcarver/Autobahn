//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricCriterionLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The RubricCriterionLevelViewModel
     /// </summary>
    public partial class RubricCriterionLevelViewModel : ViewModelBase, Interfaces.IRubricCriterionLevel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RubricCriterionLevel";

        // member variable for the Description property
        private System.String _Description;

        // member variable for the Quality property
        private System.String _Quality;

        // member variable for the Score property
        private System.Decimal? _Score;

        // member variable for the Feedback property
        private System.String _Feedback;

        // member variable for the Position property
        private System.Int32? _Position;

        // member variable for the RubricCriterionId property
        private Guid _RubricCriterionId;

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
        /// The title of the RubricCriterionLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Quality  { get => _Quality; set => SetProperty(ref _Quality, value); }

        public System.Decimal? Score { get => _Score; set => SetProperty(ref _Score, value); }

        public System.String Feedback  { get => _Feedback; set => SetProperty(ref _Feedback, value); }

        public System.Int32? Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterionId"/> model
        /// </summary>
        public Guid RubricCriterionId { get => _RubricCriterionId; set => SetProperty(ref _RubricCriterionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubricCriterionLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description;
            Quality = model.Quality;
            Score = model.Score;
            Feedback = model.Feedback;
            Position = model.Position;
            RubricCriterionId = model.RubricCriterionId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
