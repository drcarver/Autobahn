//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolImprovementViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolImprovementViewModel
     /// </summary>
    public partial class K12SchoolImprovementViewModel : BindableBase, IK12SchoolImprovement
    {
#region "Backing Fields"
        // member variable for the SchoolImprovementExitDate property
        private System.DateTime? _SchoolImprovementExitDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12SchoolId"/> model
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatusId"/> model
        /// </summary>
        public Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementFundsId"/> model
        /// </summary>
        public Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSigInterventionTypeId"/> model
        /// </summary>
        public Guid? RefSigInterventionTypeId { get; set; }

        public System.DateTime? SchoolImprovementExitDate { get => _SchoolImprovementExitDate; set => SetProperty(ref _SchoolImprovementExitDate, value); }

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
        public void Load(IK12SchoolImprovement model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId;
            RefSchoolImprovementStatusId = model.RefSchoolImprovementStatusId;
            RefSchoolImprovementFundsId = model.RefSchoolImprovementFundsId;
            RefSigInterventionTypeId = model.RefSigInterventionTypeId;
            SchoolImprovementExitDate = model.SchoolImprovementExitDate;
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
