//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonRelationshipModel.cs
//* Name:       Person Relationship to Learner Contact Priority Number
//* Definition: The numeric order in the preferred sequence and priority for contacting a person related to the learner.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The numeric order in the preferred sequence and priority for contacting a person related to the learner.
     /// </summary>
    public partial class PersonRelationshipModel : AutobahnBase, Interfaces.IPersonRelationship
    {
        /// <summary>
        /// Person Relationship to Learner Contact Priority Number
        /// <para>
        /// The numeric order in the preferred sequence and priority for contacting a person related to the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20392">Person Relationship to Learner Contact Priority Number</a>
        /// </para>
        /// </summary>
        public System.Int32? ContactPriorityNumber { get; set; }

        /// <summary>
        /// Person Relationship to Learner Contact Restrictions Description
        /// <para>
        /// Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20393">Person Relationship to Learner Contact Restrictions Description</a>
        /// </para>
        /// </summary>
        public System.String ContactRestrictions { get; set; }

        /// <summary>
        /// Custodial Parent or Guardian Indicator
        /// <para>
        /// An indication that a person has legal custody of a child.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19328">Custodial Parent or Guardian Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? CustodialRelationshipIndicator { get; set; }

        /// <summary>
        /// Emergency Contact Indicator
        /// <para>
        /// Indicates whether or not the person is a designated emergency contact for the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20308">Emergency Contact Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? EmergencyContactInd { get; set; }

        /// <summary>
        /// Person Relationship to Learner Lives with Indicator
        /// <para>
        /// Indicates whether or not the learner lives with the related person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20394">Person Relationship to Learner Lives with Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? LivesWithIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Primary Contact Indicator
        /// <para>
        /// Indicates that a person is a primary contact within the specified context, such as a primary parental contact specified in Person Relationship to Learner or a primary administrative contact for an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20397">Primary Contact Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? PrimaryContactIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPersonRelationshipType"/> model
        /// </summary>
        public Guid RefPersonRelationshipTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRelatedPerson"/> model
        /// </summary>
        public Guid RelatedPersonId { get; set; }

    }
}
