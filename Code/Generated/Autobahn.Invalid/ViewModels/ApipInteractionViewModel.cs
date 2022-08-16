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

        // member variable for the APIPInteractionSequenceNumber property
        private  _APIPInteractionSequenceNumber;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefApipInteractionTypeId property
        private  _RefApipInteractionTypeId;

        // member variable for the Xml property
        private Guid? _Xml;

        // member variable for the XML property
        private  _XML;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  APIPInteractionSequenceNumber { get => _APIPInteractionSequenceNumber; set => SetProperty(ref _APIPInteractionSequenceNumber, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefApipInteractionType"/> model
        /// </summary>
        public  RefApipInteractionTypeId { get => _RefApipInteractionTypeId; set => SetProperty(ref _RefApipInteractionTypeId, value); }

        /// <summary>
        /// </summary>
        public Guid? Xml { get => _Xml; set => SetProperty(ref _Xml, value); }

        /// <summary>
        /// </summary>
        public  XML { get => _XML; set => SetProperty(ref _XML, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IApipInteraction model)
        {
            IsBusy = true;
            Id = model.Id;
            APIPInteractionSequenceNumber = model.APIPInteractionSequenceNumber; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefApipInteractionTypeId = model.RefApipInteractionTypeId; // 
            Xml = model.Xml; // 
            XML = model.XML; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
