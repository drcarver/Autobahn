//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDisabilityViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDisabilityViewModel
     /// </summary>
    public partial class PersonDisabilityViewModel : ViewModelBase, Interfaces.IPersonDisability
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDisability";

        // member variable for the PrimaryDisabilityTypeId property
        private Guid? _PrimaryDisabilityTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDisabilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PrimaryDisabilityType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19218">Primary Disability Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Primary Disability Type")]
        public Guid? PrimaryDisabilityTypeId { get => _PrimaryDisabilityTypeId; set => SetProperty(ref _PrimaryDisabilityTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDisability model)
        {
            IsBusy = true;
            Id = model.Id;
            PrimaryDisabilityTypeId = model.PrimaryDisabilityTypeId; // Primary Disability Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region "ICommands for Navigation Properties"
        /// <summary>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19218">Primary Disability Type</a>
        /// </para>
        /// </summary>
        public ICommand PrimaryDisabilityTypeCommand { get; set; }

        #endregion
    }
}
