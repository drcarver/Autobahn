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
        /// A unique number or alphanumeric code assigned to an assessment by a school, school system, a state, or other agency or entity.  This may be the publisher identifier.
        /// </summary>
        System.String Identifier { get; set; }

    }
}
