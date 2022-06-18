using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartLibrary
{
    public partial class BarChartControl : UserControl
    {
        private BarChartObject[] _data;
        public BarChartObject[] Data
        {
            get { return _data; }
            set { _data = value;
                Invalidate();
            }
        }
        public BarChartControl()
        {
            InitializeComponent();

            ResizeRedraw = true;

            // default data
            Data = new[] {
                new BarChartObject("Val 1", 2),
                new BarChartObject("Val 2", 3),
                new BarChartObject("Val 3", 1) };
        }
        public void ChangeData(List<string> stringList, List<int> intList)
        {
            _data = new BarChartObject[stringList.Count];
            for(var i = 0; i < stringList.Count; i++)
            {
                _data[i] = new BarChartObject(stringList[i], intList[i]);
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void BarChartControl_Paint(object sender, PaintEventArgs e)
        {
            // get drawing context
            Graphics chartGraphics = e.Graphics;
            // get drawing area
            Rectangle area = e.ClipRectangle;

            // width of bars
            var barWidth = area.Width / Data.Length;
            // max height - 90% of the entire height
            var maxHeight = area.Height * 0.9;
            // scaling factor
            var scalingFactor = maxHeight / Data.Max(x => x.Value);

            // brush to draw
            Brush myBrush = new SolidBrush(Color.Maroon);

            // draw each bar
            for (int i = 0; i < Data.Length; i++)
            {
                var currentBarHeight = scalingFactor * Data[i].Value;

                // draw bar
                chartGraphics.FillRectangle(
                    myBrush,
                    i * barWidth,
                    (float)(area.Height - currentBarHeight),
                   (float)0.8 * barWidth,
                   (float)currentBarHeight);

                // draw label
                //chartGraphics.DrawString(Data[i].Label, new Font("Century Gothic", 9), new SolidBrush(Color.Black),
                //    i * barWidth, (float)(area.Bottom + 0.2));
            }
        }
    }
}
