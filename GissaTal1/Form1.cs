namespace GissaTal1
{
    public partial class Form1 : Form
    {

        int datornstal;
        int antalgissningar;
        public Form1()
        {
            InitializeComponent();
            lblSt�rsta.Items.Add(10);
            lbxSt�rsta.Items.Add(20);
            lbxSt�rsta.SelectedItem = lbxSt�rsta.Items[0];
        }

        private void lblSpelData_Click(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            string st�rstaTal = lbxSt�rsta.SelectedItem.ToString();
            int st�rst = int.Parse(st�rstaTal);
            Random slump = new Random();
            datornstal = slump.Next(1, st�rst + 1);
            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;
            lblDatornstal.Text = "....";
            antalgissningar = 0;

        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            antalgissningar++;
            string Gissa = tbxGissa.Text;
            int gissatal = int.Parse(Gissa);

            if (gissatal == datornstal)
            {
                lblResultat.Text = "Du gissa r�tt efter " + antalgissningar + " f�rs�k";
                gbxSpelet.Enabled = false;
                btnSpelaIgen.Enabled = true;

                lblDatornstal.Text = datornstal.ToString();
                tbxMinaResultat.AppendText(antalgissningar + " f�rs�k\n");
            }

            else if (gissatal < datornstal)
            {
                lblResultat.Text = "Fel f�rs�k med ett st�rre tal";

            }

            else
            {
                lblResultat.Text = "Fel f�rs�kt med ett mindre tal";
            }
        }


    }
}