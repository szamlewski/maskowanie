namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InputText = inputBox.Text.ToString();

                if (InputText.Length <= 4)
                {
                    outputBox.Text = inputBox.Text;
                }
                else
                {
                    string mask = new string('#', InputText.Length - 4);
                    string ccMasked = mask + InputText.Substring(InputText.Length - 4);
                    outputBox.Text = ccMasked;
                }
            }
        }
    }