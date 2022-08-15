//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildHealthViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildHealthViewModel
     /// </summary>
    public partial class ELChildHealthViewModel : ViewModelBase, Interfaces.IELChildHealth
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildHealth";

        // member variable for the RefScheduledWellChildScreeningId property
        private Guid? _RefScheduledWellChildScreeningId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildHealthViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScheduledWellChildScreening"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20602">Scheduled Well Child Screening</a>
        /// </para>
        /// </summary>
        [DisplayName("Scheduled Well Child Screening")]
        public Guid? RefScheduledWellChildScreeningId { get => _RefScheduledWellChildScreeningId; set => SetProperty(ref _RefScheduledWellChildScreeningId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildHealth model)
        {
            IsBusy = true;
            Id = model.Id;
            RefScheduledWellChildScreeningId = model.RefScheduledWellChildScreeningId; // Scheduled Well Child Screening
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
