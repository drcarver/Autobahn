//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIndividualizedProgramTransitionTypeViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RefIndividualizedProgramTransitionTypeViewModel
     /// </summary>
    public partial class RefIndividualizedProgramTransitionTypeViewModel : BindableBase, IRefIndividualizedProgramTransitionType
    {
#region "Backing Fields"
        // member variable for the Description property
        private System.String _Description;

        // member variable for the Code property
        private System.String _Code;

        // member variable for the Definition property
        private System.String _Definition;

        // member variable for the SortOrder property
        private System.Decimal? _SortOrder;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Code  { get => _Code; set => SetProperty(ref _Code, value); }

        public System.String Definition  { get => _Definition; set => SetProperty(ref _Definition, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdictionId"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        public System.Decimal? SortOrder { get => _SortOrder; set => SetProperty(ref _SortOrder, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IRefIndividualizedProgramTransitionType model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description;
            Code = model.Code;
            Definition = model.Definition;
            RefJurisdictionId = model.RefJurisdictionId;
            SortOrder = model.SortOrder;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
