//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApipInteractionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The ApipInteractionViewModel
     /// </summary>
    public partial class ApipInteractionViewModel : ViewModelBase, Interfaces.IApipInteraction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ApipInteraction";

        // member variable for the APIPInteractionSequenceNumber property
        private System.Decimal? _APIPInteractionSequenceNumber;

        // member variable for the AssessmentItemApipId property
        private Guid _AssessmentItemApipId;

        // member variable for the RefApipInteractionTypeId property
        private Guid? _RefApipInteractionTypeId;

        // member variable for the SequenceNumber property
        private System.Int32? _SequenceNumber;

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
        /// </summary>
        public System.Decimal? APIPInteractionSequenceNumber { get => _APIPInteractionSequenceNumber; set => SetProperty(ref _APIPInteractionSequenceNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItemApip"/> model
        /// </summary>
        public Guid AssessmentItemApipId { get => _AssessmentItemApipId; set => SetProperty(ref _AssessmentItemApipId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefApipInteractionType"/> model
        /// </summary>
        public Guid? RefApipInteractionTypeId { get => _RefApipInteractionTypeId; set => SetProperty(ref _RefApipInteractionTypeId, value); }

        /// <summary>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </summary>
        public System.Int32? SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        /// <summary>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </summary>
        public System.String Xml { get => _Xml; set => SetProperty(ref _Xml, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IApipInteraction model)
        {
            IsBusy = true;
            Id = model.Id;
            APIPInteractionSequenceNumber = model.APIPInteractionSequenceNumber;
            AssessmentItemApipId = model.AssessmentItemApipId;
            RefApipInteractionTypeId = model.RefApipInteractionTypeId;
            SequenceNumber = model.SequenceNumber;
            Xml = model.Xml;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
