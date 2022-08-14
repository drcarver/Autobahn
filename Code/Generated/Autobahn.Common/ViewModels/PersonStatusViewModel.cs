//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonStatusViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonStatusViewModel
     /// </summary>
    public partial class PersonStatusViewModel : ViewModelBase, Interfaces.IPersonStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonStatus";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefPersonStatusTypeId property
        private Guid _RefPersonStatusTypeId;

        // member variable for the StatusEndDate property
        private System.DateTime? _StatusEndDate;

        // member variable for the StatusStartDate property
        private System.DateTime? _StatusStartDate;

        // member variable for the StatusValue property
        private System.Boolean _StatusValue;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonStatusType"/> model
        /// </summary>
        public Guid RefPersonStatusTypeId { get => _RefPersonStatusTypeId; set => SetProperty(ref _RefPersonStatusTypeId, value); }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        public System.DateTime? StatusEndDate { get => _StatusEndDate; set => SetProperty(ref _StatusEndDate, value); }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        public System.DateTime? StatusStartDate { get => _StatusStartDate; set => SetProperty(ref _StatusStartDate, value); }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        public System.Boolean StatusValue { get => _StatusValue; set => SetProperty(ref _StatusValue, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefPersonStatusTypeId = model.RefPersonStatusTypeId;
            StatusEndDate = model.StatusEndDate;
            StatusStartDate = model.StatusStartDate;
            StatusValue = model.StatusValue;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
