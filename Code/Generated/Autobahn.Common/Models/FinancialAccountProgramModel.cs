//**********************************************************
//* DomainName: Common Models
//* FileName:   FinancialAccountProgramModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The FinancialAccountProgram Model
     /// </summary>
    public partial class FinancialAccountProgramModel : AutobahnBase, Interfaces.IFinancialAccountProgram
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
        public System.String Name { get; set; }

        /// <summary>
        /// Financial Account Program Number
        /// <para>
        /// A number given to a program area within an educational institution's accounting system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20627">Financial Account Program Number</a>
        /// </para>
        /// </summary>
        public System.String ProgramNumber { get; set; }

    }
}
