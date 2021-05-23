namespace ServicoContaCorrenteIPCA
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnMakeSolicitation = new System.Windows.Forms.Button();
            this.btnMakeRequest = new System.Windows.Forms.Button();
            this.btnPendingSolicitation = new System.Windows.Forms.Button();
            this.btnPendingRequests = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblCurrentForm = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.btnMakeSolicitation);
            this.panelSide.Controls.Add(this.btnMakeRequest);
            this.panelSide.Controls.Add(this.btnPendingSolicitation);
            this.panelSide.Controls.Add(this.btnPendingRequests);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(214, 519);
            this.panelSide.TabIndex = 0;
            // 
            // btnMakeSolicitation
            // 
            this.btnMakeSolicitation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMakeSolicitation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeSolicitation.Location = new System.Drawing.Point(0, 323);
            this.btnMakeSolicitation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMakeSolicitation.Name = "btnMakeSolicitation";
            this.btnMakeSolicitation.Size = new System.Drawing.Size(214, 63);
            this.btnMakeSolicitation.TabIndex = 4;
            this.btnMakeSolicitation.Text = "Fazer solicitação";
            this.btnMakeSolicitation.UseVisualStyleBackColor = true;
            this.btnMakeSolicitation.Click += new System.EventHandler(this.btnMakeSolicitation_Click);
            // 
            // btnMakeRequest
            // 
            this.btnMakeRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMakeRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeRequest.Location = new System.Drawing.Point(0, 260);
            this.btnMakeRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMakeRequest.Name = "btnMakeRequest";
            this.btnMakeRequest.Size = new System.Drawing.Size(214, 63);
            this.btnMakeRequest.TabIndex = 3;
            this.btnMakeRequest.Text = "Fazer pedido";
            this.btnMakeRequest.UseVisualStyleBackColor = true;
            this.btnMakeRequest.Click += new System.EventHandler(this.btnMakeRequest_Click);
            // 
            // btnPendingSolicitation
            // 
            this.btnPendingSolicitation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPendingSolicitation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendingSolicitation.Location = new System.Drawing.Point(0, 197);
            this.btnPendingSolicitation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPendingSolicitation.Name = "btnPendingSolicitation";
            this.btnPendingSolicitation.Size = new System.Drawing.Size(214, 63);
            this.btnPendingSolicitation.TabIndex = 2;
            this.btnPendingSolicitation.Text = "Solicitações pendentes";
            this.btnPendingSolicitation.UseVisualStyleBackColor = true;
            this.btnPendingSolicitation.Click += new System.EventHandler(this.btnPendingSolicitation_Click);
            // 
            // btnPendingRequests
            // 
            this.btnPendingRequests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPendingRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendingRequests.Location = new System.Drawing.Point(0, 134);
            this.btnPendingRequests.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPendingRequests.Name = "btnPendingRequests";
            this.btnPendingRequests.Size = new System.Drawing.Size(214, 63);
            this.btnPendingRequests.TabIndex = 1;
            this.btnPendingRequests.Text = "Pedidos pendentes";
            this.btnPendingRequests.UseVisualStyleBackColor = true;
            this.btnPendingRequests.Click += new System.EventHandler(this.btnPendingRequests_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(214, 134);
            this.panelLogo.TabIndex = 0;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLogo.Image")));
            this.pBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(214, 134);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLogo.TabIndex = 0;
            this.pBoxLogo.TabStop = false;
            this.pBoxLogo.Click += new System.EventHandler(this.pBoxLogo_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblCurrentForm);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(214, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(719, 134);
            this.panelTop.TabIndex = 1;
            // 
            // lblCurrentForm
            // 
            this.lblCurrentForm.AutoSize = true;
            this.lblCurrentForm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentForm.Location = new System.Drawing.Point(7, 47);
            this.lblCurrentForm.Name = "lblCurrentForm";
            this.lblCurrentForm.Size = new System.Drawing.Size(353, 37);
            this.lblCurrentForm.TabIndex = 0;
            this.lblCurrentForm.Text = "Serviço de Conta Currente";
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(214, 134);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(719, 385);
            this.panelForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSide);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSide.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;

        private System.Windows.Forms.Button btnMakeRequest;

        private System.Windows.Forms.Button btnPendingSolicitation;

        private System.Windows.Forms.Button btnMakeSolicitation;

        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button btnPendingRequests;

        private System.Windows.Forms.PictureBox pBoxLogo;

        private System.Windows.Forms.Panel panelLogo;

        private System.Windows.Forms.Panel panelSide;

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblCurrentForm;
    }
}