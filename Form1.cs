using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.IO;

namespace minefield
{
    public partial class frmMineField : Form
    {
        BombHolder bombholder;

        Stopwatch stopWatch = new Stopwatch();
        DialogResult result;
        public frmMineField(ZorlukSeviyesi _zorluk)
        {
            InitializeComponent();
            zorluk = _zorluk;
            bombholder = new BombHolder(zorluk);
            frmBaslarken frmBaslarken = new frmBaslarken();
            Timer1.Start();
            Timer1.Tick += Timer1_Tick;
        }
        string path = Directory.GetCurrentDirectory();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            stopWatch.Start();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
            ts.Hours, ts.Minutes, ts.Seconds);
            lblElapsedTime.Text = elapsedTime;

        }

        public ZorlukSeviyesi zorluk { get; set; }
        int mtrsX = MineProperties.matrisX, mtrsY = MineProperties.matrisY,
            nmbrofbmbs = MineProperties.numberOfbombs, X = MineProperties.X, Y = MineProperties.Y;

        Button[] BombAdded;
        int finish = 0;
        Button btnBomba;

        int skor = 0, index = 0;


        SoundPlayer sndplyr;

        private void frmMineField_FormClosed(object sender, FormClosedEventArgs e)
        {
            Local local = new Local(lblUserName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yeni Oyun Başlatmak İstiyormusunuz ?", "Yeni Oyun", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                frmBaslarken frmBaslarken = new frmBaslarken();
                frmBaslarken.Show();
            }
            else
            {
                button1_Click(null, null);
            }
        }

        public void WhichClicked_MouseUp(object sender, MouseEventArgs e)
        {
            BombAdded = new Button[MineIncrease.MineIncreaseLevel(zorluk)];
            int levelCount = MineIncrease.MineIncreaseLevel(zorluk);

            switch (e.Button)
            {
                case MouseButtons.Left:
                    foreach (var item in mayinPaneli.Controls)
                    {
                        if (item is Button && (item as Button).Tag.ToString() != (-1).ToString())
                        {
                            BombAdded[index] = item as Button;
                            index++;
                        }
                    }

                    index = 0;

                    Button tryminefield = sender as Button;
                    if (tryminefield.Tag.ToString() == (-1).ToString())
                    {
                        //etrafmayincontrolu
                        string str = tryminefield.Name.ToString();
                        bombholder.DirectionalMineControl(sender as Button);
                    }
                    else if (tryminefield.Tag.ToString() != (-1).ToString())
                    {
                        foreach (var item in mayinPaneli.Controls)
                        {
                            if ((item as Button).Tag.ToString() != (-1).ToString())
                            {
                                (item as Button).Image = Image.FromFile(PathAdjuster() +"images\\weapons.png");
                                (item as Button).BackColor = Color.Red;
                            }
                            BombDropper();

                        }
                        string[] adres = path.Split('\\');
                        string realPath = "";
                        for (int n = 0; n < adres.Length - 2; n++)
                        {
                            realPath += adres[n] + "\\";
                        }
                        button2.Image = Image.FromFile(PathAdjuster() + "images\\deaiead.png");

                        SoundPlayer sndplyr = new SoundPlayer("y2mate.wav");

                        sndplyr.Play();
                        Timer1.Stop();
                        stopWatch.Stop();
                        result = MessageBox.Show("Tekrar Deneyin!!\n " + "\nGeçen Süre: " + lblElapsedTime.Text, "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Üzgünüm. Bir Hata Oluştu!");
                    }
                    if (skor == levelCount)
                    {

                        button2.Image = Image.FromFile(PathAdjuster() +"images\\famous.png");
                        foreach (var item in mayinPaneli.Controls)
                        {
                            if ((item as Button).Tag.ToString() != (-1).ToString())
                            {
                                (item as Button).Image = Image.FromFile(PathAdjuster()+ "images\\weapons.png");
                                (item as Button).BackColor = Color.Blue;
                            }
                        }
                        BombDropper();
                        sndplyr = new SoundPlayer("victory-music.wav");
                        sndplyr.Play();
                        Timer1.Stop();
                        stopWatch.Stop();
                        result = MessageBox.Show("Tebrikler!! " + lblElapsedTime.Text + " bitirdiniz...", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    break;
                case MouseButtons.Right:

                    if ((sender as Button).Image == null)
                    {
                        (sender as Button).Image = Image.FromFile(PathAdjuster() +"images\\flagicon.png");
                        ScoreReduction(null);
                    }
                    else
                    {
                        (sender as Button).Image = null;
                        ScoreReduction(false);
                    }
                    if (skor == levelCount || mayinPaneli.Controls.Count - levelCount == skor)
                    {
                        button2.Image = Image.FromFile(PathAdjuster() +"images\\famous.png");
                        foreach (var item in mayinPaneli.Controls)
                        {
                            if ((item as Button).Tag.ToString() != (-1).ToString())
                            {
                                (item as Button).Image = Image.FromFile(PathAdjuster() + "images\\weapons.png");
                                (item as Button).BackColor = Color.Blue;
                            }
                        }
                        BombDropper();
                        sndplyr = new SoundPlayer("victory-music.wav");
                        sndplyr.Play();
                        Timer1.Stop();
                        stopWatch.Stop();
                        result = MessageBox.Show("Tebrikler!! " + lblElapsedTime.Text + " bitirdiniz...", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
            if (DialogResult.OK == result)
            {
                //TODO
                button2_Click(null, null);
            }
        }
        public void BombDropper()
        {
            foreach (var item in mayinPaneli.Controls)
            {
                if (item is Button)
                {
                    (item as Button).MouseUp -= WhichClicked_MouseUp;
                }
            }
        }
        private string PathAdjuster()
        {
            string[] adres = path.Split('\\');
            string realPath = "";
            for (int n = 0; n < adres.Length - 2; n++)
            {
                realPath += adres[n] + "\\";
            }
            return realPath;
        }
        private void frmMineField_Load(object sender, EventArgs e)
        {
            //C:\Users\kamil\source\repos\ProjeOdevi_K.YasinABLAY\minefield\images\weapons.png
            
            mineInserter inserter = new mineInserter();

            int k = 0;

            lblfrmName.Text = this.Text;
            lblUserName.Text = (Application.OpenForms["frmBaslarken"].Controls["rchTxtName"] as RichTextBox).Text;

            frmMineField frmMineField = new frmMineField(zorluk);
            //Button[] bombalar = new Button[mtrsX];
            Random rnd = new Random();

            for (int i = 0; i < mtrsX * mtrsY; i++)
            {
                btnBomba = new Button();
                if (frmMineField.mayinPaneli.Height > Y + 54)
                {
                    btnBomba.Size = new Size(51, 51);
                    btnBomba.Location = new Point(X, Y);
                    btnBomba.Name = i.ToString() + ". buton";
                    // btnBomba.Text = i.ToString() + ". buton";
                    toolTip1.SetToolTip(btnBomba, btnBomba.Name + "  " + (btnBomba.Location.X,
                        btnBomba.Location.Y));
                    btnBomba.MouseUp += WhichClicked_MouseUp;
                    btnBomba.Tag = "-1";
                }
                else
                {
                    break;
                }
                if (mayinPaneli.Width > btnBomba.Location.X + 54)
                {
                    mayinPaneli.Controls.Add(btnBomba);
                    X += 54;
                }
                else
                {
                    mayinPaneli.Controls.Add(btnBomba);
                    X = 3;
                    if (mayinPaneli.Height > btnBomba.Location.Y + 65)
                    {
                        Y += 54;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            MineProperties.numberOfbombs = MineIncrease.MineIncreaseLevel(zorluk);
            MineProperties.locations = new int[MineProperties.numberOfbombs];
            int[] MineCarrier = inserter.MineInserter();
            foreach (var item in mayinPaneli.Controls)
            {
                if (item is Button)
                {
                    var b = (item as Button).Name.Substring(0, 1);
                    var itemName = (item as Button).Name;
                    for (int i = 0; i < MineCarrier.Length; i++)
                    {
                        bool Even = int.TryParse(itemName.Substring(0, 2), out finish);
                        bool Odd = false;
                        if (!Even)
                        {
                            Odd = int.TryParse(itemName.Substring(0, 1), out finish);
                        }
                        if (Odd || Even)
                        {
                            if (finish.ToString() == MineCarrier[i].ToString())
                            {
                                (item as Button).Tag = Image.FromFile(PathAdjuster() + "images\\weapons.png");
                                if ((Application.OpenForms["frmBaslarken"].Controls["chboxSee"] as CheckBox).Checked)
                                {
                                    (item as Button).Text = MineCarrier[i].ToString();
                                }

                                break;
                            }
                        }
                    }
                    k++;
                }
            }
            skor = mayinPaneli.Controls.Count;
            ScoreReduction(true);

            //string toDisplay = string.Join(Environment.NewLine, MineCarrier);
            //MessageBox.Show(toDisplay);

        }
        public void ScoreReduction(bool? starting)
        {
            if (starting == null && skor > 0)
            {
                skor--;
            }
            if (starting == false && skor > 0)
            {
                skor++;
            }
            lblSkor.Text = skor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
