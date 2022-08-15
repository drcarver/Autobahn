//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonIdentifierModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonIdentifier Model
     /// </summary>
    public partial class PersonIdentifierModel : AutobahnBase, Interfaces.IPersonIdentifier
    {
        /// <summary>
        /// A unique number or alphanumeric code assigned to an assessment by a school, school system, a state, or other agency or entity.  This may be the publisher identifier.
        /// </summary>
        public System.String Identifier { get; set; }

    }
}
