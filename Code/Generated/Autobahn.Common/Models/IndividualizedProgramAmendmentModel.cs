//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAmendmentModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IndividualizedProgramAmendment Model
     /// </summary>
    public partial class IndividualizedProgramAmendmentModel : AutobahnBase, Interfaces.IIndividualizedProgramAmendment
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Individualized Program Service Plan Amendment Reason Description
        /// <para>
        /// Description of the reason changes were made to the individualized program service plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20669">Individualized Program Service Plan Amendment Reason Description</a>
        /// </para>
        /// </summary>
        public System.String ReasonDescription { get; set; }

    }
}
