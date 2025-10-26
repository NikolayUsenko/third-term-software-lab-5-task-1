namespace Software_Lab5_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ContextMenuStrip = contextMenuStrip1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            toolStripComboBox2.SelectedIndex = 0;
        }

        #region Основные функции

        private void colorChance(ToolStripComboBox ComboBox)
        {
            switch (ComboBox.Text)
            {
                case "белый": BackColor = Color.White; break;
                case "красный": BackColor = Color.Red; break;
                case "черный": BackColor = Color.Black; break;
                case "синий": BackColor = Color.Blue; break;
                case "желтый": BackColor = Color.Yellow; break;
                default: BackColor = SystemColors.Control; break;
            }
        }

        private void RGB(ToolStripTextBox TextBox1, ToolStripTextBox TextBox2, ToolStripTextBox TextBox3)
        {
            try
            {
                BackColor = Color.FromArgb(
                    Convert.ToInt32(TextBox1.Text),
                    Convert.ToInt32(TextBox2.Text),
                    Convert.ToInt32(TextBox3.Text));
            }
            catch
            {
                MessageBox.Show("Необходимо ввести целое число от 0 до 255", "Ошибка в задании цвета");
            }
        }

        #endregion

        #region Обработчики для MenuStrip

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorChance(toolStripComboBox1);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            RGB(toolStripTextBox1, toolStripTextBox2, toolStripTextBox3);
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            RGB(toolStripTextBox1, toolStripTextBox2, toolStripTextBox3);
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            RGB(toolStripTextBox1, toolStripTextBox2, toolStripTextBox3);
        }

        #endregion

        #region Обработчики закрытия формы

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Обрабочики для ContextMenuStrip

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorChance(toolStripComboBox2);
        }
        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            RGB(toolStripTextBox4, toolStripTextBox5, toolStripTextBox6);
        }

        private void toolStripTextBox5_TextChanged(object sender, EventArgs e)
        {
            RGB(toolStripTextBox4, toolStripTextBox5, toolStripTextBox6);
        }

        private void toolStripTextBox6_TextChanged(object sender, EventArgs e)
        {
            RGB(toolStripTextBox4, toolStripTextBox5, toolStripTextBox6);
        }

        #endregion

    }
}
