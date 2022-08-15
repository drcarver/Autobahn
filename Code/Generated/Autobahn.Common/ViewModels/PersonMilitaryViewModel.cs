//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMilitaryViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonMilitaryViewModel
     /// </summary>
    public partial class PersonMilitaryViewModel : ViewModelBase, Interfaces.IPersonMilitary
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonMilitary";

        // member variable for the RefMilitaryConnectedStudentIndicatorId property
        private Guid? _RefMilitaryConnectedStudentIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonMilitaryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryConnectedStudentIndicator"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20555">Military Connected Student Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Military Connected Student Indicator")]
        public Guid? RefMilitaryConnectedStudentIndicatorId { get => _RefMilitaryConnectedStudentIndicatorId; set => SetProperty(ref _RefMilitaryConnectedStudentIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonMilitary model)
        {
            IsBusy = true;
            Id = model.Id;
            RefMilitaryConnectedStudentIndicatorId = model.RefMilitaryConnectedStudentIndicatorId; // Military Connected Student Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
