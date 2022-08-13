//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // member variable for the K12LEATitleIIIProfessionalDevelopmentId property
        private Guid _K12LEATitleIIIProfessionalDevelopmentId;

        // member variable for the RefTitleIIIProfessionalDevelopmentTypeId property
        private Guid _RefTitleIIIProfessionalDevelopmentTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaTitleIIIProfessionalDevelopmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12LEATitleIIIProfessionalDevelopment"/> model
        /// </summary>
        public Guid K12LEATitleIIIProfessionalDevelopmentId { get => _K12LEATitleIIIProfessionalDevelopmentId; set => SetProperty(ref _K12LEATitleIIIProfessionalDevelopmentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIIProfessionalDevelopmentType"/> model
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
            K12LeaId = model.K12LeaId;
            K12LEATitleIIIProfessionalDevelopmentId = model.K12LEATitleIIIProfessionalDevelopmentId;
            RefTitleIIIProfessionalDevelopmentTypeId = model.RefTitleIIIProfessionalDevelopmentTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
