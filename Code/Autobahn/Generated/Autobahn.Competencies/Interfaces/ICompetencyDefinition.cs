//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefinition.cs
//* Name:       Competency Definition Identifier
//* Definition: The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The globally unique identifier (GUID) issued by the publisher of the competency framework that uniquely identifies the definition in the hierarchy of competency definitions using a RFC 4122 compliant 32-character hexadecimal string, such as 21EC2020-3AEA-1069-A2DD-08002B30309D.
     /// </summary>
    public partial interface ICompetencyDefinition : IAutobahnBase
    {
    }
}
