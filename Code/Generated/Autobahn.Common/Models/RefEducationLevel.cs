//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEducationLevel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefEducationLevel Model
     /// </summary>
    public partial class RefEducationLevel : ReferenceModelBase, IRefEducationLevel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationLevelType"/> model
        /// </summary>
        public Guid? RefEducationLevelTypeId { get; set; }

    }
}
