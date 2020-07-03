using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minefield
{
	public partial class frmBaslarken : Form
	{
		public frmBaslarken()
		{
			InitializeComponent();

		}


		public ZorlukSeviyesi zorluk { get; set; }
		frmMineField MayinTarlam;
		BombHolder bombholder;

		bool seviyeKontrol = false;

		private void frmBaslarken_Load(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(rchTxtName.Text))
			{
				foreach (var item in this.Controls)
				{
					if (item is Button)
					{
						(item as Button).Enabled = false;
					}
				}
			}
		}

		private void ZorlukButonControl_Click(object sender, EventArgs e)
		{
			Button levelbtn = sender as Button;
			zorluk = (ZorlukSeviyesi)Convert.ToInt32(levelbtn.Tag);

			if (!string.IsNullOrWhiteSpace(rchTxtName.Text))
			{
				switch (zorluk)
				{
					case ZorlukSeviyesi.Kolay:
						//yapılacaklar
						break;
					case ZorlukSeviyesi.Orta:
						break;
					case ZorlukSeviyesi.Zor:
						break;

						//Dinamik olarak tanımlanacak Buton tipinde iki boyutlu dizi tanımladık.
				}
				if (seviyeKontrol)
				{
					bombholder = new BombHolder(zorluk);
					MayinTarlam = new frmMineField(zorluk);
					MayinTarlam.Show();
					this.ShowInTaskbar = false;
					this.Hide();
				}
			}
			else
			{
				//toolTip1.SetToolTip(rchTxtName, "Bu alanı boş geçemezsin Dude!");
			}
		}



		private void rchTxtName_TextChanged(object sender, EventArgs e)
		{
			if (rchTxtName.Text.Length >= 3)
			{
				foreach (var item in this.Controls)
				{
					if (item is Button)
					{
						(item as Button).Enabled = true;
					}

				}
				seviyeKontrol = true;
			}
			else
			{
				foreach (var item in this.Controls)
				{
					if (item is Button)
					{
						(item as Button).Enabled = false;
					}

				}
				seviyeKontrol = true;
			}

		}

		private void frmBaslarken_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
