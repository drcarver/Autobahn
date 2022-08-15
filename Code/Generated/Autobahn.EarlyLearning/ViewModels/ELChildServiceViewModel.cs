//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildServiceViewModel
     /// </summary>
    public partial class ELChildServiceViewModel : ViewModelBase, Interfaces.IELChildService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildService";

        // member variable for the RefEarlyChildhoodServicesReceivedId property
        private Guid? _RefEarlyChildhoodServicesReceivedId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodServicesReceived"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19321">Early Childhood Services Received</a>
        /// </para>
        /// </summary>
        [DisplayName("Early Childhood Services Received")]
        public Guid? RefEarlyChildhoodServicesReceivedId { get => _RefEarlyChildhoodServicesReceivedId; set => SetProperty(ref _RefEarlyChildhoodServicesReceivedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildService model)
        {
            IsBusy = true;
            Id = model.Id;
            RefEarlyChildhoodServicesReceivedId = model.RefEarlyChildhoodServicesReceivedId; // Early Childhood Services Received
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
