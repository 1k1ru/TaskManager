namespace TaskManagerUI
{
    partial class TaskManagerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartExec = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_setup = new System.Windows.Forms.Button();
            this.button_exec = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.chartWait = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartExec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWait)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartExec
            // 
            chartArea5.AxisY.Title = "time";
            chartArea5.Name = "chartArea";
            this.chartExec.ChartAreas.Add(chartArea5);
            legend5.Name = "legend";
            this.chartExec.Legends.Add(legend5);
            this.chartExec.Location = new System.Drawing.Point(9, 31);
            this.chartExec.Margin = new System.Windows.Forms.Padding(6);
            this.chartExec.Name = "chartExec";
            this.chartExec.Size = new System.Drawing.Size(859, 135);
            this.chartExec.TabIndex = 0;
            this.chartExec.Text = "In progress";
            // 
            // button_setup
            // 
            this.button_setup.Location = new System.Drawing.Point(615, 452);
            this.button_setup.Margin = new System.Windows.Forms.Padding(6);
            this.button_setup.Name = "button_setup";
            this.button_setup.Size = new System.Drawing.Size(131, 57);
            this.button_setup.TabIndex = 1;
            this.button_setup.Text = "Setup";
            this.button_setup.UseVisualStyleBackColor = true;
            this.button_setup.Click += new System.EventHandler(this.button_setup_Click);
            // 
            // button_exec
            // 
            this.button_exec.Location = new System.Drawing.Point(758, 452);
            this.button_exec.Margin = new System.Windows.Forms.Padding(6);
            this.button_exec.Name = "button_exec";
            this.button_exec.Size = new System.Drawing.Size(131, 57);
            this.button_exec.TabIndex = 2;
            this.button_exec.Text = "Execute";
            this.button_exec.UseVisualStyleBackColor = true;
            this.button_exec.Click += new System.EventHandler(this.button_exec_Click);
            // 
            // test
            // 
            this.test.Enabled = false;
            this.test.Location = new System.Drawing.Point(510, 460);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(96, 40);
            this.test.TabIndex = 3;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // chartWait
            // 
            chartArea6.Name = "chartArea";
            this.chartWait.ChartAreas.Add(chartArea6);
            legend6.Name = "legend";
            this.chartWait.Legends.Add(legend6);
            this.chartWait.Location = new System.Drawing.Point(9, 31);
            this.chartWait.Margin = new System.Windows.Forms.Padding(6);
            this.chartWait.Name = "chartWait";
            this.chartWait.Size = new System.Drawing.Size(859, 210);
            this.chartWait.TabIndex = 4;
            this.chartWait.Text = "Ready";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartExec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 175);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In progress";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartWait);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 250);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ready";
            // 
            // TaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button_exec);
            this.Controls.Add(this.button_setup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(920, 563);
            this.MinimumSize = new System.Drawing.Size(920, 563);
            this.Name = "TaskManagerForm";
            this.Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)(this.chartExec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWait)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartExec;
        private System.Windows.Forms.Button button_setup;
        private System.Windows.Forms.Button button_exec;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWait;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

