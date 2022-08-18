//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceViewModel.cs
//* Name:       City of Birth
//* Definition:  The name of the city in which a person was born.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     ///  The name of the city in which a person was born.
     /// </summary>
    public partial class PersonBirthplaceViewModel : ViewModelBase, Interfaces.IPersonBirthplace
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonBirthplace";

        // City -- (backing property for City of Birth)
        private System.String _City;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefCountryId -- (backing property for Country of Birth Code)
        private Guid? _RefCountryId;

        // RefStateId -- (backing property for State of Birth Abbreviation)
        private Guid? _RefStateId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// City of Birth
        /// <para>
        ///  The name of the city in which a person was born.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19416">City of Birth</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String City { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Country of Birth Code
        /// <para>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19051">Country of Birth Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        /// <summary>
        /// State of Birth Abbreviation
        /// <para>
        /// The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which a person was born.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19417">State of Birth Abbreviation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonBirthplace model)
        {
            IsBusy = true;
            Id = model.Id;
            City = model.City; // City of Birth
            PersonId = model.PersonId; // 
            RefCountryId = model.RefCountryId; // Country of Birth Code
            RefStateId = model.RefStateId; // State of Birth Abbreviation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
