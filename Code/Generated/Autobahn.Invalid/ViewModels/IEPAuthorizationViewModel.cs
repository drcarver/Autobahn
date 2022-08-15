//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPAuthorizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IEPAuthorizationViewModel
     /// </summary>
    public partial class IEPAuthorizationViewModel : ViewModelBase, Interfaces.IIEPAuthorization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPAuthorization";

        // member variable for the RefIEPAuthorizationDocumentTypeId property
        private Guid? _RefIEPAuthorizationDocumentTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IEPAuthorizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPAuthorizationDocumentType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20700">IEP Authorization Document Type</a>
        /// </para>
        /// </summary>
        [DisplayName("IEP Authorization Document Type")]
        public Guid? RefIEPAuthorizationDocumentTypeId { get => _RefIEPAuthorizationDocumentTypeId; set => SetProperty(ref _RefIEPAuthorizationDocumentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPAuthorization model)
        {
            IsBusy = true;
            Id = model.Id;
            RefIEPAuthorizationDocumentTypeId = model.RefIEPAuthorizationDocumentTypeId; // IEP Authorization Document Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
