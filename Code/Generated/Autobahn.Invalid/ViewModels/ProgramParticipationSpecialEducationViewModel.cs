//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationSpecialEducationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationSpecialEducationViewModel
     /// </summary>
    public partial class ProgramParticipationSpecialEducationViewModel : ViewModelBase, Interfaces.IProgramParticipationSpecialEducation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationSpecialEducation";

        // member variable for the AwaitingInitialIDEAEvaluationStatus property
        private System.Boolean? _AwaitingInitialIDEAEvaluationStatus;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationSpecialEducationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Awaiting initial evaluation for special education programs and related services under the Individuals with Disabilities Education Act (IDEA). 
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19031">Awaiting Initial IDEA Evaluation Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Awaiting Initial IDEA Evaluation Status")]
        public System.Boolean? AwaitingInitialIDEAEvaluationStatus { get => _AwaitingInitialIDEAEvaluationStatus; set => SetProperty(ref _AwaitingInitialIDEAEvaluationStatus, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationSpecialEducation model)
        {
            IsBusy = true;
            Id = model.Id;
            AwaitingInitialIDEAEvaluationStatus = model.AwaitingInitialIDEAEvaluationStatus; // Awaiting Initial IDEA Evaluation Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
