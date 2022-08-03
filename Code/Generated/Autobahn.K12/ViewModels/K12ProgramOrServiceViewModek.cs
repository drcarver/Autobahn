//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12ProgramOrServiceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12ProgramOrServiceViewModel
     /// </summary>
    public partial class K12ProgramOrServiceViewModel : BindableBase, IK12ProgramOrService
    {
#region "Backing Fields"
        // member variable for the ProgramInMultiplePurposeFacility property
        private System.Boolean? _ProgramInMultiplePurposeFacility;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public System.Boolean? ProgramInMultiplePurposeFacility { get => _ProgramInMultiplePurposeFacility; set => SetProperty(ref _ProgramInMultiplePurposeFacility, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLengthId"/> model
        /// </summary>
        public Guid? RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKindergartenDailyLengthId"/> model
        /// </summary>
        public Guid? RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibilityId"/> model
        /// </summary>
        public Guid? RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepSessionTypeId"/> model
        /// </summary>
        public Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectTypeId"/> model
        /// </summary>
        public Guid? RefMepProjectTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIInstructionalServicesId"/> model
        /// </summary>
        public Guid? RefTitleIInstructionalServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramTypeId"/> model
        /// </summary>
        public Guid? RefTitleIProgramTypeId { get; set; }

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
        public void Load(IK12ProgramOrService model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            ProgramInMultiplePurposeFacility = model.ProgramInMultiplePurposeFacility;
            RefPrekindergartenDailyLengthId = model.RefPrekindergartenDailyLengthId;
            RefKindergartenDailyLengthId = model.RefKindergartenDailyLengthId;
            RefProgramGiftedEligibilityId = model.RefProgramGiftedEligibilityId;
            RefMepSessionTypeId = model.RefMepSessionTypeId;
            RefMepProjectTypeId = model.RefMepProjectTypeId;
            RefTitleIInstructionalServicesId = model.RefTitleIInstructionalServicesId;
            RefTitleIProgramTypeId = model.RefTitleIProgramTypeId;
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
