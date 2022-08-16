//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationIdentifier.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationIdentifier Interface
     /// </summary>
    public partial interface IOrganizationIdentifier : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Identifier { get; set; }

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
         RefOrganizationIdentificationSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefOrganizationIdentifierTypeId { get; set; }

    }
}
