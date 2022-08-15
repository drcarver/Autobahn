//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDemographicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the OtherRaceIndicator property
        private System.Boolean? _OtherRaceIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildDemographicViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Race other than American Indian, Black, Asian, White, Native Pacific Islander
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20390">Other Race Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Other Race Indicator")]
        public System.Boolean? OtherRaceIndicator { get => _OtherRaceIndicator; set => SetProperty(ref _OtherRaceIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildDemographic model)
        {
            IsBusy = true;
            Id = model.Id;
            OtherRaceIndicator = model.OtherRaceIndicator; // Other Race Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
