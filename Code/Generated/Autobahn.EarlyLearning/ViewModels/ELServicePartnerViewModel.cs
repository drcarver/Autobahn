//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELServicePartnerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELServicePartnerViewModel
     /// </summary>
    public partial class ELServicePartnerViewModel : ViewModelBase, Interfaces.IELServicePartner
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELServicePartner";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the ServicePartnerName property
        private System.String _ServicePartnerName;

        // member variable for the ServicePartnerDescription property
        private System.String _ServicePartnerDescription;

        // member variable for the MemorandumOfUnderstandingEndDate property
        private System.DateTime? _MemorandumOfUnderstandingEndDate;

        // member variable for the MemorandumOfUnderstandingStartDate property
        private System.DateTime? _MemorandumOfUnderstandingStartDate;

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
        /// The title of the ELServicePartnerViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String ServicePartnerName  { get => _ServicePartnerName; set => SetProperty(ref _ServicePartnerName, value); }

        public System.String ServicePartnerDescription  { get => _ServicePartnerDescription; set => SetProperty(ref _ServicePartnerDescription, value); }

        public System.DateTime? MemorandumOfUnderstandingEndDate { get => _MemorandumOfUnderstandingEndDate; set => SetProperty(ref _MemorandumOfUnderstandingEndDate, value); }

        public System.DateTime? MemorandumOfUnderstandingStartDate { get => _MemorandumOfUnderstandingStartDate; set => SetProperty(ref _MemorandumOfUnderstandingStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELServicePartner model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            ServicePartnerName = model.ServicePartnerName;
            ServicePartnerDescription = model.ServicePartnerDescription;
            MemorandumOfUnderstandingEndDate = model.MemorandumOfUnderstandingEndDate;
            MemorandumOfUnderstandingStartDate = model.MemorandumOfUnderstandingStartDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
