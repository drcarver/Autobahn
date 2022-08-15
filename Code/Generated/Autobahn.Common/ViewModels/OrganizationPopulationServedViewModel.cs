//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPopulationServedViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPopulationServedViewModel
     /// </summary>
    public partial class OrganizationPopulationServedViewModel : ViewModelBase, Interfaces.IOrganizationPopulationServed
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPopulationServed";

        // member variable for the YoungestAgeServed property
        private System.Int32? _YoungestAgeServed;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPopulationServedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19626">Early Learning Youngest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        [DisplayName("Early Learning Youngest Age Authorized to Serve")]
        public System.Int32? YoungestAgeServed { get => _YoungestAgeServed; set => SetProperty(ref _YoungestAgeServed, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPopulationServed model)
        {
            IsBusy = true;
            Id = model.Id;
            YoungestAgeServed = model.YoungestAgeServed; // Early Learning Youngest Age Authorized to Serve
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
