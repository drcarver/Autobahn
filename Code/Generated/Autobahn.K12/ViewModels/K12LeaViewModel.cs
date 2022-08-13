//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the CharterSchoolIndicator property
        private System.Boolean? _CharterSchoolIndicator;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefCharterLeaStatusId property
        private Guid? _RefCharterLeaStatusId;

        // member variable for the RefLeaImprovementStatusId property
        private Guid? _RefLeaImprovementStatusId;

        // member variable for the RefLeaTypeId property
        private Guid? _RefLeaTypeId;

        // member variable for the RefPublicSchoolChoiceStatusId property
        private Guid? _RefPublicSchoolChoiceStatusId;

        // member variable for the SupervisoryUnionIdentificationNumber property
        private System.String _SupervisoryUnionIdentificationNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </summary>
        public System.Boolean? CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterLeaStatus"/> model
        /// </summary>
        public Guid? RefCharterLeaStatusId { get => _RefCharterLeaStatusId; set => SetProperty(ref _RefCharterLeaStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaImprovementStatus"/> model
        /// </summary>
        public Guid? RefLeaImprovementStatusId { get => _RefLeaImprovementStatusId; set => SetProperty(ref _RefLeaImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaType"/> model
        /// </summary>
        public Guid? RefLeaTypeId { get => _RefLeaTypeId; set => SetProperty(ref _RefLeaTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
        /// </summary>
        public Guid? RefPublicSchoolChoiceStatusId { get => _RefPublicSchoolChoiceStatusId; set => SetProperty(ref _RefPublicSchoolChoiceStatusId, value); }

        /// <summary>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </summary>
        public System.String SupervisoryUnionIdentificationNumber { get => _SupervisoryUnionIdentificationNumber; set => SetProperty(ref _SupervisoryUnionIdentificationNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Lea model)
        {
            IsBusy = true;
            Id = model.Id;
            CharterSchoolIndicator = model.CharterSchoolIndicator;
            OrganizationId = model.OrganizationId;
            RefCharterLeaStatusId = model.RefCharterLeaStatusId;
            RefLeaImprovementStatusId = model.RefLeaImprovementStatusId;
            RefLeaTypeId = model.RefLeaTypeId;
            RefPublicSchoolChoiceStatusId = model.RefPublicSchoolChoiceStatusId;
            SupervisoryUnionIdentificationNumber = model.SupervisoryUnionIdentificationNumber;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
