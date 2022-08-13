//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisisViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarCrisisViewModel
     /// </summary>
    public partial class OrganizationCalendarCrisisViewModel : ViewModelBase, Interfaces.IOrganizationCalendarCrisis
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarCrisis";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarCrisisViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarCrisis model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}