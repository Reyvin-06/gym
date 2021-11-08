namespace Gym
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_pagos = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_registros = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clientes = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.cu_inicio1 = new Gym.cu_inicio();
            this.clientes1 = new Gym.Clientes();
            this.cu_Asistencia1 = new Gym.cu_Asistencia();
            this.cu_registros1 = new Gym.cu_registros();
            this.cu_pago1 = new Gym.cu_pago();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.Fecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Fechahora = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.guna2Panel1.Controls.Add(this.btn_pagos);
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.btn_registros);
            this.guna2Panel1.Controls.Add(this.btn_clientes);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(282, 900);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_pagos
            // 
            this.btn_pagos.Animated = true;
            this.btn_pagos.AutoRoundedCorners = true;
            this.btn_pagos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.btn_pagos.BorderRadius = 25;
            this.btn_pagos.CheckedState.Parent = this.btn_pagos;
            this.btn_pagos.CustomImages.Parent = this.btn_pagos;
            this.btn_pagos.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_pagos.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagos.ForeColor = System.Drawing.Color.Black;
            this.btn_pagos.HoverState.Parent = this.btn_pagos;
            this.btn_pagos.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagos.Image")));
            this.btn_pagos.ImageOffset = new System.Drawing.Point(-14, -2);
            this.btn_pagos.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_pagos.Location = new System.Drawing.Point(12, 351);
            this.btn_pagos.Name = "btn_pagos";
            this.btn_pagos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.btn_pagos.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.btn_pagos.ShadowDecoration.Parent = this.btn_pagos;
            this.btn_pagos.Size = new System.Drawing.Size(208, 52);
            this.btn_pagos.TabIndex = 4;
            this.btn_pagos.Text = "Pagos";
            this.btn_pagos.TextOffset = new System.Drawing.Point(-7, 2);
            this.btn_pagos.Click += new System.EventHandler(this.btn_pagos_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.guna2Button4.BorderRadius = 25;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button4.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageOffset = new System.Drawing.Point(-2, 0);
            this.guna2Button4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button4.Location = new System.Drawing.Point(12, 431);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.guna2Button4.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(208, 52);
            this.guna2Button4.TabIndex = 3;
            this.guna2Button4.Text = "Asistencia";
            this.guna2Button4.TextOffset = new System.Drawing.Point(0, 2);
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btn_registros
            // 
            this.btn_registros.Animated = true;
            this.btn_registros.AutoRoundedCorners = true;
            this.btn_registros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.btn_registros.BorderRadius = 25;
            this.btn_registros.CheckedState.Parent = this.btn_registros;
            this.btn_registros.CustomImages.Parent = this.btn_registros;
            this.btn_registros.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_registros.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registros.ForeColor = System.Drawing.Color.Black;
            this.btn_registros.HoverState.Parent = this.btn_registros;
            this.btn_registros.Image = ((System.Drawing.Image)(resources.GetObject("btn_registros.Image")));
            this.btn_registros.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btn_registros.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_registros.Location = new System.Drawing.Point(12, 507);
            this.btn_registros.Name = "btn_registros";
            this.btn_registros.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.btn_registros.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.btn_registros.ShadowDecoration.Parent = this.btn_registros;
            this.btn_registros.Size = new System.Drawing.Size(208, 52);
            this.btn_registros.TabIndex = 2;
            this.btn_registros.Text = "Registros";
            this.btn_registros.TextOffset = new System.Drawing.Point(3, 2);
            this.btn_registros.Click += new System.EventHandler(this.btn_registros_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.Animated = true;
            this.btn_clientes.AutoRoundedCorners = true;
            this.btn_clientes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.btn_clientes.BorderRadius = 25;
            this.btn_clientes.CheckedState.Parent = this.btn_clientes;
            this.btn_clientes.CustomImages.Parent = this.btn_clientes;
            this.btn_clientes.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clientes.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.Color.Black;
            this.btn_clientes.HoverState.Parent = this.btn_clientes;
            this.btn_clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_clientes.Image")));
            this.btn_clientes.ImageOffset = new System.Drawing.Point(-6, -2);
            this.btn_clientes.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_clientes.Location = new System.Drawing.Point(12, 278);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.btn_clientes.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.btn_clientes.ShadowDecoration.Parent = this.btn_clientes;
            this.btn_clientes.Size = new System.Drawing.Size(208, 52);
            this.btn_clientes.TabIndex = 1;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.TextOffset = new System.Drawing.Point(0, 2);
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(26, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(182, 165);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.guna2Button1.BorderRadius = 25;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-6, -2);
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(12, 196);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(112)))));
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(208, 52);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Inicio";
            this.guna2Button1.TextOffset = new System.Drawing.Point(0, 2);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoRoundedCorners = true;
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 449;
            this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(244, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1356, 900);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1311, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.cu_inicio1);
            this.guna2Panel4.Controls.Add(this.clientes1);
            this.guna2Panel4.Controls.Add(this.cu_Asistencia1);
            this.guna2Panel4.Controls.Add(this.cu_registros1);
            this.guna2Panel4.Controls.Add(this.cu_pago1);
            this.guna2Panel4.Location = new System.Drawing.Point(20, 77);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(1324, 811);
            this.guna2Panel4.TabIndex = 2;
            // 
            // cu_inicio1
            // 
            this.cu_inicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.cu_inicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cu_inicio1.Location = new System.Drawing.Point(0, 0);
            this.cu_inicio1.Name = "cu_inicio1";
            this.cu_inicio1.Size = new System.Drawing.Size(1324, 811);
            this.cu_inicio1.TabIndex = 0;
            // 
            // clientes1
            // 
            this.clientes1.Location = new System.Drawing.Point(0, 0);
            this.clientes1.Name = "clientes1";
            this.clientes1.Size = new System.Drawing.Size(1356, 900);
            this.clientes1.TabIndex = 1;
            // 
            // cu_Asistencia1
            // 
            this.cu_Asistencia1.Location = new System.Drawing.Point(0, 0);
            this.cu_Asistencia1.Name = "cu_Asistencia1";
            this.cu_Asistencia1.Size = new System.Drawing.Size(1324, 811);
            this.cu_Asistencia1.TabIndex = 2;
            // 
            // cu_registros1
            // 
            this.cu_registros1.Location = new System.Drawing.Point(-3, 0);
            this.cu_registros1.Name = "cu_registros1";
            this.cu_registros1.Size = new System.Drawing.Size(1324, 811);
            this.cu_registros1.TabIndex = 3;
            // 
            // cu_pago1
            // 
            this.cu_pago1.Location = new System.Drawing.Point(-3, 0);
            this.cu_pago1.Name = "cu_pago1";
            this.cu_pago1.Size = new System.Drawing.Size(1324, 811);
            this.cu_pago1.TabIndex = 4;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel3.Controls.Add(this.Fecha);
            this.guna2Panel3.Controls.Add(this.Hora);
            this.guna2Panel3.Location = new System.Drawing.Point(361, 12);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(723, 51);
            this.guna2Panel3.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(243, 15);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(80, 24);
            this.Fecha.TabIndex = 1;
            this.Fecha.Text = "Fecha";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(26, 15);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(66, 24);
            this.Hora.TabIndex = 0;
            this.Hora.Text = "Hora";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 80;
            this.guna2Elipse2.TargetControl = this.guna2Panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 35;
            this.guna2Elipse3.TargetControl = this.guna2Panel3;
            // 
            // Fechahora
            // 
            this.Fechahora.Enabled = true;
            this.Fechahora.Tick += new System.EventHandler(this.Fechahora_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btn_registros;
        private Guna.UI2.WinForms.Guna2Button btn_clientes;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Timer Fechahora;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private cu_inicio cu_inicio1;
        private Clientes clientes1;
        private cu_Asistencia cu_Asistencia1;
        private cu_registros cu_registros1;
        private Guna.UI2.WinForms.Guna2Button btn_pagos;
        private cu_pago cu_pago1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

