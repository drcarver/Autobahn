//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaTitleIIIProfessionalDevelopmentViewModel
     /// </summary>
    public partial class K12LeaTitleIIIProfessionalDevelopmentViewModel : ViewModelBase, Interfaces.IK12LeaTitleIIIProfessionalDevelopmentViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaTitleIIIProfessionalDevelopment";

        // member variable for the K12LEATitleIIIProfessionalDevelopmentId property
        private Guid _K12LEATitleIIIProfessionalDevelopmentId;

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // member variable for the RefTitleIIIProfessionalDevelopmentTypeId property
        private Guid _RefTitleIIIProfessionalDevelopmentTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaTitleIIIProfessionalDevelopmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEATitleIIIProfessionalDevelopmentId"/> model
        /// </summary>
        public Guid K12LEATitleIIIProfessionalDevelopmentId { get => _K12LEATitleIIIProfessionalDevelopmentId; set => SetProperty(ref _K12LEATitleIIIProfessionalDevelopmentId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LeaId"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIIIProfessionalDevelopmentTypeId"/> model
        /// </summary>
        public Guid RefTitleIIIProfessionalDevelopmentTypeId { get => _RefTitleIIIProfessionalDevelopmentTypeId; set => SetProperty(ref _RefTitleIIIProfessionalDevelopmentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaTitleIIIProfessionalDevelopment model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LEATitleIIIProfessionalDevelopmentId = model.K12LEATitleIIIProfessionalDevelopmentId;
            K12LeaId = model.K12LeaId;
            RefTitleIIIProfessionalDevelopmentTypeId = model.RefTitleIIIProfessionalDevelopmentTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
