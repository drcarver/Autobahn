//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELClassSectionServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELClassSectionServiceViewModel
     /// </summary>
    public partial class ELClassSectionServiceViewModel : ViewModelBase, Interfaces.IELClassSectionService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELClassSectionService";

        // member variable for the ELClassGroupCurriculumType property
        private System.String _ELClassGroupCurriculumType;

        // member variable for the ELClassSectionId property
        private Guid _ELClassSectionId;

        // member variable for the OldestAgeServed property
        private System.Int32? _OldestAgeServed;

        // member variable for the RefELGroupSizeStandardMetId property
        private Guid? _RefELGroupSizeStandardMetId;

        // member variable for the RefFrequencyOfServiceId property
        private Guid? _RefFrequencyOfServiceId;

        // member variable for the ServesChildrenWithSpecialNeeds property
        private System.Boolean? _ServesChildrenWithSpecialNeeds;

        // member variable for the YoungestAgeServed property
        private System.Int32? _YoungestAgeServed;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELClassSectionServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.String ELClassGroupCurriculumType { get => _ELClassGroupCurriculumType; set => SetProperty(ref _ELClassGroupCurriculumType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ELClassSection"/> model
        /// </summary>
        public Guid ELClassSectionId { get => _ELClassSectionId; set => SetProperty(ref _ELClassSectionId, value); }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Int32? OldestAgeServed { get => _OldestAgeServed; set => SetProperty(ref _OldestAgeServed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELGroupSizeStandardMet"/> model
        /// </summary>
        public Guid? RefELGroupSizeStandardMetId { get => _RefELGroupSizeStandardMetId; set => SetProperty(ref _RefELGroupSizeStandardMetId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyOfService"/> model
        /// </summary>
        public Guid? RefFrequencyOfServiceId { get => _RefFrequencyOfServiceId; set => SetProperty(ref _RefFrequencyOfServiceId, value); }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Boolean? ServesChildrenWithSpecialNeeds { get => _ServesChildrenWithSpecialNeeds; set => SetProperty(ref _ServesChildrenWithSpecialNeeds, value); }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Int32? YoungestAgeServed { get => _YoungestAgeServed; set => SetProperty(ref _YoungestAgeServed, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELClassSectionService model)
        {
            IsBusy = true;
            Id = model.Id;
            ELClassGroupCurriculumType = model.ELClassGroupCurriculumType;
            ELClassSectionId = model.ELClassSectionId;
            OldestAgeServed = model.OldestAgeServed;
            RefELGroupSizeStandardMetId = model.RefELGroupSizeStandardMetId;
            RefFrequencyOfServiceId = model.RefFrequencyOfServiceId;
            ServesChildrenWithSpecialNeeds = model.ServesChildrenWithSpecialNeeds;
            YoungestAgeServed = model.YoungestAgeServed;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
