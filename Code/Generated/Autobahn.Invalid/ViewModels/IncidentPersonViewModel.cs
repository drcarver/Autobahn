//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentPersonViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IncidentPersonViewModel
     /// </summary>
    public partial class IncidentPersonViewModel : ViewModelBase, Interfaces.IIncidentPerson
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IncidentPerson";

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the IncidentId property
        private Guid _IncidentId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefIncidentPersonRoleTypeId property
        private Guid _RefIncidentPersonRoleTypeId;

        // member variable for the RefIncidentPersonTypeId property
        private Guid? _RefIncidentPersonTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IncidentPersonViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Incident"/> model
        /// </summary>
        public Guid IncidentId { get => _IncidentId; set => SetProperty(ref _IncidentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPersonRoleType"/> model
        /// </summary>
        public Guid RefIncidentPersonRoleTypeId { get => _RefIncidentPersonRoleTypeId; set => SetProperty(ref _RefIncidentPersonRoleTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPersonType"/> model
        /// </summary>
        public Guid? RefIncidentPersonTypeId { get => _RefIncidentPersonTypeId; set => SetProperty(ref _RefIncidentPersonTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIncidentPerson model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            IncidentId = model.IncidentId;
            PersonId = model.PersonId;
            RefIncidentPersonRoleTypeId = model.RefIncidentPersonRoleTypeId;
            RefIncidentPersonTypeId = model.RefIncidentPersonTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
