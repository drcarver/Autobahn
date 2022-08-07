//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccountProgramModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The FinancialAccountProgram Model
     /// </summary>
    public partial class FinancialAccountProgramModel : AutobahnBase, Interfaces.IFinancialAccountProgramModel
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
