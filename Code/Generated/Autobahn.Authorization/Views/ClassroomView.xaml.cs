//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ClassroomView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The ClassroomView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassroomView : ContentPage
    {
        /// <summary>
        /// Inject the IClassroom View Model as the data context for the view
        /// </summary>
        public ClassroomView(Interfaces.IClassroom vm)
        {
            BindingContext  = vm;
        }
    }
}