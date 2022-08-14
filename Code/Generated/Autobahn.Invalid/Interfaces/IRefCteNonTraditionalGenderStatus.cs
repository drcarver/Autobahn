//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IRefCteNonTraditionalGenderStatus.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The RefCteNonTraditionalGenderStatus Interface Model
     /// </summary>
    public partial interface IRefCteNonTraditionalGenderStatus : IReferenceModel
    {
        /// <summary>
        /// An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
        /// </summary>
        Guid RefCTENonTraditionalGenderStatusId { get; set; }

    }
}
