//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IEPAuthorizationRejectedViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The IEPAuthorizationRejected View Model
     /// </summary>
    public partial class IEPAuthorizationRejectedViewModel : ViewModelBase, Interfaces.IIEPAuthorizationRejected
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPAuthorizationRejected";

        // member variable for the IEPAuthorizationId property
        private Guid _IEPAuthorizationId;

        // PortionDescription -- (backing property for IEP Authorization Rejected Portion Description)
        private System.String _PortionDescription;

        // PortionExplanation -- (backing property for IEP Authorization Rejected Portion Explanation)
        private System.String _PortionExplanation;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIEPAuthorization"/> model
        /// </summary>
        public Guid IEPAuthorizationId { get => _IEPAuthorizationId; set => SetProperty(ref _IEPAuthorizationId, value); }

        /// <summary>
        /// IEP Authorization Rejected Portion Description
        /// <para>
        /// Portion the authorizer does not want executed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20704">IEP Authorization Rejected Portion Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String PortionDescription { get => _PortionDescription; set => SetProperty(ref _PortionDescription, value); }

        /// <summary>
        /// IEP Authorization Rejected Portion Explanation
        /// <para>
        /// Authorizer's explanation for rejected portions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20705">IEP Authorization Rejected Portion Explanation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String PortionExplanation { get => _PortionExplanation; set => SetProperty(ref _PortionExplanation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPAuthorizationRejected model)
        {
            IsBusy = true;
            Id = model.Id;
            IEPAuthorizationId = model.IEPAuthorizationId; // 
            PortionDescription = model.PortionDescription; // IEP Authorization Rejected Portion Description
            PortionExplanation = model.PortionExplanation; // IEP Authorization Rejected Portion Explanation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
