namespace DesktopAPP
{
    partial class Form4_AñadirPregunta
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
            this.labelDificultad = new System.Windows.Forms.Label();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.labelRespuesta1 = new System.Windows.Forms.Label();
            this.labelRespuesta2 = new System.Windows.Forms.Label();
            this.labelRespuesta3 = new System.Windows.Forms.Label();
            this.labelRespuesta_correcta = new System.Windows.Forms.Label();
            this.comboBoxDificultad = new System.Windows.Forms.ComboBox();
            this.richTextBoxPregunta = new System.Windows.Forms.RichTextBox();
            this.textBoxRespuesta1 = new System.Windows.Forms.TextBox();
            this.textBoxRespuesta2 = new System.Windows.Forms.TextBox();
            this.textBoxRespuesta3 = new System.Windows.Forms.TextBox();
            this.textBoxRespuesta_correcta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDificultad
            // 
            this.labelDificultad.AutoSize = true;
            this.labelDificultad.BackColor = System.Drawing.Color.Transparent;
            this.labelDificultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDificultad.Location = new System.Drawing.Point(109, 143);
            this.labelDificultad.Name = "labelDificultad";
            this.labelDificultad.Size = new System.Drawing.Size(97, 25);
            this.labelDificultad.TabIndex = 0;
            this.labelDificultad.Text = "Dificultad:";
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.BackColor = System.Drawing.Color.Transparent;
            this.labelPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPregunta.Location = new System.Drawing.Point(109, 197);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(97, 25);
            this.labelPregunta.TabIndex = 1;
            this.labelPregunta.Text = "Pregunta:";
            // 
            // labelRespuesta1
            // 
            this.labelRespuesta1.AutoSize = true;
            this.labelRespuesta1.BackColor = System.Drawing.Color.Transparent;
            this.labelRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespuesta1.Location = new System.Drawing.Point(170, 305);
            this.labelRespuesta1.Name = "labelRespuesta1";
            this.labelRespuesta1.Size = new System.Drawing.Size(127, 25);
            this.labelRespuesta1.TabIndex = 2;
            this.labelRespuesta1.Text = "Respuesta 1:";
            // 
            // labelRespuesta2
            // 
            this.labelRespuesta2.AutoSize = true;
            this.labelRespuesta2.BackColor = System.Drawing.Color.Transparent;
            this.labelRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespuesta2.Location = new System.Drawing.Point(170, 375);
            this.labelRespuesta2.Name = "labelRespuesta2";
            this.labelRespuesta2.Size = new System.Drawing.Size(127, 25);
            this.labelRespuesta2.TabIndex = 3;
            this.labelRespuesta2.Text = "Respuesta 2:";
            // 
            // labelRespuesta3
            // 
            this.labelRespuesta3.AutoSize = true;
            this.labelRespuesta3.BackColor = System.Drawing.Color.Transparent;
            this.labelRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespuesta3.Location = new System.Drawing.Point(170, 445);
            this.labelRespuesta3.Name = "labelRespuesta3";
            this.labelRespuesta3.Size = new System.Drawing.Size(127, 25);
            this.labelRespuesta3.TabIndex = 4;
            this.labelRespuesta3.Text = "Respuesta 3:";
            // 
            // labelRespuesta_correcta
            // 
            this.labelRespuesta_correcta.AutoSize = true;
            this.labelRespuesta_correcta.BackColor = System.Drawing.Color.Transparent;
            this.labelRespuesta_correcta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRespuesta_correcta.Location = new System.Drawing.Point(109, 515);
            this.labelRespuesta_correcta.Name = "labelRespuesta_correcta";
            this.labelRespuesta_correcta.Size = new System.Drawing.Size(186, 25);
            this.labelRespuesta_correcta.TabIndex = 5;
            this.labelRespuesta_correcta.Text = "Respuesta correcta:";
            // 
            // comboBoxDificultad
            // 
            this.comboBoxDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDificultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDificultad.FormattingEnabled = true;
            this.comboBoxDificultad.Items.AddRange(new object[] {
            "BAJA",
            "MEDIA",
            "ALTA"});
            this.comboBoxDificultad.Location = new System.Drawing.Point(212, 140);
            this.comboBoxDificultad.Name = "comboBoxDificultad";
            this.comboBoxDificultad.Size = new System.Drawing.Size(104, 33);
            this.comboBoxDificultad.TabIndex = 7;
            this.comboBoxDificultad.SelectedIndexChanged += new System.EventHandler(this.comboBoxDificultad_SelectedIndexChanged);
            // 
            // richTextBoxPregunta
            // 
            this.richTextBoxPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPregunta.Location = new System.Drawing.Point(212, 194);
            this.richTextBoxPregunta.Name = "richTextBoxPregunta";
            this.richTextBoxPregunta.Size = new System.Drawing.Size(656, 91);
            this.richTextBoxPregunta.TabIndex = 9;
            this.richTextBoxPregunta.Text = "";
            this.richTextBoxPregunta.TextChanged += new System.EventHandler(this.richTextBoxPregunta_TextChanged);
            // 
            // textBoxRespuesta1
            // 
            this.textBoxRespuesta1.BackColor = System.Drawing.Color.Red;
            this.textBoxRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRespuesta1.Location = new System.Drawing.Point(303, 302);
            this.textBoxRespuesta1.Name = "textBoxRespuesta1";
            this.textBoxRespuesta1.Size = new System.Drawing.Size(565, 30);
            this.textBoxRespuesta1.TabIndex = 10;
            this.textBoxRespuesta1.TextChanged += new System.EventHandler(this.textBoxRespuesta1_TextChanged);
            // 
            // textBoxRespuesta2
            // 
            this.textBoxRespuesta2.BackColor = System.Drawing.Color.Red;
            this.textBoxRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRespuesta2.Location = new System.Drawing.Point(303, 372);
            this.textBoxRespuesta2.Name = "textBoxRespuesta2";
            this.textBoxRespuesta2.Size = new System.Drawing.Size(565, 30);
            this.textBoxRespuesta2.TabIndex = 11;
            this.textBoxRespuesta2.TextChanged += new System.EventHandler(this.textBoxRespuesta2_TextChanged);
            // 
            // textBoxRespuesta3
            // 
            this.textBoxRespuesta3.BackColor = System.Drawing.Color.Red;
            this.textBoxRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRespuesta3.Location = new System.Drawing.Point(303, 442);
            this.textBoxRespuesta3.Name = "textBoxRespuesta3";
            this.textBoxRespuesta3.Size = new System.Drawing.Size(565, 30);
            this.textBoxRespuesta3.TabIndex = 12;
            this.textBoxRespuesta3.TextChanged += new System.EventHandler(this.textBoxRespuesta3_TextChanged);
            // 
            // textBoxRespuesta_correcta
            // 
            this.textBoxRespuesta_correcta.BackColor = System.Drawing.Color.Green;
            this.textBoxRespuesta_correcta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRespuesta_correcta.Location = new System.Drawing.Point(303, 512);
            this.textBoxRespuesta_correcta.Name = "textBoxRespuesta_correcta";
            this.textBoxRespuesta_correcta.Size = new System.Drawing.Size(565, 30);
            this.textBoxRespuesta_correcta.TabIndex = 13;
            this.textBoxRespuesta_correcta.TextChanged += new System.EventHandler(this.textBoxRespuesta_correcta_TextChanged);
            // 
            // Form4_AñadirPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DesktopAPP.Properties.Resources.FondoDESKTOP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.textBoxRespuesta_correcta);
            this.Controls.Add(this.textBoxRespuesta3);
            this.Controls.Add(this.textBoxRespuesta2);
            this.Controls.Add(this.textBoxRespuesta1);
            this.Controls.Add(this.richTextBoxPregunta);
            this.Controls.Add(this.comboBoxDificultad);
            this.Controls.Add(this.labelRespuesta_correcta);
            this.Controls.Add(this.labelRespuesta3);
            this.Controls.Add(this.labelRespuesta2);
            this.Controls.Add(this.labelRespuesta1);
            this.Controls.Add(this.labelPregunta);
            this.Controls.Add(this.labelDificultad);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Form4_AñadirPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir pregunta";
            this.Load += new System.EventHandler(this.FormAdministrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDificultad;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Label labelRespuesta1;
        private System.Windows.Forms.Label labelRespuesta2;
        private System.Windows.Forms.Label labelRespuesta3;
        private System.Windows.Forms.Label labelRespuesta_correcta;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.RichTextBox richTextBoxPregunta;
        private System.Windows.Forms.TextBox textBoxRespuesta1;
        private System.Windows.Forms.TextBox textBoxRespuesta2;
        private System.Windows.Forms.TextBox textBoxRespuesta3;
        private System.Windows.Forms.TextBox textBoxRespuesta_correcta;
    }
}