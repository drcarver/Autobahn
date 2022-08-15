//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServicePlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ServicePlanViewModel
     /// </summary>
    public partial class ServicePlanViewModel : ViewModelBase, Interfaces.IServicePlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServicePlan";

        // member variable for the ReasonForDeclinedServices property
        private System.String _ReasonForDeclinedServices;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ServicePlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20460">Reason for Declined Services</a>
        /// </para>
        /// </summary>
        [DisplayName("Reason for Declined Services")]
        public System.String ReasonForDeclinedServices { get => _ReasonForDeclinedServices; set => SetProperty(ref _ReasonForDeclinedServices, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServicePlan model)
        {
            IsBusy = true;
            Id = model.Id;
            ReasonForDeclinedServices = model.ReasonForDeclinedServices; // Reason for Declined Services
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
