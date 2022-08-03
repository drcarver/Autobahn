//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricCriterionLevelViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The RubricCriterionLevelViewModel
     /// </summary>
    public partial class RubricCriterionLevelViewModel : BindableBase, IRubricCriterionLevel
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Quality  { get => _Quality; set => SetProperty(ref _Quality, value); }

        public System.Decimal? Score { get => _Score; set => SetProperty(ref _Score, value); }

        public System.String Feedback  { get => _Feedback; set => SetProperty(ref _Feedback, value); }

        public System.Int32? Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricCriterionId"/> model
        /// </summary>
        public Guid RubricCriterionId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IRubricCriterionLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description;
            Quality = model.Quality;
            Score = model.Score;
            Feedback = model.Feedback;
            Position = model.Position;
            RubricCriterionId = model.RubricCriterionId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
