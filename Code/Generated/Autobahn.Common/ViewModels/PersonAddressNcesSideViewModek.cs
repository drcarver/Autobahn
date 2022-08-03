//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAddressNcesSideViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAddressNcesSideViewModel
     /// </summary>
    public partial class PersonAddressNcesSideViewModel : BindableBase, IPersonAddressNcesSide
    {
#region "Backing Fields"
        // member variable for the NcesSideDateProcessed property
        private System.DateTime? _NcesSideDateProcessed;

        // member variable for the NcesSideEstimate property
        private System.Decimal? _NcesSideEstimate;

        // member variable for the NcesSideStandardError property
        private System.Decimal? _NcesSideStandardError;

        // member variable for the NcesSideVintageBeginYear property
        private System.String _NcesSideVintageBeginYear;

        // member variable for the NcesSideVintageEndYear property
        private System.String _NcesSideVintageEndYear;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonAddressId"/> model
        /// </summary>
        public Guid PersonAddressId { get; set; }

        public System.DateTime? NcesSideDateProcessed { get => _NcesSideDateProcessed; set => SetProperty(ref _NcesSideDateProcessed, value); }

        public System.Decimal? NcesSideEstimate { get => _NcesSideEstimate; set => SetProperty(ref _NcesSideEstimate, value); }

        public System.Decimal? NcesSideStandardError { get => _NcesSideStandardError; set => SetProperty(ref _NcesSideStandardError, value); }

        public System.String NcesSideVintageBeginYear  { get => _NcesSideVintageBeginYear; set => SetProperty(ref _NcesSideVintageBeginYear, value); }

        public System.String NcesSideVintageEndYear  { get => _NcesSideVintageEndYear; set => SetProperty(ref _NcesSideVintageEndYear, value); }

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
        public void Load(IPersonAddressNcesSide model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonAddressId = model.PersonAddressId;
            NcesSideDateProcessed = model.NcesSideDateProcessed;
            NcesSideEstimate = model.NcesSideEstimate;
            NcesSideStandardError = model.NcesSideStandardError;
            NcesSideVintageBeginYear = model.NcesSideVintageBeginYear;
            NcesSideVintageEndYear = model.NcesSideVintageEndYear;
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
