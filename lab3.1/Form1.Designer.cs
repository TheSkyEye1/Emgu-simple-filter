namespace lab3._1
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
            this.components = new System.ComponentModel.Container();
            this.IMG1 = new Emgu.CV.UI.ImageBox();
            this.IMG2 = new Emgu.CV.UI.ImageBox();
            this.loadbutton = new System.Windows.Forms.Button();
            this.filterbutton = new System.Windows.Forms.Button();
            this.tr1 = new System.Windows.Forms.TrackBar();
            this.tr2 = new System.Windows.Forms.TrackBar();
            this.filter2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carfilter = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wcbutton = new System.Windows.Forms.Button();
            this.foff = new System.Windows.Forms.Button();
            this.vloadbutton = new System.Windows.Forms.Button();
            this.vtimer = new System.Windows.Forms.Timer(this.components);
            this.ptimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG1
            // 
            this.IMG1.Location = new System.Drawing.Point(12, 12);
            this.IMG1.Name = "IMG1";
            this.IMG1.Size = new System.Drawing.Size(640, 480);
            this.IMG1.TabIndex = 2;
            this.IMG1.TabStop = false;
            // 
            // IMG2
            // 
            this.IMG2.Location = new System.Drawing.Point(932, 9);
            this.IMG2.Name = "IMG2";
            this.IMG2.Size = new System.Drawing.Size(640, 480);
            this.IMG2.TabIndex = 3;
            this.IMG2.TabStop = false;
            // 
            // loadbutton
            // 
            this.loadbutton.AutoEllipsis = true;
            this.loadbutton.Location = new System.Drawing.Point(658, 12);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(268, 23);
            this.loadbutton.TabIndex = 4;
            this.loadbutton.Text = "Load Picture";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click_1);
            // 
            // filterbutton
            // 
            this.filterbutton.AutoEllipsis = true;
            this.filterbutton.Location = new System.Drawing.Point(658, 112);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(126, 23);
            this.filterbutton.TabIndex = 5;
            this.filterbutton.Text = "Gray Filter";
            this.filterbutton.UseVisualStyleBackColor = true;
            this.filterbutton.Click += new System.EventHandler(this.filterbutton_Click);
            // 
            // tr1
            // 
            this.tr1.Location = new System.Drawing.Point(658, 141);
            this.tr1.Maximum = 100;
            this.tr1.Minimum = 1;
            this.tr1.Name = "tr1";
            this.tr1.Size = new System.Drawing.Size(227, 45);
            this.tr1.TabIndex = 6;
            this.tr1.Value = 50;
            this.tr1.ValueChanged += new System.EventHandler(this.tr1_ValueChanged);
            // 
            // tr2
            // 
            this.tr2.Location = new System.Drawing.Point(658, 192);
            this.tr2.Maximum = 100;
            this.tr2.Minimum = 1;
            this.tr2.Name = "tr2";
            this.tr2.Size = new System.Drawing.Size(227, 45);
            this.tr2.TabIndex = 7;
            this.tr2.Value = 50;
            this.tr2.ValueChanged += new System.EventHandler(this.tr2_ValueChanged);
            // 
            // filter2
            // 
            this.filter2.AutoEllipsis = true;
            this.filter2.Location = new System.Drawing.Point(799, 112);
            this.filter2.Name = "filter2";
            this.filter2.Size = new System.Drawing.Size(127, 23);
            this.filter2.TabIndex = 8;
            this.filter2.Text = "Linear Filter";
            this.filter2.UseVisualStyleBackColor = true;
            this.filter2.Click += new System.EventHandler(this.filter2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(891, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(891, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "50";
            // 
            // carfilter
            // 
            this.carfilter.AutoEllipsis = true;
            this.carfilter.Location = new System.Drawing.Point(658, 243);
            this.carfilter.Name = "carfilter";
            this.carfilter.Size = new System.Drawing.Size(268, 23);
            this.carfilter.TabIndex = 11;
            this.carfilter.Text = "Cartoony Filter";
            this.carfilter.UseVisualStyleBackColor = true;
            this.carfilter.Click += new System.EventHandler(this.carfilter_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(658, 282);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(227, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(658, 323);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(227, 45);
            this.trackBar2.TabIndex = 13;
            this.trackBar2.Value = 50;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(658, 362);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(227, 45);
            this.trackBar3.TabIndex = 14;
            this.trackBar3.Value = 180;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(658, 404);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(227, 45);
            this.trackBar4.TabIndex = 15;
            this.trackBar4.Value = 210;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(891, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(891, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(891, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "180";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(891, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "210";
            // 
            // wcbutton
            // 
            this.wcbutton.AutoEllipsis = true;
            this.wcbutton.Location = new System.Drawing.Point(658, 70);
            this.wcbutton.Name = "wcbutton";
            this.wcbutton.Size = new System.Drawing.Size(268, 23);
            this.wcbutton.TabIndex = 20;
            this.wcbutton.Text = "Web Camera";
            this.wcbutton.UseVisualStyleBackColor = true;
            this.wcbutton.Click += new System.EventHandler(this.wcbutton_Click);
            // 
            // foff
            // 
            this.foff.AutoEllipsis = true;
            this.foff.Location = new System.Drawing.Point(658, 443);
            this.foff.Name = "foff";
            this.foff.Size = new System.Drawing.Size(268, 23);
            this.foff.TabIndex = 21;
            this.foff.Text = "Turn off filter";
            this.foff.UseVisualStyleBackColor = true;
            this.foff.Click += new System.EventHandler(this.foff_Click);
            // 
            // vloadbutton
            // 
            this.vloadbutton.AutoEllipsis = true;
            this.vloadbutton.Location = new System.Drawing.Point(658, 41);
            this.vloadbutton.Name = "vloadbutton";
            this.vloadbutton.Size = new System.Drawing.Size(268, 23);
            this.vloadbutton.TabIndex = 22;
            this.vloadbutton.Text = "Load Video";
            this.vloadbutton.UseVisualStyleBackColor = true;
            this.vloadbutton.Click += new System.EventHandler(this.vloadbutton_Click);
            // 
            // vtimer
            // 
            this.vtimer.Interval = 30;
            this.vtimer.Tick += new System.EventHandler(this.vtimer_Tick);
            // 
            // ptimer
            // 
            this.ptimer.Tick += new System.EventHandler(this.ptimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 501);
            this.Controls.Add(this.vloadbutton);
            this.Controls.Add(this.foff);
            this.Controls.Add(this.wcbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.carfilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filter2);
            this.Controls.Add(this.tr2);
            this.Controls.Add(this.tr1);
            this.Controls.Add(this.filterbutton);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.IMG2);
            this.Controls.Add(this.IMG1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox IMG1;
        private Emgu.CV.UI.ImageBox IMG2;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.Button filterbutton;
        private System.Windows.Forms.TrackBar tr1;
        private System.Windows.Forms.TrackBar tr2;
        private System.Windows.Forms.Button filter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button carfilter;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button wcbutton;
        private System.Windows.Forms.Button foff;
        private System.Windows.Forms.Button vloadbutton;
        private System.Windows.Forms.Timer vtimer;
        private System.Windows.Forms.Timer ptimer;
    }
}

