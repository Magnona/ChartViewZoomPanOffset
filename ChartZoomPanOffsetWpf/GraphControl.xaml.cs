using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;

namespace ChartZoomPanOffsetWpf {
    /// <summary>
    /// Interaction logic for GraphControl.xaml
    /// </summary>
    public partial class GraphControl : UserControl {
        public GraphControl() {
            InitializeComponent();
        }
    }
    
    public class ChartData {
        public DateTime Date { get; set; }

        public double Value { get; set; }
    }


    public class GraphViewModel : ViewModelBase {
        private readonly Random rand = new Random(123456);

        public GraphViewModel() {
            Data = GetData();
        }

        public List<ChartData> Data { get; set; }

        private List<ChartData> GetData() {
            var data = new List<ChartData>();
            for (int i = 0; i < 200; i++) {
                data.Add(new ChartData() {Date = DateTime.Today.AddDays(i), Value = rand.Next(10, 100)});
            }

            return data;
        }

        private Point _panOffset;
        public Point PanOffset {
            get {
                return _panOffset;
            }
            set {
                if (this._panOffset != value) {
                    this._panOffset = value;
                    this.OnPropertyChanged("PanOffset");
                }
            }
        }

        private Size _zoom;
        public Size Zoom {
            get {
                return _zoom;
            }
            set {
                if (this._zoom != value) {
                    this._zoom = value;
                    this.OnPropertyChanged("Zoom");
                }
            }
        }
    }

}
