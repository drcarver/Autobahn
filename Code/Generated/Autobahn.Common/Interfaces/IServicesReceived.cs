//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IServicesReceived.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServicesReceived Interface
     /// </summary>
    public partial interface IServicesReceived : IAutobahnBase
    {
        /// <summary>
        /// Special Education Full Time Equivalency
        /// <para>
        /// Calculated ratio of time the student is in a special education setting. Values range from 0.00 to 1.00. If the student is in a special education setting 25% of the time, the value is .25; if 100% of the time, the value is 1.00.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20208">Special Education Full Time Equivalency</a>
        /// </para>
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServicePlan"/> model
        /// </summary>
        Guid ServicePlanId { get; set; }

    }
}
