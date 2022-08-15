//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentDisciplineViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentDisciplineViewModel
     /// </summary>
    public partial class K12StudentDisciplineViewModel : ViewModelBase, Interfaces.IK12StudentDiscipline
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentDiscipline";

        // member variable for the DisciplinaryActionEndDate property
        private System.DateTime? _DisciplinaryActionEndDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentDisciplineViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19082">Disciplinary Action End Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Disciplinary Action End Date")]
        public System.DateTime? DisciplinaryActionEndDate { get => _DisciplinaryActionEndDate; set => SetProperty(ref _DisciplinaryActionEndDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentDiscipline model)
        {
            IsBusy = true;
            Id = model.Id;
            DisciplinaryActionEndDate = model.DisciplinaryActionEndDate; // Disciplinary Action End Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
