using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace com.tk.dam.Views
{
    public partial class Wxzt_xkt : DevExpress.XtraEditors.XtraUserControl
    {
        private Random mRandom = new Random(360);

        public Wxzt_xkt()
        {
            InitializeComponent();
        }

        private void Wxzt_xkt_Load(object sender, EventArgs e)
        {
        }

        public void SetPoints(List<SeriesPoint> gpsPoints, List<SeriesPoint> gloPoints, List<SeriesPoint> bdPoints)
        {
            this.chartControl1.Series[0].Points.Clear();
            this.chartControl1.Series[1].Points.Clear();
            this.chartControl1.Series[2].Points.Clear();
            int i = 0;
            foreach (SeriesPoint point in gpsPoints)
            {
                i++;
                this.chartControl1.Series[0].Points.Add(point);
                addAnnotation(point, i);
            }
            foreach (SeriesPoint point in gloPoints)
            {
                i++;
                this.chartControl1.Series[1].Points.Add(point);
                addAnnotation(point, i);
            }
            foreach (SeriesPoint point in bdPoints)
            {
                i++;
                this.chartControl1.Series[2].Points.Add(point);
                addAnnotation(point, i);
            }
            this.timer1.Enabled = true;
            this.timer1.Start();
        }

        private void addAnnotation(SeriesPoint point, int zIndex)
        {
            TextAnnotation annotation = new TextAnnotation(point.Tag.ToString(), point.Tag.ToString());
            if (annotation != null)
            {
                //annotation.Font = new Font(annotation.Font.FontFamily, annotation.Font.Size);
                //Specify the text annotation position. 
                annotation.AnchorPoint = new SeriesPointAnchorPoint(point);
                annotation.ShapePosition = new RelativePosition();
                RelativePosition position = annotation.ShapePosition as RelativePosition;
                position.ConnectorLength = 0;
                position.Angle = 270;
                //annotation.RuntimeMoving = true;
                annotation.BackColor = Color.Transparent;
                annotation.ConnectorStyle = AnnotationConnectorStyle.None;
                annotation.AutoSize = false;
                annotation.Width = 20;
                annotation.Border.Color = Color.Transparent;
                annotation.ZOrder = zIndex;
                //Add an annotaion to the annotation repository. 
                this.chartControl1.AnnotationRepository.Add(annotation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SeriesPoint mPoint;
            for (int i = 0; i < this.chartControl1.Series[0].Points.Count; i++)
            {
                mPoint = this.chartControl1.Series[0].Points[i];
                mPoint.NumericalArgument = mPoint.NumericalArgument + mRandom.Next(7) - 3;
                mPoint.Values[0] = mPoint.Values[0] + mRandom.Next(5) - 2;
                if (i < this.chartControl1.Series[1].Points.Count)
                {
                    mPoint = this.chartControl1.Series[1].Points[i];
                    mPoint.NumericalArgument = mPoint.NumericalArgument + mRandom.Next(7) - 3;
                    mPoint.Values[0] = mPoint.Values[0] + mRandom.Next(5) - 2;
                }
                if (i < this.chartControl1.Series[2].Points.Count)
                {
                    mPoint = this.chartControl1.Series[2].Points[i];
                    mPoint.NumericalArgument = mPoint.NumericalArgument + mRandom.Next(7) - 3;
                    mPoint.Values[0] = mPoint.Values[0] + mRandom.Next(5) - 2;
                }
            }
        }
    }
}
