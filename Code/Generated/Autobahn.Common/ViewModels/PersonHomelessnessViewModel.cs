//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHomelessnessViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHomelessnessViewModel
     /// </summary>
    public partial class PersonHomelessnessViewModel : ViewModelBase, Interfaces.IPersonHomelessness
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonHomelessness";

        // member variable for the RefHomelessNighttimeResidenceId property
        private Guid _RefHomelessNighttimeResidenceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonHomelessnessViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHomelessNighttimeResidence"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19146">Homeless Primary Nighttime Residence</a>
        /// </para>
        /// </summary>
        [DisplayName("Homeless Primary Nighttime Residence")]
        public Guid RefHomelessNighttimeResidenceId { get => _RefHomelessNighttimeResidenceId; set => SetProperty(ref _RefHomelessNighttimeResidenceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHomelessness model)
        {
            IsBusy = true;
            Id = model.Id;
            RefHomelessNighttimeResidenceId = model.RefHomelessNighttimeResidenceId; // Homeless Primary Nighttime Residence
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
