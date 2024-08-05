namespace mandarOfertas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtContactos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPosicion = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chxPortapapeles = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chxIncluirTexto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIniciar.FlatAppearance.BorderSize = 50;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIniciar.Location = new System.Drawing.Point(38, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(503, 204);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtContactos
            // 
            this.txtContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactos.Location = new System.Drawing.Point(39, 316);
            this.txtContactos.Name = "txtContactos";
            this.txtContactos.Size = new System.Drawing.Size(89, 24);
            this.txtContactos.TabIndex = 1;
            this.txtContactos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contactos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contador";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblContador.Location = new System.Drawing.Point(244, 313);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(45, 35);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(433, 289);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(108, 24);
            this.lblPosicion.TabIndex = 10;
            this.lblPosicion.Text = "Posicion Nº";
            // 
            // txtPos
            // 
            this.txtPos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.Location = new System.Drawing.Point(441, 313);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(89, 24);
            this.txtPos.TabIndex = 9;
            this.txtPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTexto
            // 
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.ForeColor = System.Drawing.Color.Black;
            this.txtTexto.Location = new System.Drawing.Point(263, 390);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto.Size = new System.Drawing.Size(278, 96);
            this.txtTexto.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Texto a Mandar:";
            // 
            // chxPortapapeles
            // 
            this.chxPortapapeles.AutoSize = true;
            this.chxPortapapeles.Location = new System.Drawing.Point(405, 542);
            this.chxPortapapeles.Name = "chxPortapapeles";
            this.chxPortapapeles.Size = new System.Drawing.Size(136, 17);
            this.chxPortapapeles.TabIndex = 13;
            this.chxPortapapeles.Text = "Pegar del Portapapeles";
            this.chxPortapapeles.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevo.FlatAppearance.BorderSize = 50;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevo.Location = new System.Drawing.Point(39, 222);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(416, 49);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStop.Location = new System.Drawing.Point(461, 222);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 49);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pbProgreso
            // 
            this.pbProgreso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbProgreso.ForeColor = System.Drawing.SystemColors.Control;
            this.pbProgreso.Location = new System.Drawing.Point(38, 565);
            this.pbProgreso.Maximum = 1000;
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(503, 30);
            this.pbProgreso.Step = 1;
            this.pbProgreso.TabIndex = 16;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPorcentaje.Location = new System.Drawing.Point(257, 461);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 16);
            this.lblPorcentaje.TabIndex = 17;
            // 
            // chxIncluirTexto
            // 
            this.chxIncluirTexto.AutoSize = true;
            this.chxIncluirTexto.Location = new System.Drawing.Point(39, 542);
            this.chxIncluirTexto.Name = "chxIncluirTexto";
            this.chxIncluirTexto.Size = new System.Drawing.Size(143, 17);
            this.chxIncluirTexto.TabIndex = 18;
            this.chxIncluirTexto.Text = "Incluir texto en imagenes";
            this.chxIncluirTexto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(581, 607);
            this.Controls.Add(this.chxIncluirTexto);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.pbProgreso);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.chxPortapapeles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContactos);
            this.Controls.Add(this.btnIniciar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtContactos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chxPortapapeles;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox chxIncluirTexto;
    }
}

