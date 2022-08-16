//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   C_CEDSElementsViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The C_CEDSElementsViewModel
     /// </summary>
    public partial class C_CEDSElementsViewModel : ViewModelBase, Interfaces.IC_CEDSElements
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from C_CEDSElements";

        // member variable for the AltName property
        private System.String _AltName;

        // member variable for the ChangedInThisVersionInd property
        private System.String _ChangedInThisVersionInd;

        // member variable for the ChangeNotes property
        private System.String _ChangeNotes;

        // member variable for the ElementName property
        private System.String _ElementName;

        // member variable for the Format property
        private System.String _Format;

        // member variable for the GlobalID property
        private System.String _GlobalID;

        // member variable for the HasOptionSet property
        private System.Boolean _HasOptionSet;

        // member variable for the TermID property
        private System.Int32 _TermID;

        // member variable for the URL property
        private System.String _URL;

        // member variable for the UsageNotes property
        private System.String _UsageNotes;

        // member variable for the Version property
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public System.String AltName { get => _AltName; set => SetProperty(ref _AltName, value); }

        /// <summary>
        /// </summary>
        public System.String ChangedInThisVersionInd { get => _ChangedInThisVersionInd; set => SetProperty(ref _ChangedInThisVersionInd, value); }

        /// <summary>
        /// </summary>
        public System.String ChangeNotes { get => _ChangeNotes; set => SetProperty(ref _ChangeNotes, value); }

        /// <summary>
        /// </summary>
        public System.String ElementName { get => _ElementName; set => SetProperty(ref _ElementName, value); }

        /// <summary>
        /// </summary>
        public System.String Format { get => _Format; set => SetProperty(ref _Format, value); }

        /// <summary>
        /// </summary>
        public System.String GlobalID { get => _GlobalID; set => SetProperty(ref _GlobalID, value); }

        /// <summary>
        /// </summary>
        public System.Boolean HasOptionSet { get => _HasOptionSet; set => SetProperty(ref _HasOptionSet, value); }

        /// <summary>
        /// </summary>
        public System.Int32 TermID { get => _TermID; set => SetProperty(ref _TermID, value); }

        /// <summary>
        /// </summary>
        public System.String URL { get => _URL; set => SetProperty(ref _URL, value); }

        /// <summary>
        /// </summary>
        public System.String UsageNotes { get => _UsageNotes; set => SetProperty(ref _UsageNotes, value); }

        /// <summary>
        /// </summary>
        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IC_CEDSElements model)
        {
            IsBusy = true;
            Id = model.Id;
            AltName = model.AltName; // 
            ChangedInThisVersionInd = model.ChangedInThisVersionInd; // 
            ChangeNotes = model.ChangeNotes; // 
            ElementName = model.ElementName; // 
            Format = model.Format; // 
            GlobalID = model.GlobalID; // 
            HasOptionSet = model.HasOptionSet; // 
            TermID = model.TermID; // 
            URL = model.URL; // 
            UsageNotes = model.UsageNotes; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
