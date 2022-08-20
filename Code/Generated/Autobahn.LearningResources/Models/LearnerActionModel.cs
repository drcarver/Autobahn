//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearnerActionModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearnerAction Model
     /// </summary>
    public partial class LearnerActionModel : AutobahnBase, Interfaces.ILearnerAction
    {
        /// <summary>
        /// Assessment Item Response Aid Set Used
        /// <para>
        /// A tool or aid set used while viewing the item. This can include things like a calculator, reference tools, etc.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19397">Assessment Item Response Aid Set Used</a>
        /// </para>
        /// </summary>
        public Guid? AssessmentItemResponseId { get; set; }

        /// <summary>
        /// Learner Action Actor Identifier
        /// <para>
        ///  A unique identifier for the person performing the learner action.  The identifier should be encrypted when integrating learning experience data across systems to secure the privacy of the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20533">Learner Action Actor Identifier</a>
        /// </para>
        /// </summary>
        public System.String LearnerActionActorIdentifier { get; set; }

        /// <summary>
        /// Learner Action Date Time
        /// <para>
        /// The date and time at which the action was taken.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19938">Learner Action Date Time</a>
        /// </para>
        /// </summary>
        public System.DateTime? LearnerActionDateTime { get; set; }

        /// <summary>
        /// Learner Action Object Description
        /// <para>
        /// A description of the object upon which the person has performed the Learner Action.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20534">Learner Action Object Description</a>
        /// </para>
        /// </summary>
        public System.String LearnerActionObjectDescription { get; set; }

        /// <summary>
        /// Learner Action Object Identifier
        /// <para>
        /// A globally unique identifier for the object upon which the learning has performed the Learner Action which may be a URL with information about a learning resource or to launch the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20535">Learner Action Object Identifier</a>
        /// </para>
        /// </summary>
        public System.String LearnerActionObjectIdentifier { get; set; }

        /// <summary>
        /// Learner Action Object Type
        /// <para>
        /// The type of object upon which a person has performed the Learner Action.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20536">Learner Action Object Type</a>
        /// </para>
        /// </summary>
        public System.String LearnerActionObjectType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActionType"/> model
        /// </summary>
        public Guid? RefLearnerActionTypeId { get; set; }

        /// <summary>
        /// Learner Action Value
        /// <para>
        /// The value representing input by the learner using an online system, such as a value entered in response to an assessment question, or the URL of a learning resource link clicked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19936">Learner Action Value</a>
        /// </para>
        /// </summary>
        public System.String Value { get; set; }

    }
}