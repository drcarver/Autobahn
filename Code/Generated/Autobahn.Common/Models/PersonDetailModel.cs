//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailModel.cs
//* Name:       Birthdate
//* Definition: The year, month and day on which a person was born.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The year, month and day on which a person was born.
     /// </summary>
    public partial class PersonDetailModel : AutobahnBase, Interfaces.IPersonDetail
    {
        /// <summary>
        /// Birthdate
        /// <para>
        /// The year, month and day on which a person was born.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19033">Birthdate</a>
        /// </para>
        /// </summary>
        public System.DateTime? Birthdate { get; set; }

        /// <summary>
        /// Birthdate Verification
        /// <para>
        /// The evidence by which a child's date of birth is confirmed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19418">Birthdate Verification</a>
        /// </para>
        /// </summary>
        public System.String BirthdateVerification { get; set; }

        /// <summary>
        /// First Name
        /// <para>
        /// The full legal first name given to a person at birth, baptism, or through legal change.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19115">First Name</a>
        /// </para>
        /// </summary>
        public System.String FirstName { get; set; }

        /// <summary>
        /// Generation Code or Suffix
        /// <para>
        /// An appendage, if any, used to denote a person's generation in his family (e.g., Jr., Sr., III).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19121">Generation Code or Suffix</a>
        /// </para>
        /// </summary>
        public System.String GenerationCode { get; set; }

        /// <summary>
        /// Hispanic or Latino Ethnicity
        /// <para>
        /// An indication that the person traces his or her origin or descent to Mexico, Puerto Rico, Cuba, Central and South America, and other Spanish cultures, regardless of race.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19144">Hispanic or Latino Ethnicity</a>
        /// </para>
        /// </summary>
        public System.Boolean? HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// Last or Surname
        /// <para>
        /// The full legal last name borne in common by members of a family.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19172">Last or Surname</a>
        /// </para>
        /// </summary>
        public System.String LastName { get; set; }

        /// <summary>
        /// Middle Name
        /// <para>
        /// A full legal middle name given to a person at birth, baptism, or through legal change.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19184">Middle Name</a>
        /// </para>
        /// </summary>
        public System.String MiddleName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Personal Title or Prefix
        /// <para>
        /// An appellation, if any, used to denote rank, placement, or status (e.g., Mr., Ms., Reverend, Sister, Dr., Colonel).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19212">Personal Title or Prefix</a>
        /// </para>
        /// </summary>
        public System.String Prefix { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefHighestEducationLevelCompleted"/> model
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProofOfResidencyType"/> model
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefSex"/> model
        /// </summary>
        public Guid? RefSexId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefStateOfResidence"/> model
        /// </summary>
        public Guid? RefStateOfResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefTribalAffiliation"/> model
        /// </summary>
        public Guid? RefTribalAffiliationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefUSCitizenshipStatus"/> model
        /// </summary>
        public Guid? RefUSCitizenshipStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefVisaType"/> model
        /// </summary>
        public Guid? RefVisaTypeId { get; set; }

    }
}
