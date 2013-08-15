using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
			WriteableBitmap 
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
	}
}
