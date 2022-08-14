//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefCteNonTraditionalGenderStatusModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

using Autobahn.Invalid.Interfaces;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RefCteNonTraditionalGenderStatus Model
     /// </summary>
    public partial class RefCteNonTraditionalGenderStatus : ReferenceModelBase, Interfaces.IRefCteNonTraditionalGenderStatus
    {
        /// <summary>
        /// An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
        /// </summary>
        public Guid RefCTENonTraditionalGenderStatusId { get; set; }

    }
}
