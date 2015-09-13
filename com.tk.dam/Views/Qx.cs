using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Web;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using DevExpress.Utils;

namespace com.tk.dam.Views
{
    public partial class Qx : XtraUserControlBase
    {
        public Qx()
        {
            InitializeComponent();
        }

        Random mRandom = new Random();
        WebClient webClient = new WebClient() { Encoding = Encoding.UTF8 };


        private void Qx_Load(object sender, EventArgs e)
        {
            try
            {
                var location = webClient.DownloadString("http://int.dpool.sina.com.cn/iplookup/iplookup.php?format=json");
                var json = new JavaScriptSerializer().Deserialize<dynamic>(location);
                string city = HttpUtility.UrlDecode(json["city"]);

                LoadWeather(city);
                LoadSD(city);
            }
            catch (Exception es)
            {
                MainForm.ShowMessage("提示：", "获取气象数据失败，请检查网络是否连接正常!");
            }

            CreateSWQXChart();

            SetSWHeight();
        }

        private void LoadSD(string city)
        {
            string weatherString = webClient.DownloadString(string.Format(
                "http://api.k780.com:88/?app=weather.today&weaid={0}&appkey=10003&sign=b59bc3ef6191eb9f747dd4e83c99f2a4&format=json",
                HttpUtility.UrlEncode(city)));
            var jsonW = new JavaScriptSerializer().Deserialize<dynamic>(weatherString);
            int sd = -1;
            if (jsonW["success"] == "1")
            {
                try
                {
                    sd = int.Parse(((string)jsonW["result"]["humidity"]).TrimEnd('%'));
                }
                catch { }
            }
            if (sd > -1)
            {
                arcScaleComponent2.Value = sd;
                labelComponent2.Text = string.Format("{0}%", sd);
            }
            else
            {
                arcScaleComponent2.Value = 0;
                labelComponent2.Text = "无法获取";
            }
        }

        private void SetSWHeight()
        {
            int index = this.chartControl1.Series[0].Points.Count - 1;
            SeriesPoint point = this.chartControl1.Series[0].Points[index];
            double height = point.Values[0];

            double eachMH = 55 * pboxSW.Height / 320;
            double displayH = (height - 92) * eachMH + 16;
            pboxS.Height = (int)displayH;
        }

        private void CreateSWQXChart()
        {
            this.chartControl1.Series[0].Points.Clear();
            DateTime mNow = DateTime.Now;

            for (int i = -7; i < -1; i++)
            {
                this.chartControl1.Series[0].Points.Add(new SeriesPoint(mNow.AddDays(i), mRandom.Next(15) + 85));
            }
            this.chartControl1.Series[0].Points.Add(new SeriesPoint(mNow.AddDays(-1), mRandom.Next(4) + 93.5));
        }

        private void LoadWeather(string city)
        {
            InitDateTime();
            InitCurrentWeather(city);
            InitNextdayWeather(city);
            InitThirddayWeather(city);
            InitFourthdayWeather(city);
        }

        private void InitDateTime()
        {
            lblDateTime1.Text = string.Format("  {0}月{1}日         {2}", DateTime.Now.Month, DateTime.Now.Day,
                Enum.GetName(typeof(DayOfWeek), DateTime.Now.DayOfWeek));
            lblDateTime2.Text = Enum.GetName(typeof(DayOfWeek), DateTime.Now.AddDays(1).DayOfWeek).Substring(0, 3);
            lblDateTime3.Text = Enum.GetName(typeof(DayOfWeek), DateTime.Now.AddDays(2).DayOfWeek).Substring(0, 3);
            lblDateTime4.Text = Enum.GetName(typeof(DayOfWeek), DateTime.Now.AddDays(3).DayOfWeek).Substring(0, 3);
        }

        private void InitFourthdayWeather(string city)
        {
            XmlNode root = weatherSina(city, 3);
            lblTemperature5.Text = root["temperature1"].InnerText + "℃";
            Image image;
            if (DateTime.Now.Hour > 18 || DateTime.Now.Hour < 7)//夜间
            {
                string figure = root["figure2"].InnerText;
                image = getImage(figure, "78", "night");
            }
            else
            {
                string figure = root["figure1"].InnerText;
                image = getImage(figure, "78", "day");
            }

            pboxFigure4.Image = image;

        }

