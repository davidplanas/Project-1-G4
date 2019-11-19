namespace DesktopAPP
{
    partial class Form2_Administrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_Administrar));
            this.button2_AdmPregunta = new System.Windows.Forms.Button();
            this.button2_AdmLogros = new System.Windows.Forms.Button();
            this.button2_Atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2_AdmPregunta
            // 
            this.button2_AdmPregunta.BackColor = System.Drawing.Color.Transparent;
            this.button2_AdmPregunta.BackgroundImage = global::DesktopAPP.Properties.Resources._2_AdministrarPreguntasyLogrosDAVID;
            this.button2_AdmPregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2_AdmPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2_AdmPregunta.Location = new System.Drawing.Point(124, 176);
            this.button2_AdmPregunta.Name = "button2_AdmPregunta";
            this.button2_AdmPregunta.Size = new System.Drawing.Size(722, 113);
            this.button2_AdmPregunta.TabIndex = 0;
            this.button2_AdmPregunta.UseVisualStyleBackColor = false;
            this.button2_AdmPregunta.Click += new System.EventHandler(this.button2_AdmPregunta_Click);
            // 
            // button2_AdmLogros
            // 
            this.button2_AdmLogros.BackColor = System.Drawing.Color.Transparent;
            this.button2_AdmLogros.BackgroundImage = global::DesktopAPP.Properties.Resources._2_AdministrarLogrosDAVID__2_;
            this.button2_AdmLogros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2_AdmLogros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2_AdmLogros.Location = new System.Drawing.Point(124, 335);
            this.button2_AdmLogros.Name = "button2_AdmLogros";
            this.button2_AdmLogros.Size = new System.Drawing.Size(722, 113);
            this.button2_AdmLogros.TabIndex = 1;
            this.button2_AdmLogros.UseVisualStyleBackColor = false;
            this.button2_AdmLogros.Click += new System.EventHandler(this.button2_AdmLogros_Click);
            // 
            // button2_Atras
            // 
            this.button2_Atras.BackColor = System.Drawing.Color.Transparent;
            this.button2_Atras.BackgroundImage = global::DesktopAPP.Properties.Resources.kisspng_button_arrow_clip_art_back_arrow_5aaffc048f0102_1824054415214827565858;
            this.button2_Atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2_Atras.ForeColor = System.Drawing.Color.Transparent;
            this.button2_Atras.Location = new System.Drawing.Point(12, 12);
            this.button2_Atras.Name = "button2_Atras";
            this.button2_Atras.Size = new System.Drawing.Size(50, 50);
            this.button2_Atras.TabIndex = 17;
            this.button2_Atras.UseVisualStyleBackColor = false;
            this.button2_Atras.Click += new System.EventHandler(this.button2_Atras_Click);
            // 
            // Form2_Administrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopAPP.Properties.Resources.FondoDESKTOP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.button2_Atras);
            this.Controls.Add(this.button2_AdmLogros);
            this.Controls.Add(this.button2_AdmPregunta);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2_Administrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar preguntas y logros";
            this.Load += new System.EventHandler(this.Form2_Administrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2_AdmPregunta;
        private System.Windows.Forms.Button button2_AdmLogros;
        private System.Windows.Forms.Button button2_Atras;
    }
}