//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHomelessnessViewModel.cs
//**********************************************************

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

        // member variable for the HomelessnessStatus property
        private System.Boolean _HomelessnessStatus;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefHomelessNighttimeResidenceId property
        private Guid _RefHomelessNighttimeResidenceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonHomelessnessViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The primary nighttime residence of the person at the time the person was identified as homeless.
        /// </summary>
        public System.Boolean HomelessnessStatus { get => _HomelessnessStatus; set => SetProperty(ref _HomelessnessStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHomelessNighttimeResidence"/> model
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
            HomelessnessStatus = model.HomelessnessStatus;
            PersonId = model.PersonId;
            RefHomelessNighttimeResidenceId = model.RefHomelessNighttimeResidenceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
