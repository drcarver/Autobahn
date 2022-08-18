//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffExperience View Model
     /// </summary>
    public partial class StaffExperienceViewModel : ViewModelBase, Interfaces.IStaffExperience
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffExperience";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // YearsOfPriorAETeachingExperience -- (backing property for Years of Prior Adult Education Teaching Experience)
        private System.Decimal? _YearsOfPriorAETeachingExperience;

        // YearsOfPriorTeachingExperience -- (backing property for Years of Prior Teaching Experience)
        private System.Decimal? _YearsOfPriorTeachingExperience;

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
        /// Years of Prior Adult Education Teaching Experience
        /// <para>
        /// The total number of years that a person has previously held a teaching position in one or more adult education programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19774">Years of Prior Adult Education Teaching Experience</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? YearsOfPriorAETeachingExperience { get => _YearsOfPriorAETeachingExperience; set => SetProperty(ref _YearsOfPriorAETeachingExperience, value); }

        /// <summary>
        /// Years of Prior Teaching Experience
        /// <para>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19302">Years of Prior Teaching Experience</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? YearsOfPriorTeachingExperience { get => _YearsOfPriorTeachingExperience; set => SetProperty(ref _YearsOfPriorTeachingExperience, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffExperience model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            YearsOfPriorAETeachingExperience = model.YearsOfPriorAETeachingExperience; // Years of Prior Adult Education Teaching Experience
            YearsOfPriorTeachingExperience = model.YearsOfPriorTeachingExperience; // Years of Prior Teaching Experience
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
