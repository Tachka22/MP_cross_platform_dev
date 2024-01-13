using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;

namespace wpfImagesViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        System.Windows.Point start;
        System.Windows.Point origin;
        public MainWindow()
        {
            InitializeComponent();
            button_DownloadFirstImage.Click += Button_DownloadFirstImage_Click;
            button_DownloadSecondImage.Click += Button_DownloadSecondImage_Click;
            
            

            TransformGroup group = new TransformGroup();
            TransformGroup group1 = new TransformGroup();

            ScaleTransform xform = new ScaleTransform();
            ScaleTransform xform1 = new ScaleTransform();

            group.Children.Add(xform);
            group1.Children.Add(xform1);

            TranslateTransform tt = new TranslateTransform();
            TranslateTransform tt1 = new TranslateTransform();

            group.Children.Add(tt);
            group1.Children.Add(tt1);

            img_SecondImage.RenderTransform = group;

            img_SecondImage.MouseWheel += Img_SecondImage_MouseWheel;
            img_SecondImage.MouseLeftButtonDown += Img_SecondImage_MouseLeftButtonDown;
            img_SecondImage.MouseMove += Img_SecondImage_MouseMove;
            img_SecondImage.MouseLeftButtonUp += Img_SecondImage_MouseLeftButtonUp;

            //отдельно для каждой
            //img_FirstImage.RenderTransform = group1;
            //img_FirstImage.MouseWheel += Img_FirstImage_MouseWheel;
            //img_FirstImage.MouseLeftButtonDown += Img_FirstImage_MouseLeftButtonDown;
            //img_FirstImage.MouseMove += Img_FirstImage_MouseMove;
            //img_FirstImage.MouseLeftButtonUp += Img_FirstImage_MouseLeftButtonUp;

            //синхронно
            img_FirstImage.RenderTransform = group;
            img_FirstImage.MouseWheel += Img_SecondImage_MouseWheel;
            img_FirstImage.MouseLeftButtonDown += Img_SecondImage_MouseLeftButtonDown;
            img_FirstImage.MouseMove += Img_SecondImage_MouseMove;
            img_FirstImage.MouseLeftButtonUp += Img_SecondImage_MouseLeftButtonUp;

            RotateImage.Click += RotateImage_Click;

        }

        private void RotateImage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Img_FirstImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_FirstImage.ReleaseMouseCapture();
        }

        private void Img_FirstImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!img_FirstImage.IsMouseCaptured) return;

            var tt = (TranslateTransform)((TransformGroup)img_FirstImage.RenderTransform).Children.First(tr => tr is TranslateTransform);
            Vector v = start - e.GetPosition(img1);
            tt.X = origin.X - v.X;
            tt.Y = origin.Y - v.Y;
        }

        private void Img_FirstImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_FirstImage.CaptureMouse();
            var tt = (TranslateTransform)((TransformGroup)img_FirstImage.RenderTransform).Children.First(tr => tr is TranslateTransform);
            start = e.GetPosition(img1);
            origin = new System.Windows.Point(tt.X, tt.Y);
        }


        private void Img_SecondImage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            img_SecondImage.ReleaseMouseCapture();
        }

        private void Img_SecondImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!img_SecondImage.IsMouseCaptured) return;

            var tt = (TranslateTransform)((TransformGroup)img_SecondImage.RenderTransform).Children.First(tr => tr is TranslateTransform);
            Vector v = start - e.GetPosition(img2);
            tt.X = origin.X - v.X;
            tt.Y = origin.Y - v.Y;

        }
        private void Img_SecondImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            img_SecondImage.CaptureMouse();
            var tt = (TranslateTransform)((TransformGroup)img_SecondImage.RenderTransform).Children.First(tr => tr is TranslateTransform);
            start = e.GetPosition(img2);
            origin = new System.Windows.Point(tt.X, tt.Y);
        }


        private void Img_SecondImage_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)img_SecondImage.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];

            double zoom = e.Delta > 0 ? .2 : -.2;
            transform.ScaleX += zoom / 10;
            transform.ScaleY += zoom / 10;
        }

        private void Img_FirstImage_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            TransformGroup transformGroup = (TransformGroup)img_FirstImage.RenderTransform;
            ScaleTransform transform = (ScaleTransform)transformGroup.Children[0];

            double zoom = e.Delta > 0 ? .2 : -.2;
            transform.ScaleX += zoom / 10;
            transform.ScaleY += zoom / 10;
        }


        private void Button_DownloadSecondImage_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = OpenFileDialogMethod();
            if (fileDialog.ShowDialog() == true)
            {
                img_SecondImage.BeginInit();
                img_SecondImage.Source = new BitmapImage(new Uri(fileDialog.FileName));
                img_SecondImage.EndInit();
                
                var bitmapFrame = BitmapFrame.Create(new Uri(fileDialog.FileName), BitmapCreateOptions.None, BitmapCacheOption.None);
                var width = bitmapFrame.PixelWidth;
                var height = bitmapFrame.PixelHeight;
                var size = new FileInfo(fileDialog.FileName).Length;
                label_SeconfImage.Content = $"{fileDialog.SafeFileName}";
                label_SizeSecondImage.Content = $"{width.ToString()}x{height.ToString()}| {size.ToString()} bytes";
            }
        }

        private void Button_DownloadFirstImage_Click(object sender, RoutedEventArgs e)
        {
            var fileDialog = OpenFileDialogMethod();
            if (fileDialog.ShowDialog() == true)
            {
                img_FirstImage.BeginInit();
                img_FirstImage.Source = new BitmapImage(new Uri(fileDialog.FileName));
                img_FirstImage.EndInit();

                var bitmapFrame = BitmapFrame.Create(new Uri(fileDialog.FileName), BitmapCreateOptions.None, BitmapCacheOption.None);
                var width = bitmapFrame.PixelWidth;
                var height = bitmapFrame.PixelHeight;
                var size = new FileInfo(fileDialog.FileName).Length;
                label_FirstImage.Content = $"{fileDialog.SafeFileName}";
                label_SizeFirstImage.Content = $"{width.ToString()}x{height.ToString()} | {size.ToString()} bytes";
                
            }
        }
        private OpenFileDialog OpenFileDialogMethod()
        {
            OpenFileDialog dialog = new();
            dialog.DefaultExt = ".jpg";
            dialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|Все файлы *.*|";
            return dialog;
        }
        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
    public class WindowCommands
    {
        static WindowCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MainWindow));
        }
        public static RoutedCommand Exit { get; set; }
    }

}
