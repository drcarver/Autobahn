//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaViewModel
     /// </summary>
    public partial class K12LeaViewModel : ViewModelBase, Interfaces.IK12Lea
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12Lea";

        // member variable for the CharterSchoolIndicator property
        private System.Boolean? _CharterSchoolIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19039">Charter School Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Charter School Indicator")]
        public System.Boolean? CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Lea model)
        {
            IsBusy = true;
            Id = model.Id;
            CharterSchoolIndicator = model.CharterSchoolIndicator; // Charter School Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
