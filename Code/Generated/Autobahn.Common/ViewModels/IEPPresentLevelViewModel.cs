//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPPresentLevelViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IEPPresentLevelViewModel
     /// </summary>
    public partial class IEPPresentLevelViewModel : ViewModelBase, Interfaces.IIEPPresentLevel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPPresentLevel";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the AcademicDescription property
        private System.String _AcademicDescription;

        // member variable for the FunctionalDescription property
        private System.String _FunctionalDescription;

        // member variable for the GeneralEducationDescription property
        private System.String _GeneralEducationDescription;

        // member variable for the ParentConcernDescription property
        private System.String _ParentConcernDescription;

        // member variable for the PreschoolDescription property
        private System.String _PreschoolDescription;

        // member variable for the StudentConcernDescription property
        private System.String _StudentConcernDescription;

        // member variable for the StudentStrengthsDescription property
        private System.String _StudentStrengthsDescription;

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
        /// The title of the IEPPresentLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        public System.String AcademicDescription  { get => _AcademicDescription; set => SetProperty(ref _AcademicDescription, value); }

        public System.String FunctionalDescription  { get => _FunctionalDescription; set => SetProperty(ref _FunctionalDescription, value); }

        public System.String GeneralEducationDescription  { get => _GeneralEducationDescription; set => SetProperty(ref _GeneralEducationDescription, value); }

        public System.String ParentConcernDescription  { get => _ParentConcernDescription; set => SetProperty(ref _ParentConcernDescription, value); }

        public System.String PreschoolDescription  { get => _PreschoolDescription; set => SetProperty(ref _PreschoolDescription, value); }

        public System.String StudentConcernDescription  { get => _StudentConcernDescription; set => SetProperty(ref _StudentConcernDescription, value); }

        public System.String StudentStrengthsDescription  { get => _StudentStrengthsDescription; set => SetProperty(ref _StudentStrengthsDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPPresentLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            AcademicDescription = model.AcademicDescription;
            FunctionalDescription = model.FunctionalDescription;
            GeneralEducationDescription = model.GeneralEducationDescription;
            ParentConcernDescription = model.ParentConcernDescription;
            PreschoolDescription = model.PreschoolDescription;
            StudentConcernDescription = model.StudentConcernDescription;
            StudentStrengthsDescription = model.StudentStrengthsDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
