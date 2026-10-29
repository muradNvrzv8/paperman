namespace paperman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            count++;
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text file (*.txt)|*.txt";
            sv.FileName = "Document" + count;


            if (sv.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(sv.FileName, richTextBox1.Text);

                MessageBox.Show("Fayl uğurla yaradıldı və mətn yazıldı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnWriteFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text file *.txt | *.txt";
            op.ShowDialog();
            if (op.FileName == "")
            {
                MessageBox.Show("Fayl yol tapılmadı", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                File.AppendAllText(op.FileName, richTextBox1.Text);
                MessageBox.Show("metn yazildi");

            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All files *.* | *.*";
            op.ShowDialog();
            if (op.FileName == "")
            {
                MessageBox.Show("Fayl yol tapılmadı", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult d = MessageBox.Show("Fayl silinsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    File.Delete(op.FileName);
                    MessageBox.Show("Fayl silindi");
                }
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
        
        
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text file *.txt | *.txt";
            op.ShowDialog();

            if (op.FileName == "")
            {
                MessageBox.Show("Fayl yolu tapılmadı", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                richTextBox1.Text = File.ReadAllText(op.FileName);
            }
        
    }
    }
}
