//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12ProgramOrServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12ProgramOrServiceViewModel
     /// </summary>
    public partial class K12ProgramOrServiceViewModel : ViewModelBase, Interfaces.IK12ProgramOrService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12ProgramOrService";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the ProgramInMultiplePurposeFacility property
        private System.Boolean? _ProgramInMultiplePurposeFacility;

        // member variable for the RefKindergartenDailyLengthId property
        private Guid? _RefKindergartenDailyLengthId;

        // member variable for the RefMepProjectTypeId property
        private Guid? _RefMepProjectTypeId;

        // member variable for the RefMepSessionTypeId property
        private Guid? _RefMepSessionTypeId;

        // member variable for the RefPrekindergartenDailyLengthId property
        private Guid? _RefPrekindergartenDailyLengthId;

        // member variable for the RefProgramGiftedEligibilityId property
        private Guid? _RefProgramGiftedEligibilityId;

        // member variable for the RefTitleIInstructionalServicesId property
        private Guid? _RefTitleIInstructionalServicesId;

        // member variable for the RefTitleIProgramTypeId property
        private Guid? _RefTitleIProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12ProgramOrServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public System.Boolean? ProgramInMultiplePurposeFacility { get => _ProgramInMultiplePurposeFacility; set => SetProperty(ref _ProgramInMultiplePurposeFacility, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKindergartenDailyLength"/> model
        /// </summary>
        public Guid? RefKindergartenDailyLengthId { get => _RefKindergartenDailyLengthId; set => SetProperty(ref _RefKindergartenDailyLengthId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectType"/> model
        /// </summary>
        public Guid? RefMepProjectTypeId { get => _RefMepProjectTypeId; set => SetProperty(ref _RefMepProjectTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
        /// </summary>
        public Guid? RefMepSessionTypeId { get => _RefMepSessionTypeId; set => SetProperty(ref _RefMepSessionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLength"/> model
        /// </summary>
        public Guid? RefPrekindergartenDailyLengthId { get => _RefPrekindergartenDailyLengthId; set => SetProperty(ref _RefPrekindergartenDailyLengthId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibility"/> model
        /// </summary>
        public Guid? RefProgramGiftedEligibilityId { get => _RefProgramGiftedEligibilityId; set => SetProperty(ref _RefProgramGiftedEligibilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIInstructionalServices"/> model
        /// </summary>
        public Guid? RefTitleIInstructionalServicesId { get => _RefTitleIInstructionalServicesId; set => SetProperty(ref _RefTitleIInstructionalServicesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramType"/> model
        /// </summary>
        public Guid? RefTitleIProgramTypeId { get => _RefTitleIProgramTypeId; set => SetProperty(ref _RefTitleIProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12ProgramOrService model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            ProgramInMultiplePurposeFacility = model.ProgramInMultiplePurposeFacility;
            RefKindergartenDailyLengthId = model.RefKindergartenDailyLengthId;
            RefMepProjectTypeId = model.RefMepProjectTypeId;
            RefMepSessionTypeId = model.RefMepSessionTypeId;
            RefPrekindergartenDailyLengthId = model.RefPrekindergartenDailyLengthId;
            RefProgramGiftedEligibilityId = model.RefProgramGiftedEligibilityId;
            RefTitleIInstructionalServicesId = model.RefTitleIInstructionalServicesId;
            RefTitleIProgramTypeId = model.RefTitleIProgramTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
