using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FontAwesome;


namespace anigamer_app
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Game_search_Button1 = new FontAwesome.Sharp.IconButton();
            this.panelLOGO = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.title_condition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Output_Box = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Web_Search_Button1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.web_input = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.page_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pre_page_button = new FontAwesome.Sharp.IconButton();
            this.next_page_button = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.title_keyword = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.Game_search_Button1);
            this.panelMenu.Controls.Add(this.panelLOGO);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 584);
            this.panelMenu.TabIndex = 0;
            // 
            // Game_search_Button1
            // 
            this.Game_search_Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Game_search_Button1.FlatAppearance.BorderSize = 0;
            this.Game_search_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Game_search_Button1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game_search_Button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.Game_search_Button1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.Game_search_Button1.IconColor = System.Drawing.Color.White;
            this.Game_search_Button1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Game_search_Button1.IconSize = 32;
            this.Game_search_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Game_search_Button1.Location = new System.Drawing.Point(0, 63);
            this.Game_search_Button1.Name = "Game_search_Button1";
            this.Game_search_Button1.Size = new System.Drawing.Size(220, 60);
            this.Game_search_Button1.TabIndex = 0;
            this.Game_search_Button1.Text = "巴哈姆特攻略搜尋";
            this.Game_search_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Game_search_Button1.UseVisualStyleBackColor = true;
            this.Game_search_Button1.Click += new System.EventHandler(this.Game_search_Button1_Click);
            // 
            // panelLOGO
            // 
            this.panelLOGO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLOGO.Location = new System.Drawing.Point(0, 0);
            this.panelLOGO.Name = "panelLOGO";
            this.panelLOGO.Size = new System.Drawing.Size(220, 63);
            this.panelLOGO.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.title_condition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Web_Search_Button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.web_input);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 584);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(138, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "主題類別";
            // 
            // title_condition
            // 
            this.title_condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.title_condition.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.title_condition.FormattingEnabled = true;
            this.title_condition.Items.AddRange(new object[] {
            "",
            "【公告】",
            "【閒聊】",
            "【討論】",
            "【情報】",
            "【問題】"});
            this.title_condition.Location = new System.Drawing.Point(218, 111);
            this.title_condition.Name = "title_condition";
            this.title_condition.Size = new System.Drawing.Size(92, 29);
            this.title_condition.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "進階搜尋:";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.Output_Box);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 410);
            this.panel2.TabIndex = 5;
            // 
            // Output_Box
            // 
            this.Output_Box.ActiveLinkColor = System.Drawing.Color.Brown;
            this.Output_Box.AutoSize = true;
            this.Output_Box.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_Box.ForeColor = System.Drawing.Color.White;
            this.Output_Box.LinkColor = System.Drawing.Color.White;
            this.Output_Box.Location = new System.Drawing.Point(27, 24);
            this.Output_Box.Name = "Output_Box";
            this.Output_Box.Size = new System.Drawing.Size(0, 25);
            this.Output_Box.TabIndex = 5;
            this.Output_Box.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Output_Box_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "請輸入欲搜尋之巴哈姆特哈拉版的網址";
            // 
            // Web_Search_Button1
            // 
            this.Web_Search_Button1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Web_Search_Button1.IconColor = System.Drawing.Color.Black;
            this.Web_Search_Button1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Web_Search_Button1.IconSize = 24;
            this.Web_Search_Button1.Location = new System.Drawing.Point(771, 48);
            this.Web_Search_Button1.Name = "Web_Search_Button1";
            this.Web_Search_Button1.Size = new System.Drawing.Size(75, 28);
            this.Web_Search_Button1.TabIndex = 2;
            this.Web_Search_Button1.UseVisualStyleBackColor = true;
            this.Web_Search_Button1.Click += new System.EventHandler(this.Web_Search_Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "網站輸入:";
            // 
            // web_input
            // 
            this.web_input.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.web_input.Location = new System.Drawing.Point(108, 48);
            this.web_input.Name = "web_input";
            this.web_input.Size = new System.Drawing.Size(645, 29);
            this.web_input.TabIndex = 0;
            this.web_input.Text = "https://forum.gamer.com.tw/B.php?bsn=37505";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.page_box);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pre_page_button);
            this.panel3.Controls.Add(this.next_page_button);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.title_keyword);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 171);
            this.panel3.TabIndex = 12;
            // 
            // page_box
            // 
            this.page_box.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.page_box.Location = new System.Drawing.Point(614, 111);
            this.page_box.Name = "page_box";
            this.page_box.Size = new System.Drawing.Size(35, 29);
            this.page_box.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(645, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "頁";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(561, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "跳到第";
            // 
            // pre_page_button
            // 
            this.pre_page_button.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.pre_page_button.IconColor = System.Drawing.Color.Black;
            this.pre_page_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pre_page_button.IconSize = 24;
            this.pre_page_button.Location = new System.Drawing.Point(794, 143);
            this.pre_page_button.Name = "pre_page_button";
            this.pre_page_button.Size = new System.Drawing.Size(39, 28);
            this.pre_page_button.TabIndex = 13;
            this.pre_page_button.UseVisualStyleBackColor = true;
            this.pre_page_button.Click += new System.EventHandler(this.pre_page_button_Click);
            // 
            // next_page_button
            // 
            this.next_page_button.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.next_page_button.IconColor = System.Drawing.Color.Black;
            this.next_page_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.next_page_button.IconSize = 24;
            this.next_page_button.Location = new System.Drawing.Point(839, 143);
            this.next_page_button.Name = "next_page_button";
            this.next_page_button.Size = new System.Drawing.Size(39, 28);
            this.next_page_button.TabIndex = 12;
            this.next_page_button.UseVisualStyleBackColor = true;
            this.next_page_button.Click += new System.EventHandler(this.next_page_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(330, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "主題關鍵字";
            // 
            // title_keyword
            // 
            this.title_keyword.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.title_keyword.Location = new System.Drawing.Point(426, 111);
            this.title_keyword.Name = "title_keyword";
            this.title_keyword.Size = new System.Drawing.Size(100, 29);
            this.title_keyword.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1129, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Game_search_Button1;
        private System.Windows.Forms.Panel panelLOGO;
        private Panel panel1;
        private Label label2;
        private FontAwesome.Sharp.IconButton Web_Search_Button1;
        private Label label1;
        private TextBox web_input;
        private Panel panel2;
        private ComboBox title_condition;
        private Label label3;
        private TextBox title_keyword;
        private Label label5;
        private Label label4;
        private LinkLabel Output_Box;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton next_page_button;
        private FontAwesome.Sharp.IconButton pre_page_button;
        private TextBox page_box;
        private Label label7;
        private Label label6;
    }
}

