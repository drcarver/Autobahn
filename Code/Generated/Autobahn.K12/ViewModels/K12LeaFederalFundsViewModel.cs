//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaFederalFundsViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalFundsViewModel
     /// </summary>
    public partial class K12LeaFederalFundsViewModel : ViewModelBase, Interfaces.IK12LeaFederalFundsViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaFederalFunds";

        // member variable for the OrganizationCalendarSessionId property
        private Guid _OrganizationCalendarSessionId;

        // member variable for the InnovativeProgramsFundsReceived property
        private System.Decimal? _InnovativeProgramsFundsReceived;

        // member variable for the InnovativeDollarsSpent property
        private System.Decimal? _InnovativeDollarsSpent;

        // member variable for the InnovativeDollarsSpentOnStrategicPriorities property
        private System.Decimal? _InnovativeDollarsSpentOnStrategicPriorities;

        // member variable for the PublicSchoolChoiceFundsSpent property
        private System.Decimal? _PublicSchoolChoiceFundsSpent;

        // member variable for the SesFundsSpent property
        private System.Decimal? _SesFundsSpent;

        // member variable for the SesSchoolChoice20PercentObligation property
        private System.Decimal? _SesSchoolChoice20PercentObligation;

        // member variable for the ParentalInvolvementReservationFunds property
        private System.Decimal? _ParentalInvolvementReservationFunds;

        // member variable for the RefRlisProgramUseId property
        private Guid? _RefRlisProgramUseId;

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
        /// The title of the K12LeaFederalFundsViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSessionId"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        public System.Decimal? InnovativeProgramsFundsReceived { get => _InnovativeProgramsFundsReceived; set => SetProperty(ref _InnovativeProgramsFundsReceived, value); }

        public System.Decimal? InnovativeDollarsSpent { get => _InnovativeDollarsSpent; set => SetProperty(ref _InnovativeDollarsSpent, value); }

        public System.Decimal? InnovativeDollarsSpentOnStrategicPriorities { get => _InnovativeDollarsSpentOnStrategicPriorities; set => SetProperty(ref _InnovativeDollarsSpentOnStrategicPriorities, value); }

        public System.Decimal? PublicSchoolChoiceFundsSpent { get => _PublicSchoolChoiceFundsSpent; set => SetProperty(ref _PublicSchoolChoiceFundsSpent, value); }

        public System.Decimal? SesFundsSpent { get => _SesFundsSpent; set => SetProperty(ref _SesFundsSpent, value); }

        public System.Decimal? SesSchoolChoice20PercentObligation { get => _SesSchoolChoice20PercentObligation; set => SetProperty(ref _SesSchoolChoice20PercentObligation, value); }

        public System.Decimal? ParentalInvolvementReservationFunds { get => _ParentalInvolvementReservationFunds; set => SetProperty(ref _ParentalInvolvementReservationFunds, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRlisProgramUseId"/> model
        /// </summary>
        public Guid? RefRlisProgramUseId { get => _RefRlisProgramUseId; set => SetProperty(ref _RefRlisProgramUseId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaFederalFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            InnovativeProgramsFundsReceived = model.InnovativeProgramsFundsReceived;
            InnovativeDollarsSpent = model.InnovativeDollarsSpent;
            InnovativeDollarsSpentOnStrategicPriorities = model.InnovativeDollarsSpentOnStrategicPriorities;
            PublicSchoolChoiceFundsSpent = model.PublicSchoolChoiceFundsSpent;
            SesFundsSpent = model.SesFundsSpent;
            SesSchoolChoice20PercentObligation = model.SesSchoolChoice20PercentObligation;
            ParentalInvolvementReservationFunds = model.ParentalInvolvementReservationFunds;
            RefRlisProgramUseId = model.RefRlisProgramUseId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
