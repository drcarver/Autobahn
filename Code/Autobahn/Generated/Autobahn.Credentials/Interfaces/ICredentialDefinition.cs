//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefinition.cs
//* Name:       Classification of Instructional Program Code
//* Definition: A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
     /// </summary>
    public partial interface ICredentialDefinition : IAutobahnBase
    {
    }
}
