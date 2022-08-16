//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEmploymentViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEmploymentViewModel
     /// </summary>
    public partial class StaffEmploymentViewModel : ViewModelBase, Interfaces.IStaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEmployment";

        // member variable for the FullTimeEquivalency property
        private Guid? _FullTimeEquivalency;

        // member variable for the HireDate property
        private  _HireDate;

        // member variable for the PositionTitle property
        private  _PositionTitle;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefEmploymentSeparationReasonId property
        private  _RefEmploymentSeparationReasonId;

        // member variable for the RefEmploymentSeparationTypeId property
        private  _RefEmploymentSeparationTypeId;

        // member variable for the StandardOccupationalClassification property
        private  _StandardOccupationalClassification;

        // member variable for the UnionMembershipName property
        private  _UnionMembershipName;

        // member variable for the WeeksEmployedPerYear property
        private  _WeeksEmployedPerYear;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// </summary>
        public  HireDate { get => _HireDate; set => SetProperty(ref _HireDate, value); }

        /// <summary>
        /// </summary>
        public  PositionTitle { get => _PositionTitle; set => SetProperty(ref _PositionTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationReason"/> model
        /// </summary>
        public  RefEmploymentSeparationReasonId { get => _RefEmploymentSeparationReasonId; set => SetProperty(ref _RefEmploymentSeparationReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmploymentSeparationType"/> model
        /// </summary>
        public  RefEmploymentSeparationTypeId { get => _RefEmploymentSeparationTypeId; set => SetProperty(ref _RefEmploymentSeparationTypeId, value); }

        /// <summary>
        /// </summary>
        public  StandardOccupationalClassification { get => _StandardOccupationalClassification; set => SetProperty(ref _StandardOccupationalClassification, value); }

        /// <summary>
        /// </summary>
        public  UnionMembershipName { get => _UnionMembershipName; set => SetProperty(ref _UnionMembershipName, value); }

        /// <summary>
        /// </summary>
        public  WeeksEmployedPerYear { get => _WeeksEmployedPerYear; set => SetProperty(ref _WeeksEmployedPerYear, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeEquivalency = model.FullTimeEquivalency; // 
            HireDate = model.HireDate; // 
            PositionTitle = model.PositionTitle; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefEmploymentSeparationReasonId = model.RefEmploymentSeparationReasonId; // 
            RefEmploymentSeparationTypeId = model.RefEmploymentSeparationTypeId; // 
            StandardOccupationalClassification = model.StandardOccupationalClassification; // 
            UnionMembershipName = model.UnionMembershipName; // 
            WeeksEmployedPerYear = model.WeeksEmployedPerYear; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
