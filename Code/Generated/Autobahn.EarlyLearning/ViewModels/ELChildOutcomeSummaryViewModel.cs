//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildOutcomeSummaryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildOutcomeSummaryViewModel
     /// </summary>
    public partial class ELChildOutcomeSummaryViewModel : ViewModelBase, Interfaces.IELChildOutcomeSummary
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildOutcomeSummary";

        // member variable for the COSProgressAIndicator property
        private System.Boolean? _COSProgressAIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildOutcomeSummaryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20476">Child Outcomes Summary Progress A Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Child Outcomes Summary Progress A Indicator")]
        public System.Boolean? COSProgressAIndicator { get => _COSProgressAIndicator; set => SetProperty(ref _COSProgressAIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildOutcomeSummary model)
        {
            IsBusy = true;
            Id = model.Id;
            COSProgressAIndicator = model.COSProgressAIndicator; // Child Outcomes Summary Progress A Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
