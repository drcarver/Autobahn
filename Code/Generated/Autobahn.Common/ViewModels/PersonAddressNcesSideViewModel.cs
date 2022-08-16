//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressNcesSideViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAddressNcesSideViewModel
     /// </summary>
    public partial class PersonAddressNcesSideViewModel : ViewModelBase, Interfaces.IPersonAddressNcesSide
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAddressNcesSide";

        // member variable for the NcesSideDateProcessed property
        private  _NcesSideDateProcessed;

        // member variable for the NcesSideEstimate property
        private  _NcesSideEstimate;

        // member variable for the NcesSideStandardError property
        private  _NcesSideStandardError;

        // member variable for the NcesSideVintageBeginYear property
        private  _NcesSideVintageBeginYear;

        // member variable for the NcesSideVintageEndYear property
        private  _NcesSideVintageEndYear;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  NcesSideDateProcessed { get => _NcesSideDateProcessed; set => SetProperty(ref _NcesSideDateProcessed, value); }

        /// <summary>
        /// </summary>
        public  NcesSideEstimate { get => _NcesSideEstimate; set => SetProperty(ref _NcesSideEstimate, value); }

        /// <summary>
        /// </summary>
        public  NcesSideStandardError { get => _NcesSideStandardError; set => SetProperty(ref _NcesSideStandardError, value); }

        /// <summary>
        /// </summary>
        public  NcesSideVintageBeginYear { get => _NcesSideVintageBeginYear; set => SetProperty(ref _NcesSideVintageBeginYear, value); }

        /// <summary>
        /// </summary>
        public  NcesSideVintageEndYear { get => _NcesSideVintageEndYear; set => SetProperty(ref _NcesSideVintageEndYear, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddressNcesSide model)
        {
            IsBusy = true;
            Id = model.Id;
            NcesSideDateProcessed = model.NcesSideDateProcessed; // 
            NcesSideEstimate = model.NcesSideEstimate; // 
            NcesSideStandardError = model.NcesSideStandardError; // 
            NcesSideVintageBeginYear = model.NcesSideVintageBeginYear; // 
            NcesSideVintageEndYear = model.NcesSideVintageEndYear; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
