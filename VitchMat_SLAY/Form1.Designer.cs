
namespace VitchMat_SLAY
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.t_raz = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.Xmax = new System.Windows.Forms.DataGridView();
            this.Xlabel = new DarkUI.Controls.DarkLabel();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.t_e = new DarkUI.Controls.DarkTextBox();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.Y0 = new System.Windows.Forms.DataGridView();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.l_k = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.Lmax = new DarkUI.Controls.DarkLabel();
            this.Lmin = new DarkUI.Controls.DarkLabel();
            this.darkLabel8 = new DarkUI.Controls.DarkLabel();
            this.Xlabelmin = new DarkUI.Controls.DarkLabel();
            this.Xmin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xmin)).BeginInit();
            this.SuspendLayout();
            // 
            // t_raz
            // 
            this.t_raz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.t_raz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_raz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_raz.Location = new System.Drawing.Point(96, 16);
            this.t_raz.Name = "t_raz";
            this.t_raz.Size = new System.Drawing.Size(51, 20);
            this.t_raz.TabIndex = 0;
            this.t_raz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_raz_KeyPress);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(12, 18);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(78, 13);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Размерность:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 203);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(391, 13);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(94, 23);
            this.darkButton1.TabIndex = 50;
            this.darkButton1.Text = "Создать СЛАУ";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // Xmax
            // 
            this.Xmax.AllowUserToAddRows = false;
            this.Xmax.AllowUserToDeleteRows = false;
            this.Xmax.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Xmax.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Xmax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Xmax.ColumnHeadersVisible = false;
            this.Xmax.Location = new System.Drawing.Point(33, 255);
            this.Xmax.Margin = new System.Windows.Forms.Padding(2);
            this.Xmax.Name = "Xmax";
            this.Xmax.ReadOnly = true;
            this.Xmax.RowHeadersVisible = false;
            this.Xmax.RowHeadersWidth = 51;
            this.Xmax.RowTemplate.Height = 24;
            this.Xmax.Size = new System.Drawing.Size(73, 203);
            this.Xmax.TabIndex = 51;
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Xlabel.Location = new System.Drawing.Point(12, 255);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(17, 13);
            this.Xlabel.TabIndex = 54;
            this.Xlabel.Text = "X:";
            // 
            // darkButton2
            // 
            this.darkButton2.Enabled = false;
            this.darkButton2.Location = new System.Drawing.Point(383, 283);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(102, 23);
            this.darkButton2.TabIndex = 55;
            this.darkButton2.Text = "Степеной метод";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click_1);
            // 
            // t_e
            // 
            this.t_e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.t_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_e.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_e.Location = new System.Drawing.Point(264, 16);
            this.t_e.Name = "t_e";
            this.t_e.Size = new System.Drawing.Size(51, 20);
            this.t_e.TabIndex = 62;
            this.t_e.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_e_KeyPress);
            // 
            // darkLabel6
            // 
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(159, 18);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(105, 13);
            this.darkLabel6.TabIndex = 63;
            this.darkLabel6.Text = "Погрешность e = 0,";
            // 
            // Y0
            // 
            this.Y0.AllowUserToAddRows = false;
            this.Y0.AllowUserToDeleteRows = false;
            this.Y0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Y0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Y0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Y0.ColumnHeadersVisible = false;
            this.Y0.Location = new System.Drawing.Point(508, 41);
            this.Y0.Margin = new System.Windows.Forms.Padding(2);
            this.Y0.Name = "Y0";
            this.Y0.RowHeadersVisible = false;
            this.Y0.RowHeadersWidth = 51;
            this.Y0.RowTemplate.Height = 24;
            this.Y0.Size = new System.Drawing.Size(73, 203);
            this.Y0.TabIndex = 65;
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(505, 18);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(23, 13);
            this.darkLabel4.TabIndex = 68;
            this.darkLabel4.Text = "Y0:";
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(380, 255);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(94, 13);
            this.darkLabel5.TabIndex = 70;
            this.darkLabel5.Text = "Число Итераций:";
            // 
            // l_k
            // 
            this.l_k.AutoSize = true;
            this.l_k.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.l_k.Location = new System.Drawing.Point(480, 255);
            this.l_k.Name = "l_k";
            this.l_k.Size = new System.Drawing.Size(10, 13);
            this.l_k.TabIndex = 71;
            this.l_k.Text = "-";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(137, 255);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(25, 13);
            this.darkLabel2.TabIndex = 72;
            this.darkLabel2.Text = "L = ";
            // 
            // Lmax
            // 
            this.Lmax.AutoSize = true;
            this.Lmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Lmax.Location = new System.Drawing.Point(159, 255);
            this.Lmax.Name = "Lmax";
            this.Lmax.Size = new System.Drawing.Size(13, 13);
            this.Lmax.TabIndex = 73;
            this.Lmax.Text = "0";
            // 
            // Lmin
            // 
            this.Lmin.AutoSize = true;
            this.Lmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Lmin.Location = new System.Drawing.Point(333, 255);
            this.Lmin.Name = "Lmin";
            this.Lmin.Size = new System.Drawing.Size(13, 13);
            this.Lmin.TabIndex = 77;
            this.Lmin.Text = "0";
            // 
            // darkLabel8
            // 
            this.darkLabel8.AutoSize = true;
            this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel8.Location = new System.Drawing.Point(311, 255);
            this.darkLabel8.Name = "darkLabel8";
            this.darkLabel8.Size = new System.Drawing.Size(25, 13);
            this.darkLabel8.TabIndex = 76;
            this.darkLabel8.Text = "L = ";
            // 
            // Xlabelmin
            // 
            this.Xlabelmin.AutoSize = true;
            this.Xlabelmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Xlabelmin.Location = new System.Drawing.Point(186, 255);
            this.Xlabelmin.Name = "Xlabelmin";
            this.Xlabelmin.Size = new System.Drawing.Size(17, 13);
            this.Xlabelmin.TabIndex = 75;
            this.Xlabelmin.Text = "X:";
            // 
            // Xmin
            // 
            this.Xmin.AllowUserToAddRows = false;
            this.Xmin.AllowUserToDeleteRows = false;
            this.Xmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Xmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Xmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Xmin.ColumnHeadersVisible = false;
            this.Xmin.Location = new System.Drawing.Point(207, 255);
            this.Xmin.Margin = new System.Windows.Forms.Padding(2);
            this.Xmin.Name = "Xmin";
            this.Xmin.ReadOnly = true;
            this.Xmin.RowHeadersVisible = false;
            this.Xmin.RowHeadersWidth = 51;
            this.Xmin.RowTemplate.Height = 24;
            this.Xmin.Size = new System.Drawing.Size(73, 203);
            this.Xmin.TabIndex = 74;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 471);
            this.Controls.Add(this.Lmin);
            this.Controls.Add(this.darkLabel8);
            this.Controls.Add(this.Xlabelmin);
            this.Controls.Add(this.Xmin);
            this.Controls.Add(this.Lmax);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.l_k);
            this.Controls.Add(this.darkLabel5);
            this.Controls.Add(this.darkLabel4);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.darkLabel6);
            this.Controls.Add(this.t_e);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.Xlabel);
            this.Controls.Add(this.Xmax);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.t_raz);
            this.Name = "Form1";
            this.Text = "Решение СЛАУ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTextBox t_raz;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DarkUI.Controls.DarkButton darkButton1;
        private System.Windows.Forms.DataGridView Xmax;
        private DarkUI.Controls.DarkLabel Xlabel;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkTextBox t_e;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private System.Windows.Forms.DataGridView Y0;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkLabel l_k;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel Lmax;
        private DarkUI.Controls.DarkLabel Lmin;
        private DarkUI.Controls.DarkLabel darkLabel8;
        private DarkUI.Controls.DarkLabel Xlabelmin;
        private System.Windows.Forms.DataGridView Xmin;
    }
}

