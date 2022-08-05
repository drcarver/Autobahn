//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefEducationLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefEducationLevel Interface
     /// </summary>
    public partial interface IRefEducationLevel : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationLevelType"/> model
        /// </summary>
        Guid? RefEducationLevelTypeId { get; set; }

    }
}
