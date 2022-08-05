//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefGradeLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefGradeLevel Interface
     /// </summary>
    public partial interface IRefGradeLevel : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelType"/> model
        /// </summary>
        Guid? RefGradeLevelTypeId { get; set; }

    }
}
