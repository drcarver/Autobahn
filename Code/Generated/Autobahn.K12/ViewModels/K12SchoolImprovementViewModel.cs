//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolImprovementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the K12SchoolId property
        private Guid _K12SchoolId;

        // member variable for the RefSchoolImprovementStatusId property
        private Guid? _RefSchoolImprovementStatusId;

        // member variable for the RefSchoolImprovementFundsId property
        private Guid? _RefSchoolImprovementFundsId;

        // member variable for the RefSigInterventionTypeId property
        private Guid? _RefSigInterventionTypeId;

        // member variable for the SchoolImprovementExitDate property
        private System.DateTime? _SchoolImprovementExitDate;

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
        /// The title of the K12SchoolImprovementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12SchoolId"/> model
        /// </summary>
        public Guid K12SchoolId { get => _K12SchoolId; set => SetProperty(ref _K12SchoolId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatusId"/> model
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get => _RefSchoolImprovementStatusId; set => SetProperty(ref _RefSchoolImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementFundsId"/> model
        /// </summary>
        public Guid? RefSchoolImprovementFundsId { get => _RefSchoolImprovementFundsId; set => SetProperty(ref _RefSchoolImprovementFundsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSigInterventionTypeId"/> model
        /// </summary>
        public Guid? RefSigInterventionTypeId { get => _RefSigInterventionTypeId; set => SetProperty(ref _RefSigInterventionTypeId, value); }

        public System.DateTime? SchoolImprovementExitDate { get => _SchoolImprovementExitDate; set => SetProperty(ref _SchoolImprovementExitDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolImprovement model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId;
            RefSchoolImprovementStatusId = model.RefSchoolImprovementStatusId;
            RefSchoolImprovementFundsId = model.RefSchoolImprovementFundsId;
            RefSigInterventionTypeId = model.RefSigInterventionTypeId;
            SchoolImprovementExitDate = model.SchoolImprovementExitDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
