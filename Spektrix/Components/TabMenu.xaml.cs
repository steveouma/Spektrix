﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Spektrix.Components
{
    /// <summary>
    /// Interaction logic for TabMenu.xaml
    /// </summary>
    public partial class TabMenu : UserControl
    {
        public Tab[] tabs = new Tab[2];
        private readonly string MenuIconsResourceUrl = "pack://application:,,,/Resources/MenuIcons/";

        public TabMenu()
        {
            InitializeComponent();

            // Add named user control elements from xaml file to list
            tabs[0] = this.menu_tab_0;
            tabs[1] = this.menu_tab_1;
        }

        // Setup sets the information to be displayed
        public void Setup()
        {
            for (int i = 0; i < tabs.Length; i++)
                tabs[i].Setup(i);
        }

        // Initialize initializes the UI of the component
        public void Initialize()
        {
            // Set the unused black regions to transparent
            this.negative_space_1.Background = new SolidColorBrush(Color.FromArgb(0x80, 0, 0, 0));
            this.negative_space_2.Background = new SolidColorBrush(Color.FromArgb(0x80, 0, 0, 0));
            this.tab_menu_settings.Source = new BitmapImage(new Uri(MenuIconsResourceUrl + "control.png"));

            SetInfoVisibility(Visibility.Hidden);
        }

        // Uninitialize uninitialize(reset) the UI of the component
        public void Uninitialize()
        {
            SetInfoVisibility(Visibility.Hidden);
        }

        // Animate elements
        public void RunAnimation()
        {
            // Runs User Control Animation
            DoubleAnimation top_menu_bar_animation = new DoubleAnimation(0, this.grid_panel_bar.ActualWidth, new Duration(TimeSpan.FromSeconds(0.8)));
            panel_bar.BeginAnimation(WidthProperty, top_menu_bar_animation);

            DoubleAnimation bottom_menu_bar_animation = new DoubleAnimation(0, this.grid_panel_bar.ActualWidth, new Duration(TimeSpan.FromSeconds(1)));
            bottom_menu_bar_animation.Completed += new EventHandler((s, e) => SetInfoVisibility(Visibility.Visible));
            tab_menu_bar.BeginAnimation(WidthProperty, bottom_menu_bar_animation);
        }

        private void OpenSettings(object sender, EventArgs e)
        {
            SettingsWindow win = new SettingsWindow();
            win.InitializeComponent();
            win.Show();

            MainWindow win1 = (MainWindow)Window.GetWindow(this);
            win1.Close();
        }

        // Iterate through each groups and set visibility
        private void SetInfoVisibility(Visibility visible)
        {
            this.tab_menu_settings.Visibility = visible;
            foreach (Tab tab in tabs)
                tab.SetIconVisibility(visible);
        }
    }
}
