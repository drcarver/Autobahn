//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHomelessnessViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHomelessness View Model
     /// </summary>
    public partial class PersonHomelessnessViewModel : ViewModelBase, Interfaces.IPersonHomelessness
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonHomelessness";

        // HomelessnessStatus -- (backing property for Homelessness Status)
        private System.Boolean _HomelessnessStatus;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefHomelessNighttimeResidenceId -- (backing property for Homeless Primary Nighttime Residence)
        private Guid _RefHomelessNighttimeResidenceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Homelessness Status
        /// <para>
        /// Children and youth who lack a fixed, regular, and adequate nighttime residence. Homeless children and youth include: 1) children and youth who are sharing the housing of other persons due to loss of housing, economic hardship, or a similar reason; are living in motels, hotels, trailer parks, or camping grounds due to the lack of alternative adequate accommodations; are living in emergency or transitional shelters; are abandoned in hospitals; or are awaiting foster care placement; 2) children and youth who have a primary nighttime residence that is a public or private place not designed for or originally used as a regular sleeping accommodation for human beings; or 3) children and youths who are living in cars, parks, public spaces, abandoned buildings, substandard housing, bus or train stations, or similar settings. 4) migratory children who qualify as homeless because the children are living in circumstances described in the above. (See Section 103 of the McKinney Act for a more detailed description of this data element).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19149">Homelessness Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean HomelessnessStatus { get => _HomelessnessStatus; set => SetProperty(ref _HomelessnessStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Homeless Primary Nighttime Residence
        /// <para>
        /// The primary nighttime residence of the person at the time the person was identified as homeless.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19146">Homeless Primary Nighttime Residence</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefHomelessNighttimeResidenceId { get => _RefHomelessNighttimeResidenceId; set => SetProperty(ref _RefHomelessNighttimeResidenceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHomelessness model)
        {
            IsBusy = true;
            Id = model.Id;
            HomelessnessStatus = model.HomelessnessStatus; // Homelessness Status
            PersonId = model.PersonId; // 
            RefHomelessNighttimeResidenceId = model.RefHomelessNighttimeResidenceId; // Homeless Primary Nighttime Residence
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
