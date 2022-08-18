//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolAuthorizerAgencyViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgency View Model
     /// </summary>
    public partial class K12CharterSchoolAuthorizerAgencyViewModel : ViewModelBase, Interfaces.IK12CharterSchoolAuthorizerAgency
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12CharterSchoolAuthorizerAgency";

        // member variable for the OrganizationId property
        private Guid? _OrganizationId;

        // RefCharterSchoolAuthorizerTypeId -- (backing property for Charter School Authorizer Type)
        private Guid _RefCharterSchoolAuthorizerTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid? OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Charter School Authorizer Type
        /// <para>
        /// The type of agency that authorized the establishment or continuation of a charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20258">Charter School Authorizer Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefCharterSchoolAuthorizerTypeId { get => _RefCharterSchoolAuthorizerTypeId; set => SetProperty(ref _RefCharterSchoolAuthorizerTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12CharterSchoolAuthorizerAgency model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefCharterSchoolAuthorizerTypeId = model.RefCharterSchoolAuthorizerTypeId; // Charter School Authorizer Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
