namespace GissaTal1
{
    public partial class Form1 : Form
    {

        int datornstal;
        int antalgissningar;
        public Form1()
        {
            InitializeComponent();
            lblStörsta.Items.Add(10);
            lbxStörsta.Items.Add(20);
            lbxStörsta.SelectedItem = lbxStörsta.Items[0];
        }

        private void lblSpelData_Click(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            string störstaTal = lbxStörsta.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornstal = slump.Next(1, störst + 1);
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
                lblResultat.Text = "Du gissa rätt efter " + antalgissningar + " försök";
                gbxSpelet.Enabled = false;
                btnSpelaIgen.Enabled = true;

                lblDatornstal.Text = datornstal.ToString();
                tbxMinaResultat.AppendText(antalgissningar + " försök\n");
            }

            else if (gissatal < datornstal)
            {
                lblResultat.Text = "Fel försök med ett större tal";

            }

            else
            {
                lblResultat.Text = "Fel försökt med ett mindre tal";
            }
        }


    }
}