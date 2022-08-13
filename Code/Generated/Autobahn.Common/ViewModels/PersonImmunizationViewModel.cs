//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonImmunizationViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonImmunizationViewModel
     /// </summary>
    public partial class PersonImmunizationViewModel : ViewModelBase, Interfaces.IPersonImmunization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonImmunization";

        // member variable for the ImmunizationDate property
        private System.DateTime _ImmunizationDate;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefImmunizationTypeId property
        private Guid _RefImmunizationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonImmunizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day of an immunization.
        /// </summary>
        public System.DateTime ImmunizationDate { get => _ImmunizationDate; set => SetProperty(ref _ImmunizationDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        public Guid RefImmunizationTypeId { get => _RefImmunizationTypeId; set => SetProperty(ref _RefImmunizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonImmunization model)
        {
            IsBusy = true;
            Id = model.Id;
            ImmunizationDate = model.ImmunizationDate;
            PersonId = model.PersonId;
            RefImmunizationTypeId = model.RefImmunizationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
