//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedScreenEnhancementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentNeedScreenEnhancementViewModel
     /// </summary>
    public partial class AssessmentNeedScreenEnhancementViewModel : ViewModelBase, Interfaces.IAssessmentNeedScreenEnhancement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedScreenEnhancement";

        // member variable for the ForegroundColor property
        private  _ForegroundColor;

        // member variable for the InvertColorChoice property
        private Guid? _InvertColorChoice;

        // member variable for the Magnification property
        private  _Magnification;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ForegroundColor { get => _ForegroundColor; set => SetProperty(ref _ForegroundColor, value); }

        /// <summary>
        /// </summary>
        public Guid? InvertColorChoice { get => _InvertColorChoice; set => SetProperty(ref _InvertColorChoice, value); }

        /// <summary>
        /// </summary>
        public  Magnification { get => _Magnification; set => SetProperty(ref _Magnification, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedScreenEnhancement model)
        {
            IsBusy = true;
            Id = model.Id;
            ForegroundColor = model.ForegroundColor; // 
            InvertColorChoice = model.InvertColorChoice; // 
            Magnification = model.Magnification; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
