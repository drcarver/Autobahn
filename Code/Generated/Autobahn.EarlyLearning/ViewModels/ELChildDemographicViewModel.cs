//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDemographicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildDemographicViewModel
     /// </summary>
    public partial class ELChildDemographicViewModel : ViewModelBase, Interfaces.IELChildDemographic
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildDemographic";

        // member variable for the FosterCareEndDate property
        private System.DateTime? _FosterCareEndDate;

        // member variable for the FosterCareStartDate property
        private System.DateTime? _FosterCareStartDate;

        // member variable for the OtherRaceIndicator property
        private System.Boolean? _OtherRaceIndicator;

        // member variable for the PersonId property
        private Guid _PersonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildDemographicViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Race other than American Indian, Black, Asian, White, Native Pacific Islander
        /// </summary>
        public System.DateTime? FosterCareEndDate { get => _FosterCareEndDate; set => SetProperty(ref _FosterCareEndDate, value); }

        /// <summary>
        /// Race other than American Indian, Black, Asian, White, Native Pacific Islander
        /// </summary>
        public System.DateTime? FosterCareStartDate { get => _FosterCareStartDate; set => SetProperty(ref _FosterCareStartDate, value); }

        /// <summary>
        /// Race other than American Indian, Black, Asian, White, Native Pacific Islander
        /// </summary>
        public System.Boolean? OtherRaceIndicator { get => _OtherRaceIndicator; set => SetProperty(ref _OtherRaceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildDemographic model)
        {
            IsBusy = true;
            Id = model.Id;
            FosterCareEndDate = model.FosterCareEndDate;
            FosterCareStartDate = model.FosterCareStartDate;
            OtherRaceIndicator = model.OtherRaceIndicator;
            PersonId = model.PersonId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
