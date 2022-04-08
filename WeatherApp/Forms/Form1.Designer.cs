namespace WeatherApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmanecer = new System.Windows.Forms.Label();
            this.lblAtardecer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPresion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTemMax = new System.Windows.Forms.Label();
            this.lblTemMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(93, 42);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(176, 20);
            this.txtCity.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.Location = new System.Drawing.Point(42, 100);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(57, 13);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "Condición:";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalles.Location = new System.Drawing.Point(41, 142);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(48, 13);
            this.lblDetalles.TabIndex = 4;
            this.lblDetalles.Text = "Detalles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(43, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amanacer:";
            // 
            // lblAmanecer
            // 
            this.lblAmanecer.AutoSize = true;
            this.lblAmanecer.BackColor = System.Drawing.Color.Transparent;
            this.lblAmanecer.Location = new System.Drawing.Point(107, 184);
            this.lblAmanecer.Name = "lblAmanecer";
            this.lblAmanecer.Size = new System.Drawing.Size(27, 13);
            this.lblAmanecer.TabIndex = 6;
            this.lblAmanecer.Text = "N/A";
            // 
            // lblAtardecer
            // 
            this.lblAtardecer.AutoSize = true;
            this.lblAtardecer.BackColor = System.Drawing.Color.Transparent;
            this.lblAtardecer.Location = new System.Drawing.Point(107, 224);
            this.lblAtardecer.Name = "lblAtardecer";
            this.lblAtardecer.Size = new System.Drawing.Size(27, 13);
            this.lblAtardecer.TabIndex = 8;
            this.lblAtardecer.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(45, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Atardecer:";
            // 
            // lblPresion
            // 
            this.lblPresion.AutoSize = true;
            this.lblPresion.BackColor = System.Drawing.Color.Transparent;
            this.lblPresion.Location = new System.Drawing.Point(341, 140);
            this.lblPresion.Name = "lblPresion";
            this.lblPresion.Size = new System.Drawing.Size(27, 13);
            this.lblPresion.TabIndex = 12;
            this.lblPresion.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(290, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Presión:";
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.BackColor = System.Drawing.Color.Transparent;
            this.lblVelocidad.Location = new System.Drawing.Point(400, 100);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(27, 13);
            this.lblVelocidad.TabIndex = 10;
            this.lblVelocidad.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(288, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Velocidad del viento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(137, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Temperatura maxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Temperatura minima:";
            // 
            // lblTemMax
            // 
            this.lblTemMax.AutoSize = true;
            this.lblTemMax.BackColor = System.Drawing.Color.Transparent;
            this.lblTemMax.Location = new System.Drawing.Point(405, 184);
            this.lblTemMax.Name = "lblTemMax";
            this.lblTemMax.Size = new System.Drawing.Size(27, 13);
            this.lblTemMax.TabIndex = 16;
            this.lblTemMax.Text = "N/A";
            // 
            // lblTemMin
            // 
            this.lblTemMin.AutoSize = true;
            this.lblTemMin.BackColor = System.Drawing.Color.Transparent;
            this.lblTemMin.Location = new System.Drawing.Point(405, 224);
            this.lblTemMin.Name = "lblTemMin";
            this.lblTemMin.Size = new System.Drawing.Size(27, 13);
            this.lblTemMin.TabIndex = 17;
            this.lblTemMin.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(467, 306);
            this.Controls.Add(this.lblTemMin);
            this.Controls.Add(this.lblTemMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPresion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAtardecer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAmanecer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmanecer;
        private System.Windows.Forms.Label lblAtardecer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPresion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTemMax;
        private System.Windows.Forms.Label lblTemMin;
    }
}

