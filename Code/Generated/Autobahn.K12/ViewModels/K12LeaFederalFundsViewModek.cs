//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaFederalFundsViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalFundsViewModel
     /// </summary>
    public partial class K12LeaFederalFundsViewModel : BindableBase, IK12LeaFederalFunds
    {
#region "Backing Fields"
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarSessionId"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get; set; }

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
        public Guid? RefRlisProgramUseId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IK12LeaFederalFunds model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
