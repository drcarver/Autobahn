//**********************************************************
//* DomainName: Common Models
//* FileName:   ServiceProvidedViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ServiceProvided View Model
     /// </summary>
    public partial class ServiceProvidedViewModel : ViewModelBase, Interfaces.IServiceProvided
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceProvided";

        // RefServicesId -- (backing property for Early Childhood Services Received)
        private Guid? _RefServicesId;

        // RefStudentSupportServiceTypeId -- (backing property for Student Support Service Type)
        private Guid? _RefStudentSupportServiceTypeId;

        // member variable for the ServicesReceivedId property
        private Guid _ServicesReceivedId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Early Childhood Services Received
        /// <para>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19321">Early Childhood Services Received</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefServicesId { get => _RefServicesId; set => SetProperty(ref _RefServicesId, value); }

        /// <summary>
        /// Student Support Service Type
        /// <para>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19273">Student Support Service Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefStudentSupportServiceTypeId { get => _RefStudentSupportServiceTypeId; set => SetProperty(ref _RefStudentSupportServiceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
        /// </summary>
        public Guid ServicesReceivedId { get => _ServicesReceivedId; set => SetProperty(ref _ServicesReceivedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceProvided model)
        {
            IsBusy = true;
            Id = model.Id;
            RefServicesId = model.RefServicesId; // Early Childhood Services Received
            RefStudentSupportServiceTypeId = model.RefStudentSupportServiceTypeId; // Student Support Service Type
            ServicesReceivedId = model.ServicesReceivedId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
