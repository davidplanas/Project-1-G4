namespace DesktopAPP
{
    partial class FormIniciar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonEnglishFlag = new System.Windows.Forms.Button();
            this.buttonSpanishFlag = new System.Windows.Forms.Button();
            this.buttonCatalanFlag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.Location = new System.Drawing.Point(350, 250);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(300, 100);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "INICIAR";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(423, 356);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(150, 75);
            this.buttonSalir.TabIndex = 1;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonEnglishFlag
            // 
            this.buttonEnglishFlag.BackColor = System.Drawing.Color.Transparent;
            this.buttonEnglishFlag.BackgroundImage = global::DesktopAPP.Properties.Resources.UK_256;
            this.buttonEnglishFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEnglishFlag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnglishFlag.Location = new System.Drawing.Point(927, 12);
            this.buttonEnglishFlag.Name = "buttonEnglishFlag";
            this.buttonEnglishFlag.Size = new System.Drawing.Size(45, 45);
            this.buttonEnglishFlag.TabIndex = 2;
            this.buttonEnglishFlag.UseVisualStyleBackColor = false;
            // 
            // buttonSpanishFlag
            // 
            this.buttonSpanishFlag.BackColor = System.Drawing.Color.Transparent;
            this.buttonSpanishFlag.BackgroundImage = global::DesktopAPP.Properties.Resources.Espanya_Spain_256;
            this.buttonSpanishFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpanishFlag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpanishFlag.Location = new System.Drawing.Point(876, 12);
            this.buttonSpanishFlag.Name = "buttonSpanishFlag";
            this.buttonSpanishFlag.Size = new System.Drawing.Size(45, 45);
            this.buttonSpanishFlag.TabIndex = 3;
            this.buttonSpanishFlag.UseVisualStyleBackColor = false;
            // 
            // buttonCatalanFlag
            // 
            this.buttonCatalanFlag.BackColor = System.Drawing.Color.Transparent;
            this.buttonCatalanFlag.BackgroundImage = global::DesktopAPP.Properties.Resources.Catalunya_Catalonia_256;
            this.buttonCatalanFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCatalanFlag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCatalanFlag.Location = new System.Drawing.Point(825, 12);
            this.buttonCatalanFlag.Name = "buttonCatalanFlag";
            this.buttonCatalanFlag.Size = new System.Drawing.Size(45, 45);
            this.buttonCatalanFlag.TabIndex = 4;
            this.buttonCatalanFlag.UseVisualStyleBackColor = false;
            // 
            // FormIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DesktopAPP.Properties.Resources.FondoDESKTOP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.buttonCatalanFlag);
            this.Controls.Add(this.buttonSpanishFlag);
            this.Controls.Add(this.buttonEnglishFlag);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIniciar);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FormIniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop App";
            this.Load += new System.EventHandler(this.FormIniciar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonEnglishFlag;
        private System.Windows.Forms.Button buttonSpanishFlag;
        private System.Windows.Forms.Button buttonCatalanFlag;
    }
}

