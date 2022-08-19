//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearnerActionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearnerAction View Model
     /// </summary>
    public partial class LearnerActionViewModel : ViewModelBase, Interfaces.ILearnerAction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerAction";

        // member variable for the AssessmentItemResponseId property
        private Guid? _AssessmentItemResponseId;

        // LearnerActionActorIdentifier -- (backing property for Learner Action Actor Identifier)
        private System.String _LearnerActionActorIdentifier;

        // LearnerActionDateTime -- (backing property for Learner Action Date Time)
        private System.DateTime? _LearnerActionDateTime;

        // LearnerActionObjectDescription -- (backing property for Learner Action Object Description)
        private System.String _LearnerActionObjectDescription;

        // LearnerActionObjectIdentifier -- (backing property for Learner Action Object Identifier)
        private System.String _LearnerActionObjectIdentifier;

        // LearnerActionObjectType -- (backing property for Learner Action Object Type)
        private System.String _LearnerActionObjectType;

        // RefLearnerActionTypeId -- (backing property for Learner Action Type)
        private Guid? _RefLearnerActionTypeId;

        // Value -- (backing property for Learner Action Value)
        private System.String _Value;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItemResponse"/> model
        /// </summary>
        public Guid? AssessmentItemResponseId { get => _AssessmentItemResponseId; set => SetProperty(ref _AssessmentItemResponseId, value); }

        /// <summary>
        /// Learner Action Actor Identifier
        /// <para>
        ///  A unique identifier for the person performing the learner action.  The identifier should be encrypted when integrating learning experience data across systems to secure the privacy of the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20533">Learner Action Actor Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LearnerActionActorIdentifier { get => _LearnerActionActorIdentifier; set => SetProperty(ref _LearnerActionActorIdentifier, value); }

        /// <summary>
        /// Learner Action Date Time
        /// <para>
        /// The date and time at which the action was taken.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19938">Learner Action Date Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? LearnerActionDateTime { get => _LearnerActionDateTime; set => SetProperty(ref _LearnerActionDateTime, value); }

        /// <summary>
        /// Learner Action Object Description
        /// <para>
        /// A description of the object upon which the person has performed the Learner Action.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20534">Learner Action Object Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LearnerActionObjectDescription { get => _LearnerActionObjectDescription; set => SetProperty(ref _LearnerActionObjectDescription, value); }

        /// <summary>
        /// Learner Action Object Identifier
        /// <para>
        /// A globally unique identifier for the object upon which the learning has performed the Learner Action which may be a URL with information about a learning resource or to launch the resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20535">Learner Action Object Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LearnerActionObjectIdentifier { get => _LearnerActionObjectIdentifier; set => SetProperty(ref _LearnerActionObjectIdentifier, value); }

        /// <summary>
        /// Learner Action Object Type
        /// <para>
        /// The type of object upon which a person has performed the Learner Action.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20536">Learner Action Object Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String LearnerActionObjectType { get => _LearnerActionObjectType; set => SetProperty(ref _LearnerActionObjectType, value); }

        /// <summary>
        /// Learner Action Type
        /// <para>
        /// The type of action taken by the learner.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19935">Learner Action Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLearnerActionTypeId { get => _RefLearnerActionTypeId; set => SetProperty(ref _RefLearnerActionTypeId, value); }

        /// <summary>
        /// Learner Action Value
        /// <para>
        /// The value representing input by the learner using an online system, such as a value entered in response to an assessment question, or the URL of a learning resource link clicked.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19936">Learner Action Value</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Value { get => _Value; set => SetProperty(ref _Value, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerAction model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemResponseId = model.AssessmentItemResponseId; // 
            LearnerActionActorIdentifier = model.LearnerActionActorIdentifier; // Learner Action Actor Identifier
            LearnerActionDateTime = model.LearnerActionDateTime; // Learner Action Date Time
            LearnerActionObjectDescription = model.LearnerActionObjectDescription; // Learner Action Object Description
            LearnerActionObjectIdentifier = model.LearnerActionObjectIdentifier; // Learner Action Object Identifier
            LearnerActionObjectType = model.LearnerActionObjectType; // Learner Action Object Type
            RefLearnerActionTypeId = model.RefLearnerActionTypeId; // Learner Action Type
            Value = model.Value; // Learner Action Value
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLearnerActionType List
        /// <summary>
        /// The complete <see cref="RefLearnerActionType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLearnerActionTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("2f3b7adf-5b11-45ff-9dd2-f508ff8cc289"), Code="abandoned", Description="Abandoned", Definition="Indicates the activity provider has determined that the session was abnormally terminated either by an actor or due to a system failure.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff5d3d45-7fef-41d3-8d1b-5853880fe532"), Code="answered", Description="Answered", Definition="Indicates the actor replied to a question, where the object is generally an activity representing the question. The text of the answer will often be included in the response inside result.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("882b8dff-59dc-42e5-8518-95db282ecf6b"), Code="asked", Description="Asked", Definition="Indicates an inquiry by an actor with the expectation of a response or answer to a question.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("b4c09c04-70ab-45ec-b1ae-8ecf14e952af"), Code="attempted", Description="Attempted", Definition="Indicates the actor made an effort to access the object. An attempt statement without additional activities could be considered incomplete in some cases.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c9bf04bc-122d-4e10-a3ca-d957750a7b13"), Code="attended", Description="Attended", Definition="Indicates the actor was present at a virtual or physical event or activity.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("9b951947-5b64-4e76-a8a4-fc24d7e35f52"), Code="commented", Description="Commented", Definition="Indicates the actor provided digital or written annotations on or about an object.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("bedda12e-8f46-499d-943c-d1840b3bc87e"), Code="completed", Description="Completed", Definition="Indicates the actor finished or concluded the activity normally.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("c053cb39-4dde-41e7-8a1c-935ea9c51bba"), Code="exited", Description="Exited", Definition="Indicates the actor intentionally departed from the activity or object.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("760dd9d2-7cbe-4159-908b-961ed793e625"), Code="experienced", Description="Experienced", Definition="Indicates the actor only encountered the object, and is applicable in situations where a specific achievement or completion is not required.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("bf1a9f33-3bf4-4a1d-b091-1aee79b018a0"), Code="failed", Description="Failed", Definition="Indicates the actor did not successfully pass an activity to a level of predetermined satisfaction.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("d3637d36-3309-4d54-a487-acd3c04a1ea8"), Code="imported", Description="Imported", Definition="Indicates the actor introduced an object into a physical or virtual location.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("af5e3fc6-8e70-4628-9ebe-7173a5a7a34a"), Code="initialized", Description="Initialized", Definition="Indicates the activity provider has determined that the actor successfully started an activity.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a02606c-c558-43d2-9b40-e7ce5d89dd38"), Code="interacted", Description="Interacted", Definition="Indicates the actor engaged with a physical or virtual object.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("bbdd61e0-3510-4794-bc72-3fbfdfb10917"), Code="launched", Description="Launched", Definition="Indicates the actor attempted to start an activity.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("5b7c4407-9044-4885-bec7-fd697d99cfa7"), Code="logged-in", Description="Logged-In", Definition="Indicates the actor gained access to a system or service by identifying and authenticating with the credentials provided by the actor.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("30335f76-624d-4efb-8039-3612451d778e"), Code="logged-out", Description="Logged-Out", Definition="Indicates the actor either lost or discontinued access to a system or service.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("cdb0a14d-29d4-4b02-a79d-68b5bca72d88"), Code="mastered", Description="Mastered", Definition="Indicates the highest level of comprehension or competence the actor performed in an activity.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("73a2c678-39ed-4804-8542-78fb62dcfcb9"), Code="passed", Description="Passed", Definition="Indicates the actor successfully passed an activity to a level of predetermined satisfaction.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d3f458a-dec1-4bd4-8be2-bbdc3e6ba03e"), Code="preferred", Description="Preferred", Definition="Indicates the selected choices, favored options or settings of an actor in relation to an object or activity.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("2e289f8c-194c-4720-ae24-c74b74622bfd"), Code="progressed", Description="Progressed", Definition="Indicates a value of how much of an actor has advanced or moved through an activity.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("2870627a-650d-4f66-99b0-40fe615fb05b"), Code="registered", Description="Registered", Definition="Indicates the actor is officially enrolled or inducted in an activity.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("5d5dfc11-3646-4afa-b9b7-67cd574c5c6c"), Code="responded", Description="Responded", Definition="Indicates an actor reacted or replied to an object.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("c9170382-51cd-419c-a3a5-449c686d9740"), Code="resumed", Description="Resumed", Definition="Indicates the application has determined that the actor continued or reopened a suspended attempt on an activity.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("f54ee436-58a4-4095-b879-7898fecfc4e7"), Code="satisfied", Description="Satisfied", Definition="Indicates that the authority or activity provider determined the actor has fulfilled the criteria of the object or activity.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("09ad6eb9-5968-463c-93b2-a5e88bc529b0"), Code="scored", Description="Scored", Definition="Indicates a numerical value related to an actor's performance on an activity.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("07619fd0-348d-439e-9fbb-f8b0270e64fe"), Code="shared", Description="Shared", Definition="Indicates the actor's intent to openly provide access to an object of common interest to other actors or groups.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("a2b33e49-dfde-4105-9e43-bdbf4acb38f7"), Code="suspended", Description="Suspended", Definition="Indicates the status of a temporarily halted activity when an actor's intent is returning to the or object activity at a later time.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("d49ab9a8-ce33-46b7-8fe0-a42477fcabc6"), Code="terminated", Description="Terminated", Definition="Indicates that the actor successfully ended an activity.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("0c5fe55b-2fdd-488b-84f0-78ef437dbb0a"), Code="voided", Description="Voided", Definition="A special reserved verb used by a LRS or application to mark a statement as invalid. See the xAPI specification for details on Voided statements.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed28120e-b811-4fed-9334-66ec825f56a9"), Code="waived", Description="Waived", Definition="Indicates that the learning activity requirements were met by means other than completing the activity. A waived statement is used to indicate that the activity may be skipped by the actor.", SortOrder=Convert.ToDecimal("30.00") },
        };
        #endregion
    }
}
