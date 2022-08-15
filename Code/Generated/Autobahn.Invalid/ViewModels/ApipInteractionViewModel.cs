//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ApipInteractionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ApipInteractionViewModel
     /// </summary>
    public partial class ApipInteractionViewModel : ViewModelBase, Interfaces.IApipInteraction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ApipInteraction";

        // member variable for the Xml property
        private System.String _Xml;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ApipInteractionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20079">Assessment Item Body Custom Interaction XML</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Item Body Custom Interaction XML")]
        public System.String Xml { get => _Xml; set => SetProperty(ref _Xml, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IApipInteraction model)
        {
            IsBusy = true;
            Id = model.Id;
            Xml = model.Xml; // Assessment Item Body Custom Interaction XML
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
