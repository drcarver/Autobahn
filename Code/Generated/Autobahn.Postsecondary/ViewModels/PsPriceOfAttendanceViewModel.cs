//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsPriceOfAttendanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _BoardCharges;

        // member variable for the BooksAndSuppliesCosts property
        private  _BooksAndSuppliesCosts;

        // member variable for the ComprehensiveFee property
        private  _ComprehensiveFee;

        // member variable for the IPEDSCollectionYearDesignator property
        private  _IPEDSCollectionYearDesignator;

        // member variable for the OtherStudentExpenses property
        private  _OtherStudentExpenses;

        // member variable for the PriceOfAttendance property
        private  _PriceOfAttendance;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefTuitionUnitId property
        private  _RefTuitionUnitId;

        // member variable for the RequiredStudentFees property
        private  _RequiredStudentFees;

        // member variable for the RoomCharges property
        private  _RoomCharges;

        // member variable for the SessionDesignator property
        private Guid? _SessionDesignator;

        // member variable for the TuitionPublished property
        private  _TuitionPublished;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  BoardCharges { get => _BoardCharges; set => SetProperty(ref _BoardCharges, value); }

        /// <summary>
        /// </summary>
        public  BooksAndSuppliesCosts { get => _BooksAndSuppliesCosts; set => SetProperty(ref _BooksAndSuppliesCosts, value); }

        /// <summary>
        /// </summary>
        public  ComprehensiveFee { get => _ComprehensiveFee; set => SetProperty(ref _ComprehensiveFee, value); }

        /// <summary>
        /// </summary>
        public  IPEDSCollectionYearDesignator { get => _IPEDSCollectionYearDesignator; set => SetProperty(ref _IPEDSCollectionYearDesignator, value); }

        /// <summary>
        /// </summary>
        public  OtherStudentExpenses { get => _OtherStudentExpenses; set => SetProperty(ref _OtherStudentExpenses, value); }

        /// <summary>
        /// </summary>
        public  PriceOfAttendance { get => _PriceOfAttendance; set => SetProperty(ref _PriceOfAttendance, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionUnit"/> model
        /// </summary>
        public  RefTuitionUnitId { get => _RefTuitionUnitId; set => SetProperty(ref _RefTuitionUnitId, value); }

        /// <summary>
        /// </summary>
        public  RequiredStudentFees { get => _RequiredStudentFees; set => SetProperty(ref _RequiredStudentFees, value); }

        /// <summary>
        /// </summary>
        public  RoomCharges { get => _RoomCharges; set => SetProperty(ref _RoomCharges, value); }

        /// <summary>
        /// </summary>
        public Guid? SessionDesignator { get => _SessionDesignator; set => SetProperty(ref _SessionDesignator, value); }

        /// <summary>
        /// </summary>
        public  TuitionPublished { get => _TuitionPublished; set => SetProperty(ref _TuitionPublished, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsPriceOfAttendance model)
        {
            IsBusy = true;
            Id = model.Id;
            BoardCharges = model.BoardCharges; // 
            BooksAndSuppliesCosts = model.BooksAndSuppliesCosts; // 
            ComprehensiveFee = model.ComprehensiveFee; // 
            IPEDSCollectionYearDesignator = model.IPEDSCollectionYearDesignator; // 
            OtherStudentExpenses = model.OtherStudentExpenses; // 
            PriceOfAttendance = model.PriceOfAttendance; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefTuitionUnitId = model.RefTuitionUnitId; // 
            RequiredStudentFees = model.RequiredStudentFees; // 
            RoomCharges = model.RoomCharges; // 
            SessionDesignator = model.SessionDesignator; // 
            TuitionPublished = model.TuitionPublished; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
