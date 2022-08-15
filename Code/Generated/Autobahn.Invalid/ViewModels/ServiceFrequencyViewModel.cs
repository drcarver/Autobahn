//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceFrequencyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ServiceFrequencyViewModel
     /// </summary>
    public partial class ServiceFrequencyViewModel : ViewModelBase, Interfaces.IServiceFrequency
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceFrequency";

        // member variable for the RefFrequencyUnitId property
        private Guid? _RefFrequencyUnitId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ServiceFrequencyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyUnit"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20694">Frequency Unit</a>
        /// </para>
        /// </summary>
        [DisplayName("Frequency Unit")]
        public Guid? RefFrequencyUnitId { get => _RefFrequencyUnitId; set => SetProperty(ref _RefFrequencyUnitId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceFrequency model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFrequencyUnitId = model.RefFrequencyUnitId; // Frequency Unit
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
