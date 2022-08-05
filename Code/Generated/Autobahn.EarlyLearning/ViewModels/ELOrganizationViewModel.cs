//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationViewModel
     /// </summary>
    public partial class ELOrganizationViewModel : ViewModelBase, Interfaces.IELOrganization
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganization";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefProfitStatusId property
        private Guid? _RefProfitStatusId;

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
        /// The title of the ELOrganizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfitStatusId"/> model
        /// </summary>
        public Guid? RefProfitStatusId { get => _RefProfitStatusId; set => SetProperty(ref _RefProfitStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganization model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefProfitStatusId = model.RefProfitStatusId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
