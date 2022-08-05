//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccountProgram.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The FinancialAccountProgram
     /// </summary>
    public partial class FinancialAccountProgram : AutobahnBase, Interfaces.IFinancialAccountProgram
    {
        /// <summary>
        /// Defines the FinancialAccountProgram.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the FinancialAccountProgram.ProgramNumber non nullable property
        /// </summary>
        public System.String ProgramNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
