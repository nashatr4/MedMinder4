using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;

namespace MedMinder4
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panel2.Controls.Add(leftBorderBtn);
        }
        
        private struct RGBColors
        {
            public static Color color1 = Color.Aqua;
            public static Color color2 = Color.Violet;
            public static Color color3 = color.fromArgb(253, 138, 114);
            public static Color color4 = color.fromArgb(95, 77, 221);
            public static Color color5 = color.fromArgb(249, 88, 155);
            public static Color color6 = color.fromArgb(24, 262, 251);
        }
        
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null) 
            {
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn; 
                currentBtn.BackColor = Color.AliceBlue;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.LightSteelBlue;
                currentBtn.ForeColor = Color.MidnightBlue;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.MidnightBlue;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
<<<<<<< HEAD
        private void Form1_Load(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 8b2c1476af1f45afec01f6e5167fbac04d1c2b2c

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 plis = new Form2();
            plis.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form2 bisa = new Form2();
            bisa.Show();
            this.Hide();
            
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        
    }
}
