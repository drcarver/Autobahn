//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildServiceViewModel
     /// </summary>
    public partial class ELChildServiceViewModel : ViewModelBase, Interfaces.IELChildService
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildService";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the ECEAPEligibility property
        private System.Boolean? _ECEAPEligibility;

        // member variable for the EligibilityPriorityPoints property
        private System.String _EligibilityPriorityPoints;

        // member variable for the ServiceDate property
        private System.DateTime? _ServiceDate;

        // member variable for the RefEarlyChildhoodServicesOfferedId property
        private Guid? _RefEarlyChildhoodServicesOfferedId;

        // member variable for the RefEarlyChildhoodServicesReceivedId property
        private Guid? _RefEarlyChildhoodServicesReceivedId;

        // member variable for the RefELServiceTypeId property
        private Guid? _RefELServiceTypeId;

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
        /// The title of the ELChildServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        public System.Boolean? ECEAPEligibility { get => _ECEAPEligibility; set => SetProperty(ref _ECEAPEligibility, value); }

        public System.String EligibilityPriorityPoints  { get => _EligibilityPriorityPoints; set => SetProperty(ref _EligibilityPriorityPoints, value); }

        public System.DateTime? ServiceDate { get => _ServiceDate; set => SetProperty(ref _ServiceDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesOfferedId"/> model
        /// </summary>
        public Guid? RefEarlyChildhoodServicesOfferedId { get => _RefEarlyChildhoodServicesOfferedId; set => SetProperty(ref _RefEarlyChildhoodServicesOfferedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesReceivedId"/> model
        /// </summary>
        public Guid? RefEarlyChildhoodServicesReceivedId { get => _RefEarlyChildhoodServicesReceivedId; set => SetProperty(ref _RefEarlyChildhoodServicesReceivedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELServiceTypeId"/> model
        /// </summary>
        public Guid? RefELServiceTypeId { get => _RefELServiceTypeId; set => SetProperty(ref _RefELServiceTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildService model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ECEAPEligibility = model.ECEAPEligibility;
            EligibilityPriorityPoints = model.EligibilityPriorityPoints;
            ServiceDate = model.ServiceDate;
            RefEarlyChildhoodServicesOfferedId = model.RefEarlyChildhoodServicesOfferedId;
            RefEarlyChildhoodServicesReceivedId = model.RefEarlyChildhoodServicesReceivedId;
            RefELServiceTypeId = model.RefELServiceTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
