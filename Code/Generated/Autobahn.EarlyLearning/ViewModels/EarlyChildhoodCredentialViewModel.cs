//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The EarlyChildhoodCredential View Model
     /// </summary>
    public partial class EarlyChildhoodCredentialViewModel : ViewModelBase, Interfaces.IEarlyChildhoodCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EarlyChildhoodCredential";

        // member variable for the PersonCredentialId property
        private Guid _PersonCredentialId;

        // RefEarlyChildhoodCredentialId -- (backing property for Early Childhood Credential)
        private Guid _RefEarlyChildhoodCredentialId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
        /// </summary>
        public Guid PersonCredentialId { get => _PersonCredentialId; set => SetProperty(ref _PersonCredentialId, value); }

        /// <summary>
        /// Early Childhood Credential
        /// <para>
        /// The credential related to early childhood education or development held by a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefEarlyChildhoodCredentialId { get => _RefEarlyChildhoodCredentialId; set => SetProperty(ref _RefEarlyChildhoodCredentialId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEarlyChildhoodCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonCredentialId = model.PersonCredentialId; // 
            RefEarlyChildhoodCredentialId = model.RefEarlyChildhoodCredentialId; // Early Childhood Credential
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
