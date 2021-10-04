
namespace LW_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.mtbTimeValue = new System.Windows.Forms.MaskedTextBox();
            this.mtbRopeTimeValue = new System.Windows.Forms.MaskedTextBox();
            this.mtbWoodTimeValue = new System.Windows.Forms.MaskedTextBox();
            this.mtbSectionsValue = new System.Windows.Forms.MaskedTextBox();
            this.mtbRopeValue = new System.Windows.Forms.MaskedTextBox();
            this.mtbWoodValue = new System.Windows.Forms.MaskedTextBox();
            this.buttonTerminate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.mtbTimeValue);
            this.groupBox1.Controls.Add(this.mtbRopeTimeValue);
            this.groupBox1.Controls.Add(this.mtbWoodTimeValue);
            this.groupBox1.Controls.Add(this.mtbSectionsValue);
            this.groupBox1.Controls.Add(this.mtbRopeValue);
            this.groupBox1.Controls.Add(this.mtbWoodValue);
            this.groupBox1.Location = new System.Drawing.Point(104, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Время сборки (с)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(193, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "t(c) веревок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "t(c) досок";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Объем секций";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(193, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во веревок";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кол-во досок";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(193, 150);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(141, 89);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Поехали";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // mtbTimeValue
            // 
            this.mtbTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbTimeValue.Location = new System.Drawing.Point(6, 209);
            this.mtbTimeValue.Mask = "000";
            this.mtbTimeValue.Name = "mtbTimeValue";
            this.mtbTimeValue.Size = new System.Drawing.Size(141, 30);
            this.mtbTimeValue.TabIndex = 1;
            this.mtbTimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbRopeTimeValue
            // 
            this.mtbRopeTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbRopeTimeValue.Location = new System.Drawing.Point(193, 80);
            this.mtbRopeTimeValue.Mask = "000";
            this.mtbRopeTimeValue.Name = "mtbRopeTimeValue";
            this.mtbRopeTimeValue.Size = new System.Drawing.Size(141, 30);
            this.mtbRopeTimeValue.TabIndex = 1;
            this.mtbRopeTimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbWoodTimeValue
            // 
            this.mtbWoodTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbWoodTimeValue.Location = new System.Drawing.Point(6, 80);
            this.mtbWoodTimeValue.Mask = "000";
            this.mtbWoodTimeValue.Name = "mtbWoodTimeValue";
            this.mtbWoodTimeValue.Size = new System.Drawing.Size(141, 30);
            this.mtbWoodTimeValue.TabIndex = 1;
            this.mtbWoodTimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbSectionsValue
            // 
            this.mtbSectionsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbSectionsValue.Location = new System.Drawing.Point(6, 150);
            this.mtbSectionsValue.Mask = "000";
            this.mtbSectionsValue.Name = "mtbSectionsValue";
            this.mtbSectionsValue.Size = new System.Drawing.Size(141, 30);
            this.mtbSectionsValue.TabIndex = 0;
            this.mtbSectionsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbRopeValue
            // 
            this.mtbRopeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbRopeValue.Location = new System.Drawing.Point(193, 21);
            this.mtbRopeValue.Mask = "000";
            this.mtbRopeValue.Name = "mtbRopeValue";
            this.mtbRopeValue.Size = new System.Drawing.Size(141, 30);
            this.mtbRopeValue.TabIndex = 0;
            this.mtbRopeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbWoodValue
            // 
            this.mtbWoodValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbWoodValue.Location = new System.Drawing.Point(6, 21);
            this.mtbWoodValue.Mask = "000";
            this.mtbWoodValue.Name = "mtbWoodValue";
            this.mtbWoodValue.Size = new System.Drawing.Size(141, 30);
            this.mtbWoodValue.TabIndex = 0;
            this.mtbWoodValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonTerminate
            // 
            this.buttonTerminate.Enabled = false;
            this.buttonTerminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTerminate.Location = new System.Drawing.Point(104, 445);
            this.buttonTerminate.Name = "buttonTerminate";
            this.buttonTerminate.Size = new System.Drawing.Size(351, 31);
            this.buttonTerminate.TabIndex = 3;
            this.buttonTerminate.Text = "Прервать";
            this.buttonTerminate.UseVisualStyleBackColor = true;
            this.buttonTerminate.Click += new System.EventHandler(this.buttonTerminate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTerminate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.MaskedTextBox mtbWoodTimeValue;
        private System.Windows.Forms.MaskedTextBox mtbWoodValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTerminate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbTimeValue;
        private System.Windows.Forms.MaskedTextBox mtbRopeTimeValue;
        private System.Windows.Forms.MaskedTextBox mtbSectionsValue;
        private System.Windows.Forms.MaskedTextBox mtbRopeValue;
    }
}

