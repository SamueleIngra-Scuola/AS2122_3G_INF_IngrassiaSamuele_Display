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

            for (int j = 0; j <= 4; j++)
                for (int i = 0; i <= 2; i++)
                switch(txtLettera.Text.ToLower())
                {
                    case "a":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraA[j, i]);
                        break;
                    case "b":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraB[j, i]);
                        break;
                    case "c":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraC[j, i]);
                        break;
                    case "d":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraD[j, i]);
                        break;
                    case "e":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraE[j, i]);
                        break;
                    case "f":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraF[j, i]);
                        break;
                    case "g":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraG[j, i]);
                        break;
                    case "h":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraH[j, i]);
                        break;
                    case "i":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraI[j, i]);
                        break;
                    case "j":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraJ[j, i]);
                        break;
                    case "k":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraK[j, i]);
                        break;
                    case "l":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraL[j, i]);
                        break;
                    case "m":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraM[j, i]);
                        break;
                    case "n":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraN[j, i]);
                        break;
                    case "o":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraO[j, i]);
                        break;
                    case "p":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraP[j, i]);
                        break;
                    case "q":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraQ[j, i]);
                        break;
                    case "r":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraR[j, i]);
                        break;
                    case "s":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraS[j, i]);
                        break;
                    case "t":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraT[j, i]);
                        break;
                    case "u":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraU[j, i]);
                        break;
                    case "v":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraV[j, i]);
                        break;
                    case "w":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraW[j, i]);
                        break;
                    case "x":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraX[j, i]);
                        break;
                    case "y":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraY[j, i]);
                        break;
                    case "z":
                        IlluminaPixel(i.ToString() + j.ToString(), lettere.letteraZ[j, i]);
                        break;
                    default:
                        i = 10; //Portiamo i a 10 per terminare il ciclo
                        j = 10; //Portiamo j a 10 per terminare il ciclo
                        MessageBox.Show("Questa lettera non esiste!");
                        break;
                }
                
        }

        private void IlluminaPixel(string wxh, bool status)
        {
            switch (wxh)
            {
                case "00":
                    btn00.Visible = status;
                    break;
                case "10":
                    btn10.Visible = status;
                    break;
                case "20":
                    btn20.Visible = status;
                    break;
                case "01":
                    btn01.Visible = status;
                    break;
                case "11":
                    btn11.Visible = status;
                    break;
                case "21":
                    btn21.Visible = status;
                    break;
                case "02":
                    btn02.Visible = status;
                    break;
                case "12":
                    btn12.Visible = status;
                    break;
                case "22":
                    btn22.Visible = status;
                    break;
                case "03":
                    btn03.Visible = status;
                    break;
                case "13":
                    btn13.Visible = status;
                    break;
                case "23":
                    btn23.Visible = status;
                    break;
                case "04":
                    btn04.Visible = status;
                    break;
                case "14":
                    btn14.Visible = status;
                    break;
                case "24":
                    btn24.Visible = status;
                    break;
            }    
        }
    }
}
