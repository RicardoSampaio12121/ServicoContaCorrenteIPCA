
namespace ServicoContaCorrenteIPCA
{
    partial class FazerSolicitaçãoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodDoc = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbHE = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbArtigo = new System.Windows.Forms.RadioButton();
            this.lblArticleRB = new System.Windows.Forms.Label();
            this.txtRemainder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Docente";
            // 
            // txtCodDoc
            // 
            this.txtCodDoc.Location = new System.Drawing.Point(193, 11);
            this.txtCodDoc.Name = "txtCodDoc";
            this.txtCodDoc.Size = new System.Drawing.Size(100, 23);
            this.txtCodDoc.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(544, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 41);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Motivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(63, 50);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(475, 23);
            this.txtMotivo.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(63, 85);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(526, 220);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adicionar Verba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(544, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbHE
            // 
            this.rbHE.AutoSize = true;
            this.rbHE.Location = new System.Drawing.Point(482, 18);
            this.rbHE.Name = "rbHE";
            this.rbHE.Size = new System.Drawing.Size(14, 13);
            this.rbHE.TabIndex = 13;
            this.rbHE.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(385, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Horas-Extra";
            // 
            // rbArtigo
            // 
            this.rbArtigo.AutoSize = true;
            this.rbArtigo.Checked = true;
            this.rbArtigo.Location = new System.Drawing.Point(365, 18);
            this.rbArtigo.Name = "rbArtigo";
            this.rbArtigo.Size = new System.Drawing.Size(14, 13);
            this.rbArtigo.TabIndex = 11;
            this.rbArtigo.TabStop = true;
            this.rbArtigo.UseVisualStyleBackColor = true;
            // 
            // lblArticleRB
            // 
            this.lblArticleRB.AutoSize = true;
            this.lblArticleRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArticleRB.Location = new System.Drawing.Point(299, 12);
            this.lblArticleRB.Name = "lblArticleRB";
            this.lblArticleRB.Size = new System.Drawing.Size(60, 21);
            this.lblArticleRB.TabIndex = 10;
            this.lblArticleRB.Text = "Artigos";
            // 
            // txtRemainder
            // 
            this.txtRemainder.Location = new System.Drawing.Point(221, 85);
            this.txtRemainder.Name = "txtRemainder";
            this.txtRemainder.ReadOnly = true;
            this.txtRemainder.Size = new System.Drawing.Size(100, 23);
            this.txtRemainder.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor";
            // 
            // FazerSolicitaçãoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemainder);
            this.Controls.Add(this.rbHE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbArtigo);
            this.Controls.Add(this.lblArticleRB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCodDoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FazerSolicitaçãoForm";
            this.Text = "FazerSolicitaçãoForm";
            this.Load += new System.EventHandler(this.FazerSolicitaçãoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodDoc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbHE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbArtigo;
        private System.Windows.Forms.Label lblArticleRB;
        private System.Windows.Forms.TextBox txtRemainder;
        private System.Windows.Forms.Label label5;
    }
}