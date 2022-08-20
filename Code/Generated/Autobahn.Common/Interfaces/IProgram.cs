//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IProgram.cs
//* Name:       Credits Required
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IProgram : IAutobahnBase
    {
        /// <summary>
        /// Credits Required
        /// <para>
        /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20553">Credits Required</a>
        /// </para>
        /// </summary>
        System.Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

    }
}