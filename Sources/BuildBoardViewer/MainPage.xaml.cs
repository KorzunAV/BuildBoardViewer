using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BuildBoardViewer
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DrawString()
        {
            WriteableBitmap writeableBmp = BitmapFactory.New(512, 512);

            WriteableBitmapExtensions.
                System.Drawing.Graphics formGraphics = this.CreateGraphics();
            string drawString = "Sample Text";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 150.0f;
            float y = 50.0f;
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();

        }

        private WriteableBitmap SetupRenderedTextBitmap(string text, double fontSize)
        {
            // setup the textblock we will render to a bitmap
            TextBlock txt1 = new TextBlock();
            txt1.Text = text;
            txt1.FontSize = fontSize; // set the font size before using the Actual Width / Height

            // create our first bitmap we will render to
            WriteableBitmap bitmap = new WriteableBitmap((int)txt1.ActualWidth, (int)txt1.ActualHeight);

            // put a black textblock under the white one to create a simple dropshadow
            txt1.Foreground = new SolidColorBrush(Colors.Black);
            bitmap.Render(txt1, new TranslateTransform() { X = -2, Y = -2 });

            txt1.Foreground = new SolidColorBrush(Colors.White);
            bitmap.Render(txt1, new TranslateTransform());

            // invalidate the bitmap so that it is rendered
            bitmap.Invalidate();

            return bitmap;
        }
    }
}
