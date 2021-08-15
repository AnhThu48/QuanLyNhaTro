using System.Windows.Forms;

namespace QLNT.HeThongGiaoDien
{
    partial class TinhTrangPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Nhap = new System.Windows.Forms.TextBox();
            this.ptb_Search = new System.Windows.Forms.PictureBox();
            this.lb_TTPhong = new System.Windows.Forms.Label();
            this.lb_NhapMa = new System.Windows.Forms.Label();
            this.dgv_DSPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nhap
            // 
            this.txt_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nhap.Location = new System.Drawing.Point(255, 91);
            this.txt_Nhap.Name = "txt_Nhap";
            this.txt_Nhap.Size = new System.Drawing.Size(545, 35);
            this.txt_Nhap.TabIndex = 0;
            // 
            // ptb_Search
            // 
            this.ptb_Search.Image = global::QLNT.Properties.Resources.icon_search;
            this.ptb_Search.Location = new System.Drawing.Point(809, 91);
            this.ptb_Search.Name = "ptb_Search";
            this.ptb_Search.Size = new System.Drawing.Size(35, 35);
            this.ptb_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Search.TabIndex = 1;
            this.ptb_Search.TabStop = false;
            // 
            // lb_TTPhong
            // 
            this.lb_TTPhong.AutoSize = true;
            this.lb_TTPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(199)))));
            this.lb_TTPhong.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TTPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lb_TTPhong.Location = new System.Drawing.Point(258, 27);
            this.lb_TTPhong.Name = "lb_TTPhong";
            this.lb_TTPhong.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.lb_TTPhong.Size = new System.Drawing.Size(408, 34);
            this.lb_TTPhong.TabIndex = 2;
            this.lb_TTPhong.Text = "TÌNH TRẠNG PHÒNG";
            // 
            // lb_NhapMa
            // 
            this.lb_NhapMa.AutoSize = true;
            this.lb_NhapMa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NhapMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lb_NhapMa.Location = new System.Drawing.Point(38, 97);
            this.lb_NhapMa.Name = "lb_NhapMa";
            this.lb_NhapMa.Size = new System.Drawing.Size(211, 29);
            this.lb_NhapMa.TabIndex = 3;
            this.lb_NhapMa.Text = "Nhập mã phòng:";
            // 
            // dgv_DSPhong
            // 
            this.dgv_DSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSPhong.Location = new System.Drawing.Point(29, 194);
            this.dgv_DSPhong.Name = "dgv_DSPhong";
            this.dgv_DSPhong.RowHeadersWidth = 62;
            this.dgv_DSPhong.RowTemplate.Height = 28;
            this.dgv_DSPhong.Size = new System.Drawing.Size(903, 470);
            this.dgv_DSPhong.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(24, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH PHÒNG";
            // 
            // TinhTrangPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DSPhong);
            this.Controls.Add(this.lb_NhapMa);
            this.Controls.Add(this.lb_TTPhong);
            this.Controls.Add(this.ptb_Search);
            this.Controls.Add(this.txt_Nhap);
            this.Name = "TinhTrangPhong";
            this.Size = new System.Drawing.Size(955, 688);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private TextBox txt_Nhap;
        private PictureBox ptb_Search;
        private Label lb_TTPhong;
        private Label lb_NhapMa;
        private DataGridView dgv_DSPhong;
        private Label label1;
    }
}
