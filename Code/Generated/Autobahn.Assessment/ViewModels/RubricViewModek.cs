//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The RubricViewModel
     /// </summary>
    public partial class RubricViewModel : BindableBase, IRubric
    {
#region "Backing Fields"
        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the UrlReference property
        private System.String _UrlReference;

        // member variable for the Description property
        private System.String _Description;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String UrlReference  { get => _UrlReference; set => SetProperty(ref _UrlReference, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IRubric model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            Title = model.Title;
            UrlReference = model.UrlReference;
            Description = model.Description;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
