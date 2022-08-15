//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationNeglectedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationNeglectedViewModel
     /// </summary>
    public partial class ProgramParticipationNeglectedViewModel : ViewModelBase, Interfaces.IProgramParticipationNeglected
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationNeglected";

        // member variable for the RefNeglectedProgramTypeId property
        private Guid? _RefNeglectedProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationNeglectedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefNeglectedProgramType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19194">Neglected or Delinquent Program Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Neglected or Delinquent Program Type")]
        public Guid? RefNeglectedProgramTypeId { get => _RefNeglectedProgramTypeId; set => SetProperty(ref _RefNeglectedProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationNeglected model)
        {
            IsBusy = true;
            Id = model.Id;
            RefNeglectedProgramTypeId = model.RefNeglectedProgramTypeId; // Neglected or Delinquent Program Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
