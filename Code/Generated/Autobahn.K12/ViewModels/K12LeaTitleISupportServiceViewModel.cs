//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleISupportServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // member variable for the RefK12LeaTitleISupportServiceId property
        private Guid _RefK12LeaTitleISupportServiceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaTitleISupportServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12LeaTitleISupportService"/> model
        /// </summary>
        public Guid RefK12LeaTitleISupportServiceId { get => _RefK12LeaTitleISupportServiceId; set => SetProperty(ref _RefK12LeaTitleISupportServiceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaTitleISupportService model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LeaId = model.K12LeaId;
            RefK12LeaTitleISupportServiceId = model.RefK12LeaTitleISupportServiceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
