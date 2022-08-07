//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGradeLevelModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefGradeLevel Model
     /// </summary>
    public partial class RefGradeLevelModel : ReferenceModelBase, IRefGradeLevelModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelType"/> model
        /// </summary>
        public Guid? RefGradeLevelTypeId { get; set; }

    }
}
