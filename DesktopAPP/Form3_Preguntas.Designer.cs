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
            this.label_form3 = new System.Windows.Forms.Label();
            this.dataGridView_form3 = new System.Windows.Forms.DataGridView();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primera_respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segunda_respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tercera_respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuarta_respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3_modificarpregunta = new System.Windows.Forms.Button();
            this.button3_eliminarpregunta = new System.Windows.Forms.Button();
            this.button3_añadirpregunta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_form3)).BeginInit();
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
            // label_form3
            // 
            this.label_form3.AutoSize = true;
            this.label_form3.BackColor = System.Drawing.Color.Transparent;
            this.label_form3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_form3.Location = new System.Drawing.Point(350, 12);
            this.label_form3.Name = "label_form3";
            this.label_form3.Size = new System.Drawing.Size(244, 55);
            this.label_form3.TabIndex = 19;
            this.label_form3.Text = "Preguntas";
            // 
            // dataGridView_form3
            // 
            this.dataGridView_form3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_form3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pregunta,
            this.primera_respuesta,
            this.segunda_respuesta,
            this.tercera_respuesta,
            this.cuarta_respuesta});
            this.dataGridView_form3.Location = new System.Drawing.Point(97, 168);
            this.dataGridView_form3.Name = "dataGridView_form3";
            this.dataGridView_form3.Size = new System.Drawing.Size(788, 348);
            this.dataGridView_form3.TabIndex = 20;
            this.dataGridView_form3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Pregunta
            // 
            this.Pregunta.HeaderText = "Pregunta";
            this.Pregunta.Name = "Pregunta";
            // 
            // primera_respuesta
            // 
            this.primera_respuesta.HeaderText = "Primera Respuesta";
            this.primera_respuesta.Name = "primera_respuesta";
            // 
            // segunda_respuesta
            // 
            this.segunda_respuesta.HeaderText = "Segunda Respuesta";
            this.segunda_respuesta.Name = "segunda_respuesta";
            // 
            // tercera_respuesta
            // 
            this.tercera_respuesta.HeaderText = "Tercera Respuesta";
            this.tercera_respuesta.Name = "tercera_respuesta";
            // 
            // cuarta_respuesta
            // 
            this.cuarta_respuesta.HeaderText = "Cuarta Respuesta";
            this.cuarta_respuesta.Name = "cuarta_respuesta";
            // 
            // button3_modificarpregunta
            // 
            this.button3_modificarpregunta.BackColor = System.Drawing.Color.Transparent;
            this.button3_modificarpregunta.BackgroundImage = global::DesktopAPP.Properties.Resources.Button_modificar_pregunta;
            this.button3_modificarpregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3_modificarpregunta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3_modificarpregunta.ForeColor = System.Drawing.Color.Transparent;
            this.button3_modificarpregunta.Location = new System.Drawing.Point(97, 522);
            this.button3_modificarpregunta.Name = "button3_modificarpregunta";
            this.button3_modificarpregunta.Size = new System.Drawing.Size(239, 67);
            this.button3_modificarpregunta.TabIndex = 22;
            this.button3_modificarpregunta.UseVisualStyleBackColor = false;
            this.button3_modificarpregunta.Click += new System.EventHandler(this.button3_modificarpregunta_Click);
            // 
            // button3_eliminarpregunta
            // 
            this.button3_eliminarpregunta.BackColor = System.Drawing.Color.Transparent;
            this.button3_eliminarpregunta.BackgroundImage = global::DesktopAPP.Properties.Resources.Button_eliminar_pregunta;
            this.button3_eliminarpregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3_eliminarpregunta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3_eliminarpregunta.Location = new System.Drawing.Point(640, 520);
            this.button3_eliminarpregunta.Name = "button3_eliminarpregunta";
            this.button3_eliminarpregunta.Size = new System.Drawing.Size(245, 69);
            this.button3_eliminarpregunta.TabIndex = 23;
            this.button3_eliminarpregunta.UseCompatibleTextRendering = true;
            this.button3_eliminarpregunta.UseVisualStyleBackColor = false;
            this.button3_eliminarpregunta.Click += new System.EventHandler(this.button3_eliminarpregunta_Click);
            // 
            // button3_añadirpregunta
            // 
            this.button3_añadirpregunta.BackColor = System.Drawing.Color.Transparent;
            this.button3_añadirpregunta.BackgroundImage = global::DesktopAPP.Properties.Resources.Button_añadir_pregunta;
            this.button3_añadirpregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3_añadirpregunta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3_añadirpregunta.ForeColor = System.Drawing.Color.Transparent;
            this.button3_añadirpregunta.Location = new System.Drawing.Point(97, 95);
            this.button3_añadirpregunta.Name = "button3_añadirpregunta";
            this.button3_añadirpregunta.Size = new System.Drawing.Size(239, 67);
            this.button3_añadirpregunta.TabIndex = 24;
            this.button3_añadirpregunta.UseVisualStyleBackColor = false;
            this.button3_añadirpregunta.Click += new System.EventHandler(this.button3_añadirpregunta_Click);
            // 
            // Form3_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopAPP.Properties.Resources.FondoDESKTOP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.button3_añadirpregunta);
            this.Controls.Add(this.button3_eliminarpregunta);
            this.Controls.Add(this.button3_modificarpregunta);
            this.Controls.Add(this.dataGridView_form3);
            this.Controls.Add(this.label_form3);
            this.Controls.Add(this.button3_Atras);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3_Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.Form3_Preguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_form3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3_Atras;
        private System.Windows.Forms.Label label_form3;
        private System.Windows.Forms.DataGridView dataGridView_form3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn primera_respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn segunda_respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tercera_respuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuarta_respuesta;
        private System.Windows.Forms.Button button3_modificarpregunta;
        private System.Windows.Forms.Button button3_eliminarpregunta;
        private System.Windows.Forms.Button button3_añadirpregunta;
    }
}