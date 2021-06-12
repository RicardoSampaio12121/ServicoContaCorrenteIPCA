
namespace ServicoContaCorrenteIPCA
{
    partial class PendingSolicitations
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
            this.btnRejeitar = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbHE = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbArtigo = new System.Windows.Forms.RadioButton();
            this.lblArticleRB = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCodDocente = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblCodError = new System.Windows.Forms.Label();
            this.lblLinesError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRejeitar
            // 
            this.btnRejeitar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRejeitar.Location = new System.Drawing.Point(553, 209);
            this.btnRejeitar.Name = "btnRejeitar";
            this.btnRejeitar.Size = new System.Drawing.Size(154, 54);
            this.btnRejeitar.TabIndex = 19;
            this.btnRejeitar.Text = "Rejeitar";
            this.btnRejeitar.UseVisualStyleBackColor = true;
            this.btnRejeitar.Click += new System.EventHandler(this.btnRejeitar_Click);
            // 
            // btnAceitar
            // 
            this.btnAceitar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceitar.Location = new System.Drawing.Point(553, 149);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(154, 54);
            this.btnAceitar.TabIndex = 18;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(589, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 28);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(535, 280);
            this.dataGridView1.TabIndex = 16;
            // 
            // rbHE
            // 
            this.rbHE.AutoSize = true;
            this.rbHE.Location = new System.Drawing.Point(533, 40);
            this.rbHE.Name = "rbHE";
            this.rbHE.Size = new System.Drawing.Size(14, 13);
            this.rbHE.TabIndex = 15;
            this.rbHE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pedidos de Horas-Extra";
            // 
            // rbArtigo
            // 
            this.rbArtigo.AutoSize = true;
            this.rbArtigo.Checked = true;
            this.rbArtigo.Location = new System.Drawing.Point(321, 40);
            this.rbArtigo.Name = "rbArtigo";
            this.rbArtigo.Size = new System.Drawing.Size(14, 13);
            this.rbArtigo.TabIndex = 13;
            this.rbArtigo.TabStop = true;
            this.rbArtigo.UseVisualStyleBackColor = true;
            // 
            // lblArticleRB
            // 
            this.lblArticleRB.AutoSize = true;
            this.lblArticleRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArticleRB.Location = new System.Drawing.Point(176, 34);
            this.lblArticleRB.Name = "lblArticleRB";
            this.lblArticleRB.Size = new System.Drawing.Size(139, 21);
            this.lblArticleRB.TabIndex = 12;
            this.lblArticleRB.Text = "Pedidos de Artigos";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(12, 33);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(109, 23);
            this.txtCod.TabIndex = 11;
            // 
            // lblCodDocente
            // 
            this.lblCodDocente.AutoSize = true;
            this.lblCodDocente.Location = new System.Drawing.Point(12, 15);
            this.lblCodDocente.Name = "lblCodDocente";
            this.lblCodDocente.Size = new System.Drawing.Size(109, 15);
            this.lblCodDocente.TabIndex = 10;
            this.lblCodDocente.Text = "Código do docente";
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.Location = new System.Drawing.Point(553, 89);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(154, 54);
            this.btnInfo.TabIndex = 20;
            this.btnInfo.Text = "Informação";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblCodError
            // 
            this.lblCodError.AutoSize = true;
            this.lblCodError.Location = new System.Drawing.Point(12, 59);
            this.lblCodError.Name = "lblCodError";
            this.lblCodError.Size = new System.Drawing.Size(0, 15);
            this.lblCodError.TabIndex = 21;
            // 
            // lblLinesError
            // 
            this.lblLinesError.AutoSize = true;
            this.lblLinesError.Location = new System.Drawing.Point(12, 71);
            this.lblLinesError.Name = "lblLinesError";
            this.lblLinesError.Size = new System.Drawing.Size(0, 15);
            this.lblLinesError.TabIndex = 22;
            // 
            // PendingSolicitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 385);
            this.Controls.Add(this.lblLinesError);
            this.Controls.Add(this.lblCodError);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnRejeitar);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbHE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbArtigo);
            this.Controls.Add(this.lblArticleRB);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCodDocente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PendingSolicitations";
            this.Text = "PendingSolicitations";
            this.Load += new System.EventHandler(this.PendingSolicitations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRejeitar;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbHE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbArtigo;
        private System.Windows.Forms.Label lblArticleRB;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCodDocente;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblCodError;
        private System.Windows.Forms.Label lblLinesError;
    }
}