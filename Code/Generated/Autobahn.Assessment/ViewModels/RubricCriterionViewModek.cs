//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricCriterionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The RubricCriterionViewModel
     /// </summary>
    public partial class RubricCriterionViewModel : BindableBase, IRubricCriterion
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Category  { get => _Category; set => SetProperty(ref _Category, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.Decimal? Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        public System.Int32? Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RubricId"/> model
        /// </summary>
        public Guid RubricId { get; set; }

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
        public void Load(IRubricCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            Category = model.Category;
            Title = model.Title;
            Description = model.Description;
            Weight = model.Weight;
            Position = model.Position;
            RubricId = model.RubricId;
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
