//**********************************************************
//* DomainName: Common Models
//* FileName:   RelatedPersonView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The RelatedPersonView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelatedPersonView : ContentPage
    {
        /// <summary>
        /// Inject the IRelatedPerson View Model as the data context for the view
        /// </summary>
        public RelatedPersonView(Interfaces.IRelatedPerson vm)
        {
            BindingContext  = vm;
        }
    }
}
