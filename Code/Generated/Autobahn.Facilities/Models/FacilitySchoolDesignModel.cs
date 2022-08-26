//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignModel.cs
//***************************************************************************

using Autobahn.Interfaces.Facilities;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilitySchoolDesign Model
     /// </summary>
    public partial class FacilitySchoolDesignModel : AutobahnBase, IFacilitySchoolDesign
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
        /// </summary>
        public Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Building School Design Type
        /// <para>
        /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20809">Building School Design Type</a>
        /// </para>
        /// </summary>
        public Guid RefBuildingSchoolDesignTypeId { get; set; }

    }
}
