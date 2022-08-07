//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAidApplicationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAidApplicationViewModel
     /// </summary>
    public partial class FinancialAidApplicationViewModel : ViewModelBase, Interfaces.IFinancialAidApplicationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAidApplication";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefFinancialAidApplicationTypeId property
        private Guid _RefFinancialAidApplicationTypeId;

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
        /// The title of the FinancialAidApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefFinancialAidApplicationTypeId"/> model
        /// </summary>
        public Guid RefFinancialAidApplicationTypeId { get => _RefFinancialAidApplicationTypeId; set => SetProperty(ref _RefFinancialAidApplicationTypeId, value); }

        public System.String FinancialAidYearDesignator  { get => _FinancialAidYearDesignator; set => SetProperty(ref _FinancialAidYearDesignator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAidApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefFinancialAidApplicationTypeId = model.RefFinancialAidApplicationTypeId;
            FinancialAidYearDesignator = model.FinancialAidYearDesignator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
