//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonRelationshipView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonRelationshipView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonRelationshipView : ContentPage
    {
        /// <summary>
        /// Inject the PersonRelationshipViewModel as the data context for the view
        /// </summary>
        public PersonRelationshipView(PersonRelationshipViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}