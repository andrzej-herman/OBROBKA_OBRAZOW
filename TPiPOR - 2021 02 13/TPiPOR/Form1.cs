using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPiPOR
{
	public partial class Form1 : Form
	{
		Bitmap bmp;
		int[,,] rgb;
		public Form1()
		{
			InitializeComponent();
		}

		private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		int w, h;

		private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() != DialogResult.OK)
				return;

			bmp = new Bitmap(openFileDialog1.FileName);
			w = bmp.Width;
			h = bmp.Height;

			progressBar1.Maximum = bmp.Height;
			pictureBox1.Image = bmp;
			pictureBox1.Size = bmp.Size;

			progressBar1.Visible = true;
			rgb = new int[bmp.Width, bmp.Height, 3];
			Color kolor;
						

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value =  y ;
				for (int x = 0; x < bmp.Width; x++)
				{
					kolor = bmp.GetPixel(x, y);
					rgb[x, y, 0] = kolor.R;
					rgb[x, y, 1] = kolor.G;
					rgb[x, y, 2] = kolor.B;
				}
			}
			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}

		private void wyświetlZ_RGB()
		{
			progressBar1.Visible = true;

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value = y;
				for (int x = 0; x < bmp.Width; x++)
					bmp.SetPixel(x, y, Color.FromArgb(rgb[x, y, 0], rgb[x, y, 1], rgb[x, y, 2]));
			}
			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}

		private void dopasowanyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBox1.Size = panel1.ClientSize;
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.Refresh();

		}

		private void standardowyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBox1.Size = bmp.Size;
			pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
			pictureBox1.Refresh();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			pictureBox1.Size = new Size(bmp.Width / 2, bmp.Height / 2);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.Refresh();
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			pictureBox1.Size = new Size(bmp.Width / 4, bmp.Height / 4);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.Refresh();
		}

		private void xToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pictureBox1.Size = new Size(bmp.Width * 2, bmp.Height * 2);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.Refresh();
		}

		private void ściemnijToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void ściemnijToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value = y;
				for (int x = 0; x < bmp.Width; x++)
				{
					Color kolor = bmp.GetPixel(x, y);
					int r, g, b;
					r = kolor.R * 2;
					g = kolor.G * 2;
					b = kolor.B * 2;
					if (r > 255)
						r = 255;
					if (g > 255)
						g = 255;
					if (b > 255)
						b = 255;
					bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
				}
			}

			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}

		private void rozjaśnijToolStripMenuItem_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value = y;
				for (int x = 0; x < bmp.Width; x++)
				{
					Color kolor = bmp.GetPixel(x, y);
					bmp.SetPixel(x, y, Color.FromArgb(128 + kolor.R / 2, 128 + kolor.G / 2, 128 + kolor.B / 2));
				}
			}

			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}

		private void ocieplenieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;
			Color kolor;
			int r, g, b;

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value = y;
				for (int x = 0; x < bmp.Width; x++)
				{
					kolor = bmp.GetPixel(x, y);
					r = kolor.R * 14 / 10;
					g = kolor.G;
					b = kolor.B * 10 / 14;

					if (r > 255)
						r = 255;

					bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
				}
			}

			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}

		private void oziębienieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;
			Color kolor;
			int r, g, b;

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value = y;
				for (int x = 0; x < bmp.Width; x++)
				{
					kolor = bmp.GetPixel(x, y);
					r = kolor.R * 10 / 14;
					g = kolor.G;
					b = kolor.B * 14 / 10;

					if (b > 255)
						b = 255;

					bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
				}
			}

			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}

		private void skalaSzarościToolStripMenuItem_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;
			Color kolor;
			int g;

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value = y;
				for (int x = 0; x < bmp.Width; x++)
				{
					kolor = bmp.GetPixel(x, y);
					g = (kolor.R * 3 + kolor.G * 6 + kolor.B) / 10;

					bmp.SetPixel(x, y, Color.FromArgb(g, g, g));
				}
			}

			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}

		private void czarnoBiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;
			Color kolor;
			int g;

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value = y;
				for (int x = 0; x < bmp.Width; x++)
				{
					kolor = bmp.GetPixel(x, y);
					g = (kolor.R * 3 + kolor.G * 6 + kolor.B) / 10;

					if (g < 128)
					{
						bmp.SetPixel(x, y, Color.Black);

					}
					else
					{
						bmp.SetPixel(x, y, Color.White);

					}
				}
			}

			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}

		private void czbZWyrównaniemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;
			Color kolor;
			int g;
			int err = 0;

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value = y;
				for (int x = 0; x < bmp.Width; x++)
				{
					kolor = bmp.GetPixel(x, y);
					g = (kolor.R * 3 + kolor.G * 6 + kolor.B) / 10 + err;

					if (g < 128)
					{
						bmp.SetPixel(x, y, Color.Black);
						err = g;
					}
					else
					{
						bmp.SetPixel(x, y, Color.White);
						err = g - 255;
					}
				}
			}

			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}

		Thread [] threads;
		bool [] t_fin;
		int [] proc_fin;
		int[] t_start, t_stop;

		private void blurToolStripMenuItem_Click(object sender, EventArgs e)
		{
//			threads = new Thread[1];
			threads = new Thread[Environment.ProcessorCount];
			t_fin = new bool[threads.Length];
			proc_fin = new int[threads.Length];
			t_start = new int[threads.Length];
			t_stop = new int[threads.Length];

			int lines_per_thread = h / threads.Length;

			while (lines_per_thread * threads.Length < h)
				lines_per_thread++;

			t_start[0] = 0;
			t_stop[threads.Length - 1] = h - 1;

			for (int i = 0; i < threads.Length; i++)
			{
				threads[i] = new Thread(funkcja_blur);
				t_fin[i] = false;
				proc_fin[i] = 0;

				if (i > 0)
					t_start[i] = t_stop[i-1] + 1;

				if (i < threads.Length - 1)
					t_stop[i] = t_start[i] + lines_per_thread;

			}

			progressBar1.Visible = true;
			progressBar1.Maximum = 100;

			timer1.Enabled = true;
			
			for (int i = 0; i < threads.Length; i++)
				threads[i].Start();

		}

		void funkcja_blur()
		{
			int thread_nr = -1;

			for (int i = 0; i < threads.Length; i++)
				if (Thread.CurrentThread.ManagedThreadId == threads[i].ManagedThreadId)
					thread_nr = i;


			int[] średnia = { 0, 0, 0 };
			int ile_sąsiadów;

			for (int y = t_start[thread_nr]; y <= t_stop[thread_nr]; y++)
			{
				proc_fin[thread_nr] = 100 * (y - t_start[thread_nr])/(t_stop[thread_nr]- t_start[thread_nr]+1);
				for (int x = 0; x < w; x++)
				{
					średnia[0] = średnia[1] = średnia[2] = 0;
					ile_sąsiadów = 0;

					for (int y1 = y - 2; y1 <= y + 2; y1++)
						for (int x1 = x - 2; x1 <= x + 2; x1++)
							if (x1 >= 0 && x1 < w && y1 >= 0 && y1 < h)
							{
								ile_sąsiadów++;
								for (int s = 0; s < 3; s++)
									średnia[s] += rgb[x1, y1, s];
							}

					for (int s = 0; s < 3; s++)
						rgb[x, y, s] = średnia[s] / ile_sąsiadów;

				}
			}
			t_fin[thread_nr] = true;
		}

        

        private void timer1_Tick(object sender, EventArgs e)
		{
			bool fin = true;
			for (int i = 0; i < threads.Length; i++)
				if (!t_fin[i])
					fin = false;

			if (fin)
			{
				timer1.Enabled = false;
				progressBar1.Maximum = h; 
				wyświetlZ_RGB();
				progressBar1.Visible = false;
				pictureBox1.Refresh();
				return;
			}

			int proc = 100;
			for (int i = 0; i < threads.Length; i++)
				if (proc_fin[i]<proc)
					proc= proc_fin[i];

			progressBar1.Value = proc;

		}

		private void czbiaFSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;
			int[,] gray = new int[bmp.Width, bmp.Height];

			int err = 0;

			for (int y = 0; y < bmp.Height; y++)
			{
				progressBar1.Value = 30 * y / 100;
				for (int x = 0; x < bmp.Width; x++)
				{
					gray[x, y] = (rgb[x,y,0] * 3 + rgb[x, y, 1] * 6 + rgb[x, y, 2]) / 10;
				}
			}

			for (int y = 0; y < h; y++)
			{
				progressBar1.Value = 30*h/100 + 70 * y / 100;
				for (int x = 0; x < w; x++)
				{
					if (gray[x, y] < 128)
					{
						rgb[x, y, 0] = 0;
						rgb[x, y, 1] = 0;
						rgb[x, y, 2] = 0;

						err = gray[x, y];
					}
					else
					{
						rgb[x, y, 0] = 255;
						rgb[x, y, 1] = 255;
						rgb[x, y, 2] = 255;

						err = gray[x, y] - 255;
					}

					if (x < w - 1)
						gray[x + 1, y] += err * 7 / 16;
					if (y < h - 1)
						gray[x, y + 1] += err * 5 / 16;
					if (x < w - 1 && y < h - 1)
						gray[x + 1, y + 1] += err / 16;
					if (x > 0 && y < h - 1)
						gray[x - 1, y + 1] += err * 3 / 16;

				}
			}

			progressBar1.Visible = false;
			pictureBox1.Refresh();
		}



        private void metodaTestowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
			
            progressBar1.Visible = true;

            for (int y = 0; y < bmp.Height; y++)
            {
                progressBar1.Value = y;
                for (int x = 0; x < bmp.Width; x++)
                {
                    var r = 0;
                    var g = 0;
                    var b = 0;

                    Color kolor = bmp.GetPixel(x, y);
					var sum = Convert.ToDecimal((kolor.R + kolor.G + kolor.B) / 3);
					var average = Math.Floor(sum);

					if (average < 128)
					{
                        r = 255;
						b = 255;
						g = 255;
                    }
						
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            progressBar1.Visible = false;
            pictureBox1.Refresh();



        }
    }
}

// RGB => 159, 25, 34
// ALFA => 255