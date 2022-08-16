//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAcademicAwardViewModel
     /// </summary>
    public partial class PsStudentAcademicAwardViewModel : ViewModelBase, Interfaces.IPsStudentAcademicAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAcademicAward";

        // member variable for the AcademicAwardDate property
        private Guid? _AcademicAwardDate;

        // member variable for the AcademicAwardTitle property
        private  _AcademicAwardTitle;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAcademicAwardLevelId property
        private  _RefAcademicAwardLevelId;

        // member variable for the RefAcademicAwardPrerequisiteTypeId property
        private  _RefAcademicAwardPrerequisiteTypeId;

        // member variable for the RefPESCAwardLevelTypeId property
        private  _RefPESCAwardLevelTypeId;

        // member variable for the RequirementsURL property
        private  _RequirementsURL;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AcademicAwardDate { get => _AcademicAwardDate; set => SetProperty(ref _AcademicAwardDate, value); }

        /// <summary>
        /// </summary>
        public  AcademicAwardTitle { get => _AcademicAwardTitle; set => SetProperty(ref _AcademicAwardTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardLevel"/> model
        /// </summary>
        public  RefAcademicAwardLevelId { get => _RefAcademicAwardLevelId; set => SetProperty(ref _RefAcademicAwardLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardPrerequisiteType"/> model
        /// </summary>
        public  RefAcademicAwardPrerequisiteTypeId { get => _RefAcademicAwardPrerequisiteTypeId; set => SetProperty(ref _RefAcademicAwardPrerequisiteTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPESCAwardLevelType"/> model
        /// </summary>
        public  RefPESCAwardLevelTypeId { get => _RefPESCAwardLevelTypeId; set => SetProperty(ref _RefPESCAwardLevelTypeId, value); }

        /// <summary>
        /// </summary>
        public  RequirementsURL { get => _RequirementsURL; set => SetProperty(ref _RequirementsURL, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAcademicAward model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicAwardDate = model.AcademicAwardDate; // 
            AcademicAwardTitle = model.AcademicAwardTitle; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAcademicAwardLevelId = model.RefAcademicAwardLevelId; // 
            RefAcademicAwardPrerequisiteTypeId = model.RefAcademicAwardPrerequisiteTypeId; // 
            RefPESCAwardLevelTypeId = model.RefPESCAwardLevelTypeId; // 
            RequirementsURL = model.RequirementsURL; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
