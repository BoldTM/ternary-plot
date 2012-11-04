using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gibbs
{
	public partial class frmMain : Form
	{
		private TernaryChart tc;

		public frmMain()
		{
			InitializeComponent();
		
			tc = new TernaryChart(1280, 1280);
			chart.Image = tc.ChartBitmap;

			bs.DataSource = tc.PlotData;

			tc.OnPaint = new EventHandler(
				delegate(Object o, EventArgs e)
				{
					chart.Invalidate();
				}
				);
		}

		private void DrawDataBtn_Click(object sender, EventArgs e)
		{
			tc.DrawData();
		}
	}
}
