//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccountProgram.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The FinancialAccountProgram
     /// </summary>
    public partial class FinancialAccountProgram : IFinancialAccountProgram
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
        /// Defines the FinancialAccountProgram.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FinancialAccountProgram.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
