//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemResponseTheoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemResponseTheoryViewModel
     /// </summary>
    public partial class AssessmentItemResponseTheoryViewModel : ViewModelBase, Interfaces.IAssessmentItemResponseTheoryViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemResponseTheory";

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

        // member variable for the ParameterA property
        private System.Int32? _ParameterA;

        // member variable for the ParameterB property
        private System.Int32? _ParameterB;

        // member variable for the ParameterC property
        private System.Int32? _ParameterC;

        // member variable for the ParameterD1 property
        private System.Int32? _ParameterD1;

        // member variable for the ParameterD2 property
        private System.Int32? _ParameterD2;

        // member variable for the ParameterD3 property
        private System.Int32? _ParameterD3;

        // member variable for the ParameterD4 property
        private System.Int32? _ParameterD4;

        // member variable for the ParameterD5 property
        private System.Int32? _ParameterD5;

        // member variable for the ParameterD6 property
        private System.Int32? _ParameterD6;

        // member variable for the PointBiserialCorrelationValue property
        private System.Int32? _PointBiserialCorrelationValue;

        // member variable for the DIFValue property
        private System.Int32? _DIFValue;

        // member variable for the KappaValue property
        private System.Int32? _KappaValue;

        // member variable for the RefItemResponseTheoryDifficultyCategoryId property
        private Guid? _RefItemResponseTheoryDifficultyCategoryId;

        // member variable for the RefItemResponseTheoryKappaAlgorithmId property
        private Guid? _RefItemResponseTheoryKappaAlgorithmId;

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
        /// The title of the AssessmentItemResponseTheoryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        public System.Int32? ParameterA { get => _ParameterA; set => SetProperty(ref _ParameterA, value); }

        public System.Int32? ParameterB { get => _ParameterB; set => SetProperty(ref _ParameterB, value); }

        public System.Int32? ParameterC { get => _ParameterC; set => SetProperty(ref _ParameterC, value); }

        public System.Int32? ParameterD1 { get => _ParameterD1; set => SetProperty(ref _ParameterD1, value); }

        public System.Int32? ParameterD2 { get => _ParameterD2; set => SetProperty(ref _ParameterD2, value); }

        public System.Int32? ParameterD3 { get => _ParameterD3; set => SetProperty(ref _ParameterD3, value); }

        public System.Int32? ParameterD4 { get => _ParameterD4; set => SetProperty(ref _ParameterD4, value); }

        public System.Int32? ParameterD5 { get => _ParameterD5; set => SetProperty(ref _ParameterD5, value); }

        public System.Int32? ParameterD6 { get => _ParameterD6; set => SetProperty(ref _ParameterD6, value); }

        public System.Int32? PointBiserialCorrelationValue { get => _PointBiserialCorrelationValue; set => SetProperty(ref _PointBiserialCorrelationValue, value); }

        public System.Int32? DIFValue { get => _DIFValue; set => SetProperty(ref _DIFValue, value); }

        public System.Int32? KappaValue { get => _KappaValue; set => SetProperty(ref _KappaValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefItemResponseTheoryDifficultyCategoryId"/> model
        /// </summary>
        public Guid? RefItemResponseTheoryDifficultyCategoryId { get => _RefItemResponseTheoryDifficultyCategoryId; set => SetProperty(ref _RefItemResponseTheoryDifficultyCategoryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefItemResponseTheoryKappaAlgorithmId"/> model
        /// </summary>
        public Guid? RefItemResponseTheoryKappaAlgorithmId { get => _RefItemResponseTheoryKappaAlgorithmId; set => SetProperty(ref _RefItemResponseTheoryKappaAlgorithmId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemResponseTheory model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemId = model.AssessmentItemId;
            ParameterA = model.ParameterA;
            ParameterB = model.ParameterB;
            ParameterC = model.ParameterC;
            ParameterD1 = model.ParameterD1;
            ParameterD2 = model.ParameterD2;
            ParameterD3 = model.ParameterD3;
            ParameterD4 = model.ParameterD4;
            ParameterD5 = model.ParameterD5;
            ParameterD6 = model.ParameterD6;
            PointBiserialCorrelationValue = model.PointBiserialCorrelationValue;
            DIFValue = model.DIFValue;
            KappaValue = model.KappaValue;
            RefItemResponseTheoryDifficultyCategoryId = model.RefItemResponseTheoryDifficultyCategoryId;
            RefItemResponseTheoryKappaAlgorithmId = model.RefItemResponseTheoryKappaAlgorithmId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
