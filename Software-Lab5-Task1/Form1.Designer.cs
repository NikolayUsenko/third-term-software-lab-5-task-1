namespace Software_Lab5_Task1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            colorToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripTextBox3 = new ToolStripTextBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            colorToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripComboBox2 = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripTextBox4 = new ToolStripTextBox();
            toolStripTextBox5 = new ToolStripTextBox();
            toolStripTextBox6 = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { colorToolStripMenuItem, toolStripTextBox1, toolStripTextBox2, toolStripTextBox3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 0;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1, toolStripSeparator1, toolStripMenuItem1 });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(59, 27);
            colorToolStripMenuItem.Text = "&Color";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.Items.AddRange(new object[] { "белый", "красный", "черный", "синий", "желтый" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            toolStripComboBox1.ToolTipText = "Готовые цвета";
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(192, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(195, 26);
            toolStripMenuItem1.Text = "E&xit";
            toolStripMenuItem1.Click += closeToolStripMenuItem1_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            toolStripTextBox1.Text = "0";
            toolStripTextBox1.ToolTipText = "Красный";
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 27);
            toolStripTextBox2.Text = "0";
            toolStripTextBox2.ToolTipText = "Зеленый";
            toolStripTextBox2.TextChanged += toolStripTextBox2_TextChanged;
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(100, 27);
            toolStripTextBox3.Text = "0";
            toolStripTextBox3.ToolTipText = "Синий";
            toolStripTextBox3.TextChanged += toolStripTextBox3_TextChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(666, 358);
            button1.Name = "button1";
            button1.Size = new Size(105, 53);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { colorToolStripMenuItem1, toolStripTextBox4, toolStripTextBox5, toolStripTextBox6 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 115);
            // 
            // colorToolStripMenuItem1
            // 
            colorToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox2, toolStripSeparator2, toolStripMenuItem2 });
            colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            colorToolStripMenuItem1.Size = new Size(160, 24);
            colorToolStripMenuItem1.Text = "&Color";
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox2.Items.AddRange(new object[] { "белый", "красный", "черный", "синий", "желтый" });
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 28);
            toolStripComboBox2.ToolTipText = "Готовые цвета";
            toolStripComboBox2.SelectedIndexChanged += toolStripComboBox2_SelectedIndexChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(192, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(195, 26);
            toolStripMenuItem2.Text = "E&xit";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripTextBox4
            // 
            toolStripTextBox4.Name = "toolStripTextBox4";
            toolStripTextBox4.Size = new Size(100, 27);
            toolStripTextBox4.Text = "0";
            toolStripTextBox4.ToolTipText = "Красный";
            toolStripTextBox4.TextChanged += toolStripTextBox4_TextChanged;
            // 
            // toolStripTextBox5
            // 
            toolStripTextBox5.Name = "toolStripTextBox5";
            toolStripTextBox5.Size = new Size(100, 27);
            toolStripTextBox5.Text = "0";
            toolStripTextBox5.ToolTipText = "Зеленый";
            toolStripTextBox5.TextChanged += toolStripTextBox5_TextChanged;
            // 
            // toolStripTextBox6
            // 
            toolStripTextBox6.Name = "toolStripTextBox6";
            toolStripTextBox6.Size = new Size(100, 27);
            toolStripTextBox6.Text = "0";
            toolStripTextBox6.ToolTipText = "Синий";
            toolStripTextBox6.TextChanged += toolStripTextBox6_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Location = new Point(0, 50);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem colorToolStripMenuItem1;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripTextBox toolStripTextBox4;
        private ToolStripTextBox toolStripTextBox5;
        private ToolStripTextBox toolStripTextBox6;
    }
}
