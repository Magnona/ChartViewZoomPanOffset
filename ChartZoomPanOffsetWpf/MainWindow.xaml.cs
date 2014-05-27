using System.Windows;
using Telerik.Windows.Controls;

namespace ChartZoomPanOffsetWpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void RadTabControlBase_OnSelectionChanged(object sender, RadSelectionChangedEventArgs e) {
            var shell = DataContext as ViewModel;
            if (shell != null) {
                if (Tab1.IsSelected) {
                   // shell.Graph1Control.RadChart1.Zoom = shell.Graph2Control.RadChart1.Zoom;
                   // shell.Graph1Control.RadChart1.PanOffset = shell.Graph2Control.RadChart1.PanOffset;
                    ((GraphViewModel)shell.Graph1Control.DataContext).Zoom = ((GraphViewModel)shell.Graph2Control.DataContext).Zoom;
                    ((GraphViewModel)shell.Graph1Control.DataContext).PanOffset = ((GraphViewModel)shell.Graph2Control.DataContext).PanOffset;
                }
                else if (Tab2.IsSelected) {
                   // shell.Graph2Control.RadChart1.Zoom = shell.Graph1Control.RadChart1.Zoom;
                   // shell.Graph2Control.RadChart1.PanOffset = shell.Graph1Control.RadChart1.PanOffset;
                    ((GraphViewModel)shell.Graph2Control.DataContext).Zoom = ((GraphViewModel)shell.Graph1Control.DataContext).Zoom;
                    ((GraphViewModel)shell.Graph2Control.DataContext).PanOffset = ((GraphViewModel)shell.Graph1Control.DataContext).PanOffset;
                }
            }
        }
    }
    

    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Graph1Control = new GraphControl();
            Graph2Control = new GraphControl();
        }

        public GraphControl Graph1Control { get; set; }
        public GraphControl Graph2Control { get; set; }
    }
}
