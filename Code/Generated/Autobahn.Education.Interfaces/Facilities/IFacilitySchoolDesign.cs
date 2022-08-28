//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilitySchoolDesign.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Facilities
{
     /// <summary>
     /// The IFacilitySchoolDesign Interface
     /// </summary>
    public partial interface IFacilitySchoolDesign : IAutobahnBase
    {
        #region IFacilitySchoolDesign
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
        /// </summary>
        Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Building School Design Type
        /// <para>
        /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20809">Building School Design Type</a>
        /// </para>
        /// </summary>
        Guid RefBuildingSchoolDesignTypeId { get; set; }

        #endregion
    }
}
