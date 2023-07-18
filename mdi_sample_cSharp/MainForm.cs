using System;
using System.Windows.Forms;

namespace mdi_sample_cSharp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void tsExit_Click(object sender, EventArgs e)
		{
			DialogResult confirmResult = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo);

			if (confirmResult == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void tsExample_Click(object sender, EventArgs e)
		{
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Example")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}

			if (!isOpen)
			{
				ExampleForm form = new ExampleForm();
				form.MdiParent = this;
				form.Show();
			}
		}

		private void tsAbout_Click(object sender, EventArgs e)
		{
			ShowAboutForm();
		}

		private void ShowAboutForm()
		{
			bool isOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "About-Us")
				{
					isOpen = true;
					f.Focus();
					break;
				}
			}

			if (!isOpen)
			{
				AboutForm form = new AboutForm();
				form.MdiParent = this;
				form.Show();
			}
		}

		private void tsbExit_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void tsbHelp_Click(object sender, EventArgs e)
		{
			ShowAboutForm();
		}
	}
}
