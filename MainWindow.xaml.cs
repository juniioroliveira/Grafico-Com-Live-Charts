using LiveCharts;
using LiveCharts.Wpf;
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

namespace GraficoComLiveCharts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public SeriesCollection SeriesCollection { get; set; }
        public string[] BarLabels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Indicador1",
                    Values = new ChartValues<double> { 14550}
                }

            };

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Indicador2",
                Values = new ChartValues<double> { 3580 }
            });

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Indicador3",
                Values = new ChartValues<double> { 10585 }
            });

            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Indicador4",
                Values = new ChartValues<double> { 32744 }
            });

            BarLabels = new[] { "Indicadores" };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }
    }
}
