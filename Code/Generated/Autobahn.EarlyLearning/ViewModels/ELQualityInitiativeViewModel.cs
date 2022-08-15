//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityInitiativeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELQualityInitiativeViewModel
     /// </summary>
    public partial class ELQualityInitiativeViewModel : ViewModelBase, Interfaces.IELQualityInitiative
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELQualityInitiative";

        // member variable for the ProgramHeathSafetyChecklistUseStatus property
        private System.Boolean? _ProgramHeathSafetyChecklistUseStatus;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELQualityInitiativeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19851">Program Health Safety Checklist Use Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Program Health Safety Checklist Use Status")]
        public System.Boolean? ProgramHeathSafetyChecklistUseStatus { get => _ProgramHeathSafetyChecklistUseStatus; set => SetProperty(ref _ProgramHeathSafetyChecklistUseStatus, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELQualityInitiative model)
        {
            IsBusy = true;
            Id = model.Id;
            ProgramHeathSafetyChecklistUseStatus = model.ProgramHeathSafetyChecklistUseStatus; // Program Health Safety Checklist Use Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
