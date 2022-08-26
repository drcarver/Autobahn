//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Person Model
     /// </summary>
    public partial class PersonModel : AutobahnBase, IPerson
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonMaster"/> model
        /// </summary>
        public Guid? PersonMasterId { get; set; }

    }
}
