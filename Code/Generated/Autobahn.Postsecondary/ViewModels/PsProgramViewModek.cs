//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsProgramViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsProgramViewModel
     /// </summary>
    public partial class PsProgramViewModel : BindableBase, IPsProgram
    {
#region "Backing Fields"
        // member variable for the ProgramLengthHours property
        private System.Decimal? _ProgramLengthHours;

        // member variable for the NormalLengthTimeForCompletion property
        private System.String _NormalLengthTimeForCompletion;

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

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipVersionId"/> model
        /// </summary>
        public Guid? RefCipVersionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCodeId"/> model
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        public System.Decimal? ProgramLengthHours { get => _ProgramLengthHours; set => SetProperty(ref _ProgramLengthHours, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramLengthHoursTypeId"/> model
        /// </summary>
        public Guid? RefProgramLengthHoursTypeId { get; set; }

        public System.String NormalLengthTimeForCompletion  { get => _NormalLengthTimeForCompletion; set => SetProperty(ref _NormalLengthTimeForCompletion, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTimeForCompletionUnitsId"/> model
        /// </summary>
        public Guid? RefTimeForCompletionUnitsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSProgramLevelId"/> model
        /// </summary>
        public Guid? RefPSProgramLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDQPCategoriesOfLearningId"/> model
        /// </summary>
        public Guid? RefDQPCategoriesOfLearningId { get; set; }

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
        public void Load(IPsProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefCipVersionId = model.RefCipVersionId;
            RefCipCodeId = model.RefCipCodeId;
            ProgramLengthHours = model.ProgramLengthHours;
            RefProgramLengthHoursTypeId = model.RefProgramLengthHoursTypeId;
            NormalLengthTimeForCompletion = model.NormalLengthTimeForCompletion;
            RefTimeForCompletionUnitsId = model.RefTimeForCompletionUnitsId;
            RefPSProgramLevelId = model.RefPSProgramLevelId;
            RefDQPCategoriesOfLearningId = model.RefDQPCategoriesOfLearningId;
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
