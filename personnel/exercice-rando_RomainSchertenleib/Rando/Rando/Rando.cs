using System.Diagnostics;
using System.Xml;
using MKCoolsoft;
namespace Rando
{
    public partial class Rando : Form
    {
        List<Trackpoint> _trackpoints = new List<Trackpoint>();
        List<Point> points;
        public Rando()
        {
            InitializeComponent();

            _trackpoints = Reader.ReadGpxFile("loechegemmi.gpx");

            points = _trackpoints.Select(trackpoint => new Point((int)((trackpoint.Latitude - 46.3) * 5000), (int)((trackpoint.Longitude - 7.6) * 5000))).ToList();

            foreach (Point point in points)
            {
                Debug.WriteLine(point);
            }
            double lenght = 0;
            Func<Trackpoint, Trackpoint, Trackpoint>  findlenght = (a, b) =>
            {
                lenght += Math.Sqrt(Math.Pow(Math.Sqrt(Math.Pow(a.Latitude - b.Latitude, 2) + Math.Pow(a.Longitude - b.Longitude, 2)), 2) + Math.Pow(a.Elevation - b.Elevation, 2));

                return b;
            };

            _trackpoints.Aggregate(_trackpoints[0],(a,b) => findlenght(a,b));
        }
        
        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2; 

            this.CreateGraphics().DrawLines(myPen, points.ToArray());
        }

        

        
    }
}
