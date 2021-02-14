
namespace WebCam
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.cbxCamera = new System.Windows.Forms.ComboBox();
            this.cbxWide = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbxMove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMove)).BeginInit();
            this.SuspendLayout();
            // 
            // picWebCam
            // 
            this.picWebCam.Location = new System.Drawing.Point(-1, 0);
            this.picWebCam.Margin = new System.Windows.Forms.Padding(0);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(1, 1);
            this.picWebCam.TabIndex = 0;
            this.picWebCam.TabStop = false;
            // 
            // cbxCamera
            // 
            this.cbxCamera.FormattingEnabled = true;
            this.cbxCamera.Location = new System.Drawing.Point(12, 12);
            this.cbxCamera.Name = "cbxCamera";
            this.cbxCamera.Size = new System.Drawing.Size(196, 21);
            this.cbxCamera.TabIndex = 1;
            // 
            // cbxWide
            // 
            this.cbxWide.AutoSize = true;
            this.cbxWide.Location = new System.Drawing.Point(227, 15);
            this.cbxWide.Name = "cbxWide";
            this.cbxWide.Size = new System.Drawing.Size(47, 17);
            this.cbxWide.TabIndex = 2;
            this.cbxWide.Text = "16:9";
            this.cbxWide.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ativar Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxMove
            // 
            this.pbxMove.BackColor = System.Drawing.Color.Transparent;
            this.pbxMove.Image = ((System.Drawing.Image)(resources.GetObject("pbxMove.Image")));
            this.pbxMove.Location = new System.Drawing.Point(0, 0);
            this.pbxMove.Margin = new System.Windows.Forms.Padding(0);
            this.pbxMove.Name = "pbxMove";
            this.pbxMove.Size = new System.Drawing.Size(4, 4);
            this.pbxMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMove.TabIndex = 4;
            this.pbxMove.TabStop = false;
            this.pbxMove.Visible = false;
            this.pbxMove.MouseLeave += new System.EventHandler(this.pbxMove_MouseLeave);
            this.pbxMove.MouseHover += new System.EventHandler(this.pbxMove_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.pbxMove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxWide);
            this.Controls.Add(this.cbxCamera);
            this.Controls.Add(this.picWebCam);
            this.Name = "Form1";
            this.Text = "frmWebCam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWebCam;
        private System.Windows.Forms.ComboBox cbxCamera;
        private System.Windows.Forms.CheckBox cbxWide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbxMove;
    }
}

