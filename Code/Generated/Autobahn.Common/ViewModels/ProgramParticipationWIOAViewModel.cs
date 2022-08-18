//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationWIOAViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationWIOA View Model
     /// </summary>
    public partial class ProgramParticipationWIOAViewModel : ViewModelBase, Interfaces.IProgramParticipationWIOA
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationWIOA";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // WIOACareerServices -- (backing property for WIOA Career Services)
        private System.Boolean? _WIOACareerServices;

        // WIOATrainingServices -- (backing property for WIOA Training Services)
        private System.Boolean? _WIOATrainingServices;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// WIOA Career Services
        /// <para>
        /// An indication of whether or not the individual has received services as identified in sec. 134(c)(2) of the Workforce Innovation and Opportunity Act (WIOA) consisting of (a) basic career services, (b) individualized career services, or (c) follow-up services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20970">WIOA Career Services</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? WIOACareerServices { get => _WIOACareerServices; set => SetProperty(ref _WIOACareerServices, value); }

        /// <summary>
        /// WIOA Training Services
        /// <para>
        /// An indication of whether or not the individual has received services as defined by the Workforce Innovation and Opportunity Act (WIOA), one or more courses or classes, or a structured regimen that provides the services in 20 CFR part 680.200 and leads to: (a) An industry-recognized certificate or certification, a certificate of completion of a registered apprenticeship, a license recognized by the State involved or the Federal Government, an associate or baccalaureate degree, or community college certificate of completion; (b) Consistent with  680.350, a secondary school diploma or its equivalent; (c) Employment; or (d) Measurable skill gains toward a credential described in paragraph (a) or (b) of this section or employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20971">WIOA Training Services</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? WIOATrainingServices { get => _WIOATrainingServices; set => SetProperty(ref _WIOATrainingServices, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationWIOA model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            WIOACareerServices = model.WIOACareerServices; // WIOA Career Services
            WIOATrainingServices = model.WIOATrainingServices; // WIOA Training Services
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
