namespace bar
{
    public partial class Form1 : Form
    {
        // Lists to store the graph values and labels
        List<float> values = new List<float>();
        List<string> labels = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous data to ensure fresh input processing
            values.Clear();
            labels.Clear();
            string inputval = txtValues.Text;
            string inputlab = txtlabels.Text;
            if (string.IsNullOrWhiteSpace(inputval))
            {
                MessageBox.Show("Enter Aleast The values to make graph", "Error");
            }
            else
            {

                // Split the input values and labels by commas
                string[] stringLab = inputlab.Split(',');
                string[] stringL = inputval.Split(",");
                float[] inpvalues = Array.ConvertAll(stringL, float.Parse);
                // If labels are empty, generate default labels (A, B, C, ...)
                if (string.IsNullOrWhiteSpace(inputlab))
                {
                    for (int i = 0; i < inpvalues.Length; i++)
                    {
                        char letter = (char)('A' + i);
                        string l = letter.ToString();
                        labels.Add(l);
                    }
                }
                else if (stringLab.Length > inpvalues.Length)
                    {
                        MessageBox.Show("Enter all the values for labels.");
                        return;
                    }
                else if (stringLab.Length < inpvalues.Length)
                {
                    MessageBox.Show("Enter all the labels for values.");
                    return;
                }
                else
                { // If labels match the number of values, add them to the labels list
                    foreach (string v in stringLab)
                    {
                        labels.Add(v.Trim());// Trim whitespace to clean up the input
                    }
                }
               
                foreach (int v in inpvalues)
                {
                    values.Add(v);
                }
            }

            bar1.set(values, labels);
        }

       
        
    }
}
