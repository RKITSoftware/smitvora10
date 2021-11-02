
namespace serialization_example
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtCollege = new System.Windows.Forms.TextBox();
            this.lblCollege = new System.Windows.Forms.Label();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(131, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name : ";
            this.lblName.Click += new System.EventHandler(this.Name_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(276, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(276, 148);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(125, 27);
            this.txtDepartment.TabIndex = 5;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(146, 151);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(100, 20);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "Department : ";
            this.lblDepartment.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCollege
            // 
            this.txtCollege.Location = new System.Drawing.Point(276, 203);
            this.txtCollege.Name = "txtCollege";
            this.txtCollege.Size = new System.Drawing.Size(125, 27);
            this.txtCollege.TabIndex = 7;
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Location = new System.Drawing.Point(175, 203);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(71, 20);
            this.lblCollege.TabIndex = 6;
            this.lblCollege.Text = "College : ";
            this.lblCollege.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(175, 332);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(94, 29);
            this.btnSerialize.TabIndex = 8;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(307, 332);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(94, 29);
            this.btnDeserialize.TabIndex = 9;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(175, 403);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.txtCollege);
            this.Controls.Add(this.lblCollege);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtCollege;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Label lblStatus;
    }
}

