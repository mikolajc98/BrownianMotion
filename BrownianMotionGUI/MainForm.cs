using BrownianMotionModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BrownianMotionGUI
{
    public partial class MainForm : Form
    {
        private decimal _points = 0;
        public decimal Points
        {
            get => _points;
            set
            {
                _points = value;
                Refresh();
            }
        }

        private Pen _pen;
        public Pen Pen
        {
            get => _pen ?? new Pen(Color.Black, 2);
            set => _pen = value;
        }

        //Punkty na kontrolce są zapisywane jako piksele. Na ekranie HD (1080x1980) punkt (0;0) oraz punkt (2;5) 
        //byłyby praktycznie w tym samym miejscu. Mnożnik poniżej pomaga uwidocznić efekt na kontrolce
        private const int multipler = 30;



        public MainForm()
        {
            InitializeComponent();
            Pen = new Pen(Color.Black, 1);
        }

        private void _mainPanel_Paint(object sender, PaintEventArgs e)
        {
            if (Points < 2)
                return;

            var points = BrownPoint.GenerateNPoints((int)Points);

            // 0;0 to jest lewy górny punkt. Trzeba zrobić tak, żeby punkt 0;0 był na środku kontrolki.
            var panelZeroX = _mainPanel.Width / 2;
            var panelZeroY = _mainPanel.Height / 2;

            var pointsConverted = points.Select(brownPoint =>
            new Point((int)(brownPoint.X * multipler) + panelZeroX, -(int)(brownPoint.Y * multipler) + panelZeroY)).ToList();

            e.Graphics.DrawLines(Pen, pointsConverted.ToArray());
        }

        private void nudPoints_ValueChanged(object sender, System.EventArgs e)
        {
            Points = ((NumericUpDown)sender).Value;
        }

        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            Refresh();
        }
    }
}
