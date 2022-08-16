//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPPresentLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IEPPresentLevelViewModel
     /// </summary>
    public partial class IEPPresentLevelViewModel : ViewModelBase, Interfaces.IIEPPresentLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPPresentLevel";

        // member variable for the AcademicDescription property
        private Guid? _AcademicDescription;

        // member variable for the FunctionalDescription property
        private  _FunctionalDescription;

        // member variable for the GeneralEducationDescription property
        private  _GeneralEducationDescription;

        // member variable for the ParentConcernDescription property
        private  _ParentConcernDescription;

        // member variable for the PreschoolDescription property
        private  _PreschoolDescription;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the StudentConcernDescription property
        private  _StudentConcernDescription;

        // member variable for the StudentStrengthsDescription property
        private  _StudentStrengthsDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AcademicDescription { get => _AcademicDescription; set => SetProperty(ref _AcademicDescription, value); }

        /// <summary>
        /// </summary>
        public  FunctionalDescription { get => _FunctionalDescription; set => SetProperty(ref _FunctionalDescription, value); }

        /// <summary>
        /// </summary>
        public  GeneralEducationDescription { get => _GeneralEducationDescription; set => SetProperty(ref _GeneralEducationDescription, value); }

        /// <summary>
        /// </summary>
        public  ParentConcernDescription { get => _ParentConcernDescription; set => SetProperty(ref _ParentConcernDescription, value); }

        /// <summary>
        /// </summary>
        public  PreschoolDescription { get => _PreschoolDescription; set => SetProperty(ref _PreschoolDescription, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  StudentConcernDescription { get => _StudentConcernDescription; set => SetProperty(ref _StudentConcernDescription, value); }

        /// <summary>
        /// </summary>
        public  StudentStrengthsDescription { get => _StudentStrengthsDescription; set => SetProperty(ref _StudentStrengthsDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPPresentLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicDescription = model.AcademicDescription; // 
            FunctionalDescription = model.FunctionalDescription; // 
            GeneralEducationDescription = model.GeneralEducationDescription; // 
            ParentConcernDescription = model.ParentConcernDescription; // 
            PreschoolDescription = model.PreschoolDescription; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            StudentConcernDescription = model.StudentConcernDescription; // 
            StudentStrengthsDescription = model.StudentStrengthsDescription; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
