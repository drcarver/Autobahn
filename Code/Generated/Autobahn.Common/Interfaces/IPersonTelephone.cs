//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonTelephone.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonTelephone Interface
     /// </summary>
    public partial interface IPersonTelephone : IAutobahnBase
    {
        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </summary>
        System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

    }
}
