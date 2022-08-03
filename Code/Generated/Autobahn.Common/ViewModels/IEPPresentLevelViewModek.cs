//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPPresentLevelViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IEPPresentLevelViewModel
     /// </summary>
    public partial class IEPPresentLevelViewModel : BindableBase, IIEPPresentLevel
    {
#region "Backing Fields"
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

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        public System.String AcademicDescription  { get => _AcademicDescription; set => SetProperty(ref _AcademicDescription, value); }

        public System.String FunctionalDescription  { get => _FunctionalDescription; set => SetProperty(ref _FunctionalDescription, value); }

        public System.String GeneralEducationDescription  { get => _GeneralEducationDescription; set => SetProperty(ref _GeneralEducationDescription, value); }

        public System.String ParentConcernDescription  { get => _ParentConcernDescription; set => SetProperty(ref _ParentConcernDescription, value); }

        public System.String PreschoolDescription  { get => _PreschoolDescription; set => SetProperty(ref _PreschoolDescription, value); }

        public System.String StudentConcernDescription  { get => _StudentConcernDescription; set => SetProperty(ref _StudentConcernDescription, value); }

        public System.String StudentStrengthsDescription  { get => _StudentStrengthsDescription; set => SetProperty(ref _StudentStrengthsDescription, value); }

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
        public void Load(IIEPPresentLevel model)
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
