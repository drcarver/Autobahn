//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolImprovementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolImprovementViewModel
     /// </summary>
    public partial class K12SchoolImprovementViewModel : ViewModelBase, Interfaces.IK12SchoolImprovement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolImprovement";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefSchoolImprovementFundsId property
        private Guid? _RefSchoolImprovementFundsId;

        // member variable for the RefSchoolImprovementStatusId property
        private  _RefSchoolImprovementStatusId;

        // member variable for the RefSigInterventionTypeId property
        private  _RefSigInterventionTypeId;

        // member variable for the SchoolImprovementExitDate property
        private  _SchoolImprovementExitDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
        /// </summary>
        public Guid? RefSchoolImprovementFundsId { get => _RefSchoolImprovementFundsId; set => SetProperty(ref _RefSchoolImprovementFundsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        public  RefSchoolImprovementStatusId { get => _RefSchoolImprovementStatusId; set => SetProperty(ref _RefSchoolImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
        /// </summary>
        public  RefSigInterventionTypeId { get => _RefSigInterventionTypeId; set => SetProperty(ref _RefSigInterventionTypeId, value); }

        /// <summary>
        /// </summary>
        public  SchoolImprovementExitDate { get => _SchoolImprovementExitDate; set => SetProperty(ref _SchoolImprovementExitDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolImprovement model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefSchoolImprovementFundsId = model.RefSchoolImprovementFundsId; // 
            RefSchoolImprovementStatusId = model.RefSchoolImprovementStatusId; // 
            RefSigInterventionTypeId = model.RefSigInterventionTypeId; // 
            SchoolImprovementExitDate = model.SchoolImprovementExitDate; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
