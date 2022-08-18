//**********************************************************
//* DomainName: Common Models
//* FileName:   IncidentPersonViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IncidentPerson View Model
     /// </summary>
    public partial class IncidentPersonViewModel : ViewModelBase, Interfaces.IIncidentPerson
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IncidentPerson";

        // Identifier -- (backing property for Incident Perpetrator Identifier)
        private System.String _Identifier;

        // member variable for the IncidentId property
        private Guid _IncidentId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefIncidentPersonRoleTypeId -- (backing property for Incident Person Role Type)
        private Guid _RefIncidentPersonRoleTypeId;

        // RefIncidentPersonTypeId -- (backing property for Incident Perpetrator Type)
        private Guid? _RefIncidentPersonTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Incident Perpetrator Identifier
        /// <para>
        /// Identifies the perpetrator of the incident by use of a pre-existing unique identifier assigned to a student or staff member by a school or district.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20338">Incident Perpetrator Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIncident"/> model
        /// </summary>
        public Guid IncidentId { get => _IncidentId; set => SetProperty(ref _IncidentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Incident Person Role Type
        /// <para>
        /// The role or type of participation of a person in a discipline incident.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20341">Incident Person Role Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefIncidentPersonRoleTypeId { get => _RefIncidentPersonRoleTypeId; set => SetProperty(ref _RefIncidentPersonRoleTypeId, value); }

        /// <summary>
        /// Incident Perpetrator Type
        /// <para>
        /// Information on the type of individual who committed an incident. A "perpetrator" is an individual involved in an incident as an offender (the person who committed the infraction constituting the incident).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20340">Incident Perpetrator Type</a>
        /// </para>
        /// </summary>
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
            Identifier = model.Identifier; // Incident Perpetrator Identifier
            IncidentId = model.IncidentId; // 
            PersonId = model.PersonId; // 
            RefIncidentPersonRoleTypeId = model.RefIncidentPersonRoleTypeId; // Incident Person Role Type
            RefIncidentPersonTypeId = model.RefIncidentPersonTypeId; // Incident Perpetrator Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
