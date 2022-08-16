//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationProgramType.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationProgramType Interface
     /// </summary>
    public partial interface IOrganizationProgramType : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefProgramTypeId { get; set; }

    }
}
