//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalFundsViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalFundsViewModel
     /// </summary>
    public partial class K12LeaFederalFundsViewModel : ViewModelBase, Interfaces.IK12LeaFederalFunds
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaFederalFunds";

        // member variable for the InnovativeDollarsSpent property
        private System.Decimal? _InnovativeDollarsSpent;

        // member variable for the InnovativeDollarsSpentOnStrategicPriorities property
        private System.Decimal? _InnovativeDollarsSpentOnStrategicPriorities;

        // member variable for the InnovativeProgramsFundsReceived property
        private System.Decimal? _InnovativeProgramsFundsReceived;

        // member variable for the OrganizationCalendarSessionId property
        private Guid _OrganizationCalendarSessionId;

        // member variable for the ParentalInvolvementReservationFunds property
        private System.Decimal? _ParentalInvolvementReservationFunds;

        // member variable for the PublicSchoolChoiceFundsSpent property
        private System.Decimal? _PublicSchoolChoiceFundsSpent;

        // member variable for the RefRlisProgramUseId property
        private Guid? _RefRlisProgramUseId;

        // member variable for the SesFundsSpent property
        private System.Decimal? _SesFundsSpent;

        // member variable for the SesSchoolChoice20PercentObligation property
        private System.Decimal? _SesSchoolChoice20PercentObligation;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaFederalFundsViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? InnovativeDollarsSpent { get => _InnovativeDollarsSpent; set => SetProperty(ref _InnovativeDollarsSpent, value); }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? InnovativeDollarsSpentOnStrategicPriorities { get => _InnovativeDollarsSpentOnStrategicPriorities; set => SetProperty(ref _InnovativeDollarsSpentOnStrategicPriorities, value); }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? InnovativeProgramsFundsReceived { get => _InnovativeProgramsFundsReceived; set => SetProperty(ref _InnovativeProgramsFundsReceived, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? ParentalInvolvementReservationFunds { get => _ParentalInvolvementReservationFunds; set => SetProperty(ref _ParentalInvolvementReservationFunds, value); }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? PublicSchoolChoiceFundsSpent { get => _PublicSchoolChoiceFundsSpent; set => SetProperty(ref _PublicSchoolChoiceFundsSpent, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRlisProgramUse"/> model
        /// </summary>
        public Guid? RefRlisProgramUseId { get => _RefRlisProgramUseId; set => SetProperty(ref _RefRlisProgramUseId, value); }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? SesFundsSpent { get => _SesFundsSpent; set => SetProperty(ref _SesFundsSpent, value); }

        /// <summary>
        /// LEA notified the State that they were transferring funds under the LEA Transferability authority of Section 6123(b).
        /// </summary>
        public System.Decimal? SesSchoolChoice20PercentObligation { get => _SesSchoolChoice20PercentObligation; set => SetProperty(ref _SesSchoolChoice20PercentObligation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaFederalFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            InnovativeDollarsSpent = model.InnovativeDollarsSpent;
            InnovativeDollarsSpentOnStrategicPriorities = model.InnovativeDollarsSpentOnStrategicPriorities;
            InnovativeProgramsFundsReceived = model.InnovativeProgramsFundsReceived;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            ParentalInvolvementReservationFunds = model.ParentalInvolvementReservationFunds;
            PublicSchoolChoiceFundsSpent = model.PublicSchoolChoiceFundsSpent;
            RefRlisProgramUseId = model.RefRlisProgramUseId;
            SesFundsSpent = model.SesFundsSpent;
            SesSchoolChoice20PercentObligation = model.SesSchoolChoice20PercentObligation;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
