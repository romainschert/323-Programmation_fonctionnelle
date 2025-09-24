using System.Xml;

namespace Rando
{
    public partial class Rando : Form
    {
        List<Trackpoint> _trackpoints = new List<Trackpoint>();
        public Rando()
        {
            InitializeComponent();

            _trackpoints = Reader.ReadGpxFile("loechegemmi.gpx");
        }

        
        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;

            Point[] points = new Point[4] { new Point(30,50), new Point(50,10), new Point(80,50), new Point(111,400) };
            this.CreateGraphics().DrawLines(myPen, points);
        }
    }
}
