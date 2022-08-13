//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsProgramViewModel
     /// </summary>
    public partial class PsProgramViewModel : ViewModelBase, Interfaces.IPsProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsProgram";

        // member variable for the NormalLengthTimeForCompletion property
        private System.String _NormalLengthTimeForCompletion;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the ProgramLengthHours property
        private System.Decimal? _ProgramLengthHours;

        // member variable for the RefCipCodeId property
        private Guid? _RefCipCodeId;

        // member variable for the RefCipVersionId property
        private Guid? _RefCipVersionId;

        // member variable for the RefDQPCategoriesOfLearningId property
        private Guid? _RefDQPCategoriesOfLearningId;

        // member variable for the RefProgramLengthHoursTypeId property
        private Guid? _RefProgramLengthHoursTypeId;

        // member variable for the RefPSProgramLevelId property
        private Guid? _RefPSProgramLevelId;

        // member variable for the RefTimeForCompletionUnitsId property
        private Guid? _RefTimeForCompletionUnitsId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String NormalLengthTimeForCompletion { get => _NormalLengthTimeForCompletion; set => SetProperty(ref _NormalLengthTimeForCompletion, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.Decimal? ProgramLengthHours { get => _ProgramLengthHours; set => SetProperty(ref _ProgramLengthHours, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipVersion"/> model
        /// </summary>
        public Guid? RefCipVersionId { get => _RefCipVersionId; set => SetProperty(ref _RefCipVersionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDQPCategoriesOfLearning"/> model
        /// </summary>
        public Guid? RefDQPCategoriesOfLearningId { get => _RefDQPCategoriesOfLearningId; set => SetProperty(ref _RefDQPCategoriesOfLearningId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramLengthHoursType"/> model
        /// </summary>
        public Guid? RefProgramLengthHoursTypeId { get => _RefProgramLengthHoursTypeId; set => SetProperty(ref _RefProgramLengthHoursTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSProgramLevel"/> model
        /// </summary>
        public Guid? RefPSProgramLevelId { get => _RefPSProgramLevelId; set => SetProperty(ref _RefPSProgramLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTimeForCompletionUnits"/> model
        /// </summary>
        public Guid? RefTimeForCompletionUnitsId { get => _RefTimeForCompletionUnitsId; set => SetProperty(ref _RefTimeForCompletionUnitsId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            NormalLengthTimeForCompletion = model.NormalLengthTimeForCompletion;
            OrganizationId = model.OrganizationId;
            ProgramLengthHours = model.ProgramLengthHours;
            RefCipCodeId = model.RefCipCodeId;
            RefCipVersionId = model.RefCipVersionId;
            RefDQPCategoriesOfLearningId = model.RefDQPCategoriesOfLearningId;
            RefProgramLengthHoursTypeId = model.RefProgramLengthHoursTypeId;
            RefPSProgramLevelId = model.RefPSProgramLevelId;
            RefTimeForCompletionUnitsId = model.RefTimeForCompletionUnitsId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
