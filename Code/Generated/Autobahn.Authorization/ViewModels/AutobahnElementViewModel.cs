//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AutobahnElementViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AutobahnElement View Model
     /// </summary>
    public partial class AutobahnElementViewModel : ViewModelBase, Interfaces.IAutobahnElement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AutobahnElement";

        // member variable for the AltName property
        private System.String _AltName;

        // member variable for the AutobahnDomainList property
        private System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] _AutobahnDomainList;

        // member variable for the AutobahnTableList property
        private System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] _AutobahnTableList;

        // member variable for the ChangeNotes property
        private System.String _ChangeNotes;

        // member variable for the ElementName property
        private System.String _ElementName;

        // member variable for the Format property
        private System.String _Format;

        // member variable for the GlobalId property
        private Guid _GlobalId;

        // member variable for the HasOptionSet property
        private System.String _HasOptionSet;

        // member variable for the Id property
        private Guid _Id;

        // member variable for the TechnicalName property
        private System.String _TechnicalName;

        // member variable for the TermID property
        private System.String _TermID;

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

        public System.String AltName { get => _AltName; set => SetProperty(ref _AltName, value); }

        public System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnDomainList { get => _AutobahnDomainList; set => SetProperty(ref _AutobahnDomainList, value); }

        public System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnTableList { get => _AutobahnTableList; set => SetProperty(ref _AutobahnTableList, value); }

        public System.String ChangeNotes { get => _ChangeNotes; set => SetProperty(ref _ChangeNotes, value); }

        public System.String ElementName { get => _ElementName; set => SetProperty(ref _ElementName, value); }

        public System.String Format { get => _Format; set => SetProperty(ref _Format, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGlobal"/> model
        /// </summary>
        public Guid GlobalId { get => _GlobalId; set => SetProperty(ref _GlobalId, value); }

        public System.String HasOptionSet { get => _HasOptionSet; set => SetProperty(ref _HasOptionSet, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="I"/> model
        /// </summary>
        public Guid Id { get => _Id; set => SetProperty(ref _Id, value); }

        public System.String TechnicalName { get => _TechnicalName; set => SetProperty(ref _TechnicalName, value); }

        public System.String TermID { get => _TermID; set => SetProperty(ref _TermID, value); }

        public System.String URL { get => _URL; set => SetProperty(ref _URL, value); }

        public System.String UsageNotes { get => _UsageNotes; set => SetProperty(ref _UsageNotes, value); }

        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAutobahnElement model)
        {
            IsBusy = true;
            Id = model.Id;
            AltName = model.AltName; // 
            AutobahnDomainList = model.AutobahnDomainList; // 
            AutobahnTableList = model.AutobahnTableList; // 
            ChangeNotes = model.ChangeNotes; // 
            ElementName = model.ElementName; // 
            Format = model.Format; // 
            GlobalId = model.GlobalId; // 
            HasOptionSet = model.HasOptionSet; // 
            Id = model.Id; // 
            TechnicalName = model.TechnicalName; // 
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
