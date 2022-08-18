//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationFoodServiceViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationFoodService View Model
     /// </summary>
    public partial class ProgramParticipationFoodServiceViewModel : ViewModelBase, Interfaces.IProgramParticipationFoodService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationFoodService";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // RefSchoolFoodServiceProgramId -- (backing property for Participation in School Food Service Programs)
        private Guid _RefSchoolFoodServiceProgramId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Participation in School Food Service Programs
        /// <para>
        /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19325">Participation in School Food Service Programs</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefSchoolFoodServiceProgramId { get => _RefSchoolFoodServiceProgramId; set => SetProperty(ref _RefSchoolFoodServiceProgramId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationFoodService model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            RefSchoolFoodServiceProgramId = model.RefSchoolFoodServiceProgramId; // Participation in School Food Service Programs
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
