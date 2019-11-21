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
            this.label_form3.Location = new System.Drawing.Point(348, 22);
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
            this.dataGridView_form3.Location = new System.Drawing.Point(207, 94);
            this.dataGridView_form3.Name = "dataGridView_form3";
            this.dataGridView_form3.Size = new System.Drawing.Size(543, 465);
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
            // Form3_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopAPP.Properties.Resources.FondoDESKTOP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.dataGridView_form3);
            this.Controls.Add(this.label_form3);
            this.Controls.Add(this.button3_Atras);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3_Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas";
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
    }
}