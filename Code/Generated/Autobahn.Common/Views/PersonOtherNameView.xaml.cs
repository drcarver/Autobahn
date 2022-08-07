//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonOtherNameView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonOtherNameView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonOtherNameView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonOtherNameViewModel as the data context for the view
        /// </summary>
        public PersonOtherNameView(IPersonOtherNameViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
