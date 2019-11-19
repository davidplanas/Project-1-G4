namespace DesktopAPP
{
    partial class Form3_Preguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_Preguntas));
            this.button3_Atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3_Atras
            // 
            this.button3_Atras.BackColor = System.Drawing.Color.Transparent;
            this.button3_Atras.BackgroundImage = global::DesktopAPP.Properties.Resources.kisspng_button_arrow_clip_art_back_arrow_5aaffc048f0102_1824054415214827565858;
            this.button3_Atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3_Atras.ForeColor = System.Drawing.Color.Transparent;
            this.button3_Atras.Location = new System.Drawing.Point(12, 12);
            this.button3_Atras.Name = "button3_Atras";
            this.button3_Atras.Size = new System.Drawing.Size(50, 50);
            this.button3_Atras.TabIndex = 18;
            this.button3_Atras.UseVisualStyleBackColor = false;
            this.button3_Atras.Click += new System.EventHandler(this.button3_Atras_Click);
            // 
            // Form3_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopAPP.Properties.Resources.FondoDESKTOP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.button3_Atras);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3_Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3_Atras;
    }
}