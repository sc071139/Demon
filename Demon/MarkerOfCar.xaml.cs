﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using GMap.NET.WindowsPresentation;

namespace Demon
{
    /// <summary>
    /// Interaction logic for MarkerOfCar.xaml
    /// </summary>
    public partial class MarkerOfCar
    {
        //Popup Popup;
        //Label Label;
        GMapMarker Marker;
        MainWindow MainWindow;

        public MarkerOfCar(MainWindow window, GMapMarker marker)//(MainWindow window, GMapMarker marker, string title)
        {
            this.InitializeComponent();
            
            this.MainWindow = window;
            this.Marker = marker;
            
            
            //Popup = new Popup();
            //Label = new Label();

            this.Loaded += new RoutedEventHandler(CustomMarkerDemo_Loaded);
            this.SizeChanged += new SizeChangedEventHandler(CustomMarkerDemo_SizeChanged);
            this.MouseEnter += new MouseEventHandler(MarkerControl_MouseEnter);
            this.MouseLeave += new MouseEventHandler(MarkerControl_MouseLeave);
            this.MouseMove += new MouseEventHandler(CustomMarkerDemo_MouseMove);
            this.MouseLeftButtonUp += new MouseButtonEventHandler(CustomMarkerDemo_MouseLeftButtonUp);
            this.MouseLeftButtonDown += new MouseButtonEventHandler(CustomMarkerDemo_MouseLeftButtonDown);

            /*Popup.Placement = PlacementMode.Mouse;
            {
                Label.Background = Brushes.Blue;
                Label.Foreground = Brushes.White;
                Label.BorderBrush = Brushes.WhiteSmoke;
                Label.BorderThickness = new Thickness(2);
                Label.Padding = new Thickness(5);
                Label.FontSize = 22;
                Label.Content = title;
            }
            Popup.Child = Label;*/
        }

        void CustomMarkerDemo_Loaded(object sender, RoutedEventArgs e)
        {
            if (icon.Source.CanFreeze)
            {
                icon.Source.Freeze();
            }
        }

        void CustomMarkerDemo_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Marker.Offset = new Point(-e.NewSize.Width / 2, -e.NewSize.Height);
        }

        void CustomMarkerDemo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && IsMouseCaptured)
            {
                Point p = e.GetPosition(MainWindow.mapControl);
                
                Marker.Position = MainWindow.mapControl.FromLocalToLatLng((int)p.X, (int)p.Y);
                
            }

            
        }

        void CustomMarkerDemo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsMouseCaptured)
            {
                Mouse.Capture(this);
            }
        }

        void CustomMarkerDemo_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (IsMouseCaptured)
            {
                Mouse.Capture(null);
            }
        }

        void MarkerControl_MouseLeave(object sender, MouseEventArgs e)
        {
            Marker.ZIndex -= 10000;
            //Popup.IsOpen = false;
        }

        void MarkerControl_MouseEnter(object sender, MouseEventArgs e)
        {
            Marker.ZIndex += 10000;
            //Popup.IsOpen = true;
            Random randID = new Random();
            MarkerOfCar msender = sender as MarkerOfCar;
            CarRecord carTag = msender.Marker.Tag as CarRecord;
            MainWindow.TbOfID.Text = carTag.carId.ToString();
            MainWindow.TbOfLatlng.Text = "东经" + carTag.longitude.ToString() + " 北纬" + carTag.latitude.ToString();//msender.Marker.Position.ToString();//randID.Next().ToString() + "  " + randID.Next().ToString();
            MainWindow.TbOfType.Text = "出租车";
        }
    }
}
