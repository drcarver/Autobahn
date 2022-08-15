//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationFoodServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationFoodServiceViewModel
     /// </summary>
    public partial class ProgramParticipationFoodServiceViewModel : ViewModelBase, Interfaces.IProgramParticipationFoodService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationFoodService";

        // member variable for the RefSchoolFoodServiceProgramId property
        private Guid _RefSchoolFoodServiceProgramId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationFoodServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolFoodServiceProgram"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19325">Participation in School Food Service Programs</a>
        /// </para>
        /// </summary>
        [DisplayName("Participation in School Food Service Programs")]
        public Guid RefSchoolFoodServiceProgramId { get => _RefSchoolFoodServiceProgramId; set => SetProperty(ref _RefSchoolFoodServiceProgramId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationFoodService model)
        {
            IsBusy = true;
            Id = model.Id;
            RefSchoolFoodServiceProgramId = model.RefSchoolFoodServiceProgramId; // Participation in School Food Service Programs
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
