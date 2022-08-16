//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaTitleIIIProfessionalDevelopmentViewModel
     /// </summary>
    public partial class K12LeaTitleIIIProfessionalDevelopmentViewModel : ViewModelBase, Interfaces.IK12LeaTitleIIIProfessionalDevelopment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaTitleIIIProfessionalDevelopment";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefTitleIIIProfessionalDevelopmentTypeId property
        private Guid? _RefTitleIIIProfessionalDevelopmentTypeId;

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
        /// Reference to an optional instance of the <see cref="RefTitleIIIProfessionalDevelopmentType"/> model
        /// </summary>
        public Guid? RefTitleIIIProfessionalDevelopmentTypeId { get => _RefTitleIIIProfessionalDevelopmentTypeId; set => SetProperty(ref _RefTitleIIIProfessionalDevelopmentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaTitleIIIProfessionalDevelopment model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefTitleIIIProfessionalDevelopmentTypeId = model.RefTitleIIIProfessionalDevelopmentTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
