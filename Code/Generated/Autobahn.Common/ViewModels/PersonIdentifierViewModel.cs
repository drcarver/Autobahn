//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonIdentifierViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonIdentifierViewModel
     /// </summary>
    public partial class PersonIdentifierViewModel : ViewModelBase, Interfaces.IPersonIdentifier
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonIdentifier";

        // member variable for the Identifier property
        private System.String _Identifier;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonIdentifierViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment by a school, school system, a state, or other agency or entity.  This may be the publisher identifier.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19152">Assessment Identifier</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Identifier")]
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonIdentifier model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier; // Assessment Identifier
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
