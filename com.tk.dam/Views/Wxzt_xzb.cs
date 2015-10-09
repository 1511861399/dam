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
    public partial class Wxzt_xzb : DevExpress.XtraEditors.XtraUserControl
    {
        Dictionary<int, string> mAxisDic = new Dictionary<int, string>();

        public Wxzt_xzb()
        {
            InitializeComponent();
        }

        private void Wxzt_xzb_Load(object sender, EventArgs e)
        {
            
        }

        public void SetPoints(List<SeriesPoint> points1, List<SeriesPoint> points2)
        {
            this.chartControl2.Series[0].Points.Clear();
            this.chartControl2.Series[1].Points.Clear();
            mAxisDic.Clear();

            int i = 0;
            foreach (SeriesPoint point in points1)
            {
                i++;
                SeriesPoint point1 = new SeriesPoint(i, point.Values[0]);
                mAxisDic.Add(i, point.Tag.ToString());
                point1.Tag = point.Tag;
                this.chartControl2.Series[0].Points.Add(point1);
                addAnnotation(point, i);
            }

            i = 0;
            foreach (SeriesPoint point in points2)
            {
                i++;
                SeriesPoint point2 = new SeriesPoint(i, point.Values[0]);
                point2.Tag = point.Tag;
                this.chartControl2.Series[1].Points.Add(point2);
                addAnnotation(point, i);
            }
        }

        private void addAnnotation(SeriesPoint point, int zIndex)
        {
            //TextAnnotation annotation = new TextAnnotation(point.Tag.ToString(), point.Tag.ToString());
            //if (annotation != null)
            //{
            //    //annotation.Font = new Font(annotation.Font.FontFamily, annotation.Font.Size);
            //    //Specify the text annotation position. 
            //    annotation.AnchorPoint = new SeriesPointAnchorPoint(point);
            //    annotation.ShapePosition = new RelativePosition();
            //    RelativePosition position = annotation.ShapePosition as RelativePosition;
            //    position.ConnectorLength = point.Values[0];
            //    position.Angle = 270;
        
            //    //annotation.RuntimeMoving = true;
            //    annotation.BackColor = Color.Transparent;
            //    annotation.ConnectorStyle = AnnotationConnectorStyle.None;
            //    annotation.AutoSize = false;
            //    annotation.Width = 20;
            //    annotation.Border.Color = Color.Transparent;
            //    annotation.ZOrder = zIndex;
            //    //Add an annotaion to the annotation repository. 
            //    this.chartControl2.AnnotationRepository.Add(annotation);
            //}
        }

        private void chartControl2_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e)
        {
            e.LabelText = e.SeriesPoint.Tag.ToString();
        }

        private void chartControl2_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e)
        {
            if (e.Item.Axis is AxisX)
            {
                int value = (int)double.Parse(e.Item.AxisValue.ToString());
                if (mAxisDic.ContainsKey(value))
                {
                    e.Item.Text = mAxisDic[value];
                }
                else
                {
                    e.Item.Text = "";
                }
            }
        }

    }
}
