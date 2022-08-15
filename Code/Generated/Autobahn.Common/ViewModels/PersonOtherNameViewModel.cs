//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonOtherNameViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonOtherNameViewModel
     /// </summary>
    public partial class PersonOtherNameViewModel : ViewModelBase, Interfaces.IPersonOtherName
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonOtherName";

        // member variable for the OtherName property
        private System.String _OtherName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonOtherNameViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Previous, alternate or other names or aliases associated with the person.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19206">Other Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Other Name")]
        public System.String OtherName { get => _OtherName; set => SetProperty(ref _OtherName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonOtherName model)
        {
            IsBusy = true;
            Id = model.Id;
            OtherName = model.OtherName; // Other Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
