using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AS2122_3G_INF_Ingrassia_Display.Lib;

namespace AS2122_3G_INF_IngrassiaSamuele_Display
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            Lettere lettere = new Lettere();
            bool[,] letteraScelta = new bool[3, 5];

            switch (txtLettera.Text.ToLower())
            {
                case "a":
                    letteraScelta = lettere.letteraA;
                    break;
                case "b":
                    letteraScelta = lettere.letteraB;
                    break;
                case "c":
                    letteraScelta = lettere.letteraC;
                    break;
                case "d":
                    letteraScelta = lettere.letteraD;
                    break;
                case "e":
                    letteraScelta = lettere.letteraE;
                    break;
                case "f":
                    letteraScelta = lettere.letteraF;
                    break;
                case "g":
                    letteraScelta = lettere.letteraG;
                    break;
                case "h":
                    letteraScelta = lettere.letteraH;
                    break;
                case "i":
                    letteraScelta = lettere.letteraI;
                    break;
                case "j":
                    letteraScelta = lettere.letteraJ;
                    break;
                case "k":
                    letteraScelta = lettere.letteraK;
                    break;
                case "l":
                    letteraScelta = lettere.letteraL;
                    break;
                case "m":
                    letteraScelta = lettere.letteraM;
                    break;
                case "n":
                    letteraScelta = lettere.letteraN;
                    break;
                case "o":
                    letteraScelta = lettere.letteraO;
                    break;
                case "p":
                    letteraScelta = lettere.letteraP;
                    break;
                case "q":
                    letteraScelta = lettere.letteraQ;
                    break;
                case "r":
                    letteraScelta = lettere.letteraR;
                    break;
                case "s":
                    letteraScelta = lettere.letteraS;
                    break;
                case "t":
                    letteraScelta = lettere.letteraT;
                    break;
                case "u":
                    letteraScelta = lettere.letteraU;
                    break;
                case "v":
                    letteraScelta = lettere.letteraV;
                    break;
                case "w":
                    letteraScelta = lettere.letteraW;
                    break;
                case "x":
                    letteraScelta = lettere.letteraX;
                    break;
                case "y":
                    letteraScelta = lettere.letteraY;
                    break;
                case "z":
                    letteraScelta = lettere.letteraZ;
                    break;
                case " ":
                    letteraScelta = lettere.vuoto;
                    break;
                case "!":
                    letteraScelta = lettere.esclamazione;
                    break;
                default:
                    letteraScelta = lettere.vuoto;
                    MessageBox.Show("Questa lettera non esiste!");
                    break;
            }

            if (letteraScelta != null)
                for (int j = 0; j <= 4; j++)
                    for (int i = 0; i <= 2; i++)
                        IlluminaPixel(i.ToString() + j.ToString(), letteraScelta[j, i]);


        }

        private void IlluminaPixel(string wxh, bool status)
        {
            switch (wxh)
            {
                case "00":
                    btn100.Visible = status;
                    break;
                case "10":
                    btn110.Visible = status;
                    break;
                case "20":
                    btn120.Visible = status;
                    break;
                case "01":
                    btn101.Visible = status;
                    break;
                case "11":
                    btn111.Visible = status;
                    break;
                case "21":
                    btn121.Visible = status;
                    break;
                case "02":
                    btn102.Visible = status;
                    break;
                case "12":
                    btn112.Visible = status;
                    break;
                case "22":
                    btn122.Visible = status;
                    break;
                case "03":
                    btn103.Visible = status;
                    break;
                case "13":
                    btn113.Visible = status;
                    break;
                case "23":
                    btn123.Visible = status;
                    break;
                case "04":
                    btn104.Visible = status;
                    break;
                case "14":
                    btn114.Visible = status;
                    break;
                case "24":
                    btn124.Visible = status;
                    break;
            }    
        }
    }
}
