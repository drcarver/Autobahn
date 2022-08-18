//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAccommodationSubjectViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubject View Model
     /// </summary>
    public partial class IndividualizedProgramAccommodationSubjectViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAccommodationSubject
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAccommodationSubject";

        // member variable for the IndividualizedProgramAccommodationId property
        private Guid _IndividualizedProgramAccommodationId;

        // RefSCEDCourseSubjectAreaId -- (backing property for School Courses for the Exchange of Data Course Subject Area)
        private Guid _RefSCEDCourseSubjectAreaId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgramAccommodation"/> model
        /// </summary>
        public Guid IndividualizedProgramAccommodationId { get => _IndividualizedProgramAccommodationId; set => SetProperty(ref _IndividualizedProgramAccommodationId, value); }

        /// <summary>
        /// School Courses for the Exchange of Data Course Subject Area
        /// <para>
        /// The intended major subject area of the education course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20491">School Courses for the Exchange of Data Course Subject Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefSCEDCourseSubjectAreaId { get => _RefSCEDCourseSubjectAreaId; set => SetProperty(ref _RefSCEDCourseSubjectAreaId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAccommodationSubject model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramAccommodationId = model.IndividualizedProgramAccommodationId; // 
            RefSCEDCourseSubjectAreaId = model.RefSCEDCourseSubjectAreaId; // School Courses for the Exchange of Data Course Subject Area
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