        private void InitThirddayWeather(string city)
        {
            XmlNode root = weatherSina(city, 2);
            lblTemperature4.Text = root["temperature1"].InnerText + "℃";
            Image image;
            if (DateTime.Now.Hour > 18 || DateTime.Now.Hour < 7)//夜间
            {
                string figure = root["figure2"].InnerText;
                image = getImage(figure, "78", "night");
            }
            else
            {
                string figure = root["figure1"].InnerText;
                image = getImage(figure, "78", "day");
            }

            pboxFigure3.Image = image;
        }

        private void InitNextdayWeather(string city)
        {
            XmlNode root = weatherSina(city, 1);
            lblTemperature3.Text = root["temperature1"].InnerText + "℃";
            Image image;
            if (DateTime.Now.Hour > 18 || DateTime.Now.Hour < 7)//夜间
            {
                string figure = root["figure2"].InnerText;
                image = getImage(figure, "78", "night");
            }
            else
            {
                string figure = root["figure1"].InnerText;
                image = getImage(figure, "78", "day");
            }

            pboxFigure2.Image = image;
        }

        private void InitCurrentWeather(string city)
        {

            XmlNode root = weatherSina(city, 0);
            lblTemperature1.Text = root["temperature1"].InnerText + "℃";
            lblTemperature2.Text = "\\" + root["temperature2"].InnerText + "℃";


            Image imageFigure;
            if (DateTime.Now.Hour > 18 || DateTime.Now.Hour < 7)//夜间
            {
                lblDirection.Text = root["direction2"].InnerText;
                lblPower.Text = root["power2"].InnerText.Replace("-", "~") + "级";
                string figure = root["figure2"].InnerText;
                imageFigure = getImage(figure, "180", "night");
            }
            else
            {
                lblDirection.Text = root["direction1"].InnerText;
                lblPower.Text = root["power1"].InnerText.Replace("-", "~") + "级";
                string figure = root["figure1"].InnerText;
                imageFigure = getImage(figure, "180", "day");
            }

            InitDirection(lblDirection.Text);
            pboxFigure1.Image = imageFigure;
        }

        private void InitDirection(string direction)
        {
            pboxDirectionN.Visible = false;
            pboxDirectionNE.Visible = false;
            pboxDirectionE.Visible = false;
            pboxDirectionES.Visible = false;
            pboxDirectionS.Visible = false;
            pboxDirectionSW.Visible = false;
            pboxDirectionW.Visible = false;
            pboxDirectionWN.Visible = false;

            if (direction.Contains("北"))
            {
                if (direction.Contains("西"))
                {
                    pboxDirectionES.Visible = true;
                    return;
                }
                else if (direction.Contains("东"))
                {
                    pboxDirectionSW.Visible = true;
                    return;
                }
                else
                {
                    pboxDirectionS.Visible = true;
                    return;
                }
            }
            if (direction.Contains("南"))
            {
                if (direction.Contains("西"))
                {
                    pboxDirectionNE.Visible = true;
                    return;
                }
                else if (direction.Contains("东"))
                {
                    pboxDirectionWN.Visible = true;
                    return;
                }
                else
                {
                    pboxDirectionN.Visible = true;
                    return;
                }
            }
            if (direction.Contains("西"))
            {
                pboxDirectionE.Visible = true;
                return;
            }
            if (direction.Contains("东"))
            {
                pboxDirectionW.Visible = true;
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="figure"></param>
        /// <param name="size">180 or 78</param>
        /// <param name="dayorNight">day or night</param>
        /// <returns></returns>
        private static Image getImage(string figure, string size, string dayorNight)
        {
            var webClient = new WebClient() { Encoding = Encoding.UTF8 };
            byte[] bytes;
            string figureUri;
            if (size == "180")
            {
                if (dayorNight == "day")
                {
                    figureUri = string.Format("http://php.weather.sina.com.cn/images/yb3/180_180/{0}_0.png", figure);
                }
                else if (dayorNight == "night")
                {
                    figureUri = string.Format("http://php.weather.sina.com.cn/images/yb3/180_180/{0}_1.png", figure);
                }
                else
                {
                    throw new Exception("dayorNight 类型不支持");
                }
            }
            else if (size == "78")
            {
                if (dayorNight == "day")
                {
                    figureUri = string.Format("http://php.weather.sina.com.cn/images/yb3/78_78/{0}_0.png", figure);
                }
                else if (dayorNight == "night")
                {
                    figureUri = string.Format("http://php.weather.sina.com.cn/images/yb3/78_78/{0}_1.png", figure);
                }
                else
                {
                    throw new Exception("dayorNight 类型不支持");
                }
            }
            else
            {
                throw new Exception("size 类型不支持");
            }
            bytes = webClient.DownloadData(figureUri);
            Image image = null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                ms.Write(bytes, 0, bytes.Length);
                image = Image.FromStream(ms, true);
            }
            return image;
        }

        /// <summary>
        /// 从sina获取天气预报信息
        /// </summary>
        /// <param name="day">day为0表示当天天气，1表示第二天的天气，2表示第三天的天气，以此类推，最大为4</param>
        public XmlNode weatherSina(string city, int day)
        {
            //Get weather data(xml format)其中，city是城市名称,password固定，day为0表示当天天气，1表示第二天的天气，2表示第三天的天气，以此类推，最大为4
            string weather = webClient.DownloadString(string.Format(
                "http://php.weather.sina.com.cn/xml.php?city={0}&password=DJOYnieT8234jlsK&day={1}",
                HttpUtility.UrlEncode(city, Encoding.GetEncoding("GB2312")), day));

            // 图片格式：
            //figure1和figure2标签分别代表天气的白天和夜间标志，根据下面的规则转换为具体的路径：
            //多云的78 * 78 小图：
            // 白天： http://php.weather.sina.com.cn/images/yb3/78_78/duoyun_0.png 
            // 夜间： http://php.weather.sina.com.cn/images/yb3/78_78/duoyun_1.png
            //多云的 180 * 180 大图：
            // 白天：http://php.weather.sina.com.cn/images/yb3/180_180/duoyun_0.png
            // 夜间：http://php.weather.sina.com.cn/images/yb3/180_180/duoyun_1.png

            var xml = new XmlDocument();
            xml.LoadXml(weather);
            //Get weather detail
            var root = xml.SelectSingleNode("/Profiles/Weather");
            return root;

        }
    }

