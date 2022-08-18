//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IEPAuthorizationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The IEPAuthorization View Model
     /// </summary>
    public partial class IEPAuthorizationViewModel : ViewModelBase, Interfaces.IIEPAuthorization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPAuthorization";

        // member variable for the AuthorizationDocumentId property
        private Guid _AuthorizationDocumentId;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // RefIEPAuthorizationDocumentTypeId -- (backing property for IEP Authorization Document Type)
        private Guid? _RefIEPAuthorizationDocumentTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAuthorizationDocument"/> model
        /// </summary>
        public Guid AuthorizationDocumentId { get => _AuthorizationDocumentId; set => SetProperty(ref _AuthorizationDocumentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// IEP Authorization Document Type
        /// <para>
        /// Type of Individualized Education Plan document authorized.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20700">IEP Authorization Document Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIEPAuthorizationDocumentTypeId { get => _RefIEPAuthorizationDocumentTypeId; set => SetProperty(ref _RefIEPAuthorizationDocumentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPAuthorization model)
        {
            IsBusy = true;
            Id = model.Id;
            AuthorizationDocumentId = model.AuthorizationDocumentId; // 
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            RefIEPAuthorizationDocumentTypeId = model.RefIEPAuthorizationDocumentTypeId; // IEP Authorization Document Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
