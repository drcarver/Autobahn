//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   CompetencySet_RubricCriterionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Competencies.Interfaces;

namespace Autobahn.Competencies.ViewModels
{
     /// <summary>
     /// The CompetencySet_RubricCriterionViewModel
     /// </summary>
    public partial class CompetencySet_RubricCriterionViewModel : BindableBase, ICompetencySet_RubricCriterion
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CompetencySetId"/> model
        /// </summary>
        public Guid CompetencySetId { get; set; }

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
        public void Load(ICompetencySet_RubricCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            CompetencySetId = model.CompetencySetId;
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
