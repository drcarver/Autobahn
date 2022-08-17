//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationWIOAModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ProgramParticipationWIOA Model
     /// </summary>
    public partial class ProgramParticipationWIOAModel : AutobahnBase, Interfaces.IProgramParticipationWIOA
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// WIOA Career Services
        /// <para>
        /// An indication of whether or not the individual has received services as identified in sec. 134(c)(2) of the Workforce Innovation and Opportunity Act (WIOA) consisting of (a) basic career services, (b) individualized career services, or (c) follow-up services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20970">WIOA Career Services</a>
        /// </para>
        /// </summary>
        public System.Boolean? WIOACareerServices { get; set; }

        /// <summary>
        /// WIOA Training Services
        /// <para>
        /// An indication of whether or not the individual has received services as defined by the Workforce Innovation and Opportunity Act (WIOA), one or more courses or classes, or a structured regimen that provides the services in 20 CFR part 680.200 and leads to: (a) An industry-recognized certificate or certification, a certificate of completion of a registered apprenticeship, a license recognized by the State involved or the Federal Government, an associate or baccalaureate degree, or community college certificate of completion; (b) Consistent with  680.350, a secondary school diploma or its equivalent; (c) Employment; or (d) Measurable skill gains toward a credential described in paragraph (a) or (b) of this section or employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20971">WIOA Training Services</a>
        /// </para>
        /// </summary>
        public System.Boolean? WIOATrainingServices { get; set; }

    }
}
