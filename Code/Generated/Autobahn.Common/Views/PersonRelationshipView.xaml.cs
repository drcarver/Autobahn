//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonRelationshipView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonRelationshipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonRelationshipView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonRelationship View Model as the data context for the view
        /// </summary>
        public PersonRelationshipView(Interfaces.IPersonRelationship vm)
        {
            BindingContext  = vm;
        }
    }
}
