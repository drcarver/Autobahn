//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAccountProgram.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAccountProgram Interface
     /// </summary>
    public partial interface IFinancialAccountProgram : IAutobahnBase
    {
        /// <summary>
        /// Financial Account Program Name
        /// <para>
        /// The name given to the program area in an educational institution's accounting system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20626">Financial Account Program Name</a>
        /// </para>
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Financial Account Program Number
        /// <para>
        /// A number given to a program area within an educational institution's accounting system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20627">Financial Account Program Number</a>
        /// </para>
        /// </summary>
        System.String ProgramNumber { get; set; }

    }
}
