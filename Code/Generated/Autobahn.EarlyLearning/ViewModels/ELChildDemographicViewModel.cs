//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDemographicViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildDemographic View Model
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

        // OtherRaceIndicator -- (backing property for Other Race Indicator)
        private System.Boolean? _OtherRaceIndicator;

        // member variable for the PersonId property
        private Guid _PersonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.DateTime? FosterCareEndDate { get => _FosterCareEndDate; set => SetProperty(ref _FosterCareEndDate, value); }

        public System.DateTime? FosterCareStartDate { get => _FosterCareStartDate; set => SetProperty(ref _FosterCareStartDate, value); }

        /// <summary>
        /// Other Race Indicator
        /// <para>
        /// Race other than American Indian, Black, Asian, White, Native Pacific Islander
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20390">Other Race Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? OtherRaceIndicator { get => _OtherRaceIndicator; set => SetProperty(ref _OtherRaceIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
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
            FosterCareEndDate = model.FosterCareEndDate; // 
            FosterCareStartDate = model.FosterCareStartDate; // 
            OtherRaceIndicator = model.OtherRaceIndicator; // Other Race Indicator
            PersonId = model.PersonId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
