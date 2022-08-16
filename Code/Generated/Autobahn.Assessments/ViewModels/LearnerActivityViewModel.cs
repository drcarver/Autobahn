//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The LearnerActivityViewModel
     /// </summary>
    public partial class LearnerActivityViewModel : ViewModelBase, Interfaces.ILearnerActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerActivity";

        // member variable for the CreationDate property
        private  _CreationDate;

        // member variable for the Description property
        private  _Description;

        // member variable for the DueDate property
        private  _DueDate;

        // member variable for the DueTime property
        private  _DueTime;

        // member variable for the MaximumAttemptsAllowed property
        private  _MaximumAttemptsAllowed;

        // member variable for the MaximumTimeAllowed property
        private  _MaximumTimeAllowed;

        // member variable for the PossiblePoints property
        private  _PossiblePoints;

        // member variable for the Prerequisite property
        private  _Prerequisite;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefLanguageId property
        private Guid? _RefLanguageId;

        // member variable for the RefLearnerActivityAddToGradeBookFlagId property
        private  _RefLearnerActivityAddToGradeBookFlagId;

        // member variable for the RefLearnerActivityMaximumTimeAllowedUnitsId property
        private  _RefLearnerActivityMaximumTimeAllowedUnitsId;

        // member variable for the RefLearnerActivityTypeId property
        private  _RefLearnerActivityTypeId;

        // member variable for the ReleaseDate property
        private  _ReleaseDate;

        // member variable for the RubricUrl property
        private  _RubricUrl;

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
        public  CreationDate { get => _CreationDate; set => SetProperty(ref _CreationDate, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  DueDate { get => _DueDate; set => SetProperty(ref _DueDate, value); }

        /// <summary>
        /// </summary>
        public  DueTime { get => _DueTime; set => SetProperty(ref _DueTime, value); }

        /// <summary>
        /// </summary>
        public  MaximumAttemptsAllowed { get => _MaximumAttemptsAllowed; set => SetProperty(ref _MaximumAttemptsAllowed, value); }

        /// <summary>
        /// </summary>
        public  MaximumTimeAllowed { get => _MaximumTimeAllowed; set => SetProperty(ref _MaximumTimeAllowed, value); }

        /// <summary>
        /// </summary>
        public  PossiblePoints { get => _PossiblePoints; set => SetProperty(ref _PossiblePoints, value); }

        /// <summary>
        /// </summary>
        public  Prerequisite { get => _Prerequisite; set => SetProperty(ref _Prerequisite, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguage"/> model
        /// </summary>
        public Guid? RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityAddToGradeBookFlag"/> model
        /// </summary>
        public  RefLearnerActivityAddToGradeBookFlagId { get => _RefLearnerActivityAddToGradeBookFlagId; set => SetProperty(ref _RefLearnerActivityAddToGradeBookFlagId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnits"/> model
        /// </summary>
        public  RefLearnerActivityMaximumTimeAllowedUnitsId { get => _RefLearnerActivityMaximumTimeAllowedUnitsId; set => SetProperty(ref _RefLearnerActivityMaximumTimeAllowedUnitsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActivityType"/> model
        /// </summary>
        public  RefLearnerActivityTypeId { get => _RefLearnerActivityTypeId; set => SetProperty(ref _RefLearnerActivityTypeId, value); }

        /// <summary>
        /// </summary>
        public  ReleaseDate { get => _ReleaseDate; set => SetProperty(ref _ReleaseDate, value); }

        /// <summary>
        /// </summary>
        public  RubricUrl { get => _RubricUrl; set => SetProperty(ref _RubricUrl, value); }

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
        public void Load(Interfaces.ILearnerActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            CreationDate = model.CreationDate; // 
            Description = model.Description; // 
            DueDate = model.DueDate; // 
            DueTime = model.DueTime; // 
            MaximumAttemptsAllowed = model.MaximumAttemptsAllowed; // 
            MaximumTimeAllowed = model.MaximumTimeAllowed; // 
            PossiblePoints = model.PossiblePoints; // 
            Prerequisite = model.Prerequisite; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefLanguageId = model.RefLanguageId; // 
            RefLearnerActivityAddToGradeBookFlagId = model.RefLearnerActivityAddToGradeBookFlagId; // 
            RefLearnerActivityMaximumTimeAllowedUnitsId = model.RefLearnerActivityMaximumTimeAllowedUnitsId; // 
            RefLearnerActivityTypeId = model.RefLearnerActivityTypeId; // 
            ReleaseDate = model.ReleaseDate; // 
            RubricUrl = model.RubricUrl; // 
            Title = model.Title; // 
            Weight = model.Weight; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
