//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleISupportServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaTitleISupportServiceViewModel
     /// </summary>
    public partial class K12LeaTitleISupportServiceViewModel : ViewModelBase, Interfaces.IK12LeaTitleISupportService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaTitleISupportService";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefK12LeaTitleISupportServiceId property
        private Guid? _RefK12LeaTitleISupportServiceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12LeaTitleISupportService"/> model
        /// </summary>
        public Guid? RefK12LeaTitleISupportServiceId { get => _RefK12LeaTitleISupportServiceId; set => SetProperty(ref _RefK12LeaTitleISupportServiceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaTitleISupportService model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefK12LeaTitleISupportServiceId = model.RefK12LeaTitleISupportServiceId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
