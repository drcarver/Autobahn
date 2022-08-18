//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramModel.cs
//* Name:       Credits Required
//* Definition: The total number of credits required for a student to graduate from the school of enrollment or complete a program.
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The total number of credits required for a student to graduate from the school of enrollment or complete a program.
     /// </summary>
    public partial class ProgramModel : AutobahnBase, Interfaces.IProgram
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
        public System.Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

    }
}
