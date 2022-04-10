using System;
using System.Windows;

namespace editor
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        /// <summary>
        /// Main Editor window for the Huckleberry Engine
        /// </summary>
        public Editor()
        {
            InitializeComponent();
            Loaded += OnEditorWindowLoaded;
        }

        /// <summary>
        /// When loading the Editor Window - Open the Project Browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditorWindowLoaded(object sender, RoutedEventArgs e)
        {
            // Upon Loading window, detach the event listener
            Loaded -= OnEditorWindowLoaded;
            OpenProjectBrowser();
        }

        /// <summary>
        /// Opens the Project Browser Diaglog Window Dialog
        /// If the Exit button is clicked within the Project Dialog - Shut Down the Application
        /// </summary>
        private static void OpenProjectBrowser()
        {
            var projectBrowser = new app.ProjectBrowser();

            if (projectBrowser.ShowDialog() == false)
            {
                Application.Current.Shutdown();
            }
            else
            {

            }
        }
    }
}
