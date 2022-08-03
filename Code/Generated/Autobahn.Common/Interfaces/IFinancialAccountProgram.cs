//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IFinancialAccountProgram.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAccountProgram
     /// </summary>
    public partial interface IFinancialAccountProgram
    {
        /// <summary>
        /// Defines the FinancialAccountProgram.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the FinancialAccountProgram.ProgramNumber non nullable property
        /// </summary>
        System.String ProgramNumber { get; set; }

        /// <summary>
        /// Defines the FinancialAccountProgram.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FinancialAccountProgram.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
