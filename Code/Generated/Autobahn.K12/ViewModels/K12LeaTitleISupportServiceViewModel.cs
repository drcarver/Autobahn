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

        // member variable for the RefK12LeaTitleISupportServiceId property
        private Guid _RefK12LeaTitleISupportServiceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaTitleISupportServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12LeaTitleISupportService"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19289">Title I Support Services</a>
        /// </para>
        /// </summary>
        [DisplayName("Title I Support Services")]
        public Guid RefK12LeaTitleISupportServiceId { get => _RefK12LeaTitleISupportServiceId; set => SetProperty(ref _RefK12LeaTitleISupportServiceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaTitleISupportService model)
        {
            IsBusy = true;
            Id = model.Id;
            RefK12LeaTitleISupportServiceId = model.RefK12LeaTitleISupportServiceId; // Title I Support Services
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
