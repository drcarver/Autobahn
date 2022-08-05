//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   IRefBuildingHistoricStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The RefBuildingHistoricStatu Interface
     /// </summary>
    public partial interface IRefBuildingHistoricStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefBuildingHistoricStatus"/> model
        /// </summary>
        Guid RefBuildingHistoricStatusId { get; set; }

    }
}
