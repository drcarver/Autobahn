//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilitySchoolDesign.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The IFacilitySchoolDesign Interface
     /// </summary>
    public partial interface IFacilitySchoolDesign : IAutobahnBase
    {
        /// <summary>
        /// Building Architect Name
        /// <para>
        /// The name of the architect of record for the building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20815">Building Architect Name</a>
        /// </para>
        /// </summary>
        Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSchoolDesignType"/> model
        /// </summary>
        Guid RefBuildingSchoolDesignTypeId { get; set; }

    }
}
