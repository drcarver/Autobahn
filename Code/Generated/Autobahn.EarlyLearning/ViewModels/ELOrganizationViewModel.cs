//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationViewModel
     /// </summary>
    public partial class ELOrganizationViewModel : ViewModelBase, Interfaces.IELOrganization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganization";

        // member variable for the RefProfitStatusId property
        private Guid? _RefProfitStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELOrganizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfitStatus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19834">Facility Profit Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Profit Status")]
        public Guid? RefProfitStatusId { get => _RefProfitStatusId; set => SetProperty(ref _RefProfitStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganization model)
        {
            IsBusy = true;
            Id = model.Id;
            RefProfitStatusId = model.RefProfitStatusId; // Facility Profit Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
