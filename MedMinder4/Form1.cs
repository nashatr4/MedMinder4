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
            public static Color color1 = color.fromArgb(172, 126, 241);
            public static Color color2 = color.fromArgb(249, 118, 176);
            public static Color color3 = color.fromArgb(253, 138, 114);
            public static Color color4 = color.fromArgb(95, 77, 221);
            public static Color color5 = color.fromArgb(249, 88, 155);
            public static Color color6 = color.fromArgb(24, 262, 251);
        }
        
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null) 
            {
                DisableButton()

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();
            g.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AcceptButton(sender, RGBColors.color2)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AcceptButton(sender, RGBColors.color1)
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            AcceptButton(sender, RGBColors.color3)
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            AcceptButton(sender, RGBColors.color4)
        }
    }
}
