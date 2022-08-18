//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicHonorViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentAcademicHonor View Model
     /// </summary>
    public partial class K12StudentAcademicHonorViewModel : ViewModelBase, Interfaces.IK12StudentAcademicHonor
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentAcademicHonor";

        // HonorDescription -- (backing property for Honors Description)
        private System.String _HonorDescription;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefAcademicHonorTypeId -- (backing property for Academic Honors Type)
        private Guid? _RefAcademicHonorTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Honors Description
        /// <para>
        /// A description of the type of academic distinctions earned by or awarded to the person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19150">Honors Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String HonorDescription { get => _HonorDescription; set => SetProperty(ref _HonorDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Academic Honors Type
        /// <para>
        /// A designation of the type of academic distinctions earned by or awarded to the student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19004">Academic Honors Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAcademicHonorTypeId { get => _RefAcademicHonorTypeId; set => SetProperty(ref _RefAcademicHonorTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentAcademicHonor model)
        {
            IsBusy = true;
            Id = model.Id;
            HonorDescription = model.HonorDescription; // Honors Description
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefAcademicHonorTypeId = model.RefAcademicHonorTypeId; // Academic Honors Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
