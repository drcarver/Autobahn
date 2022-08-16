//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseTheoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentItemResponseTheoryViewModel
     /// </summary>
    public partial class AssessmentItemResponseTheoryViewModel : ViewModelBase, Interfaces.IAssessmentItemResponseTheory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemResponseTheory";

        // member variable for the DIFValue property
        private  _DIFValue;

        // member variable for the KappaValue property
        private  _KappaValue;

        // member variable for the ParameterA property
        private Guid? _ParameterA;

        // member variable for the ParameterB property
        private  _ParameterB;

        // member variable for the ParameterC property
        private  _ParameterC;

        // member variable for the ParameterD1 property
        private  _ParameterD1;

        // member variable for the ParameterD2 property
        private  _ParameterD2;

        // member variable for the ParameterD3 property
        private  _ParameterD3;

        // member variable for the ParameterD4 property
        private  _ParameterD4;

        // member variable for the ParameterD5 property
        private  _ParameterD5;

        // member variable for the ParameterD6 property
        private  _ParameterD6;

        // member variable for the PointBiserialCorrelationValue property
        private  _PointBiserialCorrelationValue;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefItemResponseTheoryDifficultyCategoryId property
        private  _RefItemResponseTheoryDifficultyCategoryId;

        // member variable for the RefItemResponseTheoryKappaAlgorithmId property
        private  _RefItemResponseTheoryKappaAlgorithmId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DIFValue { get => _DIFValue; set => SetProperty(ref _DIFValue, value); }

        /// <summary>
        /// </summary>
        public  KappaValue { get => _KappaValue; set => SetProperty(ref _KappaValue, value); }

        /// <summary>
        /// </summary>
        public Guid? ParameterA { get => _ParameterA; set => SetProperty(ref _ParameterA, value); }

        /// <summary>
        /// </summary>
        public  ParameterB { get => _ParameterB; set => SetProperty(ref _ParameterB, value); }

        /// <summary>
        /// </summary>
        public  ParameterC { get => _ParameterC; set => SetProperty(ref _ParameterC, value); }

        /// <summary>
        /// </summary>
        public  ParameterD1 { get => _ParameterD1; set => SetProperty(ref _ParameterD1, value); }

        /// <summary>
        /// </summary>
        public  ParameterD2 { get => _ParameterD2; set => SetProperty(ref _ParameterD2, value); }

        /// <summary>
        /// </summary>
        public  ParameterD3 { get => _ParameterD3; set => SetProperty(ref _ParameterD3, value); }

        /// <summary>
        /// </summary>
        public  ParameterD4 { get => _ParameterD4; set => SetProperty(ref _ParameterD4, value); }

        /// <summary>
        /// </summary>
        public  ParameterD5 { get => _ParameterD5; set => SetProperty(ref _ParameterD5, value); }

        /// <summary>
        /// </summary>
        public  ParameterD6 { get => _ParameterD6; set => SetProperty(ref _ParameterD6, value); }

        /// <summary>
        /// </summary>
        public  PointBiserialCorrelationValue { get => _PointBiserialCorrelationValue; set => SetProperty(ref _PointBiserialCorrelationValue, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefItemResponseTheoryDifficultyCategory"/> model
        /// </summary>
        public  RefItemResponseTheoryDifficultyCategoryId { get => _RefItemResponseTheoryDifficultyCategoryId; set => SetProperty(ref _RefItemResponseTheoryDifficultyCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefItemResponseTheoryKappaAlgorithm"/> model
        /// </summary>
        public  RefItemResponseTheoryKappaAlgorithmId { get => _RefItemResponseTheoryKappaAlgorithmId; set => SetProperty(ref _RefItemResponseTheoryKappaAlgorithmId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemResponseTheory model)
        {
            IsBusy = true;
            Id = model.Id;
            DIFValue = model.DIFValue; // 
            KappaValue = model.KappaValue; // 
            ParameterA = model.ParameterA; // 
            ParameterB = model.ParameterB; // 
            ParameterC = model.ParameterC; // 
            ParameterD1 = model.ParameterD1; // 
            ParameterD2 = model.ParameterD2; // 
            ParameterD3 = model.ParameterD3; // 
            ParameterD4 = model.ParameterD4; // 
            ParameterD5 = model.ParameterD5; // 
            ParameterD6 = model.ParameterD6; // 
            PointBiserialCorrelationValue = model.PointBiserialCorrelationValue; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefItemResponseTheoryDifficultyCategoryId = model.RefItemResponseTheoryDifficultyCategoryId; // 
            RefItemResponseTheoryKappaAlgorithmId = model.RefItemResponseTheoryKappaAlgorithmId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
