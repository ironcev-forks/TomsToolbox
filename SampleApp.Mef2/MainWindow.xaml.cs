﻿namespace SampleApp.Mef2
{
    using System.Composition;
    using System.Windows;

    using JetBrains.Annotations;

    using TomsToolbox.Wpf;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [Export]
    public partial class MainWindow
    {
        [ImportingConstructor]
        public MainWindow([NotNull] IExportProvider exportProvider)
        {
            this.SetExportProvider(exportProvider);

            InitializeComponent();
        }

        private void ShowPopup_Click(object sender, RoutedEventArgs e)
        {
            new PopupWindow { Owner = this }.ShowDialog();
        }
    }
}