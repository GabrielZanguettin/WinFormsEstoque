namespace EstoqueWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button5 = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(659, 193);
            button2.Name = "button2";
            button2.Size = new Size(139, 23);
            button2.TabIndex = 1;
            button2.Text = "Remover do estoque";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(348, 363);
            button3.Name = "button3";
            button3.Size = new Size(139, 23);
            button3.TabIndex = 2;
            button3.Text = "Consultar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(659, 410);
            button4.Name = "button4";
            button4.Size = new Size(226, 23);
            button4.TabIndex = 3;
            button4.Text = "Consultar todos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(68, 143);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(139, 112);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(661, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(660, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(348, 328);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 76);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 16;
            label1.Text = "Nome do produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 125);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 18;
            label3.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(660, 136);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 21;
            label6.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(660, 76);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 22;
            label2.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 308);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 23;
            label4.Text = "Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 35);
            label5.Name = "label5";
            label5.Size = new Size(185, 25);
            label5.TabIndex = 24;
            label5.Text = "Criação de produto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(659, 35);
            label7.Name = "label7";
            label7.Size = new Size(196, 25);
            label7.TabIndex = 25;
            label7.Text = "Remover do estoque";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 76);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 26;
            label8.Text = "Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(351, 136);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 27;
            label9.Text = "Quantidade";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(351, 94);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 28;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(351, 154);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 23);
            textBox6.TabIndex = 29;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(351, 193);
            button5.Name = "button5";
            button5.Size = new Size(139, 23);
            button5.TabIndex = 30;
            button5.Text = "Adicionar ao estoque";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(351, 35);
            label10.Name = "label10";
            label10.Size = new Size(201, 25);
            label10.TabIndex = 31;
            label10.Text = "Adicionar ao estoque";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(659, 271);
            label11.Name = "label11";
            label11.Size = new Size(140, 25);
            label11.TabIndex = 32;
            label11.Text = "Consulta geral";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(348, 271);
            label12.Name = "label12";
            label12.Size = new Size(204, 25);
            label12.TabIndex = 33;
            label12.Text = "Consulte um produto";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(660, 310);
            label13.Name = "label13";
            label13.Size = new Size(43, 15);
            label13.TabIndex = 34;
            label13.Text = "Página";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(659, 354);
            label14.Name = "label14";
            label14.Size = new Size(173, 15);
            label14.TabIndex = 35;
            label14.Text = "Quantidade de itens por página";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(659, 328);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(226, 23);
            textBox7.TabIndex = 36;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(659, 372);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(226, 23);
            textBox8.TabIndex = 37;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 573);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button5);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
