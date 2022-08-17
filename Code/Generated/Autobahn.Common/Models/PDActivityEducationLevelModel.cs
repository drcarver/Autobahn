//**********************************************************
//* DomainName: Common Models
//* FileName:   PDActivityEducationLevelModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The PDActivityEducationLevel Model
     /// </summary>
    public partial class PDActivityEducationLevelModel : AutobahnBase, Interfaces.IPDActivityEducationLevel
    {
        /// <summary>
        /// Professional Development Activity Code
        /// <para>
        /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20404">Professional Development Activity Code</a>
        /// </para>
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPDActivityEducationLevelsAddressed"/> model
        /// </summary>
        public Guid RefPDActivityEducationLevelsAddressedId { get; set; }

    }
}