    public static class ImageEx
    {
        public static Image GetRotateImage(this Image img, float angle)
        {
            angle = angle % 360;//弧度转换
            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);
            //原图的宽和高
            int w = img.Width;
            int h = img.Height;
            int W = (int)(Math.Max(Math.Abs(w * cos - h * sin), Math.Abs(w * cos + h * sin)));
            int H = (int)(Math.Max(Math.Abs(w * sin - h * cos), Math.Abs(w * sin + h * cos)));
            //目标位图
            Image dsImage = new Bitmap(W, H, img.PixelFormat);
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(dsImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //计算偏移量
                Point Offset = new Point((W - w) / 2, (H - h) / 2);
                //构造图像显示区域：让图像的中心与窗口的中心点一致
                Rectangle rect = new Rectangle(Offset.X, Offset.Y, w, h);
                Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                g.TranslateTransform(center.X, center.Y);
                g.RotateTransform(360 - angle);
                //恢复图像在水平和垂直方向的平移
                g.TranslateTransform(-center.X, -center.Y);
                g.DrawImage(img, rect);
                //重至绘图的所有变换
                g.ResetTransform();
                g.Save();
            }
            return dsImage;
        }
    }

    /// <summary>
    /// Panel扩展类
    /// </summary>
    public abstract class PanelExtend : Panel
    {
        protected Graphics graphics;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // 实现透明样式

                return cp;
            }
        }

        public PanelExtend()
        {
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.graphics = e.Graphics;

            this.graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            OnDraw();
        }

        protected abstract void OnDraw();
    }

    /// <summary>
    /// 实现绘制图像
    /// </summary>
    public class PictureBoxModel : PanelExtend
    {
        public PictureBoxModel()
        {
            //this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnDraw()
        {
            // 获取图像
            Image imageModel = Properties.Resources.dam_sw1;
            //Image imageShui = Properties.Resources.shui;

            //int width = imageModel.Size.Width;
            //int height = imageModel.Size.Height;

            int width = this.Width;
            int height = this.Height;
            Rectangle recModel = new Rectangle(0, 0, width, height);
            //Rectangle recShui = new Rectangle(0, 0, imageShui.Width, imageShui.Height);

            this.graphics.DrawImage(imageModel, recModel);
            //this.graphics.DrawImage(imageShui, recShui);
        }
    }
}
