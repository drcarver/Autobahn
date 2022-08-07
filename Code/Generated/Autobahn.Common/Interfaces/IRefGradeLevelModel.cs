//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefGradeLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefGradeLevel Interface Model
     /// </summary>
    public partial interface IRefGradeLevelModel : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelType"/> model
        /// </summary>
        Guid? RefGradeLevelTypeId { get; set; }

    }
}
