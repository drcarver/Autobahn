//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaFederalFundsViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SeaFederalFunds View Model
     /// </summary>
    public partial class K12SeaFederalFundsViewModel : ViewModelBase, Interfaces.IK12SeaFederalFunds
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SeaFederalFunds";

        // DateStateReceivedTitleIIIAllocation -- (backing property for Date State Received Title III Allocation)
        private System.DateTime? _DateStateReceivedTitleIIIAllocation;

        // DateTitleIIIFundsAvailableToSubgrantees -- (backing property for Date Title III Funds Available to Subgrantees)
        private System.DateTime? _DateTitleIIIFundsAvailableToSubgrantees;

        // member variable for the K12SeaId property
        private Guid _K12SeaId;

        // NumberOfDaysForTitleIIISubgrants -- (backing property for Number of Days for Title III Subgrants)
        private System.Decimal? _NumberOfDaysForTitleIIISubgrants;

        // StateTransferabilityOfFunds -- (backing property for State Transferability of Funds)
        private System.Boolean? _StateTransferabilityOfFunds;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Date State Received Title III Allocation
        /// <para>
        /// Annual date the State receives the Title III allocation from U.S. Department of Education (ED).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19445">Date State Received Title III Allocation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DateStateReceivedTitleIIIAllocation { get => _DateStateReceivedTitleIIIAllocation; set => SetProperty(ref _DateStateReceivedTitleIIIAllocation, value); }

        /// <summary>
        /// Date Title III Funds Available to Subgrantees
        /// <para>
        /// Annual date that Title III funds are available to approved subgrantees.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19446">Date Title III Funds Available to Subgrantees</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DateTitleIIIFundsAvailableToSubgrantees { get => _DateTitleIIIFundsAvailableToSubgrantees; set => SetProperty(ref _DateTitleIIIFundsAvailableToSubgrantees, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12Sea"/> model
        /// </summary>
        public Guid K12SeaId { get => _K12SeaId; set => SetProperty(ref _K12SeaId, value); }

        /// <summary>
        /// Number of Days for Title III Subgrants
        /// <para>
        /// Average number of days for States receiving Title III funds to make subgrants to subgrantees beginning from July 1 of each year, except under conditions where funds are being withheld.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19447">Number of Days for Title III Subgrants</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NumberOfDaysForTitleIIISubgrants { get => _NumberOfDaysForTitleIIISubgrants; set => SetProperty(ref _NumberOfDaysForTitleIIISubgrants, value); }

        /// <summary>
        /// State Transferability of Funds
        /// <para>
        /// Did the State transfer funds under the State Transferability authority of Section 6123(a)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19435">State Transferability of Funds</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? StateTransferabilityOfFunds { get => _StateTransferabilityOfFunds; set => SetProperty(ref _StateTransferabilityOfFunds, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SeaFederalFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            DateStateReceivedTitleIIIAllocation = model.DateStateReceivedTitleIIIAllocation; // Date State Received Title III Allocation
            DateTitleIIIFundsAvailableToSubgrantees = model.DateTitleIIIFundsAvailableToSubgrantees; // Date Title III Funds Available to Subgrantees
            K12SeaId = model.K12SeaId; // 
            NumberOfDaysForTitleIIISubgrants = model.NumberOfDaysForTitleIIISubgrants; // Number of Days for Title III Subgrants
            StateTransferabilityOfFunds = model.StateTransferabilityOfFunds; // State Transferability of Funds
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
