//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELEnrollmentOtherFundingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELEnrollmentOtherFundingViewModel
     /// </summary>
    public partial class ELEnrollmentOtherFundingViewModel : ViewModelBase, Interfaces.IELEnrollmentOtherFunding
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELEnrollmentOtherFunding";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefELOtherFederalFundingSourcesId property
        private Guid _RefELOtherFederalFundingSourcesId;

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
        /// The title of the ELEnrollmentOtherFundingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefELOtherFederalFundingSourcesId"/> model
        /// </summary>
        public Guid RefELOtherFederalFundingSourcesId { get => _RefELOtherFederalFundingSourcesId; set => SetProperty(ref _RefELOtherFederalFundingSourcesId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELEnrollmentOtherFunding model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefELOtherFederalFundingSourcesId = model.RefELOtherFederalFundingSourcesId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
