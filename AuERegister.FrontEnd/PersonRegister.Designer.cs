namespace AuERegister.FrontEnd
{
    partial class PersonRegister
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
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            clickMasculino = new RadioButton();
            clickFeminino = new RadioButton();
            txtCidade = new TextBox();
            label3 = new Label();
            buttonIncluir = new Button();
            buttonAltera = new Button();
            buttonExclui = new Button();
            button4 = new Button();
            ListPersons = new DataGridView();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)ListPersons).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(642, 43);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(698, 39);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(343, 27);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(642, 95);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Sexo:";
            // 
            // clickMasculino
            // 
            clickMasculino.AutoSize = true;
            clickMasculino.Location = new Point(698, 95);
            clickMasculino.Margin = new Padding(3, 4, 3, 4);
            clickMasculino.Name = "clickMasculino";
            clickMasculino.Size = new Size(97, 24);
            clickMasculino.TabIndex = 4;
            clickMasculino.TabStop = true;
            clickMasculino.Text = "Masculino";
            clickMasculino.UseVisualStyleBackColor = true;
            // 
            // clickFeminino
            // 
            clickFeminino.AutoSize = true;
            clickFeminino.Location = new Point(796, 95);
            clickFeminino.Margin = new Padding(3, 4, 3, 4);
            clickFeminino.Name = "clickFeminino";
            clickFeminino.Size = new Size(91, 24);
            clickFeminino.TabIndex = 6;
            clickFeminino.TabStop = true;
            clickFeminino.Text = "Feminino";
            clickFeminino.UseVisualStyleBackColor = true;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(698, 145);
            txtCidade.Margin = new Padding(3, 4, 3, 4);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(343, 27);
            txtCidade.TabIndex = 8;
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(642, 149);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 7;
            label3.Text = "Cidade:";
            // 
            // buttonIncluir
            // 
            buttonIncluir.Location = new Point(642, 223);
            buttonIncluir.Margin = new Padding(3, 4, 3, 4);
            buttonIncluir.Name = "buttonIncluir";
            buttonIncluir.Size = new Size(86, 31);
            buttonIncluir.TabIndex = 9;
            buttonIncluir.Text = "Inclui";
            buttonIncluir.UseVisualStyleBackColor = true;
            buttonIncluir.Click += button1_Click;
            // 
            // buttonAltera
            // 
            buttonAltera.Location = new Point(742, 223);
            buttonAltera.Margin = new Padding(3, 4, 3, 4);
            buttonAltera.Name = "buttonAltera";
            buttonAltera.Size = new Size(86, 31);
            buttonAltera.TabIndex = 10;
            buttonAltera.Text = "Altera";
            buttonAltera.UseVisualStyleBackColor = true;
            buttonAltera.Click += button2_Click;
            // 
            // buttonExclui
            // 
            buttonExclui.Location = new Point(835, 223);
            buttonExclui.Margin = new Padding(3, 4, 3, 4);
            buttonExclui.Name = "buttonExclui";
            buttonExclui.Size = new Size(86, 31);
            buttonExclui.TabIndex = 11;
            buttonExclui.Text = "Exclui";
            buttonExclui.UseVisualStyleBackColor = true;
            buttonExclui.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(14, 723);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(269, 31);
            button4.TabIndex = 13;
            button4.Text = "Contar no de contatos por cidade";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ListPersons
            // 
            ListPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListPersons.Location = new Point(14, 16);
            ListPersons.Margin = new Padding(3, 4, 3, 4);
            ListPersons.Name = "ListPersons";
            ListPersons.RowHeadersWidth = 51;
            ListPersons.RowTemplate.Height = 25;
            ListPersons.Size = new Size(622, 333);
            ListPersons.TabIndex = 14;
            ListPersons.CellContentClick += dataGridView1_CellContentClick;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 357);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(982, 356);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // PersonRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 769);
            Controls.Add(richTextBox1);
            Controls.Add(ListPersons);
            Controls.Add(button4);
            Controls.Add(buttonExclui);
            Controls.Add(buttonAltera);
            Controls.Add(buttonIncluir);
            Controls.Add(txtCidade);
            Controls.Add(label3);
            Controls.Add(clickFeminino);
            Controls.Add(clickMasculino);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PersonRegister";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ListPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private RadioButton clickMasculino;
        private RadioButton clickFeminino;
        private TextBox txtCidade;
        private Label label3;
        private Button buttonIncluir;
        private Button buttonAltera;
        private Button buttonExclui;
        private Button button4;
        private DataGridView ListPersons;
        private RichTextBox richTextBox1;
    }
}

