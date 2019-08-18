using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ModManifestDownloadInstaller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public MainWindow()
        {
            InitializeComponent();

            Logger.Info("Application Start.");
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Logger.Trace("HomeButton_Click");
            HomeBorder.Visibility = Visibility.Visible;
            CreateManifestItemBorder.Visibility = Visibility.Hidden;
            CreateModManifestBorder.Visibility = Visibility.Hidden;
            InstallModManifestBorder.Visibility = Visibility.Hidden;
            SettingsBorder.Visibility = Visibility.Hidden;
        }

        private void CreateManifestItemButton_Click(object sender, RoutedEventArgs e)
        {
            Logger.Trace("CreateManifestItemButton_Click");
            HomeBorder.Visibility = Visibility.Hidden;
            CreateManifestItemBorder.Visibility = Visibility.Visible;
            CreateModManifestBorder.Visibility = Visibility.Hidden;
            InstallModManifestBorder.Visibility = Visibility.Hidden;
            SettingsBorder.Visibility = Visibility.Hidden;
        }

        private void CreateModManifestButton_Click(object sender, RoutedEventArgs e)
        {
            Logger.Trace("CreateModManifestButton_Click");
            HomeBorder.Visibility = Visibility.Hidden;
            CreateManifestItemBorder.Visibility = Visibility.Hidden;
            CreateModManifestBorder.Visibility = Visibility.Visible;
            InstallModManifestBorder.Visibility = Visibility.Hidden;
            SettingsBorder.Visibility = Visibility.Hidden;
        }

        private void InstallModManifestButton_Click(object sender, RoutedEventArgs e)
        {
            Logger.Trace("InstallModManifestButton_Click");
            HomeBorder.Visibility = Visibility.Hidden;
            CreateManifestItemBorder.Visibility = Visibility.Hidden;
            CreateModManifestBorder.Visibility = Visibility.Hidden;
            InstallModManifestBorder.Visibility = Visibility.Visible;
            SettingsBorder.Visibility = Visibility.Hidden;
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Logger.Trace("SettingsButton_Click");
            HomeBorder.Visibility = Visibility.Hidden;
            CreateManifestItemBorder.Visibility = Visibility.Hidden;
            CreateModManifestBorder.Visibility = Visibility.Hidden;
            InstallModManifestBorder.Visibility = Visibility.Hidden;
            SettingsBorder.Visibility = Visibility.Visible;
        }
    }
}
