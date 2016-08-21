using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picjudge
{
	public partial class Form1 : Form
	{
		List<String> files = null;
		int fileitem = 0;
		bool?[] deleteOnSave = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_ResizeEnd(object sender, EventArgs e)
		{
			//int width = Convert.ToInt32((double)218 * ((double)this.Size.Width / (double)561));
			int width = btnLoad.Location.X - 25;
			btnNoGood.Size = new Size(width, btnNoGood.Size.Height);
			btnNext.Size = new Size(width, btnNoGood.Size.Height);

			Point curLoc = btnNext.Location;
			btnNext.Location = new Point((this.Size.Width - btnNext.Size.Width) - 30, curLoc.Y);
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x0112) // WM_SYSCOMMAND
			{
				// Check your window state here
				if (m.WParam == new IntPtr(0xF030)) // Maximize event - SC_MAXIMIZE from Winuser.h
				{
					// THe window is being maximized
					Form1_ResizeEnd(null,null);
				}
			}
			base.WndProc(ref m);
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			Form1_ResizeEnd(null, null);
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			pbImage.Image = null;

			if(files != null)
			{
				fileitem = 0;
				foreach(var item in files)
				{
					string shortfilename = item.Substring(item.LastIndexOf('\\'));

					if(deleteOnSave[fileitem] != null)
						if ((bool)deleteOnSave[fileitem])
							File.Move(item, Directory.GetCurrentDirectory() + "\\DELETED\\" + shortfilename);
						else
							File.Move(item, Directory.GetCurrentDirectory() + "\\GOOD\\" + shortfilename);

					fileitem++;
				}
				MessageBox.Show("Picture Judge Saved. Goodbye");
				Application.Exit();
			}

			FolderBrowserDialog fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();

			files = DirSearch(fbd.SelectedPath);
			if (files == null || files.Count == 0)
				return;

			btnLoad.Text = "Save";

			//btnLoad_Click(null, null);

			btnBack.Enabled = true;
			btnNoGood.Enabled = true;
			btnNext.Enabled = true;

			var boolArray = new List<bool?>();

			foreach (var item in files)
				boolArray.Add(null);

			deleteOnSave = boolArray.ToArray();

			AdvancePicture(true);

			new object();

		}

		private void AdvancePicture(bool dontAdvance = false)
		{
			if(fileitem == files.Count-1)
			{
				MessageBox.Show("Last picture validated");
				return;
			}


			if (!dontAdvance)
				fileitem++;

			pbImage.Image = GetCopyImage(files[fileitem]);
			deleteOnSave[fileitem] = false;

		}

		private void RewindPicture()
		{
			if (fileitem != 0)
				fileitem--;

			pbImage.Image = GetCopyImage(files[fileitem]);
			deleteOnSave[fileitem] = false;

		}

		private Image GetCopyImage(string path)
		{
			using (Image im = Image.FromFile(path))
			{
				Bitmap bm = new Bitmap(im);
				return bm;
			}
		}

		private List<String> DirSearch(string sDir)
		{
			List<String> files = new List<String>();
			try
			{
				foreach (string f in Directory.GetFiles(sDir))
				{
					files.Add(f);
				}
				foreach (string d in Directory.GetDirectories(sDir))
				{
					files.AddRange(DirSearch(d));
				}
			}
			catch (System.Exception excpt)
			{
				MessageBox.Show(excpt.Message);
			}
			if (files.Count == 0)
				return null;

			return files;
		}

		private void btnNoGood_Click(object sender, EventArgs e)
		{
			deleteOnSave[fileitem] = true;
			AdvancePicture();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			AdvancePicture();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			RewindPicture();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pbImage.SizeMode = PictureBoxSizeMode.Zoom;

			if (!Directory.Exists("GOOD"))
				Directory.CreateDirectory("GOOD");

			if (!Directory.Exists("DELETED"))
				Directory.CreateDirectory("DELETED");
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{

		}
	}
}
