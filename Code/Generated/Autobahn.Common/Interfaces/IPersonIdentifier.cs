//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonIdentifier.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonIdentifier Interface
     /// </summary>
    public partial interface IPersonIdentifier : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Identifier { get; set; }

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
         RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPersonIdentificationSystemId { get; set; }

    }
}
