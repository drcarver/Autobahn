//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilityFinancialViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityFinancialViewModel
     /// </summary>
    public partial class FacilityFinancialViewModel : BindableBase, IFacilityFinancial
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationFinancialId"/> model
        /// </summary>
        public Guid OrganizationFinancialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityLeaseId"/> model
        /// </summary>
        public Guid? FacilityLeaseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgageId"/> model
        /// </summary>
        public Guid? FacilityMortgageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="FacilityMortgageFeeId"/> model
        /// </summary>
        public Guid? FacilityMortgageFeeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IFacilityFinancial model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationFinancialId = model.OrganizationFinancialId;
            FacilityLeaseId = model.FacilityLeaseId;
            FacilityMortgageId = model.FacilityMortgageId;
            FacilityMortgageFeeId = model.FacilityMortgageFeeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
