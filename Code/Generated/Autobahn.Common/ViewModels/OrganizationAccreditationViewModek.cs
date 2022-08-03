//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationAccreditationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationAccreditationViewModel
     /// </summary>
    public partial class OrganizationAccreditationViewModel : BindableBase, IOrganizationAccreditation
    {
#region "Backing Fields"
        // member variable for the AccreditationStatus property
        private System.Boolean? _AccreditationStatus;

        // member variable for the AccreditationAwardDate property
        private System.DateTime? _AccreditationAwardDate;

        // member variable for the AccreditationExpirationDate property
        private System.DateTime? _AccreditationExpirationDate;

        // member variable for the SeekingAccreditationDate property
        private System.DateTime? _SeekingAccreditationDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the AccreditationAgencyName property
        private System.String _AccreditationAgencyName;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public System.Boolean? AccreditationStatus { get => _AccreditationStatus; set => SetProperty(ref _AccreditationStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccreditationAgencyId"/> model
        /// </summary>
        public Guid? RefAccreditationAgencyId { get; set; }

        public System.DateTime? AccreditationAwardDate { get => _AccreditationAwardDate; set => SetProperty(ref _AccreditationAwardDate, value); }

        public System.DateTime? AccreditationExpirationDate { get => _AccreditationExpirationDate; set => SetProperty(ref _AccreditationExpirationDate, value); }

        public System.DateTime? SeekingAccreditationDate { get => _SeekingAccreditationDate; set => SetProperty(ref _SeekingAccreditationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatusId"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.String AccreditationAgencyName  { get => _AccreditationAgencyName; set => SetProperty(ref _AccreditationAgencyName, value); }

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
        public void Load(IOrganizationAccreditation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            AccreditationStatus = model.AccreditationStatus;
            RefAccreditationAgencyId = model.RefAccreditationAgencyId;
            AccreditationAwardDate = model.AccreditationAwardDate;
            AccreditationExpirationDate = model.AccreditationExpirationDate;
            SeekingAccreditationDate = model.SeekingAccreditationDate;
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            AccreditationAgencyName = model.AccreditationAgencyName;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
