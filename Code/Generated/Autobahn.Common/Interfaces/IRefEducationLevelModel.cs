//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefEducationLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefEducationLevel Interface Model
     /// </summary>
    public partial interface IRefEducationLevelModel : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationLevelType"/> model
        /// </summary>
        Guid? RefEducationLevelTypeId { get; set; }

    }
}
