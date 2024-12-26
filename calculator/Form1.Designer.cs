namespace calculator
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
            this.btnExt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbCalc = new System.Windows.Forms.Label();
            this.btndevide = new Guna.UI2.WinForms.Guna2Button();
            this.btnrd = new Guna.UI2.WinForms.Guna2Button();
            this.btnnine = new Guna.UI2.WinForms.Guna2Button();
            this.btnone = new Guna.UI2.WinForms.Guna2Button();
            this.btnfour = new Guna.UI2.WinForms.Guna2Button();
            this.btneight = new Guna.UI2.WinForms.Guna2Button();
            this.btnseven = new Guna.UI2.WinForms.Guna2Button();
            this.btnequal = new Guna.UI2.WinForms.Guna2Button();
            this.btnmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnplus = new Guna.UI2.WinForms.Guna2Button();
            this.btnmulti = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btntwo = new Guna.UI2.WinForms.Guna2Button();
            this.btnthree = new Guna.UI2.WinForms.Guna2Button();
            this.btndot = new Guna.UI2.WinForms.Guna2Button();
            this.btnzero = new Guna.UI2.WinForms.Guna2Button();
            this.btnsix = new Guna.UI2.WinForms.Guna2Button();
            this.btnfive = new Guna.UI2.WinForms.Guna2Button();
            this.txtstore = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtresult = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExt
            // 
            this.btnExt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExt.Image = global::calculator.Properties.Resources.icons8_start_100;
            this.btnExt.ImageRotate = 0F;
            this.btnExt.Location = new System.Drawing.Point(384, 1);
            this.btnExt.Name = "btnExt";
            this.btnExt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExt.Size = new System.Drawing.Size(51, 49);
            this.btnExt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExt.TabIndex = 1;
            this.btnExt.TabStop = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // lbCalc
            // 
            this.lbCalc.AutoSize = true;
            this.lbCalc.BackColor = System.Drawing.Color.Black;
            this.lbCalc.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalc.ForeColor = System.Drawing.Color.Purple;
            this.lbCalc.Location = new System.Drawing.Point(12, 9);
            this.lbCalc.Name = "lbCalc";
            this.lbCalc.Size = new System.Drawing.Size(120, 25);
            this.lbCalc.TabIndex = 2;
            this.lbCalc.Text = "calculator";
            // 
            // btndevide
            // 
            this.btndevide.BackColor = System.Drawing.Color.Transparent;
            this.btndevide.BorderRadius = 15;
            this.btndevide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndevide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndevide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndevide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndevide.FillColor = System.Drawing.Color.Black;
            this.btndevide.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndevide.ForeColor = System.Drawing.Color.Fuchsia;
            this.btndevide.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btndevide.Location = new System.Drawing.Point(278, 231);
            this.btndevide.Name = "btndevide";
            this.btndevide.ShadowDecoration.BorderRadius = 15;
            this.btndevide.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btndevide.ShadowDecoration.Enabled = true;
            this.btndevide.Size = new System.Drawing.Size(61, 36);
            this.btndevide.TabIndex = 3;
            this.btndevide.Tag = "/";
            this.btndevide.Text = "/";
            this.btndevide.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnrd
            // 
            this.btnrd.BackColor = System.Drawing.Color.Transparent;
            this.btnrd.BorderRadius = 15;
            this.btnrd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrd.FillColor = System.Drawing.Color.Black;
            this.btnrd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrd.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnrd.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnrd.Location = new System.Drawing.Point(211, 231);
            this.btnrd.Name = "btnrd";
            this.btnrd.ShadowDecoration.BorderRadius = 15;
            this.btnrd.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnrd.ShadowDecoration.Enabled = true;
            this.btnrd.Size = new System.Drawing.Size(61, 36);
            this.btnrd.TabIndex = 4;
            this.btnrd.Tag = "%";
            this.btnrd.Text = "%";
            this.btnrd.Click += new System.EventHandler(this.PrecentageCalculate);
            // 
            // btnnine
            // 
            this.btnnine.BackColor = System.Drawing.Color.Transparent;
            this.btnnine.BorderRadius = 15;
            this.btnnine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnnine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnnine.FillColor = System.Drawing.Color.Black;
            this.btnnine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnine.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnnine.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnnine.Location = new System.Drawing.Point(211, 293);
            this.btnnine.Name = "btnnine";
            this.btnnine.ShadowDecoration.BorderRadius = 15;
            this.btnnine.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnnine.ShadowDecoration.Enabled = true;
            this.btnnine.Size = new System.Drawing.Size(61, 36);
            this.btnnine.TabIndex = 5;
            this.btnnine.Tag = "9";
            this.btnnine.Text = "9";
            this.btnnine.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnone
            // 
            this.btnone.BackColor = System.Drawing.Color.Transparent;
            this.btnone.BorderRadius = 15;
            this.btnone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnone.FillColor = System.Drawing.Color.Black;
            this.btnone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnone.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnone.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnone.Location = new System.Drawing.Point(59, 397);
            this.btnone.Name = "btnone";
            this.btnone.ShadowDecoration.BorderRadius = 15;
            this.btnone.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnone.ShadowDecoration.Enabled = true;
            this.btnone.Size = new System.Drawing.Size(61, 36);
            this.btnone.TabIndex = 6;
            this.btnone.Tag = "1";
            this.btnone.Text = "1";
            this.btnone.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnfour
            // 
            this.btnfour.BackColor = System.Drawing.Color.Transparent;
            this.btnfour.BorderRadius = 15;
            this.btnfour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfour.FillColor = System.Drawing.Color.Black;
            this.btnfour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfour.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnfour.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnfour.Location = new System.Drawing.Point(59, 344);
            this.btnfour.Name = "btnfour";
            this.btnfour.ShadowDecoration.BorderRadius = 15;
            this.btnfour.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnfour.ShadowDecoration.Enabled = true;
            this.btnfour.Size = new System.Drawing.Size(61, 36);
            this.btnfour.TabIndex = 7;
            this.btnfour.Tag = "4";
            this.btnfour.Text = "4";
            this.btnfour.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btneight
            // 
            this.btneight.BackColor = System.Drawing.Color.Transparent;
            this.btneight.BorderRadius = 15;
            this.btneight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneight.FillColor = System.Drawing.Color.Black;
            this.btneight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneight.ForeColor = System.Drawing.Color.Fuchsia;
            this.btneight.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btneight.Location = new System.Drawing.Point(137, 293);
            this.btneight.Name = "btneight";
            this.btneight.ShadowDecoration.BorderRadius = 15;
            this.btneight.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btneight.ShadowDecoration.Enabled = true;
            this.btneight.Size = new System.Drawing.Size(61, 36);
            this.btneight.TabIndex = 8;
            this.btneight.Tag = "8";
            this.btneight.Text = "8";
            this.btneight.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnseven
            // 
            this.btnseven.BackColor = System.Drawing.Color.Transparent;
            this.btnseven.BorderRadius = 15;
            this.btnseven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnseven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnseven.FillColor = System.Drawing.Color.Black;
            this.btnseven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseven.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnseven.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnseven.Location = new System.Drawing.Point(59, 293);
            this.btnseven.Name = "btnseven";
            this.btnseven.ShadowDecoration.BorderRadius = 15;
            this.btnseven.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnseven.ShadowDecoration.Enabled = true;
            this.btnseven.Size = new System.Drawing.Size(61, 36);
            this.btnseven.TabIndex = 9;
            this.btnseven.Tag = "7";
            this.btnseven.Text = "7";
            this.btnseven.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.Transparent;
            this.btnequal.BorderRadius = 15;
            this.btnequal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnequal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnequal.FillColor = System.Drawing.Color.Black;
            this.btnequal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequal.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnequal.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnequal.Location = new System.Drawing.Point(211, 450);
            this.btnequal.Name = "btnequal";
            this.btnequal.ShadowDecoration.BorderRadius = 15;
            this.btnequal.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnequal.ShadowDecoration.Enabled = true;
            this.btnequal.Size = new System.Drawing.Size(128, 36);
            this.btnequal.TabIndex = 10;
            this.btnequal.Tag = "=";
            this.btnequal.Text = "=";
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.BorderRadius = 15;
            this.btnmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmin.FillColor = System.Drawing.Color.Black;
            this.btnmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnmin.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnmin.Location = new System.Drawing.Point(278, 397);
            this.btnmin.Name = "btnmin";
            this.btnmin.ShadowDecoration.BorderRadius = 15;
            this.btnmin.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnmin.ShadowDecoration.Enabled = true;
            this.btnmin.Size = new System.Drawing.Size(61, 36);
            this.btnmin.TabIndex = 11;
            this.btnmin.Tag = "-";
            this.btnmin.Text = "-";
            this.btnmin.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.Transparent;
            this.btnplus.BorderRadius = 15;
            this.btnplus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnplus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnplus.FillColor = System.Drawing.Color.Black;
            this.btnplus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnplus.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnplus.Location = new System.Drawing.Point(278, 344);
            this.btnplus.Name = "btnplus";
            this.btnplus.ShadowDecoration.BorderRadius = 15;
            this.btnplus.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnplus.ShadowDecoration.Enabled = true;
            this.btnplus.Size = new System.Drawing.Size(61, 36);
            this.btnplus.TabIndex = 12;
            this.btnplus.Tag = "+";
            this.btnplus.Text = "+";
            this.btnplus.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnmulti
            // 
            this.btnmulti.BackColor = System.Drawing.Color.Transparent;
            this.btnmulti.BorderRadius = 15;
            this.btnmulti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmulti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmulti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmulti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmulti.FillColor = System.Drawing.Color.Black;
            this.btnmulti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmulti.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnmulti.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnmulti.Location = new System.Drawing.Point(278, 293);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.ShadowDecoration.BorderRadius = 15;
            this.btnmulti.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnmulti.ShadowDecoration.Enabled = true;
            this.btnmulti.Size = new System.Drawing.Size(61, 36);
            this.btnmulti.TabIndex = 13;
            this.btnmulti.Tag = "*";
            this.btnmulti.Text = "*";
            this.btnmulti.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BorderRadius = 15;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.Black;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnclear.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnclear.Location = new System.Drawing.Point(59, 231);
            this.btnclear.Name = "btnclear";
            this.btnclear.ShadowDecoration.BorderRadius = 15;
            this.btnclear.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnclear.ShadowDecoration.Enabled = true;
            this.btnclear.Size = new System.Drawing.Size(139, 36);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "C";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btntwo
            // 
            this.btntwo.BackColor = System.Drawing.Color.Transparent;
            this.btntwo.BorderRadius = 15;
            this.btntwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntwo.FillColor = System.Drawing.Color.Black;
            this.btntwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntwo.ForeColor = System.Drawing.Color.Fuchsia;
            this.btntwo.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btntwo.Location = new System.Drawing.Point(137, 397);
            this.btntwo.Name = "btntwo";
            this.btntwo.ShadowDecoration.BorderRadius = 15;
            this.btntwo.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btntwo.ShadowDecoration.Enabled = true;
            this.btntwo.Size = new System.Drawing.Size(61, 36);
            this.btntwo.TabIndex = 15;
            this.btntwo.Tag = "2";
            this.btntwo.Text = "2";
            this.btntwo.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnthree
            // 
            this.btnthree.BackColor = System.Drawing.Color.Transparent;
            this.btnthree.BorderRadius = 15;
            this.btnthree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthree.FillColor = System.Drawing.Color.Black;
            this.btnthree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthree.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnthree.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnthree.Location = new System.Drawing.Point(211, 397);
            this.btnthree.Name = "btnthree";
            this.btnthree.ShadowDecoration.BorderRadius = 15;
            this.btnthree.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnthree.ShadowDecoration.Enabled = true;
            this.btnthree.Size = new System.Drawing.Size(61, 36);
            this.btnthree.TabIndex = 16;
            this.btnthree.Tag = "3";
            this.btnthree.Text = "3";
            this.btnthree.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.Transparent;
            this.btndot.BorderRadius = 15;
            this.btndot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndot.FillColor = System.Drawing.Color.Black;
            this.btndot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.ForeColor = System.Drawing.Color.Fuchsia;
            this.btndot.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btndot.Location = new System.Drawing.Point(137, 450);
            this.btndot.Name = "btndot";
            this.btndot.ShadowDecoration.BorderRadius = 15;
            this.btndot.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btndot.ShadowDecoration.Enabled = true;
            this.btndot.Size = new System.Drawing.Size(61, 36);
            this.btndot.TabIndex = 17;
            this.btndot.Tag = ".";
            this.btndot.Text = ".";
            this.btndot.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnzero
            // 
            this.btnzero.BackColor = System.Drawing.Color.Transparent;
            this.btnzero.BorderRadius = 15;
            this.btnzero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnzero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnzero.FillColor = System.Drawing.Color.Black;
            this.btnzero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnzero.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnzero.Location = new System.Drawing.Point(59, 450);
            this.btnzero.Name = "btnzero";
            this.btnzero.ShadowDecoration.BorderRadius = 15;
            this.btnzero.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnzero.ShadowDecoration.Enabled = true;
            this.btnzero.Size = new System.Drawing.Size(61, 36);
            this.btnzero.TabIndex = 18;
            this.btnzero.Tag = "0";
            this.btnzero.Text = "0";
            this.btnzero.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnsix
            // 
            this.btnsix.BackColor = System.Drawing.Color.Transparent;
            this.btnsix.BorderRadius = 15;
            this.btnsix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsix.FillColor = System.Drawing.Color.Black;
            this.btnsix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsix.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnsix.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnsix.Location = new System.Drawing.Point(211, 344);
            this.btnsix.Name = "btnsix";
            this.btnsix.ShadowDecoration.BorderRadius = 15;
            this.btnsix.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnsix.ShadowDecoration.Enabled = true;
            this.btnsix.Size = new System.Drawing.Size(61, 36);
            this.btnsix.TabIndex = 19;
            this.btnsix.Tag = "6";
            this.btnsix.Text = "6";
            this.btnsix.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // btnfive
            // 
            this.btnfive.BackColor = System.Drawing.Color.Transparent;
            this.btnfive.BorderRadius = 15;
            this.btnfive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfive.FillColor = System.Drawing.Color.Black;
            this.btnfive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfive.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnfive.HoverState.FillColor = System.Drawing.Color.Purple;
            this.btnfive.Location = new System.Drawing.Point(137, 344);
            this.btnfive.Name = "btnfive";
            this.btnfive.ShadowDecoration.BorderRadius = 15;
            this.btnfive.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.btnfive.ShadowDecoration.Enabled = true;
            this.btnfive.Size = new System.Drawing.Size(61, 36);
            this.btnfive.TabIndex = 20;
            this.btnfive.Tag = "5";
            this.btnfive.Text = "5";
            this.btnfive.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // txtstore
            // 
            this.txtstore.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.txtstore.BorderThickness = 0;
            this.txtstore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstore.DefaultText = "";
            this.txtstore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstore.FillColor = System.Drawing.Color.Black;
            this.txtstore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstore.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtstore.ForeColor = System.Drawing.Color.Silver;
            this.txtstore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstore.Location = new System.Drawing.Point(46, 88);
            this.txtstore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtstore.Name = "txtstore";
            this.txtstore.PasswordChar = '\0';
            this.txtstore.PlaceholderText = "";
            this.txtstore.SelectedText = "";
            this.txtstore.Size = new System.Drawing.Size(311, 47);
            this.txtstore.TabIndex = 21;
            this.txtstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtresult
            // 
            this.txtresult.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.txtresult.BorderThickness = 0;
            this.txtresult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresult.DefaultText = "";
            this.txtresult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtresult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtresult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresult.FillColor = System.Drawing.Color.Black;
            this.txtresult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresult.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtresult.ForeColor = System.Drawing.Color.White;
            this.txtresult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresult.Location = new System.Drawing.Point(46, 55);
            this.txtresult.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtresult.Name = "txtresult";
            this.txtresult.PasswordChar = '\0';
            this.txtresult.PlaceholderText = "0";
            this.txtresult.SelectedText = "";
            this.txtresult.Size = new System.Drawing.Size(322, 31);
            this.txtresult.TabIndex = 22;
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Purple;
            this.guna2Button1.Location = new System.Drawing.Point(204, 144);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 15;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(61, 36);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Tag = "cos";
            this.guna2Button1.Text = "cos";
            this.guna2Button1.Click += new System.EventHandler(this.calculatecos);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Fuchsia;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Purple;
            this.guna2Button2.Location = new System.Drawing.Point(59, 189);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.BorderRadius = 15;
            this.guna2Button2.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.guna2Button2.ShadowDecoration.Enabled = true;
            this.guna2Button2.Size = new System.Drawing.Size(61, 36);
            this.guna2Button2.TabIndex = 24;
            this.guna2Button2.Tag = "lg";
            this.guna2Button2.Text = "lg";
            this.guna2Button2.Click += new System.EventHandler(this.calculateLG);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Fuchsia;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Purple;
            this.guna2Button3.Location = new System.Drawing.Point(137, 189);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.BorderRadius = 15;
            this.guna2Button3.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.guna2Button3.ShadowDecoration.Enabled = true;
            this.guna2Button3.Size = new System.Drawing.Size(61, 36);
            this.guna2Button3.TabIndex = 25;
            this.guna2Button3.Tag = "ln(";
            this.guna2Button3.Text = "ln";
            this.guna2Button3.Click += new System.EventHandler(this.calculateLN);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 15;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Black;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Fuchsia;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.Purple;
            this.guna2Button4.Location = new System.Drawing.Point(204, 189);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.BorderRadius = 15;
            this.guna2Button4.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.guna2Button4.ShadowDecoration.Enabled = true;
            this.guna2Button4.Size = new System.Drawing.Size(61, 36);
            this.guna2Button4.TabIndex = 26;
            this.guna2Button4.Tag = "(";
            this.guna2Button4.Text = "(";
            this.guna2Button4.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 15;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Black;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.Fuchsia;
            this.guna2Button5.HoverState.FillColor = System.Drawing.Color.Purple;
            this.guna2Button5.Location = new System.Drawing.Point(278, 189);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.BorderRadius = 15;
            this.guna2Button5.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.guna2Button5.ShadowDecoration.Enabled = true;
            this.guna2Button5.Size = new System.Drawing.Size(61, 36);
            this.guna2Button5.TabIndex = 27;
            this.guna2Button5.Tag = ")";
            this.guna2Button5.Text = ")";
            this.guna2Button5.Click += new System.EventHandler(this.Guna2Button_click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.BorderRadius = 15;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.Black;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.Fuchsia;
            this.guna2Button7.HoverState.FillColor = System.Drawing.Color.Purple;
            this.guna2Button7.Location = new System.Drawing.Point(278, 144);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.BorderRadius = 15;
            this.guna2Button7.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.guna2Button7.ShadowDecoration.Enabled = true;
            this.guna2Button7.Size = new System.Drawing.Size(61, 36);
            this.guna2Button7.TabIndex = 29;
            this.guna2Button7.Tag = "tan";
            this.guna2Button7.Text = "tan";
            this.guna2Button7.Click += new System.EventHandler(this.calculateTAN);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button8.BorderRadius = 15;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.Black;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.Fuchsia;
            this.guna2Button8.HoverState.FillColor = System.Drawing.Color.Purple;
            this.guna2Button8.Location = new System.Drawing.Point(137, 144);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.ShadowDecoration.BorderRadius = 15;
            this.guna2Button8.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.guna2Button8.ShadowDecoration.Enabled = true;
            this.guna2Button8.Size = new System.Drawing.Size(61, 36);
            this.guna2Button8.TabIndex = 30;
            this.guna2Button8.Tag = "sin";
            this.guna2Button8.Text = "sin";
            this.guna2Button8.Click += new System.EventHandler(this.calculateSIN);
            // 
            // guna2Button9
            // 
            this.guna2Button9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button9.BorderRadius = 15;
            this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button9.FillColor = System.Drawing.Color.Black;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button9.ForeColor = System.Drawing.Color.Fuchsia;
            this.guna2Button9.HoverState.FillColor = System.Drawing.Color.Purple;
            this.guna2Button9.Location = new System.Drawing.Point(59, 144);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.ShadowDecoration.BorderRadius = 15;
            this.guna2Button9.ShadowDecoration.Color = System.Drawing.Color.Purple;
            this.guna2Button9.ShadowDecoration.Enabled = true;
            this.guna2Button9.Size = new System.Drawing.Size(61, 36);
            this.guna2Button9.TabIndex = 31;
            this.guna2Button9.Tag = "1/x";
            this.guna2Button9.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(436, 511);
            this.Controls.Add(this.guna2Button9);
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtstore);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btnrd);
            this.Controls.Add(this.btndevide);
            this.Controls.Add(this.lbCalc);
            this.Controls.Add(this.btnExt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox btnExt;
        private System.Windows.Forms.Label lbCalc;
        private Guna.UI2.WinForms.Guna2Button btndevide;
        private Guna.UI2.WinForms.Guna2Button btnrd;
        private Guna.UI2.WinForms.Guna2Button btnnine;
        private Guna.UI2.WinForms.Guna2Button btnone;
        private Guna.UI2.WinForms.Guna2Button btnfour;
        private Guna.UI2.WinForms.Guna2Button btneight;
        private Guna.UI2.WinForms.Guna2Button btnseven;
        private Guna.UI2.WinForms.Guna2Button btnequal;
        private Guna.UI2.WinForms.Guna2Button btnmin;
        private Guna.UI2.WinForms.Guna2Button btnplus;
        private Guna.UI2.WinForms.Guna2Button btnmulti;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btntwo;
        private Guna.UI2.WinForms.Guna2Button btnthree;
        private Guna.UI2.WinForms.Guna2Button btndot;
        private Guna.UI2.WinForms.Guna2Button btnzero;
        private Guna.UI2.WinForms.Guna2Button btnsix;
        private Guna.UI2.WinForms.Guna2Button btnfive;
        private Guna.UI2.WinForms.Guna2TextBox txtstore;
        private Guna.UI2.WinForms.Guna2TextBox txtresult;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
    }
}

