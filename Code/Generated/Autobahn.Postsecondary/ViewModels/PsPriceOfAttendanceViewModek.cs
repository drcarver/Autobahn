//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsPriceOfAttendanceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsPriceOfAttendanceViewModel
     /// </summary>
    public partial class PsPriceOfAttendanceViewModel : BindableBase, IPsPriceOfAttendance
    {
#region "Backing Fields"
        // member variable for the SessionDesignator property
        private System.String _SessionDesignator;

        // member variable for the TuitionPublished property
        private System.Decimal? _TuitionPublished;

        // member variable for the BoardCharges property
        private System.Decimal? _BoardCharges;

        // member variable for the RoomCharges property
        private System.Decimal? _RoomCharges;

        // member variable for the BooksAndSuppliesCosts property
        private System.Decimal? _BooksAndSuppliesCosts;

        // member variable for the RequiredStudentFees property
        private System.Decimal? _RequiredStudentFees;

        // member variable for the ComprehensiveFee property
        private System.Decimal? _ComprehensiveFee;

        // member variable for the OtherStudentExpenses property
        private System.Decimal? _OtherStudentExpenses;

        // member variable for the PriceOfAttendance property
        private System.Decimal? _PriceOfAttendance;

        // member variable for the IPEDSCollectionYearDesignator property
        private System.String _IPEDSCollectionYearDesignator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PSPriceOfAttendanceId"/> model
        /// </summary>
        public Guid PSPriceOfAttendanceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PsInstitutionId"/> model
        /// </summary>
        public Guid PsInstitutionId { get; set; }

        public System.String SessionDesignator  { get => _SessionDesignator; set => SetProperty(ref _SessionDesignator, value); }

        public System.Decimal? TuitionPublished { get => _TuitionPublished; set => SetProperty(ref _TuitionPublished, value); }

        public System.Decimal? BoardCharges { get => _BoardCharges; set => SetProperty(ref _BoardCharges, value); }

        public System.Decimal? RoomCharges { get => _RoomCharges; set => SetProperty(ref _RoomCharges, value); }

        public System.Decimal? BooksAndSuppliesCosts { get => _BooksAndSuppliesCosts; set => SetProperty(ref _BooksAndSuppliesCosts, value); }

        public System.Decimal? RequiredStudentFees { get => _RequiredStudentFees; set => SetProperty(ref _RequiredStudentFees, value); }

        public System.Decimal? ComprehensiveFee { get => _ComprehensiveFee; set => SetProperty(ref _ComprehensiveFee, value); }

        public System.Decimal? OtherStudentExpenses { get => _OtherStudentExpenses; set => SetProperty(ref _OtherStudentExpenses, value); }

        public System.Decimal? PriceOfAttendance { get => _PriceOfAttendance; set => SetProperty(ref _PriceOfAttendance, value); }

        public System.String IPEDSCollectionYearDesignator  { get => _IPEDSCollectionYearDesignator; set => SetProperty(ref _IPEDSCollectionYearDesignator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionUnitId"/> model
        /// </summary>
        public Guid? RefTuitionUnitId { get; set; }

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
        public void Load(IPsPriceOfAttendance model)
        {
            IsBusy = true;
            Id = model.Id;
            PSPriceOfAttendanceId = model.PSPriceOfAttendanceId;
            PsInstitutionId = model.PsInstitutionId;
            SessionDesignator = model.SessionDesignator;
            TuitionPublished = model.TuitionPublished;
            BoardCharges = model.BoardCharges;
            RoomCharges = model.RoomCharges;
            BooksAndSuppliesCosts = model.BooksAndSuppliesCosts;
            RequiredStudentFees = model.RequiredStudentFees;
            ComprehensiveFee = model.ComprehensiveFee;
            OtherStudentExpenses = model.OtherStudentExpenses;
            PriceOfAttendance = model.PriceOfAttendance;
            IPEDSCollectionYearDesignator = model.IPEDSCollectionYearDesignator;
            RefTuitionUnitId = model.RefTuitionUnitId;
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
