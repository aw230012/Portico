using System;
using System.Linq;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Phone.UI.Input;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace PorticoMobile
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class Registration_1 : Page
   {
      public Registration_1()
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

      protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
      {
         HardwareButtons.BackPressed -= HardwareButtonsOnBackPressed;
      }

      private void HardwareButtonsOnBackPressed(object sender, BackPressedEventArgs backPressedEventArgs)
      {
         
      }

      private void NextButton_OnClick(object sender, RoutedEventArgs e)
      {
         Frame.Navigate(typeof (Registration_2));
      }

      async private void TakePictureButton_OnClick(object sender, RoutedEventArgs e)
      {
         var cameraId = await GetCameraId(Windows.Devices.Enumeration.Panel.Back);
         var captureManager = new MediaCapture();

         await captureManager.InitializeAsync(new MediaCaptureInitializationSettings
         {
            StreamingCaptureMode = StreamingCaptureMode.Video,
            PhotoCaptureSource = PhotoCaptureSource.Photo,
            AudioDeviceId = string.Empty,
            VideoDeviceId = cameraId.Id
         });

         var imgFormat = ImageEncodingProperties.CreatePng();
         var file = await ApplicationData.Current.LocalFolder.CreateFileAsync("Photo.png", CreationCollisionOption.ReplaceExisting);

         await captureManager.CapturePhotoToStorageFileAsync(imgFormat, file);
      }

      private static async Task<DeviceInformation> GetCameraId(Windows.Devices.Enumeration.Panel desired)
      {
         var deviceId = (await DeviceInformation.FindAllAsync(DeviceClass.VideoCapture))
            .FirstOrDefault(x => x.EnclosureLocation != null && x.EnclosureLocation.Panel == desired);

         if (deviceId != null)
            return deviceId;

         throw new Exception(string.Format("Camera of type {0} doesn't exist.", desired));
      }
   }
}
