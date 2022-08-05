//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaViewModel
     /// </summary>
    public partial class K12LeaViewModel : ViewModelBase, Interfaces.IK12Lea
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12Lea";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the SupervisoryUnionIdentificationNumber property
        private System.String _SupervisoryUnionIdentificationNumber;

        // member variable for the CharterSchoolIndicator property
        private System.Boolean? _CharterSchoolIndicator;

        // member variable for the RefLeaTypeId property
        private Guid? _RefLeaTypeId;

        // member variable for the RefLeaImprovementStatusId property
        private Guid? _RefLeaImprovementStatusId;

        // member variable for the RefPublicSchoolChoiceStatusId property
        private Guid? _RefPublicSchoolChoiceStatusId;

        // member variable for the RefCharterLeaStatusId property
        private Guid? _RefCharterLeaStatusId;

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
        /// The title of the K12LeaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String SupervisoryUnionIdentificationNumber  { get => _SupervisoryUnionIdentificationNumber; set => SetProperty(ref _SupervisoryUnionIdentificationNumber, value); }

        public System.Boolean? CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaTypeId"/> model
        /// </summary>
        public Guid? RefLeaTypeId { get => _RefLeaTypeId; set => SetProperty(ref _RefLeaTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaImprovementStatusId"/> model
        /// </summary>
        public Guid? RefLeaImprovementStatusId { get => _RefLeaImprovementStatusId; set => SetProperty(ref _RefLeaImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatusId"/> model
        /// </summary>
        public Guid? RefPublicSchoolChoiceStatusId { get => _RefPublicSchoolChoiceStatusId; set => SetProperty(ref _RefPublicSchoolChoiceStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterLeaStatusId"/> model
        /// </summary>
        public Guid? RefCharterLeaStatusId { get => _RefCharterLeaStatusId; set => SetProperty(ref _RefCharterLeaStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Lea model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            SupervisoryUnionIdentificationNumber = model.SupervisoryUnionIdentificationNumber;
            CharterSchoolIndicator = model.CharterSchoolIndicator;
            RefLeaTypeId = model.RefLeaTypeId;
            RefLeaImprovementStatusId = model.RefLeaImprovementStatusId;
            RefPublicSchoolChoiceStatusId = model.RefPublicSchoolChoiceStatusId;
            RefCharterLeaStatusId = model.RefCharterLeaStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
