//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramServiceViewModel
     /// </summary>
    public partial class IndividualizedProgramServiceViewModel : ViewModelBase, Interfaces.IIndividualizedProgramService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramService";

        // member variable for the PlannedServiceStartDate property
        private System.DateTime? _PlannedServiceStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The date the service is planned to begin.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20350">Individualized Program Planned Service Start Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Individualized Program Planned Service Start Date")]
        public System.DateTime? PlannedServiceStartDate { get => _PlannedServiceStartDate; set => SetProperty(ref _PlannedServiceStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramService model)
        {
            IsBusy = true;
            Id = model.Id;
            PlannedServiceStartDate = model.PlannedServiceStartDate; // Individualized Program Planned Service Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
