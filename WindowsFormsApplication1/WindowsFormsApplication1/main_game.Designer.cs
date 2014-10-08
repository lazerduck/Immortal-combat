namespace WindowsFormsApplication1
{
    partial class main_game
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c_in_d = new System.Windows.Forms.TextBox();
            this.c_left = new System.Windows.Forms.TextBox();
            this.other_cards = new System.Windows.Forms.TextBox();
            this.your_cards = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.curr_name = new System.Windows.Forms.TextBox();
            this.curr_smite = new System.Windows.Forms.TextBox();
            this.curr_defence = new System.Windows.Forms.TextBox();
            this.curr_followers = new System.Windows.Forms.TextBox();
            this.curr_cruelty = new System.Windows.Forms.TextBox();
            this.curr_forgiveness = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.smite_btn = new System.Windows.Forms.Button();
            this.defence_btn = new System.Windows.Forms.Button();
            this.followers_btn = new System.Windows.Forms.Button();
            this.cruelty_btn = new System.Windows.Forms.Button();
            this.forgiveness_btn = new System.Windows.Forms.Button();
            this.turn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.opponant = new System.Windows.Forms.Label();
            this.dice_btn = new System.Windows.Forms.Button();
            this.chance = new System.Windows.Forms.Button();
            this.other_cruelty_lbl = new System.Windows.Forms.Label();
            this.other_forgiveness_lbl = new System.Windows.Forms.Label();
            this.other_followers_lbl = new System.Windows.Forms.Label();
            this.other_defence_lbl = new System.Windows.Forms.Label();
            this.other_smite_lbl = new System.Windows.Forms.Label();
            this.other_name_lbl = new System.Windows.Forms.Label();
            this.other_forgiveness = new System.Windows.Forms.TextBox();
            this.other_cruelty = new System.Windows.Forms.TextBox();
            this.other_followers = new System.Windows.Forms.TextBox();
            this.other_defence = new System.Windows.Forms.TextBox();
            this.other_smite = new System.Windows.Forms.TextBox();
            this.other_name = new System.Windows.Forms.TextBox();
            this.player_box = new System.Windows.Forms.PictureBox();
            this.enemy_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cards in deck";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cards left over";
            // 
            // c_in_d
            // 
            this.c_in_d.Enabled = false;
            this.c_in_d.Location = new System.Drawing.Point(90, 6);
            this.c_in_d.Name = "c_in_d";
            this.c_in_d.Size = new System.Drawing.Size(25, 20);
            this.c_in_d.TabIndex = 2;
            // 
            // c_left
            // 
            this.c_left.Enabled = false;
            this.c_left.Location = new System.Drawing.Point(228, 6);
            this.c_left.Name = "c_left";
            this.c_left.Size = new System.Drawing.Size(25, 20);
            this.c_left.TabIndex = 3;
            // 
            // other_cards
            // 
            this.other_cards.Enabled = false;
            this.other_cards.Location = new System.Drawing.Point(735, 51);
            this.other_cards.Name = "other_cards";
            this.other_cards.Size = new System.Drawing.Size(25, 20);
            this.other_cards.TabIndex = 6;
            // 
            // your_cards
            // 
            this.your_cards.Enabled = false;
            this.your_cards.Location = new System.Drawing.Point(90, 51);
            this.your_cards.Name = "your_cards";
            this.your_cards.Size = new System.Drawing.Size(25, 20);
            this.your_cards.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "your cards";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "opponents cards";
            // 
            // curr_name
            // 
            this.curr_name.Enabled = false;
            this.curr_name.Location = new System.Drawing.Point(90, 190);
            this.curr_name.Name = "curr_name";
            this.curr_name.Size = new System.Drawing.Size(77, 20);
            this.curr_name.TabIndex = 10;
            // 
            // curr_smite
            // 
            this.curr_smite.Enabled = false;
            this.curr_smite.Location = new System.Drawing.Point(90, 216);
            this.curr_smite.Name = "curr_smite";
            this.curr_smite.Size = new System.Drawing.Size(25, 20);
            this.curr_smite.TabIndex = 11;
            // 
            // curr_defence
            // 
            this.curr_defence.Enabled = false;
            this.curr_defence.Location = new System.Drawing.Point(90, 242);
            this.curr_defence.Name = "curr_defence";
            this.curr_defence.Size = new System.Drawing.Size(25, 20);
            this.curr_defence.TabIndex = 12;
            // 
            // curr_followers
            // 
            this.curr_followers.Enabled = false;
            this.curr_followers.Location = new System.Drawing.Point(90, 268);
            this.curr_followers.Name = "curr_followers";
            this.curr_followers.Size = new System.Drawing.Size(25, 20);
            this.curr_followers.TabIndex = 13;
            // 
            // curr_cruelty
            // 
            this.curr_cruelty.Enabled = false;
            this.curr_cruelty.Location = new System.Drawing.Point(90, 294);
            this.curr_cruelty.Name = "curr_cruelty";
            this.curr_cruelty.Size = new System.Drawing.Size(25, 20);
            this.curr_cruelty.TabIndex = 14;
            // 
            // curr_forgiveness
            // 
            this.curr_forgiveness.Enabled = false;
            this.curr_forgiveness.Location = new System.Drawing.Point(90, 320);
            this.curr_forgiveness.Name = "curr_forgiveness";
            this.curr_forgiveness.Size = new System.Drawing.Size(25, 20);
            this.curr_forgiveness.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Smite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Defence";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Followers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Forgiveness";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cruelty";
            // 
            // smite_btn
            // 
            this.smite_btn.Location = new System.Drawing.Point(121, 214);
            this.smite_btn.Name = "smite_btn";
            this.smite_btn.Size = new System.Drawing.Size(101, 23);
            this.smite_btn.TabIndex = 22;
            this.smite_btn.Text = "Use smite";
            this.smite_btn.UseVisualStyleBackColor = true;
            this.smite_btn.Click += new System.EventHandler(this.smite_btn_Click);
            // 
            // defence_btn
            // 
            this.defence_btn.Location = new System.Drawing.Point(121, 240);
            this.defence_btn.Name = "defence_btn";
            this.defence_btn.Size = new System.Drawing.Size(101, 23);
            this.defence_btn.TabIndex = 23;
            this.defence_btn.Text = "Use defence";
            this.defence_btn.UseVisualStyleBackColor = true;
            this.defence_btn.Click += new System.EventHandler(this.defence_btn_Click);
            // 
            // followers_btn
            // 
            this.followers_btn.Location = new System.Drawing.Point(121, 266);
            this.followers_btn.Name = "followers_btn";
            this.followers_btn.Size = new System.Drawing.Size(101, 23);
            this.followers_btn.TabIndex = 24;
            this.followers_btn.Text = "Use followers";
            this.followers_btn.UseVisualStyleBackColor = true;
            this.followers_btn.Click += new System.EventHandler(this.followers_btn_Click);
            // 
            // cruelty_btn
            // 
            this.cruelty_btn.Location = new System.Drawing.Point(121, 292);
            this.cruelty_btn.Name = "cruelty_btn";
            this.cruelty_btn.Size = new System.Drawing.Size(101, 23);
            this.cruelty_btn.TabIndex = 25;
            this.cruelty_btn.Text = "Use cruelty";
            this.cruelty_btn.UseVisualStyleBackColor = true;
            this.cruelty_btn.Click += new System.EventHandler(this.cruelty_btn_Click);
            // 
            // forgiveness_btn
            // 
            this.forgiveness_btn.Location = new System.Drawing.Point(121, 318);
            this.forgiveness_btn.Name = "forgiveness_btn";
            this.forgiveness_btn.Size = new System.Drawing.Size(101, 23);
            this.forgiveness_btn.TabIndex = 26;
            this.forgiveness_btn.Text = "Use forgiveness";
            this.forgiveness_btn.UseVisualStyleBackColor = true;
            this.forgiveness_btn.Click += new System.EventHandler(this.forgiveness_btn_Click);
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn.Location = new System.Drawing.Point(347, 19);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(121, 31);
            this.turn.TabIndex = 27;
            this.turn.Text = "your turn";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // opponant
            // 
            this.opponant.AutoSize = true;
            this.opponant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponant.Location = new System.Drawing.Point(30, 87);
            this.opponant.Name = "opponant";
            this.opponant.Size = new System.Drawing.Size(350, 24);
            this.opponant.TabIndex = 28;
            this.opponant.Text = "                                                                    ";
            // 
            // dice_btn
            // 
            this.dice_btn.Location = new System.Drawing.Point(309, 134);
            this.dice_btn.Name = "dice_btn";
            this.dice_btn.Size = new System.Drawing.Size(75, 23);
            this.dice_btn.TabIndex = 29;
            this.dice_btn.Text = "Dice";
            this.dice_btn.UseVisualStyleBackColor = true;
            this.dice_btn.Visible = false;
            this.dice_btn.Click += new System.EventHandler(this.dice_btn_Click);
            // 
            // chance
            // 
            this.chance.Location = new System.Drawing.Point(429, 134);
            this.chance.Name = "chance";
            this.chance.Size = new System.Drawing.Size(75, 23);
            this.chance.TabIndex = 30;
            this.chance.Text = "chance card";
            this.chance.UseVisualStyleBackColor = true;
            this.chance.Visible = false;
            this.chance.Click += new System.EventHandler(this.chance_Click);
            // 
            // other_cruelty_lbl
            // 
            this.other_cruelty_lbl.AutoSize = true;
            this.other_cruelty_lbl.Location = new System.Drawing.Point(686, 297);
            this.other_cruelty_lbl.Name = "other_cruelty_lbl";
            this.other_cruelty_lbl.Size = new System.Drawing.Size(39, 13);
            this.other_cruelty_lbl.TabIndex = 42;
            this.other_cruelty_lbl.Text = "Cruelty";
            // 
            // other_forgiveness_lbl
            // 
            this.other_forgiveness_lbl.AutoSize = true;
            this.other_forgiveness_lbl.Location = new System.Drawing.Point(661, 323);
            this.other_forgiveness_lbl.Name = "other_forgiveness_lbl";
            this.other_forgiveness_lbl.Size = new System.Drawing.Size(64, 13);
            this.other_forgiveness_lbl.TabIndex = 41;
            this.other_forgiveness_lbl.Text = "Forgiveness";
            // 
            // other_followers_lbl
            // 
            this.other_followers_lbl.AutoSize = true;
            this.other_followers_lbl.Location = new System.Drawing.Point(674, 271);
            this.other_followers_lbl.Name = "other_followers_lbl";
            this.other_followers_lbl.Size = new System.Drawing.Size(51, 13);
            this.other_followers_lbl.TabIndex = 40;
            this.other_followers_lbl.Text = "Followers";
            // 
            // other_defence_lbl
            // 
            this.other_defence_lbl.AutoSize = true;
            this.other_defence_lbl.Location = new System.Drawing.Point(677, 245);
            this.other_defence_lbl.Name = "other_defence_lbl";
            this.other_defence_lbl.Size = new System.Drawing.Size(48, 13);
            this.other_defence_lbl.TabIndex = 39;
            this.other_defence_lbl.Text = "Defence";
            // 
            // other_smite_lbl
            // 
            this.other_smite_lbl.AutoSize = true;
            this.other_smite_lbl.Location = new System.Drawing.Point(692, 219);
            this.other_smite_lbl.Name = "other_smite_lbl";
            this.other_smite_lbl.Size = new System.Drawing.Size(33, 13);
            this.other_smite_lbl.TabIndex = 38;
            this.other_smite_lbl.Text = "Smite";
            // 
            // other_name_lbl
            // 
            this.other_name_lbl.AutoSize = true;
            this.other_name_lbl.Location = new System.Drawing.Point(690, 193);
            this.other_name_lbl.Name = "other_name_lbl";
            this.other_name_lbl.Size = new System.Drawing.Size(35, 13);
            this.other_name_lbl.TabIndex = 37;
            this.other_name_lbl.Text = "Name";
            // 
            // other_forgiveness
            // 
            this.other_forgiveness.Enabled = false;
            this.other_forgiveness.Location = new System.Drawing.Point(731, 320);
            this.other_forgiveness.Name = "other_forgiveness";
            this.other_forgiveness.Size = new System.Drawing.Size(25, 20);
            this.other_forgiveness.TabIndex = 36;
            // 
            // other_cruelty
            // 
            this.other_cruelty.Enabled = false;
            this.other_cruelty.Location = new System.Drawing.Point(731, 294);
            this.other_cruelty.Name = "other_cruelty";
            this.other_cruelty.Size = new System.Drawing.Size(25, 20);
            this.other_cruelty.TabIndex = 35;
            // 
            // other_followers
            // 
            this.other_followers.Enabled = false;
            this.other_followers.Location = new System.Drawing.Point(731, 268);
            this.other_followers.Name = "other_followers";
            this.other_followers.Size = new System.Drawing.Size(25, 20);
            this.other_followers.TabIndex = 34;
            // 
            // other_defence
            // 
            this.other_defence.Enabled = false;
            this.other_defence.Location = new System.Drawing.Point(731, 242);
            this.other_defence.Name = "other_defence";
            this.other_defence.Size = new System.Drawing.Size(25, 20);
            this.other_defence.TabIndex = 33;
            // 
            // other_smite
            // 
            this.other_smite.Enabled = false;
            this.other_smite.Location = new System.Drawing.Point(731, 216);
            this.other_smite.Name = "other_smite";
            this.other_smite.Size = new System.Drawing.Size(25, 20);
            this.other_smite.TabIndex = 32;
            // 
            // other_name
            // 
            this.other_name.Enabled = false;
            this.other_name.Location = new System.Drawing.Point(731, 190);
            this.other_name.Name = "other_name";
            this.other_name.Size = new System.Drawing.Size(77, 20);
            this.other_name.TabIndex = 31;
            // 
            // player_box
            // 
            this.player_box.ErrorImage = null;
            this.player_box.ImageLocation = "";
            this.player_box.InitialImage = null;
            this.player_box.Location = new System.Drawing.Point(243, 196);
            this.player_box.Name = "player_box";
            this.player_box.Size = new System.Drawing.Size(180, 174);
            this.player_box.TabIndex = 43;
            this.player_box.TabStop = false;
            // 
            // enemy_box
            // 
            this.enemy_box.Location = new System.Drawing.Point(475, 196);
            this.enemy_box.Name = "enemy_box";
            this.enemy_box.Size = new System.Drawing.Size(180, 174);
            this.enemy_box.TabIndex = 44;
            this.enemy_box.TabStop = false;
            // 
            // main_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 417);
            this.Controls.Add(this.enemy_box);
            this.Controls.Add(this.player_box);
            this.Controls.Add(this.other_cruelty_lbl);
            this.Controls.Add(this.other_forgiveness_lbl);
            this.Controls.Add(this.other_followers_lbl);
            this.Controls.Add(this.other_defence_lbl);
            this.Controls.Add(this.other_smite_lbl);
            this.Controls.Add(this.other_name_lbl);
            this.Controls.Add(this.other_forgiveness);
            this.Controls.Add(this.other_cruelty);
            this.Controls.Add(this.other_followers);
            this.Controls.Add(this.other_defence);
            this.Controls.Add(this.other_smite);
            this.Controls.Add(this.other_name);
            this.Controls.Add(this.chance);
            this.Controls.Add(this.dice_btn);
            this.Controls.Add(this.opponant);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.forgiveness_btn);
            this.Controls.Add(this.cruelty_btn);
            this.Controls.Add(this.followers_btn);
            this.Controls.Add(this.defence_btn);
            this.Controls.Add(this.smite_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.curr_forgiveness);
            this.Controls.Add(this.curr_cruelty);
            this.Controls.Add(this.curr_followers);
            this.Controls.Add(this.curr_defence);
            this.Controls.Add(this.curr_smite);
            this.Controls.Add(this.curr_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.your_cards);
            this.Controls.Add(this.other_cards);
            this.Controls.Add(this.c_left);
            this.Controls.Add(this.c_in_d);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "main_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_game";
            this.Load += new System.EventHandler(this.main_game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_in_d;
        private System.Windows.Forms.TextBox c_left;
        private System.Windows.Forms.TextBox other_cards;
        private System.Windows.Forms.TextBox your_cards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox curr_name;
        private System.Windows.Forms.TextBox curr_smite;
        private System.Windows.Forms.TextBox curr_defence;
        private System.Windows.Forms.TextBox curr_followers;
        private System.Windows.Forms.TextBox curr_cruelty;
        private System.Windows.Forms.TextBox curr_forgiveness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button smite_btn;
        private System.Windows.Forms.Button defence_btn;
        private System.Windows.Forms.Button followers_btn;
        private System.Windows.Forms.Button cruelty_btn;
        private System.Windows.Forms.Button forgiveness_btn;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label opponant;
        private System.Windows.Forms.Button dice_btn;
        private System.Windows.Forms.Button chance;
        private System.Windows.Forms.Label other_cruelty_lbl;
        private System.Windows.Forms.Label other_forgiveness_lbl;
        private System.Windows.Forms.Label other_followers_lbl;
        private System.Windows.Forms.Label other_defence_lbl;
        private System.Windows.Forms.Label other_smite_lbl;
        private System.Windows.Forms.Label other_name_lbl;
        private System.Windows.Forms.TextBox other_forgiveness;
        private System.Windows.Forms.TextBox other_cruelty;
        private System.Windows.Forms.TextBox other_followers;
        private System.Windows.Forms.TextBox other_defence;
        private System.Windows.Forms.TextBox other_smite;
        private System.Windows.Forms.TextBox other_name;
        private System.Windows.Forms.PictureBox player_box;
        private System.Windows.Forms.PictureBox enemy_box;
    }
}