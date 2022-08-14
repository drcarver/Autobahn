//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPPresentLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.String _AcademicDescription;

        // member variable for the FunctionalDescription property
        private System.String _FunctionalDescription;

        // member variable for the GeneralEducationDescription property
        private System.String _GeneralEducationDescription;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the ParentConcernDescription property
        private System.String _ParentConcernDescription;

        // member variable for the PreschoolDescription property
        private System.String _PreschoolDescription;

        // member variable for the StudentConcernDescription property
        private System.String _StudentConcernDescription;

        // member variable for the StudentStrengthsDescription property
        private System.String _StudentStrengthsDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IEPPresentLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String AcademicDescription { get => _AcademicDescription; set => SetProperty(ref _AcademicDescription, value); }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String FunctionalDescription { get => _FunctionalDescription; set => SetProperty(ref _FunctionalDescription, value); }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String GeneralEducationDescription { get => _GeneralEducationDescription; set => SetProperty(ref _GeneralEducationDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String ParentConcernDescription { get => _ParentConcernDescription; set => SetProperty(ref _ParentConcernDescription, value); }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String PreschoolDescription { get => _PreschoolDescription; set => SetProperty(ref _PreschoolDescription, value); }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String StudentConcernDescription { get => _StudentConcernDescription; set => SetProperty(ref _StudentConcernDescription, value); }

        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        public System.String StudentStrengthsDescription { get => _StudentStrengthsDescription; set => SetProperty(ref _StudentStrengthsDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPPresentLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicDescription = model.AcademicDescription;
            FunctionalDescription = model.FunctionalDescription;
            GeneralEducationDescription = model.GeneralEducationDescription;
            IndividualizedProgramId = model.IndividualizedProgramId;
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
