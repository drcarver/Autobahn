//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleViewModel
     /// </summary>
    public partial class OrganizationPersonRoleViewModel : ViewModelBase, Interfaces.IOrganizationPersonRole
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRole";

        // member variable for the EntryDate property
        private System.DateTime? _EntryDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPersonRoleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which the person began to participate in the activity.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19007">Activity Involvement Begin Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Activity Involvement Begin Date")]
        public System.DateTime? EntryDate { get => _EntryDate; set => SetProperty(ref _EntryDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRole model)
        {
            IsBusy = true;
            Id = model.Id;
            EntryDate = model.EntryDate; // Activity Involvement Begin Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
