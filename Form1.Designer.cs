namespace ProjetoIntegradorDijkstra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAlert1 = new System.Windows.Forms.Label();
            this.cbxCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLimparCidades = new System.Windows.Forms.Button();
            this.btnLimparCaminhos = new System.Windows.Forms.Button();
            this.ddlDestino = new System.Windows.Forms.ComboBox();
            this.btnAddDistancia = new System.Windows.Forms.Button();
            this.vlrDistancia = new System.Windows.Forms.NumericUpDown();
            this.txtLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlrDistancia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(64, 84);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PlaceholderText = "Cidade";
            this.txtCidade.Size = new System.Drawing.Size(164, 45);
            this.txtCidade.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(542, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 336);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblAlert1
            // 
            this.lblAlert1.AutoSize = true;
            this.lblAlert1.Location = new System.Drawing.Point(64, 180);
            this.lblAlert1.Name = "lblAlert1";
            this.lblAlert1.Size = new System.Drawing.Size(50, 20);
            this.lblAlert1.TabIndex = 3;
            this.lblAlert1.Text = "label1";
            this.lblAlert1.Visible = false;
            // 
            // cbxCidadeOrigem
            // 
            this.cbxCidadeOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidadeOrigem.FormattingEnabled = true;
            this.cbxCidadeOrigem.Location = new System.Drawing.Point(571, 101);
            this.cbxCidadeOrigem.Name = "cbxCidadeOrigem";
            this.cbxCidadeOrigem.Size = new System.Drawing.Size(151, 28);
            this.cbxCidadeOrigem.TabIndex = 4;
            this.cbxCidadeOrigem.SelectedIndexChanged += new System.EventHandler(this.cbxCidadeOrigem_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(326, 318);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 50);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(326, 283);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(152, 29);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnLimparCidades
            // 
            this.btnLimparCidades.Location = new System.Drawing.Point(496, 409);
            this.btnLimparCidades.Name = "btnLimparCidades";
            this.btnLimparCidades.Size = new System.Drawing.Size(144, 29);
            this.btnLimparCidades.TabIndex = 6;
            this.btnLimparCidades.Text = "Limpar Cidades";
            this.btnLimparCidades.UseVisualStyleBackColor = true;
            this.btnLimparCidades.Click += new System.EventHandler(this.btnLimparCidades_Click);
            // 
            // btnLimparCaminhos
            // 
            this.btnLimparCaminhos.Location = new System.Drawing.Point(646, 409);
            this.btnLimparCaminhos.Name = "btnLimparCaminhos";
            this.btnLimparCaminhos.Size = new System.Drawing.Size(142, 29);
            this.btnLimparCaminhos.TabIndex = 7;
            this.btnLimparCaminhos.Text = "Limpar Caminhos";
            this.btnLimparCaminhos.UseVisualStyleBackColor = true;
            this.btnLimparCaminhos.Click += new System.EventHandler(this.btnLimparCaminhos_Click);
            // 
            // ddlDestino
            // 
            this.ddlDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDestino.FormattingEnabled = true;
            this.ddlDestino.Location = new System.Drawing.Point(571, 160);
            this.ddlDestino.Name = "ddlDestino";
            this.ddlDestino.Size = new System.Drawing.Size(151, 28);
            this.ddlDestino.TabIndex = 8;
            // 
            // btnAddDistancia
            // 
            this.btnAddDistancia.Location = new System.Drawing.Point(588, 255);
            this.btnAddDistancia.Name = "btnAddDistancia";
            this.btnAddDistancia.Size = new System.Drawing.Size(120, 29);
            this.btnAddDistancia.TabIndex = 9;
            this.btnAddDistancia.Text = "Add Distancia";
            this.btnAddDistancia.UseVisualStyleBackColor = true;
            this.btnAddDistancia.Click += new System.EventHandler(this.btnAddDistancia_Click);
            // 
            // vlrDistancia
            // 
            this.vlrDistancia.Location = new System.Drawing.Point(614, 208);
            this.vlrDistancia.Name = "vlrDistancia";
            this.vlrDistancia.Size = new System.Drawing.Size(72, 27);
            this.vlrDistancia.TabIndex = 10;
            // 
            // txtLog
            // 
            this.txtLog.Enabled = false;
            this.txtLog.Location = new System.Drawing.Point(284, 73);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(231, 162);
            this.txtLog.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(15)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.vlrDistancia);
            this.Controls.Add(this.btnAddDistancia);
            this.Controls.Add(this.ddlDestino);
            this.Controls.Add(this.btnLimparCaminhos);
            this.Controls.Add(this.btnLimparCidades);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbxCidadeOrigem);
            this.Controls.Add(this.lblAlert1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Encurtador3000";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlrDistancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAlert1;
        private System.Windows.Forms.ComboBox cbxCidadeOrigem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLimparCidades;
        private System.Windows.Forms.Button btnLimparCaminhos;
        private System.Windows.Forms.ComboBox ddlDestino;
        private System.Windows.Forms.Button btnAddDistancia;
        private System.Windows.Forms.NumericUpDown vlrDistancia;
        private System.Windows.Forms.TextBox txtLog;
    }
}

