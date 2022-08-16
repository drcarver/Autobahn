//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12CharterSchoolAuthorizerAgency.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12CharterSchoolAuthorizerAgency Interface
     /// </summary>
    public partial interface IK12CharterSchoolAuthorizerAgency : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? K12CharterSchoolAuthorizerAgencyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCharterSchoolAuthorizerTypeId { get; set; }

    }
}
