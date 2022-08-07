//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELClassSectionServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELClassSectionServiceViewModel
     /// </summary>
    public partial class ELClassSectionServiceViewModel : ViewModelBase, Interfaces.IELClassSectionServiceViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELClassSectionService";

        // member variable for the ELClassSectionId property
        private Guid _ELClassSectionId;

        // member variable for the YoungestAgeServed property
        private System.Int32? _YoungestAgeServed;

        // member variable for the OldestAgeServed property
        private System.Int32? _OldestAgeServed;

        // member variable for the ServesChildrenWithSpecialNeeds property
        private System.Boolean? _ServesChildrenWithSpecialNeeds;

        // member variable for the ELClassGroupCurriculumType property
        private System.String _ELClassGroupCurriculumType;

        // member variable for the RefELGroupSizeStandardMetId property
        private Guid? _RefELGroupSizeStandardMetId;

        // member variable for the RefFrequencyOfServiceId property
        private Guid? _RefFrequencyOfServiceId;

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
        /// The title of the ELClassSectionServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="ELClassSectionId"/> model
        /// </summary>
        public Guid ELClassSectionId { get => _ELClassSectionId; set => SetProperty(ref _ELClassSectionId, value); }

        public System.Int32? YoungestAgeServed { get => _YoungestAgeServed; set => SetProperty(ref _YoungestAgeServed, value); }

        public System.Int32? OldestAgeServed { get => _OldestAgeServed; set => SetProperty(ref _OldestAgeServed, value); }

        public System.Boolean? ServesChildrenWithSpecialNeeds { get => _ServesChildrenWithSpecialNeeds; set => SetProperty(ref _ServesChildrenWithSpecialNeeds, value); }

        public System.String ELClassGroupCurriculumType  { get => _ELClassGroupCurriculumType; set => SetProperty(ref _ELClassGroupCurriculumType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELGroupSizeStandardMetId"/> model
        /// </summary>
        public Guid? RefELGroupSizeStandardMetId { get => _RefELGroupSizeStandardMetId; set => SetProperty(ref _RefELGroupSizeStandardMetId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyOfServiceId"/> model
        /// </summary>
        public Guid? RefFrequencyOfServiceId { get => _RefFrequencyOfServiceId; set => SetProperty(ref _RefFrequencyOfServiceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELClassSectionService model)
        {
            IsBusy = true;
            Id = model.Id;
            ELClassSectionId = model.ELClassSectionId;
            YoungestAgeServed = model.YoungestAgeServed;
            OldestAgeServed = model.OldestAgeServed;
            ServesChildrenWithSpecialNeeds = model.ServesChildrenWithSpecialNeeds;
            ELClassGroupCurriculumType = model.ELClassGroupCurriculumType;
            RefELGroupSizeStandardMetId = model.RefELGroupSizeStandardMetId;
            RefFrequencyOfServiceId = model.RefFrequencyOfServiceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
