//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Interfaces
{
     /// <summary>
     /// The FacilitySchoolDesign Model
     /// </summary>
    public partial class FacilitySchoolDesignModel : AutobahnBase, Interfaces.IFacilitySchoolDesign
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
        public Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefBuildingSchoolDesignType"/> model
        /// </summary>
        public Guid RefBuildingSchoolDesignTypeId { get; set; }

    }
}
