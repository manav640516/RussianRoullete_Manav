using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullete_Manav
{
    public partial class Form1 : Form
    {
        AllFunctionClass functionClass = new AllFunctionClass();

        public Form1()
        {
            InitializeComponent();
            functionClass.bulletManav = 0;
        }

        private void LoadBulletBtn_Click(object sender, EventArgs e)
        {
            functionClass.Load();
            SoundPlayer player = new SoundPlayer(Resource1.GunLoad);// playing sound when gun will be loaded
            player.Play();

            functionClass.bulletManav = 0;
            pictureLoadGun.Image = Resource1.loadgun;
            LoadBulletBtn.Enabled = false;

            SpinChamberBtn.Enabled = true;
        }

        private void SpinChamberBtn_Click(object sender, EventArgs e)
        {
            functionClass.Spin();
            pictureLoadGun.Image = Resource1.spin;
            SpinChamberBtn.Enabled = false;
            ShootheadBtn.Enabled = true;
            ShootawayBtn.Enabled = true;
        }

        private void ShootheadBtn_Click(object sender, EventArgs e)
        {
            functionClass.ShootAtHead();
            pictureLoadGun.Image = Resource1.loadgun;
            txtGamePoints.Text = functionClass.pointManav + "";
            SoundPlayer player = new SoundPlayer(Resource1.Shoot);
            player.Play();
            if (functionClass.dieManav == true)
            {

                ShootheadBtn.Enabled = false;
                ShootawayBtn.Enabled = false;

                ExitBtn.Enabled = true;
            }
            else
            {
                ShootheadBtn.Enabled = true;
                ShootawayBtn.Enabled = true;
                ExitBtn.Enabled = true;
            }
        }

        private void ShootawayBtn_Click(object sender, EventArgs e)
        {
            functionClass.ShootAway();
            txtGamePoints.Text = functionClass.pointManav + "";
            pictureLoadGun.Image = Resource1.loadgun;
            SoundPlayer player = new SoundPlayer(Resource1.Shoot);
            player.Play();
            if (functionClass.dieManav == true)
            {

                ShootheadBtn.Enabled = false;
                ShootawayBtn.Enabled = false;

                ExitBtn.Enabled = true;


            }
            else
            {
                ShootheadBtn.Enabled = true;
                ShootawayBtn.Enabled = true;

                ExitBtn.Enabled = true;

            }
        }

        private void PlayAgainbtn_Click(object sender, EventArgs e)
        {
            
            (new Form1()).Show();
            this.Hide();
            ExitBtn.Enabled = true;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit the game", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // disable spin, playagain, textbox, shoot button and enable load button only at MainForm Load
            LoadBulletBtn.Enabled = true;
            SpinChamberBtn.Enabled = false;
            ExitBtn.Enabled = true;
            txtGamePoints.Enabled = false;
            ShootheadBtn.Enabled = false;
            ShootawayBtn.Enabled = false;
        }
    }
}
