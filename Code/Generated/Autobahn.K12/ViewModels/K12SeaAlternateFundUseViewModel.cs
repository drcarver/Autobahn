//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SeaAlternateFundUseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SeaAlternateFundUseViewModel
     /// </summary>
    public partial class K12SeaAlternateFundUseViewModel : ViewModelBase, Interfaces.IK12SeaAlternateFundUse
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SeaAlternateFundUse";

        // member variable for the K12SeaFederalFundsId property
        private Guid _K12SeaFederalFundsId;

        // member variable for the RefAlternateFundUsesId property
        private Guid _RefAlternateFundUsesId;

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
        /// The title of the K12SeaAlternateFundUseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12SeaFederalFundsId"/> model
        /// </summary>
        public Guid K12SeaFederalFundsId { get => _K12SeaFederalFundsId; set => SetProperty(ref _K12SeaFederalFundsId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternateFundUsesId"/> model
        /// </summary>
        public Guid RefAlternateFundUsesId { get => _RefAlternateFundUsesId; set => SetProperty(ref _RefAlternateFundUsesId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SeaAlternateFundUse model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SeaFederalFundsId = model.K12SeaFederalFundsId;
            RefAlternateFundUsesId = model.RefAlternateFundUsesId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
