//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefLearnerActionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefLearnerActionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearnerActionTypeModel"> List
         /// </summary>
        public static List<RefLearnerActionTypeModel> RefLearnerActionTypeList = new List<RefLearnerActionTypeModel>
        {
            new RefLearnerActionType { Id=Guid.Parse("44876ade-44c6-4a40-987a-56adceffbfc0"), Code="abandoned", Description="Abandoned", Definition="Indicates the activity provider has determined that the session was abnormally terminated either by an actor or due to a system failure.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActionType { Id=Guid.Parse("d5f72b7a-221d-45ee-bfea-bf09975c4636"), Code="answered", Description="Answered", Definition="Indicates the actor replied to a question, where the object is generally an activity representing the question. The text of the answer will often be included in the response inside result.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActionType { Id=Guid.Parse("2d0daed2-8513-4a6e-af5a-2f300d5e2ac1"), Code="asked", Description="Asked", Definition="Indicates an inquiry by an actor with the expectation of a response or answer to a question.", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearnerActionType { Id=Guid.Parse("c951047d-9c6c-4885-92a3-a4cd6f9aacc8"), Code="attempted", Description="Attempted", Definition="Indicates the actor made an effort to access the object. An attempt statement without additional activities could be considered incomplete in some cases.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearnerActionType { Id=Guid.Parse("2660b96c-d1f6-439e-8b9b-d227b5963741"), Code="attended", Description="Attended", Definition="Indicates the actor was present at a virtual or physical event or activity.", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearnerActionType { Id=Guid.Parse("055d73de-1cdf-425b-8cca-23311925a0e5"), Code="commented", Description="Commented", Definition="Indicates the actor provided digital or written annotations on or about an object.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearnerActionType { Id=Guid.Parse("1481fad6-1c69-419b-8e2c-d9ad69c325f6"), Code="completed", Description="Completed", Definition="Indicates the actor finished or concluded the activity normally.", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearnerActionType { Id=Guid.Parse("d9b79c56-47de-4a1a-b538-d4f02b32f9ff"), Code="exited", Description="Exited", Definition="Indicates the actor intentionally departed from the activity or object.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearnerActionType { Id=Guid.Parse("20a4be75-1880-4cd3-ac03-23a90ecce857"), Code="experienced", Description="Experienced", Definition="Indicates the actor only encountered the object, and is applicable in situations where a specific achievement or completion is not required.", SortOrder=Convert.ToDecimal("9.00") },
            new RefLearnerActionType { Id=Guid.Parse("62c61d2e-e265-4dfa-a2e8-baf288a19717"), Code="failed", Description="Failed", Definition="Indicates the actor did not successfully pass an activity to a level of predetermined satisfaction.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearnerActionType { Id=Guid.Parse("c646f428-d623-4abf-9465-76d0b773efdb"), Code="imported", Description="Imported", Definition="Indicates the actor introduced an object into a physical or virtual location.", SortOrder=Convert.ToDecimal("11.00") },
            new RefLearnerActionType { Id=Guid.Parse("94819706-23a7-4f70-96d4-0becb3a37734"), Code="initialized", Description="Initialized", Definition="Indicates the activity provider has determined that the actor successfully started an activity.", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearnerActionType { Id=Guid.Parse("0d974f47-9723-4d61-bb68-05e74e346a74"), Code="interacted", Description="Interacted", Definition="Indicates the actor engaged with a physical or virtual object.", SortOrder=Convert.ToDecimal("13.00") },
            new RefLearnerActionType { Id=Guid.Parse("2b81d702-0405-472a-882b-0a1fb7eab5f3"), Code="launched", Description="Launched", Definition="Indicates the actor attempted to start an activity.", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearnerActionType { Id=Guid.Parse("94f56f09-932e-4774-89ed-628ec4fd872d"), Code="logged-in", Description="Logged-In", Definition="Indicates the actor gained access to a system or service by identifying and authenticating with the credentials provided by the actor.", SortOrder=Convert.ToDecimal("15.00") },
            new RefLearnerActionType { Id=Guid.Parse("1e8802b7-9157-4d90-a1df-385cc8048773"), Code="logged-out", Description="Logged-Out", Definition="Indicates the actor either lost or discontinued access to a system or service.", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearnerActionType { Id=Guid.Parse("57557466-f56e-4d58-b90a-09e95754c138"), Code="mastered", Description="Mastered", Definition="Indicates the highest level of comprehension or competence the actor performed in an activity.", SortOrder=Convert.ToDecimal("17.00") },
            new RefLearnerActionType { Id=Guid.Parse("fb8f8af8-27b5-4fa0-8f7c-f38873ed69d3"), Code="passed", Description="Passed", Definition="Indicates the actor successfully passed an activity to a level of predetermined satisfaction.", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearnerActionType { Id=Guid.Parse("81aa03d7-0705-487f-a844-268d9cd593b3"), Code="preferred", Description="Preferred", Definition="Indicates the selected choices, favored options or settings of an actor in relation to an object or activity.", SortOrder=Convert.ToDecimal("19.00") },
            new RefLearnerActionType { Id=Guid.Parse("d0a8fea4-e036-4990-8350-08b6c137dc92"), Code="progressed", Description="Progressed", Definition="Indicates a value of how much of an actor has advanced or moved through an activity.", SortOrder=Convert.ToDecimal("20.00") },
            new RefLearnerActionType { Id=Guid.Parse("8ddc2409-613c-421a-9967-07f7f870529c"), Code="registered", Description="Registered", Definition="Indicates the actor is officially enrolled or inducted in an activity.", SortOrder=Convert.ToDecimal("21.00") },
            new RefLearnerActionType { Id=Guid.Parse("f785fb99-f775-4d65-a5ea-e3c5eca20478"), Code="responded", Description="Responded", Definition="Indicates an actor reacted or replied to an object.", SortOrder=Convert.ToDecimal("22.00") },
            new RefLearnerActionType { Id=Guid.Parse("e65ba537-7f02-4bb1-b97e-b7cefffd51db"), Code="resumed", Description="Resumed", Definition="Indicates the application has determined that the actor continued or reopened a suspended attempt on an activity.", SortOrder=Convert.ToDecimal("23.00") },
            new RefLearnerActionType { Id=Guid.Parse("d509b522-e322-4411-8a3e-5b4c9aeaefab"), Code="satisfied", Description="Satisfied", Definition="Indicates that the authority or activity provider determined the actor has fulfilled the criteria of the object or activity.", SortOrder=Convert.ToDecimal("24.00") },
            new RefLearnerActionType { Id=Guid.Parse("a15f6f1a-a354-4360-8f90-1b5c10a286fc"), Code="scored", Description="Scored", Definition="Indicates a numerical value related to an actor's performance on an activity.", SortOrder=Convert.ToDecimal("25.00") },
            new RefLearnerActionType { Id=Guid.Parse("f8784e4d-53a0-4e6b-8045-ea84cd258d28"), Code="shared", Description="Shared", Definition="Indicates the actor's intent to openly provide access to an object of common interest to other actors or groups.", SortOrder=Convert.ToDecimal("26.00") },
            new RefLearnerActionType { Id=Guid.Parse("05b866f5-5915-4911-b245-d4d289426364"), Code="suspended", Description="Suspended", Definition="Indicates the status of a temporarily halted activity when an actor's intent is returning to the or object activity at a later time.", SortOrder=Convert.ToDecimal("27.00") },
            new RefLearnerActionType { Id=Guid.Parse("0a3e5011-74c8-468e-825d-7f111e73c3b6"), Code="terminated", Description="Terminated", Definition="Indicates that the actor successfully ended an activity.", SortOrder=Convert.ToDecimal("28.00") },
            new RefLearnerActionType { Id=Guid.Parse("3dcda835-c649-4068-b7b0-5939f58a65fd"), Code="voided", Description="Voided", Definition="A special reserved verb used by a LRS or application to mark a statement as invalid. See the xAPI specification for details on Voided statements.", SortOrder=Convert.ToDecimal("29.00") },
            new RefLearnerActionType { Id=Guid.Parse("3d60e8f5-3d8a-42cf-a015-bfb03a1454cb"), Code="waived", Description="Waived", Definition="Indicates that the learning activity requirements were met by means other than completing the activity. A waived statement is used to indicate that the activity may be skipped by the actor.", SortOrder=Convert.ToDecimal("30.00") },
        };

        /// <summary>
        /// The Reference RefLearnerActionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearnerActionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearnerActionType { Id=Guid.Parse("44876ade-44c6-4a40-987a-56adceffbfc0"), Description="Abandoned", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearnerActionType { Id=Guid.Parse("d5f72b7a-221d-45ee-bfea-bf09975c4636"), Description="Answered", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearnerActionType { Id=Guid.Parse("2d0daed2-8513-4a6e-af5a-2f300d5e2ac1"), Description="Asked", SortOrder=Convert.ToDecimal("3.00") },
            new RefLearnerActionType { Id=Guid.Parse("c951047d-9c6c-4885-92a3-a4cd6f9aacc8"), Description="Attempted", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearnerActionType { Id=Guid.Parse("2660b96c-d1f6-439e-8b9b-d227b5963741"), Description="Attended", SortOrder=Convert.ToDecimal("5.00") },
            new RefLearnerActionType { Id=Guid.Parse("055d73de-1cdf-425b-8cca-23311925a0e5"), Description="Commented", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearnerActionType { Id=Guid.Parse("1481fad6-1c69-419b-8e2c-d9ad69c325f6"), Description="Completed", SortOrder=Convert.ToDecimal("7.00") },
            new RefLearnerActionType { Id=Guid.Parse("d9b79c56-47de-4a1a-b538-d4f02b32f9ff"), Description="Exited", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearnerActionType { Id=Guid.Parse("20a4be75-1880-4cd3-ac03-23a90ecce857"), Description="Experienced", SortOrder=Convert.ToDecimal("9.00") },
            new RefLearnerActionType { Id=Guid.Parse("62c61d2e-e265-4dfa-a2e8-baf288a19717"), Description="Failed", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearnerActionType { Id=Guid.Parse("c646f428-d623-4abf-9465-76d0b773efdb"), Description="Imported", SortOrder=Convert.ToDecimal("11.00") },
            new RefLearnerActionType { Id=Guid.Parse("94819706-23a7-4f70-96d4-0becb3a37734"), Description="Initialized", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearnerActionType { Id=Guid.Parse("0d974f47-9723-4d61-bb68-05e74e346a74"), Description="Interacted", SortOrder=Convert.ToDecimal("13.00") },
            new RefLearnerActionType { Id=Guid.Parse("2b81d702-0405-472a-882b-0a1fb7eab5f3"), Description="Launched", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearnerActionType { Id=Guid.Parse("94f56f09-932e-4774-89ed-628ec4fd872d"), Description="Logged-In", SortOrder=Convert.ToDecimal("15.00") },
            new RefLearnerActionType { Id=Guid.Parse("1e8802b7-9157-4d90-a1df-385cc8048773"), Description="Logged-Out", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearnerActionType { Id=Guid.Parse("57557466-f56e-4d58-b90a-09e95754c138"), Description="Mastered", SortOrder=Convert.ToDecimal("17.00") },
            new RefLearnerActionType { Id=Guid.Parse("fb8f8af8-27b5-4fa0-8f7c-f38873ed69d3"), Description="Passed", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearnerActionType { Id=Guid.Parse("81aa03d7-0705-487f-a844-268d9cd593b3"), Description="Preferred", SortOrder=Convert.ToDecimal("19.00") },
            new RefLearnerActionType { Id=Guid.Parse("d0a8fea4-e036-4990-8350-08b6c137dc92"), Description="Progressed", SortOrder=Convert.ToDecimal("20.00") },
            new RefLearnerActionType { Id=Guid.Parse("8ddc2409-613c-421a-9967-07f7f870529c"), Description="Registered", SortOrder=Convert.ToDecimal("21.00") },
            new RefLearnerActionType { Id=Guid.Parse("f785fb99-f775-4d65-a5ea-e3c5eca20478"), Description="Responded", SortOrder=Convert.ToDecimal("22.00") },
            new RefLearnerActionType { Id=Guid.Parse("e65ba537-7f02-4bb1-b97e-b7cefffd51db"), Description="Resumed", SortOrder=Convert.ToDecimal("23.00") },
            new RefLearnerActionType { Id=Guid.Parse("d509b522-e322-4411-8a3e-5b4c9aeaefab"), Description="Satisfied", SortOrder=Convert.ToDecimal("24.00") },
            new RefLearnerActionType { Id=Guid.Parse("a15f6f1a-a354-4360-8f90-1b5c10a286fc"), Description="Scored", SortOrder=Convert.ToDecimal("25.00") },
            new RefLearnerActionType { Id=Guid.Parse("f8784e4d-53a0-4e6b-8045-ea84cd258d28"), Description="Shared", SortOrder=Convert.ToDecimal("26.00") },
            new RefLearnerActionType { Id=Guid.Parse("05b866f5-5915-4911-b245-d4d289426364"), Description="Suspended", SortOrder=Convert.ToDecimal("27.00") },
            new RefLearnerActionType { Id=Guid.Parse("0a3e5011-74c8-468e-825d-7f111e73c3b6"), Description="Terminated", SortOrder=Convert.ToDecimal("28.00") },
            new RefLearnerActionType { Id=Guid.Parse("3dcda835-c649-4068-b7b0-5939f58a65fd"), Description="Voided", SortOrder=Convert.ToDecimal("29.00") },
            new RefLearnerActionType { Id=Guid.Parse("3d60e8f5-3d8a-42cf-a015-bfb03a1454cb"), Description="Waived", SortOrder=Convert.ToDecimal("30.00") },
       };
   }
}
