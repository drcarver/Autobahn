//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonStatusViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonStatusViewModel
     /// </summary>
    public partial class PersonStatusViewModel : ViewModelBase, Interfaces.IPersonStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonStatus";

        // member variable for the RefPersonStatusTypeId property
        private Guid _RefPersonStatusTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonStatusType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19086">Economic Disadvantage Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Economic Disadvantage Status")]
        public Guid RefPersonStatusTypeId { get => _RefPersonStatusTypeId; set => SetProperty(ref _RefPersonStatusTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RefPersonStatusTypeId = model.RefPersonStatusTypeId; // Economic Disadvantage Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
