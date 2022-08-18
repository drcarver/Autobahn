//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeProviderViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeProvider View Model
     /// </summary>
    public partial class AeProviderViewModel : ViewModelBase, Interfaces.IAeProvider
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeProvider";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefLevelOfInstitutionId -- (backing property for Level of Institution)
        private Guid _RefLevelOfInstitutionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Level of Institution
        /// <para>
        /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefLevelOfInstitutionId { get => _RefLevelOfInstitutionId; set => SetProperty(ref _RefLevelOfInstitutionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeProvider model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefLevelOfInstitutionId = model.RefLevelOfInstitutionId; // Level of Institution
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
