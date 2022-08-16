//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationAccreditationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationAccreditationViewModel
     /// </summary>
    public partial class OrganizationAccreditationViewModel : ViewModelBase, Interfaces.IOrganizationAccreditation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationAccreditation";

        // member variable for the AccreditationAgencyName property
        private  _AccreditationAgencyName;

        // member variable for the AccreditationAwardDate property
        private  _AccreditationAwardDate;

        // member variable for the AccreditationExpirationDate property
        private  _AccreditationExpirationDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAccreditationAgencyId property
        private  _RefAccreditationAgencyId;

        // member variable for the RefHigherEducationInstitutionAccreditationStatusId property
        private Guid? _RefHigherEducationInstitutionAccreditationStatusId;

        // member variable for the SeekingAccreditationDate property
        private  _SeekingAccreditationDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AccreditationAgencyName { get => _AccreditationAgencyName; set => SetProperty(ref _AccreditationAgencyName, value); }

        /// <summary>
        /// </summary>
        public  AccreditationAwardDate { get => _AccreditationAwardDate; set => SetProperty(ref _AccreditationAwardDate, value); }

        /// <summary>
        /// </summary>
        public  AccreditationExpirationDate { get => _AccreditationExpirationDate; set => SetProperty(ref _AccreditationExpirationDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccreditationAgency"/> model
        /// </summary>
        public  RefAccreditationAgencyId { get => _RefAccreditationAgencyId; set => SetProperty(ref _RefAccreditationAgencyId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatus"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get => _RefHigherEducationInstitutionAccreditationStatusId; set => SetProperty(ref _RefHigherEducationInstitutionAccreditationStatusId, value); }

        /// <summary>
        /// </summary>
        public  SeekingAccreditationDate { get => _SeekingAccreditationDate; set => SetProperty(ref _SeekingAccreditationDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationAccreditation model)
        {
            IsBusy = true;
            Id = model.Id;
            AccreditationAgencyName = model.AccreditationAgencyName; // 
            AccreditationAwardDate = model.AccreditationAwardDate; // 
            AccreditationExpirationDate = model.AccreditationExpirationDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAccreditationAgencyId = model.RefAccreditationAgencyId; // 
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId; // 
            SeekingAccreditationDate = model.SeekingAccreditationDate; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
