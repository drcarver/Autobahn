//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressNcesSideViewModel.cs
//**********************************************************

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
        private System.DateTime? _NcesSideDateProcessed;

        // member variable for the NcesSideEstimate property
        private System.Decimal? _NcesSideEstimate;

        // member variable for the NcesSideStandardError property
        private System.Decimal? _NcesSideStandardError;

        // member variable for the NcesSideVintageBeginYear property
        private System.String _NcesSideVintageBeginYear;

        // member variable for the NcesSideVintageEndYear property
        private System.String _NcesSideVintageEndYear;

        // member variable for the PersonAddressId property
        private Guid _PersonAddressId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonAddressNcesSideViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.DateTime? NcesSideDateProcessed { get => _NcesSideDateProcessed; set => SetProperty(ref _NcesSideDateProcessed, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? NcesSideEstimate { get => _NcesSideEstimate; set => SetProperty(ref _NcesSideEstimate, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? NcesSideStandardError { get => _NcesSideStandardError; set => SetProperty(ref _NcesSideStandardError, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String NcesSideVintageBeginYear { get => _NcesSideVintageBeginYear; set => SetProperty(ref _NcesSideVintageBeginYear, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String NcesSideVintageEndYear { get => _NcesSideVintageEndYear; set => SetProperty(ref _NcesSideVintageEndYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonAddress"/> model
        /// </summary>
        public Guid PersonAddressId { get => _PersonAddressId; set => SetProperty(ref _PersonAddressId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddressNcesSide model)
        {
            IsBusy = true;
            Id = model.Id;
            NcesSideDateProcessed = model.NcesSideDateProcessed;
            NcesSideEstimate = model.NcesSideEstimate;
            NcesSideStandardError = model.NcesSideStandardError;
            NcesSideVintageBeginYear = model.NcesSideVintageBeginYear;
            NcesSideVintageEndYear = model.NcesSideVintageEndYear;
            PersonAddressId = model.PersonAddressId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
