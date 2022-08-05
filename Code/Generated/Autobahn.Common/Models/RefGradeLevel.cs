//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGradeLevel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefGradeLevel Model
     /// </summary>
    public partial class RefGradeLevel : ReferenceModelBase, IRefGradeLevel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelType"/> model
        /// </summary>
        public Guid? RefGradeLevelTypeId { get; set; }

    }
}
