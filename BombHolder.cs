using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace minefield
{
	public class BombHolder : MineProperties
	{
		public BombHolder(ZorlukSeviyesi _zorluk)
		{
			zorluk = _zorluk;
			MayMine = new Button[9];

		}

		int bombNumber = 0, MayMineNumber = 0;
		bool twoDigits = false, oneDigits = false;
		Button[] bombS;
		int sayac = 0, recursive = 0;
		Button[] MayMine;
		Button firstClick;
		bool a = true, b = true, c = true, d = true, e = true, n = true, h = true, p = true, k = true;

		public void DirectionalMineControl(Button _MayMine)
		{
			MayMine[recursive] = _MayMine;
			if (recursive < 8)
			{
				recursive++;
			}
			if (a)
			{
				a = false;
				firstClick = _MayMine;
			}

			bombNumber = 0;
			bombS = new Button[((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count];

			foreach (var item in ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls)
			{
				bombS[bombNumber] = item as Button;
				bombNumber++;
			}
			bombNumber = 0;

			twoDigits = int.TryParse(_MayMine.Name.Substring(0, 2).ToString(), out MayMineNumber);
			if (MayMineNumber == 0)
			{
				oneDigits = int.TryParse(_MayMine.Name.Substring(0, 1).ToString(), out MayMineNumber);
			}

			if (twoDigits || oneDigits)
			{
				ArrayList controlledbombs = new ArrayList();

				controlledbombs.Add(bombS[MayMineNumber]);
				if (MayMineNumber - 11 >= 0)
				{
					if (bombS[MayMineNumber - 11] != null)
					{
						controlledbombs.Add(bombS[MayMineNumber - 11]);
					}
				}
				if (MayMineNumber - 12 >= 0)
				{
					if (bombS[MayMineNumber - 12] != null)
					{
						controlledbombs.Add(bombS[MayMineNumber - 12]);
					}
				}
				if (MayMineNumber - 13 >= 0)
				{
					if (bombS[MayMineNumber - 13] != null && MayMineNumber - 13 >= 0)
					{
						controlledbombs.Add(bombS[MayMineNumber - 13]);
					}
				}
				if (MayMineNumber - 1 >= 0)
				{
					if (bombS[MayMineNumber - 1] != null)
					{
						controlledbombs.Add(bombS[MayMineNumber - 1]);
					}
				}
				if (MayMineNumber + 1 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[MayMineNumber + 1] != null)
					{
						controlledbombs.Add(bombS[MayMineNumber + 1]);
					}
				}
				if (MayMineNumber + 11 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[MayMineNumber + 11] != null)
					{
						controlledbombs.Add(bombS[MayMineNumber + 11]);
					}
				}
				if (MayMineNumber + 12 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[MayMineNumber + 12] != null)
					{
						controlledbombs.Add(bombS[MayMineNumber + 12]);
					}
				}
				if (MayMineNumber + 13 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[MayMineNumber + 13] != null)
					{
						controlledbombs.Add(bombS[MayMineNumber + 13]);
					}
				}
				DoYouHaveBomb(controlledbombs);
			}
			else
			{
				MessageBox.Show("Üzgünüm! Beklenmedik Bir hatayla karşılaştık.");
			}

		}
		public void DoYouHaveBomb(ArrayList controlledbombs)
		{
			for (int i = 0; i < controlledbombs.Count; i++)
			{
				if (Math.Abs((controlledbombs[0] as Button).Location.X - (controlledbombs[i] as Button).Location.X) < 109 &&
					Math.Abs((controlledbombs[0] as Button).Location.Y - (controlledbombs[i] as Button).Location.Y) < 109)
				{
					sayac += (controlledbombs[i] as Button).Tag.ToString() != (-1).ToString() ? 1 : 0;
				}
				else
				{
					if (controlledbombs.Count >= i)
					{
						controlledbombs.Remove(controlledbombs[i]);
						i--;
					}
				}
				bombNumber++;
			}
			if (sayac == 0)
			{
				sayac = 0;

				if ((controlledbombs[0] as Button).FlatStyle != FlatStyle.Flat)
				{
					foreach (var bmbCntrl in controlledbombs)
					{
						if ((bmbCntrl as Button).FlatStyle != FlatStyle.Flat && (bmbCntrl as Button).Tag.ToString() == (-1).ToString())
						{
							((frmMineField)Application.OpenForms["frmMineField"]).ScoreReduction(null);
							(bmbCntrl as Button).FlatStyle = FlatStyle.Flat;
						}
					}
				}
				else
				{
					return;
				}
			}
			else
			{
				bombNumber = 0;
				if (bombS[MayMineNumber].Text == "" /*&& bombS[MayMineNumber].FlatStyle != FlatStyle.Flat*/)
				{
					if (sayac == 1 && bombS[MayMineNumber].Tag.ToString() == (-1).ToString())
					{

						bombS[MayMineNumber].ForeColor = Color.Blue;
						bombS[MayMineNumber].Text = sayac.ToString();

					}
					else if (sayac == 2 && bombS[MayMineNumber].Tag.ToString() == (-1).ToString())
					{

						bombS[MayMineNumber].ForeColor = Color.Green;
						bombS[MayMineNumber].Text = sayac.ToString();

					}
					else if (sayac == 3 && bombS[MayMineNumber].Tag.ToString() == (-1).ToString())
					{

						bombS[MayMineNumber].ForeColor = Color.DarkBlue;
						bombS[MayMineNumber].Text = sayac.ToString();

					}
					else if (sayac == 4 && bombS[MayMineNumber].Tag.ToString() == (-1).ToString())
					{

						bombS[MayMineNumber].ForeColor = Color.Brown;
						bombS[MayMineNumber].Text = sayac.ToString();

					}
					else if (sayac == 5 && bombS[MayMineNumber].Tag.ToString() == (-1).ToString())
					{

						bombS[MayMineNumber].ForeColor = Color.Crimson;
						bombS[MayMineNumber].Text = sayac.ToString();

					}
					else if (sayac == 6 && bombS[MayMineNumber].Tag.ToString() == (-1).ToString())
					{

						bombS[MayMineNumber].ForeColor = Color.MediumVioletRed;
						bombS[MayMineNumber].Text = sayac.ToString();

					}
					else if (sayac == 7 && bombS[MayMineNumber].Tag.ToString() == (-1).ToString())
					{

						bombS[MayMineNumber].ForeColor = Color.Red;
						bombS[MayMineNumber].Text = sayac.ToString();

					}
					else if (sayac == 8 && bombS[MayMineNumber].Tag.ToString() == (-1).ToString())
					{

						bombS[MayMineNumber].ForeColor = Color.DarkRed;
						bombS[MayMineNumber].Text = sayac.ToString();

					}
					if (bombS[MayMineNumber].FlatStyle != FlatStyle.Flat&& bombS[MayMineNumber].Tag.ToString() == (-1).ToString())
					{
						((frmMineField)Application.OpenForms["frmMineField"]).ScoreReduction(null);
						bombS[MayMineNumber].FlatStyle = FlatStyle.Flat;
					}

				}

			}


			foreach (var item in ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls)
			{
				bombS[bombNumber] = item as Button;
				if (bombNumber < 83)
				{
					bombNumber++;
				}

			}
			for (int i = 0; i < bombS.Count(); i++)
			{
				if (i + 1 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[i].Name == MayMine[0].Name && Math.Abs(bombS[i + 1].Location.X - MayMine[0].Location.X) < 109 && Math.Abs(bombS[i].Location.Y - MayMine[0].Location.Y) < 109)
					{
						MayMine[1] = bombS[i + 1];
					}

				}
				if (i - 1 >= 0 && i + 1 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[i].Name == MayMine[0].Name && Math.Abs(bombS[i + 1].Location.X - MayMine[0].Location.X) < 109 && Math.Abs(bombS[i].Location.Y - MayMine[0].Location.Y) < 109)
					{
						MayMine[2] = bombS[i - 1];
					}

				}
				if (i + 11 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[i].Name == MayMine[0].Name && Math.Abs(bombS[i + 11].Location.X - MayMine[0].Location.X) < 109 && Math.Abs(bombS[i].Location.Y - MayMine[0].Location.Y) < 109)
					{
						MayMine[3] = bombS[i + 11];
					}
				}
				if (i + 12 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[i].Name == MayMine[0].Name && Math.Abs(bombS[i + 12].Location.X - MayMine[0].Location.X) < 109 && Math.Abs(bombS[i].Location.Y - MayMine[0].Location.Y) < 109)
					{
						MayMine[4] = bombS[i + 12];
					}
				}
				if (i + 13 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[i].Name == MayMine[0].Name && Math.Abs(bombS[i + 13].Location.X - MayMine[0].Location.X) < 109 && Math.Abs(bombS[i].Location.Y - MayMine[0].Location.Y) < 109)
					{
						MayMine[5] = bombS[i + 13];
					}

				}
				if (i - 11 >= 0 && i - 11 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[i].Name == MayMine[0].Name && Math.Abs(bombS[i - 11].Location.X - MayMine[0].Location.X) < 109 && Math.Abs(bombS[i].Location.Y - MayMine[0].Location.Y) < 109)
					{
						MayMine[6] = bombS[i - 11];
					}

				}
				if (i - 12 >= 0 && i - 12 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[i].Name == MayMine[0].Name && Math.Abs(bombS[i - 12].Location.X - MayMine[0].Location.X) < 109 && Math.Abs(bombS[i].Location.Y - MayMine[0].Location.Y) < 109)
					{
						MayMine[7] = bombS[i - 12];
					}

				}
				if (i - 13 >= 0 && i - 13 < ((frmMineField)Application.OpenForms["frmMineField"]).mayinPaneli.Controls.Count)
				{
					if (bombS[i].Name == MayMine[0].Name && Math.Abs(bombS[i - 13].Location.X - MayMine[0].Location.X) < 109 && Math.Abs(bombS[i].Location.Y - MayMine[0].Location.Y) < 109)
					{
						MayMine[8] = bombS[i - 13];
					}
				}
			}
			bombNumber = 0;
			if (sayac == 0)
			{
				if (firstClick != MayMine[1] && MayMine[1] != null)
				{
					DirectionalMineControl(MayMine[1]);
					MayMine[1] = null;
				}
				if (firstClick != MayMine[2] && MayMine[2] != null)
				{
					DirectionalMineControl(MayMine[2]);
					MayMine[2] = null;
				}
				if (firstClick != MayMine[3] && MayMine[3] != null)
				{

					DirectionalMineControl(MayMine[3]);
					MayMine[3] = null;
				}
				if (firstClick != MayMine[4] && MayMine[4] != null)
				{

					DirectionalMineControl(MayMine[4]);
					MayMine[4] = null;
				}
				if (firstClick != MayMine[5] && MayMine[5] != null)
				{

					DirectionalMineControl(MayMine[5]);
					MayMine[5] = null;
				}
				if (firstClick != MayMine[6] && MayMine[6] != null)
				{

					DirectionalMineControl(MayMine[6]);
					MayMine[6] = null;
				}
				if (firstClick != MayMine[7] && MayMine[7] != null)
				{

					DirectionalMineControl(MayMine[7]);
					MayMine[7] = null;
				}
				if (firstClick != MayMine[8] && MayMine[8] != null)
				{

					DirectionalMineControl(MayMine[8]);
					MayMine[8] = null;
				}
			}
			//a = true; b = true; c = true; d = true; e = true; n = true; h = true; p = true;
			k = true;
			recursive = 0;
			sayac = 0;

		}
	}
}
