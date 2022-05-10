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
            
            
            string frase = txtLettera.Text.ToLower();
            



            for (int i = 0; i < frase.Length - 3; i++)
            {
                int schermo = 1;
                for (int j = i; schermo <= 4; j++, schermo++)
                {
                    InserisciLettera(schermo, frase[j]);           
                }
                Application.DoEvents();
                System.Threading.Thread.Sleep(300);
            }

        }
        

        private void InserisciLettera(int schermo, char lettera)
        {
            for (int j = 0; j <= 4; j++)
                for (int i = 0; i <= 2; i++)
                    IlluminaPixel(schermo, i.ToString() + j.ToString(), IndividuaLettera(lettera)[j, i]);
        }

        private bool[,] IndividuaLettera(char lettera)
        {
            Lettere lettere = new Lettere();

            switch (lettera)
            {
                case 'a':
                    return lettere.letteraA;
                case 'b':
                    return lettere.letteraB;
                case 'c':
                    return lettere.letteraC;
                case 'd':
                    return lettere.letteraD;                    
                case 'e':
                    return lettere.letteraE;                    
                case 'f':
                    return lettere.letteraF;                   
                case 'g':
                    return lettere.letteraG;                   
                case 'h':
                    return lettere.letteraH;                    
                case 'i':
                    return lettere.letteraI;                   
                case 'j':
                    return lettere.letteraJ;                   
                case 'k':
                    return lettere.letteraK;                   
                case 'l':
                    return lettere.letteraL;                    
                case 'm':
                    return lettere.letteraM;                    
                case 'n':
                    return lettere.letteraN;                    
                case 'o':
                    return lettere.letteraO;                    
                case 'p':
                    return lettere.letteraP;                    
                case 'q':
                    return lettere.letteraQ;                    
                case 'r':
                    return lettere.letteraR;                    
                case 's':
                    return lettere.letteraS;                   
                case 't':
                    return lettere.letteraT;                    
                case 'u':
                    return lettere.letteraU;                    
                case 'v':
                    return lettere.letteraV;                    
                case 'w':
                    return lettere.letteraW;                    
                case 'x':
                    return lettere.letteraX;                    
                case 'y':
                    return lettere.letteraY;                    
                case 'z':
                    return lettere.letteraZ;                    
                case ' ':
                    return lettere.vuoto;                    
                case '!':
                    return lettere.esclamazione;
                default:
                    return lettere.vuoto;   
            }
        }

        private void IlluminaPixel(int schermo, string wxh, bool status)
        {
            switch (schermo)
            {
                case 1:
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
                    break;
                case 2:
                    switch (wxh)
                    {
                        case "00":
                            btn200.Visible = status;
                            break;
                        case "10":
                            btn210.Visible = status;
                            break;
                        case "20":
                            btn220.Visible = status;
                            break;
                        case "01":
                            btn201.Visible = status;
                            break;
                        case "11":
                            btn211.Visible = status;
                            break;
                        case "21":
                            btn221.Visible = status;
                            break;
                        case "02":
                            btn202.Visible = status;
                            break;
                        case "12":
                            btn212.Visible = status;
                            break;
                        case "22":
                            btn222.Visible = status;
                            break;
                        case "03":
                            btn203.Visible = status;
                            break;
                        case "13":
                            btn213.Visible = status;
                            break;
                        case "23":
                            btn223.Visible = status;
                            break;
                        case "04":
                            btn204.Visible = status;
                            break;
                        case "14":
                            btn214.Visible = status;
                            break;
                        case "24":
                            btn224.Visible = status;
                            break;
                    }
                    break;
                case 3:
                    switch (wxh)
                    {
                        case "00":
                            btn300.Visible = status;
                            break;
                        case "10":
                            btn310.Visible = status;
                            break;
                        case "20":
                            btn320.Visible = status;
                            break;
                        case "01":
                            btn301.Visible = status;
                            break;
                        case "11":
                            btn311.Visible = status;
                            break;
                        case "21":
                            btn321.Visible = status;
                            break;
                        case "02":
                            btn302.Visible = status;
                            break;
                        case "12":
                            btn312.Visible = status;
                            break;
                        case "22":
                            btn322.Visible = status;
                            break;
                        case "03":
                            btn303.Visible = status;
                            break;
                        case "13":
                            btn313.Visible = status;
                            break;
                        case "23":
                            btn323.Visible = status;
                            break;
                        case "04":
                            btn304.Visible = status;
                            break;
                        case "14":
                            btn314.Visible = status;
                            break;
                        case "24":
                            btn324.Visible = status;
                            break;
                    }
                    break;
                case 4:
                    switch (wxh)
                    {
                        case "00":
                            btn400.Visible = status;
                            break;
                        case "10":
                            btn410.Visible = status;
                            break;
                        case "20":
                            btn420.Visible = status;
                            break;
                        case "01":
                            btn401.Visible = status;
                            break;
                        case "11":
                            btn411.Visible = status;
                            break;
                        case "21":
                            btn421.Visible = status;
                            break;
                        case "02":
                            btn402.Visible = status;
                            break;
                        case "12":
                            btn412.Visible = status;
                            break;
                        case "22":
                            btn422.Visible = status;
                            break;
                        case "03":
                            btn403.Visible = status;
                            break;
                        case "13":
                            btn413.Visible = status;
                            break;
                        case "23":
                            btn423.Visible = status;
                            break;
                        case "04":
                            btn404.Visible = status;
                            break;
                        case "14":
                            btn414.Visible = status;
                            break;
                        case "24":
                            btn424.Visible = status;
                            break;
                    }
                    break;
            }
        }
    }
}
