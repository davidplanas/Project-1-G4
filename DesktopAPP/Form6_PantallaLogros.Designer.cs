namespace DesktopAPP
{
    partial class Form6_PantallaLogros
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
            this.button5_Atras = new System.Windows.Forms.Button();
            this.label_form5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_eliminarlogro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5_Atras
            // 
            this.button5_Atras.BackColor = System.Drawing.Color.Transparent;
            this.button5_Atras.BackgroundImage = global::DesktopAPP.Properties.Resources.kisspng_button_arrow_clip_art_back_arrow_5aaffc048f0102_1824054415214827565858;
            this.button5_Atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5_Atras.ForeColor = System.Drawing.Color.Transparent;
            this.button5_Atras.Location = new System.Drawing.Point(12, 12);
            this.button5_Atras.Name = "button5_Atras";
            this.button5_Atras.Size = new System.Drawing.Size(50, 50);
            this.button5_Atras.TabIndex = 19;
            this.button5_Atras.UseVisualStyleBackColor = false;
            // 
            // label_form5
            // 
            this.label_form5.AutoSize = true;
            this.label_form5.BackColor = System.Drawing.Color.Transparent;
            this.label_form5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_form5.Location = new System.Drawing.Point(298, 12);
            this.label_form5.Name = "label_form5";
            this.label_form5.Size = new System.Drawing.Size(172, 55);
            this.label_form5.TabIndex = 20;
            this.label_form5.Text = "Logros";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(630, 227);
            this.textBox1.TabIndex = 21;
            // 
            // button_eliminarlogro
            // 
            this.button_eliminarlogro.BackColor = System.Drawing.Color.Transparent;
            this.button_eliminarlogro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_eliminarlogro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_eliminarlogro.ForeColor = System.Drawing.Color.Transparent;
            this.button_eliminarlogro.Image = global::DesktopAPP.Properties.Resources.Button_eliminar_logro;
            this.button_eliminarlogro.Location = new System.Drawing.Point(420, 379);
            this.button_eliminarlogro.Name = "button_eliminarlogro";
            this.button_eliminarlogro.Size = new System.Drawing.Size(310, 68);
            this.button_eliminarlogro.TabIndex = 22;
            this.button_eliminarlogro.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DesktopAPP.Properties.Resources.Button_añadir_logro;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(100, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 68);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::DesktopAPP.Properties.Resources.Button_modificar_logro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(100, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 68);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form6_PantallaLogros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopAPP.Properties.Resources.FondoDESKTOP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_eliminarlogro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_form5);
            this.Controls.Add(this.button5_Atras);
            this.DoubleBuffered = true;
            this.Name = "Form6_PantallaLogros";
            this.Text = "Form6_PantallaLogros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5_Atras;
        private System.Windows.Forms.Label label_form5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_eliminarlogro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}