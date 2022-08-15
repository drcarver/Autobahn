//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PSStudentProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PSStudentProgramViewModel
     /// </summary>
    public partial class PSStudentProgramViewModel : ViewModelBase, Interfaces.IPSStudentProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PSStudentProgram";

        // member variable for the RefCipUseId property
        private Guid? _RefCipUseId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PSStudentProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipUse"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19044">Classification of Instructional Program Use</a>
        /// </para>
        /// </summary>
        [DisplayName("Classification of Instructional Program Use")]
        public Guid? RefCipUseId { get => _RefCipUseId; set => SetProperty(ref _RefCipUseId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPSStudentProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCipUseId = model.RefCipUseId; // Classification of Instructional Program Use
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
