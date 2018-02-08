namespace PalabraPalindroma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSi = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(31)))), ((int)(((byte)(94)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(78)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(120)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Ubuntu Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(487, 73);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(113, 39);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Verificar";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Font = new System.Drawing.Font("Ubuntu Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtIngreso.Location = new System.Drawing.Point(200, 27);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(400, 30);
            this.txtIngreso.TabIndex = 5;
            this.txtIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngreso_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresa la palabra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hecho por: Daniel Díaz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(401, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "GitHub:";
            // 
            // lblSi
            // 
            this.lblSi.AutoSize = true;
            this.lblSi.Font = new System.Drawing.Font("Ubuntu Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSi.ForeColor = System.Drawing.Color.White;
            this.lblSi.Location = new System.Drawing.Point(278, 146);
            this.lblSi.Name = "lblSi";
            this.lblSi.Size = new System.Drawing.Size(68, 63);
            this.lblSi.TabIndex = 9;
            this.lblSi.Text = "Sí";
            this.lblSi.Visible = false;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Ubuntu Light", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(278, 146);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(96, 63);
            this.lblNo.TabIndex = 10;
            this.lblNo.Text = "No";
            this.lblNo.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Ubuntu Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(484, 289);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 24);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "@DanitoxMX";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(628, 322);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblSi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblNo);
            this.Font = new System.Drawing.Font("Ubuntu Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palabras Palíndromas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSi;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

