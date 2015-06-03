using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace PorticoMobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
      private readonly DispatcherTimer _dispatcherTimer;

      public MainPage()
      {
         this.InitializeComponent();
         this.NavigationCacheMode = NavigationCacheMode.Required;

         _dispatcherTimer = new DispatcherTimer();
         _dispatcherTimer.Tick += dispatcherTimer_Tick;
         _dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
         _dispatcherTimer.Start();
      }

      /// <summary>
      /// Invoked when this page is about to be displayed in a Frame.
      /// </summary>
      /// <param name="e">Event data that describes how this page was reached.
      /// This parameter is typically used to configure the page.</param>
      protected override void OnNavigatedTo(NavigationEventArgs e)
      {
         // TODO: Prepare page for display here.

         // TODO: If your application contains multiple pages, ensure that you are
         // handling the hardware Back button by registering for the
         // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
         // If you are using the NavigationHelper provided by some templates,
         // this event is handled for you.
      }

      private void dispatcherTimer_Tick(object sender, object o)
      {
         _dispatcherTimer.Stop();
         Frame.Navigate(typeof (Registration_1));
      }
   }
}
