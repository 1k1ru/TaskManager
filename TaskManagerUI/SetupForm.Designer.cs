namespace TaskManagerUI
{
    partial class SetupForm
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
            this.taskList = new System.Windows.Forms.ListBox();
            this.priorityUpdateCoef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.TextBox();
            this.basePriority = new System.Windows.Forms.TextBox();
            this.launchTime = new System.Windows.Forms.TextBox();
            this.execTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeTask = new System.Windows.Forms.Button();
            this.addTask = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_priorityUpdateInterval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_globalExecTime = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskList
            // 
            this.taskList.FormattingEnabled = true;
            this.taskList.ItemHeight = 24;
            this.taskList.Location = new System.Drawing.Point(9, 31);
            this.taskList.Margin = new System.Windows.Forms.Padding(6);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(282, 268);
            this.taskList.TabIndex = 8;
            // 
            // priorityUpdateCoef
            // 
            this.priorityUpdateCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityUpdateCoef.Location = new System.Drawing.Point(247, 218);
            this.priorityUpdateCoef.Margin = new System.Windows.Forms.Padding(6);
            this.priorityUpdateCoef.Name = "priorityUpdateCoef";
            this.priorityUpdateCoef.Size = new System.Drawing.Size(162, 29);
            this.priorityUpdateCoef.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.basePriority);
            this.groupBox1.Controls.Add(this.launchTime);
            this.groupBox1.Controls.Add(this.execTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.priorityUpdateCoef);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(421, 272);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Settings";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(247, 31);
            this.name.Margin = new System.Windows.Forms.Padding(6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(162, 29);
            this.name.TabIndex = 1;
            // 
            // basePriority
            // 
            this.basePriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basePriority.Location = new System.Drawing.Point(247, 77);
            this.basePriority.Margin = new System.Windows.Forms.Padding(6);
            this.basePriority.Name = "basePriority";
            this.basePriority.Size = new System.Drawing.Size(162, 29);
            this.basePriority.TabIndex = 2;
            // 
            // launchTime
            // 
            this.launchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.launchTime.Location = new System.Drawing.Point(247, 122);
            this.launchTime.Margin = new System.Windows.Forms.Padding(6);
            this.launchTime.Name = "launchTime";
            this.launchTime.Size = new System.Drawing.Size(162, 29);
            this.launchTime.TabIndex = 3;
            // 
            // execTime
            // 
            this.execTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.execTime.Location = new System.Drawing.Point(247, 169);
            this.execTime.Margin = new System.Windows.Forms.Padding(6);
            this.execTime.Name = "execTime";
            this.execTime.Size = new System.Drawing.Size(162, 29);
            this.execTime.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Priority update coefficient:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(95, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Execution time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(117, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Launch time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(118, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base priority:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeTask);
            this.groupBox2.Controls.Add(this.addTask);
            this.groupBox2.Controls.Add(this.taskList);
            this.groupBox2.Location = new System.Drawing.Point(448, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(303, 362);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tasks";
            // 
            // removeTask
            // 
            this.removeTask.Location = new System.Drawing.Point(160, 306);
            this.removeTask.Name = "removeTask";
            this.removeTask.Size = new System.Drawing.Size(134, 44);
            this.removeTask.TabIndex = 10;
            this.removeTask.Text = "Remove";
            this.removeTask.UseVisualStyleBackColor = true;
            this.removeTask.Click += new System.EventHandler(this.removeTask_Click);
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(9, 306);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(134, 44);
            this.addTask.TabIndex = 9;
            this.addTask.Text = "Add";
            this.addTask.UseVisualStyleBackColor = true;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_priorityUpdateInterval);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tb_globalExecTime);
            this.groupBox3.Location = new System.Drawing.Point(15, 299);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(421, 154);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Global Settings";
            // 
            // tb_priorityUpdateInterval
            // 
            this.tb_priorityUpdateInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_priorityUpdateInterval.Location = new System.Drawing.Point(223, 98);
            this.tb_priorityUpdateInterval.Margin = new System.Windows.Forms.Padding(6);
            this.tb_priorityUpdateInterval.Name = "tb_priorityUpdateInterval";
            this.tb_priorityUpdateInterval.Size = new System.Drawing.Size(181, 29);
            this.tb_priorityUpdateInterval.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Priority update interval:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(71, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Execution time:";
            // 
            // tb_globalExecTime
            // 
            this.tb_globalExecTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_globalExecTime.Location = new System.Drawing.Point(223, 39);
            this.tb_globalExecTime.Margin = new System.Windows.Forms.Padding(6);
            this.tb_globalExecTime.Name = "tb_globalExecTime";
            this.tb_globalExecTime.Size = new System.Drawing.Size(181, 29);
            this.tb_globalExecTime.TabIndex = 6;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(608, 397);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(134, 44);
            this.apply.TabIndex = 12;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(457, 397);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 44);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 467);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(765, 467);
            this.MinimumSize = new System.Drawing.Size(765, 467);
            this.Name = "SetupForm";
            this.Text = "SetupForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SetupForm_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.TextBox priorityUpdateCoef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeTask;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_globalExecTime;
        private System.Windows.Forms.TextBox tb_priorityUpdateInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox basePriority;
        private System.Windows.Forms.TextBox launchTime;
        private System.Windows.Forms.TextBox execTime;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button cancel;
    }
}