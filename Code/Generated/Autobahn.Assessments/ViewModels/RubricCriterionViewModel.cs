//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricCriterionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _Category;

        // member variable for the Description property
        private  _Description;

        // member variable for the Position property
        private  _Position;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the Title property
        private  _Title;

        // member variable for the Weight property
        private  _Weight;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Category { get => _Category; set => SetProperty(ref _Category, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// </summary>
        public  Weight { get => _Weight; set => SetProperty(ref _Weight, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubricCriterion model)
        {
            IsBusy = true;
            Id = model.Id;
            Category = model.Category; // 
            Description = model.Description; // 
            Position = model.Position; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            Title = model.Title; // 
            Weight = model.Weight; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
