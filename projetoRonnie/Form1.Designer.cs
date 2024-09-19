namespace projetoRonnie
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
            lblAgenda = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtFone = new TextBox();
            lblFone = new Label();
            lblSexo = new Label();
            btnAdicionar = new Button();
            btnRestaurar = new Button();
            btnNovo = new Button();
            btnExcluir = new Button();
            brnIMportar = new Button();
            btnExportar = new Button();
            btnLimparContato = new Button();
            lblFooter = new Label();
            lblMinimizar = new Label();
            lblFechar = new Label();
            comboSexo = new ComboBox();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // lblAgenda
            // 
            lblAgenda.AutoEllipsis = true;
            lblAgenda.BackColor = Color.Cyan;
            lblAgenda.Dock = DockStyle.Top;
            lblAgenda.Font = new Font("Berlin Sans FB", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgenda.Location = new Point(0, 0);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(800, 82);
            lblAgenda.TabIndex = 0;
            lblAgenda.Text = "Agenda 2024";
            lblAgenda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(8, 91);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(60, 24);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(8, 118);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(392, 34);
            txtNome.TabIndex = 0;
            // 
            // txtFone
            // 
            txtFone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFone.Location = new Point(8, 193);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(392, 34);
            txtFone.TabIndex = 1;
            // 
            // lblFone
            // 
            lblFone.AutoSize = true;
            lblFone.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFone.Location = new Point(8, 166);
            lblFone.Name = "lblFone";
            lblFone.Size = new Size(52, 24);
            lblFone.TabIndex = 3;
            lblFone.Text = "Fone:";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSexo.Location = new Point(8, 251);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(52, 24);
            lblSexo.TabIndex = 5;
            lblSexo.Text = "Sexo:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(11, 340);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(152, 70);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(169, 340);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(152, 70);
            btnRestaurar.TabIndex = 4;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(11, 416);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(152, 70);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(169, 416);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(152, 70);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // brnIMportar
            // 
            brnIMportar.Location = new Point(327, 416);
            brnIMportar.Name = "brnIMportar";
            brnIMportar.Size = new Size(152, 70);
            brnIMportar.TabIndex = 7;
            brnIMportar.Text = "Importar";
            brnIMportar.UseVisualStyleBackColor = true;
            brnIMportar.Click += brnIMportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(485, 416);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(152, 70);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnLimparContato
            // 
            btnLimparContato.Location = new Point(643, 416);
            btnLimparContato.Name = "btnLimparContato";
            btnLimparContato.Size = new Size(152, 70);
            btnLimparContato.TabIndex = 9;
            btnLimparContato.Text = "Limpar Contato";
            btnLimparContato.UseVisualStyleBackColor = true;
            btnLimparContato.Click += btnLimparContato_Click;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = SystemColors.MenuHighlight;
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooter.Location = new Point(0, 523);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(800, 57);
            lblFooter.TabIndex = 15;
            lblFooter.Text = "Leonardo";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMinimizar
            // 
            lblMinimizar.AutoSize = true;
            lblMinimizar.BackColor = Color.Cyan;
            lblMinimizar.ForeColor = Color.Black;
            lblMinimizar.Location = new Point(12, 42);
            lblMinimizar.Name = "lblMinimizar";
            lblMinimizar.Size = new Size(75, 20);
            lblMinimizar.TabIndex = 16;
            lblMinimizar.Text = "Minimizar";
            lblMinimizar.Click += lblMinimizar_Click;
            // 
            // lblFechar
            // 
            lblFechar.AutoSize = true;
            lblFechar.BackColor = Color.Cyan;
            lblFechar.ForeColor = Color.Black;
            lblFechar.Location = new Point(118, 42);
            lblFechar.Name = "lblFechar";
            lblFechar.Size = new Size(52, 20);
            lblFechar.TabIndex = 17;
            lblFechar.Text = "Fechar";
            lblFechar.Click += lblFechar_Click;
            // 
            // comboSexo
            // 
            comboSexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboSexo.FormattingEnabled = true;
            comboSexo.Items.AddRange(new object[] { "", "Masculino", "Feminino" });
            comboSexo.Location = new Point(8, 278);
            comboSexo.Name = "comboSexo";
            comboSexo.Size = new Size(392, 36);
            comboSexo.TabIndex = 2;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(525, 118);
            listBox.Name = "listBox";
            listBox.Size = new Size(245, 224);
            listBox.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 580);
            Controls.Add(listBox);
            Controls.Add(comboSexo);
            Controls.Add(lblFechar);
            Controls.Add(lblMinimizar);
            Controls.Add(lblFooter);
            Controls.Add(btnLimparContato);
            Controls.Add(btnExportar);
            Controls.Add(brnIMportar);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(btnRestaurar);
            Controls.Add(btnAdicionar);
            Controls.Add(lblSexo);
            Controls.Add(txtFone);
            Controls.Add(lblFone);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblAgenda);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgenda;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtFone;
        private Label lblFone;
        private Label lblSexo;
        private Button btnAdicionar;
        private Button btnRestaurar;
        private Button btnNovo;
        private Button btnExcluir;
        private Button brnIMportar;
        private Button btnExportar;
        private Button btnLimparContato;
        private Label lblFooter;
        private Label lblMinimizar;
        private Label lblFechar;
        private ComboBox comboSexo;
        private ListBox listBox;
    }
}
