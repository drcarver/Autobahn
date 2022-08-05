//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAidAwardViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAidAwardViewModel
     /// </summary>
    public partial class FinancialAidAwardViewModel : ViewModelBase, Interfaces.IFinancialAidAward
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAidAward";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefFinancialAidAwardTypeId property
        private Guid? _RefFinancialAidAwardTypeId;

        // member variable for the RefFinancialAidStatusId property
        private Guid? _RefFinancialAidStatusId;

        // member variable for the FinancialAidAwardAmount property
        private System.Decimal? _FinancialAidAwardAmount;

        // member variable for the FinancialAidYearDesignator property
        private System.String _FinancialAidYearDesignator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the FinancialAidAwardViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidAwardTypeId"/> model
        /// </summary>
        public Guid? RefFinancialAidAwardTypeId { get => _RefFinancialAidAwardTypeId; set => SetProperty(ref _RefFinancialAidAwardTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidStatusId"/> model
        /// </summary>
        public Guid? RefFinancialAidStatusId { get => _RefFinancialAidStatusId; set => SetProperty(ref _RefFinancialAidStatusId, value); }

        public System.Decimal? FinancialAidAwardAmount { get => _FinancialAidAwardAmount; set => SetProperty(ref _FinancialAidAwardAmount, value); }

        public System.String FinancialAidYearDesignator  { get => _FinancialAidYearDesignator; set => SetProperty(ref _FinancialAidYearDesignator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAidAward model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefFinancialAidAwardTypeId = model.RefFinancialAidAwardTypeId;
            RefFinancialAidStatusId = model.RefFinancialAidStatusId;
            FinancialAidAwardAmount = model.FinancialAidAwardAmount;
            FinancialAidYearDesignator = model.FinancialAidYearDesignator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
