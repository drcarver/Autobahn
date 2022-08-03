//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationTechnicalAssistanceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationTechnicalAssistanceViewModel
     /// </summary>
    public partial class OrganizationTechnicalAssistanceViewModel : BindableBase, IOrganizationTechnicalAssistance
    {
#region "Backing Fields"
        // member variable for the TechnicalAssistanceApprovedInd property
        private System.Boolean? _TechnicalAssistanceApprovedInd;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceTypeId"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceDeliveryTypeId"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        public System.Boolean? TechnicalAssistanceApprovedInd { get => _TechnicalAssistanceApprovedInd; set => SetProperty(ref _TechnicalAssistanceApprovedInd, value); }

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
        public void Load(IOrganizationTechnicalAssistance model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefTechnicalAssistanceTypeId = model.RefTechnicalAssistanceTypeId;
            RefTechnicalAssistanceDeliveryTypeId = model.RefTechnicalAssistanceDeliveryTypeId;
            TechnicalAssistanceApprovedInd = model.TechnicalAssistanceApprovedInd;
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
