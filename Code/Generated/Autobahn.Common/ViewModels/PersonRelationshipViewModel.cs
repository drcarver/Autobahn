//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonRelationshipViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonRelationshipViewModel
     /// </summary>
    public partial class PersonRelationshipViewModel : ViewModelBase, Interfaces.IPersonRelationship
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonRelationship";

        // member variable for the CustodialRelationshipIndicator property
        private System.Boolean? _CustodialRelationshipIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonRelationshipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication that a person has legal custody of a child.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19328">Custodial Parent or Guardian Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Custodial Parent or Guardian Indicator")]
        public System.Boolean? CustodialRelationshipIndicator { get => _CustodialRelationshipIndicator; set => SetProperty(ref _CustodialRelationshipIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonRelationship model)
        {
            IsBusy = true;
            Id = model.Id;
            CustodialRelationshipIndicator = model.CustodialRelationshipIndicator; // Custodial Parent or Guardian Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
