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
            new ReferenceModelBase { Id=Guid.Parse("2ee766e1-34f7-4a5b-9ceb-d05b0bfb713b"), Code="abandoned", Description="Abandoned", Definition="Indicates the activity provider has determined that the session was abnormally terminated either by an actor or due to a system failure.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("495385d1-b972-4acb-b9bd-847ee41d783e"), Code="answered", Description="Answered", Definition="Indicates the actor replied to a question, where the object is generally an activity representing the question. The text of the answer will often be included in the response inside result.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("31af3be0-79c5-4c5a-a63d-1bc7476d794d"), Code="asked", Description="Asked", Definition="Indicates an inquiry by an actor with the expectation of a response or answer to a question.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("38d7dc92-bac3-4bba-880e-f42fc78c604c"), Code="attempted", Description="Attempted", Definition="Indicates the actor made an effort to access the object. An attempt statement without additional activities could be considered incomplete in some cases.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("ca80868c-869d-43a1-a486-5d51a69f9e00"), Code="attended", Description="Attended", Definition="Indicates the actor was present at a virtual or physical event or activity.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("1d944445-f453-4cd7-a56d-3ba6fb963f27"), Code="commented", Description="Commented", Definition="Indicates the actor provided digital or written annotations on or about an object.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("86773d2b-cf5c-4023-af66-d6ac7569e05f"), Code="completed", Description="Completed", Definition="Indicates the actor finished or concluded the activity normally.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("4f7c514b-91f8-4503-9c04-98a897594d9c"), Code="exited", Description="Exited", Definition="Indicates the actor intentionally departed from the activity or object.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("9abd234f-c3af-400c-8107-5e521e2ba323"), Code="experienced", Description="Experienced", Definition="Indicates the actor only encountered the object, and is applicable in situations where a specific achievement or completion is not required.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("398a94d3-41b9-4eb6-8e99-ec23ab8687d0"), Code="failed", Description="Failed", Definition="Indicates the actor did not successfully pass an activity to a level of predetermined satisfaction.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("b45511ff-2615-4131-a383-4968b4866164"), Code="imported", Description="Imported", Definition="Indicates the actor introduced an object into a physical or virtual location.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("9a17c095-d622-4815-afd5-064a88a16af4"), Code="initialized", Description="Initialized", Definition="Indicates the activity provider has determined that the actor successfully started an activity.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("7b1c3e27-7c9b-4794-9705-cbcc1d83fb56"), Code="interacted", Description="Interacted", Definition="Indicates the actor engaged with a physical or virtual object.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("2c3796ac-f34d-4412-80f8-d2a5fe2111f3"), Code="launched", Description="Launched", Definition="Indicates the actor attempted to start an activity.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("6997b2f5-d8fa-4fc0-bcdb-483709ed3fab"), Code="logged-in", Description="Logged-In", Definition="Indicates the actor gained access to a system or service by identifying and authenticating with the credentials provided by the actor.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("daa60aff-92fb-4fb1-9971-5c9300e99e2a"), Code="logged-out", Description="Logged-Out", Definition="Indicates the actor either lost or discontinued access to a system or service.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("60ee5026-f797-42e0-94a2-73123e80e7eb"), Code="mastered", Description="Mastered", Definition="Indicates the highest level of comprehension or competence the actor performed in an activity.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("6e2b4c2e-b6e5-43d0-bf14-cd9d330e7634"), Code="passed", Description="Passed", Definition="Indicates the actor successfully passed an activity to a level of predetermined satisfaction.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("26a073fe-efae-4bc3-a056-db8dca69a25c"), Code="preferred", Description="Preferred", Definition="Indicates the selected choices, favored options or settings of an actor in relation to an object or activity.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("6855e7ee-4823-4f11-bee0-c9ccc16bae6e"), Code="progressed", Description="Progressed", Definition="Indicates a value of how much of an actor has advanced or moved through an activity.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("b176faf1-25f4-4d52-a67b-8c7dcf4455e2"), Code="registered", Description="Registered", Definition="Indicates the actor is officially enrolled or inducted in an activity.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("5a0391c0-b38e-4990-b4ba-73c9e033c959"), Code="responded", Description="Responded", Definition="Indicates an actor reacted or replied to an object.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a858966-4e1a-41c8-b619-1c36ebc9f9f0"), Code="resumed", Description="Resumed", Definition="Indicates the application has determined that the actor continued or reopened a suspended attempt on an activity.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("af0c0fb8-353b-4f62-a524-ca03cecb5580"), Code="satisfied", Description="Satisfied", Definition="Indicates that the authority or activity provider determined the actor has fulfilled the criteria of the object or activity.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("f7118e55-f970-4322-99d6-936fcdaa78b9"), Code="scored", Description="Scored", Definition="Indicates a numerical value related to an actor's performance on an activity.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("e30865da-d2e1-4e43-b1b4-8c91f7abca28"), Code="shared", Description="Shared", Definition="Indicates the actor's intent to openly provide access to an object of common interest to other actors or groups.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("50fae15b-dac8-4956-8626-17c5e260a74d"), Code="suspended", Description="Suspended", Definition="Indicates the status of a temporarily halted activity when an actor's intent is returning to the or object activity at a later time.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("f1e7ec6a-160b-4d49-8192-afbae1235b50"), Code="terminated", Description="Terminated", Definition="Indicates that the actor successfully ended an activity.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("4228a3c7-c668-4e9e-93cc-294cd338b380"), Code="voided", Description="Voided", Definition="A special reserved verb used by a LRS or application to mark a statement as invalid. See the xAPI specification for details on Voided statements.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("0554c085-380d-438e-b4d0-b72648bd1c29"), Code="waived", Description="Waived", Definition="Indicates that the learning activity requirements were met by means other than completing the activity. A waived statement is used to indicate that the activity may be skipped by the actor.", SortOrder=Convert.ToDecimal("30.00") },
        };
        #endregion
    }
}
