//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricCriterionLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the Description property
        private Guid? _Description;

        // member variable for the Feedback property
        private  _Feedback;

        // member variable for the Position property
        private  _Position;

        // member variable for the Quality property
        private  _Quality;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the Score property
        private  _Score;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  Feedback { get => _Feedback; set => SetProperty(ref _Feedback, value); }

        /// <summary>
        /// </summary>
        public  Position { get => _Position; set => SetProperty(ref _Position, value); }

        /// <summary>
        /// </summary>
        public  Quality { get => _Quality; set => SetProperty(ref _Quality, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  Score { get => _Score; set => SetProperty(ref _Score, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubricCriterionLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description; // 
            Feedback = model.Feedback; // 
            Position = model.Position; // 
            Quality = model.Quality; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            Score = model.Score; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
