//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeStaff View Model
     /// </summary>
    public partial class AeStaffViewModel : ViewModelBase, Interfaces.IAeStaff
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeStaff";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefAeStaffClassificationId -- (backing property for Adult Education Staff Classification)
        private Guid? _RefAeStaffClassificationId;

        // RefAeStaffEmploymentStatusId -- (backing property for Adult Education Staff Employment Status)
        private Guid? _RefAeStaffEmploymentStatusId;

        // YearsOfPriorAeTeachingExperience -- (backing property for Years of Prior Adult Education Teaching Experience)
        private System.Decimal? _YearsOfPriorAeTeachingExperience;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Adult Education Staff Classification
        /// <para>
        /// The titles of employment, official status, or rank of adult education staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19770">Adult Education Staff Classification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAeStaffClassificationId { get => _RefAeStaffClassificationId; set => SetProperty(ref _RefAeStaffClassificationId, value); }

        /// <summary>
        /// Adult Education Staff Employment Status
        /// <para>
        /// The condition under which a person has agreed to serve as an employee.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19771">Adult Education Staff Employment Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAeStaffEmploymentStatusId { get => _RefAeStaffEmploymentStatusId; set => SetProperty(ref _RefAeStaffEmploymentStatusId, value); }

        /// <summary>
        /// Years of Prior Adult Education Teaching Experience
        /// <para>
        /// The total number of years that a person has previously held a teaching position in one or more adult education programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19774">Years of Prior Adult Education Teaching Experience</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? YearsOfPriorAeTeachingExperience { get => _YearsOfPriorAeTeachingExperience; set => SetProperty(ref _YearsOfPriorAeTeachingExperience, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeStaff model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefAeStaffClassificationId = model.RefAeStaffClassificationId; // Adult Education Staff Classification
            RefAeStaffEmploymentStatusId = model.RefAeStaffEmploymentStatusId; // Adult Education Staff Employment Status
            YearsOfPriorAeTeachingExperience = model.YearsOfPriorAeTeachingExperience; // Years of Prior Adult Education Teaching Experience
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
