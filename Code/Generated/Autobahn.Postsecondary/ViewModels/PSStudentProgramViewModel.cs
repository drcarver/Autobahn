//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PSStudentProgramViewModel
     /// </summary>
    public partial class PSStudentProgramViewModel : ViewModelBase, Interfaces.IPSStudentProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PSStudentProgram";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCareerClusterId property
        private  _RefCareerClusterId;

        // member variable for the RefCipUseId property
        private Guid? _RefCipUseId;

        // member variable for the RefTransferOutIndicatorId property
        private  _RefTransferOutIndicatorId;

        // member variable for the RefWorkbasedLearningOpportunityTypeId property
        private  _RefWorkbasedLearningOpportunityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
        /// </summary>
        public  RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipUse"/> model
        /// </summary>
        public Guid? RefCipUseId { get => _RefCipUseId; set => SetProperty(ref _RefCipUseId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTransferOutIndicator"/> model
        /// </summary>
        public  RefTransferOutIndicatorId { get => _RefTransferOutIndicatorId; set => SetProperty(ref _RefTransferOutIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        public  RefWorkbasedLearningOpportunityTypeId { get => _RefWorkbasedLearningOpportunityTypeId; set => SetProperty(ref _RefWorkbasedLearningOpportunityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPSStudentProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCareerClusterId = model.RefCareerClusterId; // 
            RefCipUseId = model.RefCipUseId; // 
            RefTransferOutIndicatorId = model.RefTransferOutIndicatorId; // 
            RefWorkbasedLearningOpportunityTypeId = model.RefWorkbasedLearningOpportunityTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
