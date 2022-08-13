//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsPriceOfAttendanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsPriceOfAttendanceViewModel
     /// </summary>
    public partial class PsPriceOfAttendanceViewModel : ViewModelBase, Interfaces.IPsPriceOfAttendance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsPriceOfAttendance";

        // member variable for the BoardCharges property
        private System.Decimal? _BoardCharges;

        // member variable for the BooksAndSuppliesCosts property
        private System.Decimal? _BooksAndSuppliesCosts;

        // member variable for the ComprehensiveFee property
        private System.Decimal? _ComprehensiveFee;

        // member variable for the IPEDSCollectionYearDesignator property
        private System.String _IPEDSCollectionYearDesignator;

        // member variable for the OtherStudentExpenses property
        private System.Decimal? _OtherStudentExpenses;

        // member variable for the PriceOfAttendance property
        private System.Decimal? _PriceOfAttendance;

        // member variable for the PsInstitutionId property
        private Guid _PsInstitutionId;

        // member variable for the PSPriceOfAttendanceId property
        private Guid _PSPriceOfAttendanceId;

        // member variable for the RefTuitionUnitId property
        private Guid? _RefTuitionUnitId;

        // member variable for the RequiredStudentFees property
        private System.Decimal? _RequiredStudentFees;

        // member variable for the RoomCharges property
        private System.Decimal? _RoomCharges;

        // member variable for the SessionDesignator property
        private System.String _SessionDesignator;

        // member variable for the TuitionPublished property
        private System.Decimal? _TuitionPublished;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsPriceOfAttendanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? BoardCharges { get => _BoardCharges; set => SetProperty(ref _BoardCharges, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? BooksAndSuppliesCosts { get => _BooksAndSuppliesCosts; set => SetProperty(ref _BooksAndSuppliesCosts, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? ComprehensiveFee { get => _ComprehensiveFee; set => SetProperty(ref _ComprehensiveFee, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.String IPEDSCollectionYearDesignator { get => _IPEDSCollectionYearDesignator; set => SetProperty(ref _IPEDSCollectionYearDesignator, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? OtherStudentExpenses { get => _OtherStudentExpenses; set => SetProperty(ref _OtherStudentExpenses, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? PriceOfAttendance { get => _PriceOfAttendance; set => SetProperty(ref _PriceOfAttendance, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PsInstitution"/> model
        /// </summary>
        public Guid PsInstitutionId { get => _PsInstitutionId; set => SetProperty(ref _PsInstitutionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PSPriceOfAttendance"/> model
        /// </summary>
        public Guid PSPriceOfAttendanceId { get => _PSPriceOfAttendanceId; set => SetProperty(ref _PSPriceOfAttendanceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionUnit"/> model
        /// </summary>
        public Guid? RefTuitionUnitId { get => _RefTuitionUnitId; set => SetProperty(ref _RefTuitionUnitId, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? RequiredStudentFees { get => _RequiredStudentFees; set => SetProperty(ref _RequiredStudentFees, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? RoomCharges { get => _RoomCharges; set => SetProperty(ref _RoomCharges, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.String SessionDesignator { get => _SessionDesignator; set => SetProperty(ref _SessionDesignator, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? TuitionPublished { get => _TuitionPublished; set => SetProperty(ref _TuitionPublished, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsPriceOfAttendance model)
        {
            IsBusy = true;
            Id = model.Id;
            BoardCharges = model.BoardCharges;
            BooksAndSuppliesCosts = model.BooksAndSuppliesCosts;
            ComprehensiveFee = model.ComprehensiveFee;
            IPEDSCollectionYearDesignator = model.IPEDSCollectionYearDesignator;
            OtherStudentExpenses = model.OtherStudentExpenses;
            PriceOfAttendance = model.PriceOfAttendance;
            PsInstitutionId = model.PsInstitutionId;
            PSPriceOfAttendanceId = model.PSPriceOfAttendanceId;
            RefTuitionUnitId = model.RefTuitionUnitId;
            RequiredStudentFees = model.RequiredStudentFees;
            RoomCharges = model.RoomCharges;
            SessionDesignator = model.SessionDesignator;
            TuitionPublished = model.TuitionPublished;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
