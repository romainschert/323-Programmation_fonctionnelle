using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Rando
{
    public partial class Rando : Form
    {
        private List<Point> trackPoints2D = new List<Point>();

        public Rando()
        {
            InitializeComponent();
            LoadTrackpoints("Gemmi-Kandersteg.gpx");
        }

        private void LoadTrackpoints(string path)
        {
            XDocument gpxDoc = XDocument.Load(path);
            XNamespace ns = "http://www.topografix.com/GPX/1/1";

            var trackpoints = gpxDoc.Descendants(ns + "trkpt")
                .Select(tp => new
                {
                    Lat = double.Parse(tp.Attribute("lat").Value, CultureInfo.InvariantCulture),
                    Lon = double.Parse(tp.Attribute("lon").Value, CultureInfo.InvariantCulture)
                }).ToList();

            // Normalisation pour rentrer dans la fenêtre
            double minLat = trackpoints.Min(t => t.Lat);
            double maxLat = trackpoints.Max(t => t.Lat);
            double minLon = trackpoints.Min(t => t.Lon);
            double maxLon = trackpoints.Max(t => t.Lon);

            int width = this.ClientSize.Width - 20;
            int height = this.ClientSize.Height - 20;

            trackPoints2D = trackpoints.Select(tp => new Point(
                (int)((tp.Lon - minLon) / (maxLon - minLon) * width),
                height - (int)((tp.Lat - minLat) / (maxLat - minLat) * height)
            )).ToList();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (trackPoints2D.Count > 1)
            {
                using (Pen myPen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawLines(myPen, trackPoints2D.ToArray());
                }
            }
        }
    }
}