using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PorticoMobile
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class Registration_2 : Page
   {
      public Registration_2()
      {
         this.InitializeComponent();
         NavigationCacheMode = NavigationCacheMode.Required;
      }

      /// <summary>
      /// Invoked when this page is about to be displayed in a Frame.
      /// </summary>
      /// <param name="e">Event data that describes how this page was reached.
      /// This parameter is typically used to configure the page.</param>
      protected override void OnNavigatedTo(NavigationEventArgs e)
      {
         HardwareButtons.BackPressed += HardwareButtonsOnBackPressed;
      }

      protected override void OnNavigatedFrom(NavigationEventArgs e)
      {
         HardwareButtons.BackPressed -= HardwareButtonsOnBackPressed;
      }

      private void HardwareButtonsOnBackPressed(object sender, BackPressedEventArgs e)
      {
         var frame = Window.Current.Content as Frame;

         if (frame == null || !frame.CanGoBack)
            return;

         frame.GoBack();
         e.Handled = true;
      }

      private void BackButton_OnClick(object sender, RoutedEventArgs e)
      {
         Frame.GoBack();
      }
   }
}
