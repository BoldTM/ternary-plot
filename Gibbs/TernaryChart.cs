using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace Gibbs
{
    class TernaryChart : IDisposable
    {
        private Bitmap _bmp;
        private Graphics _surface;
        private int _width;
        private int _height;

        public EventHandler OnPaint;
        private void NotifyOnPaint()
        {
            if (OnPaint != null)
                OnPaint(this, null);
        }

        public TernaryChart(int width, int height)
        {
            _width = width;
            _height = height;
            _bmp = new Bitmap(_width, _height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            _surface = Graphics.FromImage(_bmp);
            _surface.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            _surface.Clear(Color.White);

            DrawEmptyChart();

            _PlotData = new BindingList<TernaryData>();
        }

        private BindingList<TernaryData> _PlotData;
        public BindingList<TernaryData> PlotData
        {
            get { return _PlotData; }
            set { _PlotData = value; } 
        }

        public void Dispose()
        {
            _surface.Dispose();
            _bmp.Dispose();
        }

        public Bitmap ChartBitmap
        { 
            get { return _bmp; } 
        }
        
        public Graphics Chart
        {
            get { return _surface; }
        }

        private Point ScalePoint(Point point, double f)
        {
            point.X = (int)(f * point.X + 0.50 * _width * (1 - f) );
            point.Y = (int)(f * point.Y + 0.50 * (_height - _width * f * Math.Sqrt(3)/2) );

            return point;
        }

        private Point ToCart(double a, double b, double c)
        {
            Point result = new Point(0, 0);

            try
            {
                result.X = (int)(_width * 0.5 * (2 * b + c) / (a + b + c));
                result.Y = (int)(_height * Math.Pow(1.5, -0.5) * (a + b) / (a + b + c));
            }
            catch (Exception)
            { }

            return ScalePoint(result, 0.8);
        }

        private Point ToCart(double a, double b)
        {
            return ToCart(a, b, 1 - a - b);
        }

        private void DrawPoint(double a, double b, double c, Pen pen)
        {
            try
            {
                _surface.DrawRectangle(pen, ToCart(a/100, b/100, c/100).X, ToCart(a/100, b/100, c/100).Y, 1, 1);
                NotifyOnPaint();
            }
            catch (Exception)
            { }
        }

        private void DrawEmptyChart()
        {
            #region Linie Wewnętrzne
            using (Pen pióro = new Pen(Color.LightGray, 0.01f))
            {
                for (double i = 0.0f; i <= 1; i = i + 0.01)
                {
                    _surface.DrawLine(pióro, ToCart(i, 1 - i, 0), ToCart(0, 1 - i, i));
                    _surface.DrawLine(pióro, ToCart(0, i, 1 - i), ToCart(i, 0, 1 - i));
                    _surface.DrawLine(pióro, ToCart(i, 1 - i, 0), ToCart(i, 0, 1 - i));
                }           
            }
            using (Pen pióro = new Pen(Color.LightGray, 2f))
            {
                for (double i = 0.0f; i <= 1; i = i + 0.05)
                {
                    _surface.DrawLine(pióro, ToCart(i, 1 - i, 0), ToCart(0, 1 - i, i));
                    _surface.DrawLine(pióro, ToCart(0, i, 1 - i), ToCart(i, 0, 1 - i));
                    _surface.DrawLine(pióro, ToCart(i, 1 - i, 0), ToCart(i, 0, 1 - i));
                }
            }
            #endregion

            #region Trójkąt
            using (Pen pióro = new Pen(Color.Black, 2))
            {
                _surface.DrawLine(pióro, ToCart(1, 0, 0), ToCart(0, 1, 0));
                _surface.DrawLine(pióro, ToCart(1, 0, 0), ToCart(0, 0, 1));
                _surface.DrawLine(pióro, ToCart(0, 0, 1), ToCart(0, 1, 0));
            }
            #endregion

            #region Legenda
            using (Font krój = new Font(FontFamily.GenericMonospace, 15.0f, FontStyle.Bold)) 
            using (Brush pędzel = new SolidBrush(Color.Brown))
            {
                #region Oś A-B
                for (double i = 0.0f; i <= 1; i = i + 0.1)
                {
                    String label = (i * 100).ToString();

                    _surface.ResetTransform();
                    _surface.TranslateTransform(ToCart(1 - i, i, 0).X - 15, ToCart(1 - i, i, 0).Y + 5);
                    
                    _surface.DrawString(
                        label,
                        krój,
                        pędzel,
                        0, 0
                        );
                    
                }
                _surface.ResetTransform();
                #endregion

                #region Oś B-C
                for (double i = 0.0f; i <= 1; i = i + 0.1)
                {
                    String label = (i * 100).ToString();

                    _surface.ResetTransform();
                    _surface.TranslateTransform(ToCart(0, 1 - i, i).X + 5, ToCart(0, 1 - i, i).Y - 12);
                    //_surface.RotateTransform(-30);
                    
                    _surface.DrawString(
                        label,
                        krój,
                        pędzel,
                        0, 0,
                        new StringFormat() { Alignment = StringAlignment.Near }
                        );
                    
                }
                _surface.ResetTransform();
                #endregion

                #region Oś C-A
                for (double i = 0.0f; i <= 1; i = i + 0.1)
                {
                    String label = (i * 100).ToString();

                    _surface.ResetTransform();
                    _surface.TranslateTransform(ToCart(i, 0, 1 - i).X - 3 , ToCart(i, 0, 1 - i).Y - 12);
                    //_surface.RotateTransform(30);

                    _surface.DrawString(
                        label,
                        krój,
                        pędzel,
                        0, 0,
                        new StringFormat() { Alignment = StringAlignment.Far }
                        );
                    

                }
                _surface.ResetTransform();
                #endregion
            }
            
            using (Font krój = new Font(FontFamily.GenericMonospace, 35.0f, FontStyle.Bold))
            using (Brush pędzel = new SolidBrush(Color.Blue))
            {
                #region Wierzchołek A
                _surface.ResetTransform();
                _surface.TranslateTransform(ToCart(1, 0, 0).X - 50, ToCart(1, 0, 0).Y);

                _surface.DrawString(
                    "A",
                    krój,
                    pędzel,
                    0, 0
                    );
                #endregion

                #region Wierzchołek B
                _surface.ResetTransform();
                _surface.TranslateTransform(ToCart(0, 1, 0).X + 20, ToCart(0, 1, 0).Y);

                _surface.DrawString(
                    "B",
                    krój,
                    pędzel,
                    0, 0
                    );
                #endregion

                #region Wierzchołek C
                _surface.ResetTransform();
                _surface.TranslateTransform(ToCart(0, 0, 1).X - 20, ToCart(0, 0, 1).Y - 50);

                _surface.DrawString(
                    "C",
                    krój,
                    pędzel,
                    0, 0
                    );
                #endregion
            }
            _surface.ResetTransform();
            #endregion

            NotifyOnPaint();
        }

        private void RedrawData()
        {

        }

        public void DrawData()
        {
            foreach (TernaryData td in _PlotData)
            {
                DrawPoint(td.A, td.B, td.C, new Pen(Color.Red, 10));
            }
            DrawBezier();
            NotifyOnPaint();
        }

        public void DrawBezier()
        {
            for (int n = 0; n <= _PlotData.Count - 4; n = n + 4 )
            {
                _surface.DrawBezier(new Pen(Color.Green),
                    ToCart(_PlotData[n].A, _PlotData[n].B, _PlotData[n].C),
                    ToCart(_PlotData[n + 1].A, _PlotData[n + 1].B, _PlotData[n + 1].C),
                    ToCart(_PlotData[n + 2].A, _PlotData[n + 2].B, _PlotData[n + 2].C),
                    ToCart(_PlotData[n + 3].A, _PlotData[n + 3].B, _PlotData[n + 3].C)
                    );
            }            
        }
    }
}
