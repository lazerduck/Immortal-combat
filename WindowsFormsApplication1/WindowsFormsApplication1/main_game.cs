using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class main_game : Form
    {
        // generate the classes
        deck main_deck = new deck();
        Random rnd = new Random();
        random rand = new random();
        win victory = new win();
        loss lost = new loss();
        human player;
        Ai ai;
        // create some variables
        int temp = 0;
        int temp_count = 0;
        int ai_type = 0;
        int player_get = 0;
        int ai_get = 0;
        //sets up the game
        public main_game()
        {
            //makes the victory form accesible using the resources class
            resources.victory = victory;
            //hide the form so it can be shown when the player wins
            resources.victory.Hide();
            //makes the lose form accesible using the resources class
            resources.lose = lost;
            //hides the for so it can be shown when the player loses
            resources.lose.Hide();
            //uses a method to set which player goes first
            rand.go_first();
            InitializeComponent();
            //tells the player the number of cards they are working with
            c_in_d.Text = Convert.ToString(main_deck.card_list.Count);
            //creates the list of cards for the players
            List<card> player_list = new List<card>();
            List<card> ai_list = new List<card>();
            // sets up temp count for later use
            temp_count = main_deck.card_list.Count;
            //loops through the cards so that they are randomly dealt to the players
            for (int i = 0; i < temp_count/2; i++)
            {
                temp = rnd.Next(0, main_deck.card_list.Count);
                player_list.Add(main_deck.card_list[temp]);
                main_deck.card_list.RemoveAt(temp);
            }
            if (temp_count%2 != 0)
            {
                //selects a random card and removes it
                temp = rnd.Next(0, main_deck.card_list.Count);
                main_deck.card_list.RemoveAt(temp);
                //tells the player that one card was not used in this game
                c_left.Text = "1";
                foreach (card c in main_deck.card_list)
                {
                    // adds the ramaining cards to the computers deck
                    ai_list.Add(c);
                }
            }
            else
            {
                c_left.Text = "0";
                foreach (card c in main_deck.card_list)
                {
                    ai_list.Add(c);
                }
            }
            //create the player and the computer classes
            player = new human(player_list);
            ai = new Ai(ai_list);
            //display the number of cards each player has
            your_cards.Text = Convert.ToString(player.list.Count);
            other_cards.Text = Convert.ToString(ai.list.Count);
            //calls a method to update all of the values on screen
            update_values();
            // checks whos turn it is and then uses a timer to add a wait to the comouters actions
            if (!resources.turn)
            {
                wait(resources.wait_time);
            }
        }
        private void main_game_Load(object sender, EventArgs e)
        {

        }
        //does this when the game is closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //closes the form and shows the main menu
            resources.close_game = true;
            resources.main_menu.Show();
        }
        //updates the valuse shown to the player
        private void update_values()
        {
            // checks win and loss conditions to see if the values need updating
            if (ai.list.Count == 0)
            {
                resources.victory.Show();
                resources.game.Close();
            }
            else if (player.list.Count == 0)
            {
                resources.lose.Show();
                resources.game.Close();
            }
            else
            { 
                // creates a temp string to store the location of the image for checking if it exists
                string temp_string = resources.location + "\\content\\images\\" + player.list[0].name + ".jpg";
                if (File.Exists(temp_string))
                {
                    // if the file exists it shows it
                    player_box.ImageLocation = resources.location + "\\content\\images\\" + player.list[0].name + ".jpg";
                }
                else
                {
                    // if the file doesn't exist then use a default image
                    player_box.ImageLocation = resources.location + "\\content\\images\\default.jpg";
                }
                // same as the previous but for the computers image
                temp_string = resources.location + "\\content\\images\\" + ai.list[0].name + ".jpg";
                if (File.Exists(temp_string))
                {
                    enemy_box.ImageLocation = resources.location + "\\content\\images\\" + ai.list[0].name + ".jpg";
                }
                else
                {
                    enemy_box.ImageLocation = resources.location + "\\content\\images\\default.jpg";
                }
                //update all of the values on screen
                curr_name.Text = player.list[0].name;
                curr_smite.Text = Convert.ToString(player.list[0].smite);
                curr_defence.Text = Convert.ToString(player.list[0].defence);
                curr_followers.Text = Convert.ToString(player.list[0].followers);
                curr_cruelty.Text = Convert.ToString(player.list[0].cruelty);
                curr_forgiveness.Text = Convert.ToString(player.list[0].forgiveness);
                your_cards.Text = Convert.ToString(player.list.Count);
                other_cards.Text = Convert.ToString(ai.list.Count);
                other_name.Text = ai.list[0].name;
                other_smite.Text = Convert.ToString(ai.list[0].smite);
                other_defence.Text = Convert.ToString(ai.list[0].defence);
                other_followers.Text = Convert.ToString(ai.list[0].followers);
                other_cruelty.Text = Convert.ToString(ai.list[0].cruelty);
                other_forgiveness.Text = Convert.ToString(ai.list[0].forgiveness);
                // if cheat mode is on then the computers values can be seen
                if (resources.cheat_mode)
                {
                    enemy_box.Visible = true;
                    other_name.Visible = true;
                    other_smite.Visible = true;
                    other_defence.Visible = true;
                    other_followers.Visible = true;
                    other_cruelty.Visible = true;
                    other_forgiveness.Visible = true;
                    other_name_lbl.Visible = true;
                    other_smite_lbl.Visible = true;
                    other_defence_lbl.Visible = true;
                    other_followers_lbl.Visible = true;
                    other_cruelty_lbl.Visible = true;
                    other_forgiveness_lbl.Visible = true;
                }
                else
                {
                    // if cheat mode is off then the vallues are hidden
                    enemy_box.Visible = false;
                    other_name_lbl.Visible = false;
                    other_smite_lbl.Visible = false;
                    other_defence_lbl.Visible = false;
                    other_followers_lbl.Visible = false;
                    other_cruelty_lbl.Visible = false;
                    other_forgiveness_lbl.Visible = false;
                    other_name.Visible = false;
                    other_smite.Visible = false;
                    other_defence.Visible = false;
                    other_followers.Visible = false;
                    other_cruelty.Visible = false;
                    other_forgiveness.Visible = false;
                }
            }
            //tell the player whose turn it is
            if(resources.turn)
            {
                turn.Text = "your turn";
            }
            if (!resources.turn)
            {
                //starts the computers turn
                turn.Text = "Opponents turn";
                wait(resources.wait_time);
            }
            else
            {
                //stops the timer so the computer doesn't take an extra turn
                timer1.Stop();
            }           
        }
        //posiible outcomes
        #region out_comes
        //give the players the computers card and adds it to the back with the players first card
        private void win()
        {
            card temp = player.list[0];
            player.list.RemoveAt(0);
            player.list.Add(temp);
            player.list.Add(ai.list[0]);
            ai.list.RemoveAt(0);
            update_values();
        }
        //the same as the previous one but for the computer and not the player
        private void lose()
        {
            card temp = ai.list[0];
            ai.list.RemoveAt(0);
            ai.list.Add(temp);
            ai.list.Add(player.list[0]);
            player.list.RemoveAt(0);
            update_values();
        }
        // each players card gets returned to the back of the list
        private void draw()
        {
            card temp = ai.list[0];
            ai.list.RemoveAt(0);
            ai.list.Add(temp);
            temp = player.list[0];
            player.list.RemoveAt(0);
            player.list.Add(temp);
            update_values();
        }
        #endregion out_comes
        //players' methods
        #region player buttons
        //the button for using the smite value
        private void smite_btn_Click(object sender, EventArgs e)
        {
            //checks if its the players turn
            if (resources.turn)
            {
                //checks if the player is in the middle of a chance roll
                if (!resources.chance_go)
                {
                    //performs a method to see if the player will use a chance roll or the value
                    if (!test_chance())
                    {
                        //compares the values and calls the appropriate method
                        if (player.list[0].Compare(ai.list[0].smite, "smite") == 0)
                        {
                            opponant.Text = "you won with " + player.list[0].smite + " and your opponant had " + ai.list[0].smite;
                            win();
                        }
                        else if (player.list[0].Compare(ai.list[0].smite, "smite") == 1)
                        {
                            opponant.Text = "you lost with " + player.list[0].smite + " and your opponant had " + ai.list[0].smite;
                            //if the player loses then its the computers turn
                            resources.turn = false;
                            lose();
                            
                        }
                        else
                        {
                            opponant.Text = "you drew with " + player.list[0].smite;
                            draw();
                        }
                    }
                    else
                    {
                        //begin the chance methods
                        resources.chance_go = true;
                        show_chance();
                    }
                }
            }
        }
        //the button for using the defence value
        private void defence_btn_Click(object sender, EventArgs e)
        {
            if (resources.turn)
            {
                if (!resources.chance_go)
                {
                    if (!test_chance())
                    {
                        if (player.list[0].Compare(ai.list[0].defence, "defence") == 0)
                        {
                            opponant.Text = "you won with " + player.list[0].defence + " and your opponant had " + ai.list[0].defence;
                            win();
                        }
                        else if (player.list[0].Compare(ai.list[0].defence, "defence") == 1)
                        {
                            opponant.Text = "you lost with " + player.list[0].defence + " and your opponant had " + ai.list[0].defence;
                            resources.turn = false;
                            lose();
                        }
                        else
                        {
                            opponant.Text = "you drew with " + player.list[0].defence;
                            draw();
                        }
                    }
                    else
                    {
                        resources.chance_go = true;
                        show_chance();
                    }
                }
            }
        }
        //the button for the followers value
        private void followers_btn_Click(object sender, EventArgs e)
        {
            if (resources.turn)
            {
                if (!resources.chance_go)
                {
                    if (!test_chance())
                    { 
                        if (player.list[0].Compare(ai.list[0].followers, "followers") == 0)
                        {
                            opponant.Text = "you won with " + player.list[0].followers + " and your opponant had " + ai.list[0].followers;
                            win();
                        }
                        else if (player.list[0].Compare(ai.list[0].followers, "followers") == 1)
                        {
                            opponant.Text = "you lost with " + player.list[0].followers + " and your opponant had " + ai.list[0].followers;
                            resources.turn = false;
                            lose();
                            
                        }
                        else
                        {
                            opponant.Text = "you drew with " + player.list[0].followers;
                            draw();
                        }
                    }
                    else
                    {
                        resources.chance_go = true;
                        show_chance();
                    }
                }
            }
        }
        // the button for the cruelty value
        private void cruelty_btn_Click(object sender, EventArgs e)
        {
            if (resources.turn)
            {
                if (!resources.chance_go)
                {
                    if (!test_chance())
                    {
                        if (player.list[0].Compare(ai.list[0].cruelty, "cruelty") == 0)
                        {
                            opponant.Text = "you won with " + player.list[0].cruelty + " and your opponant had " + ai.list[0].cruelty;
                            win();
                        }
                        else if (player.list[0].Compare(ai.list[0].cruelty, "cruelty") == 1)
                        {
                            opponant.Text = "you lost with " + player.list[0].cruelty + " and your opponant had " + ai.list[0].cruelty;
                            resources.turn = false;
                            lose();   
                        }
                        else
                        {
                            opponant.Text = "you drew with " + player.list[0].cruelty;
                            draw();
                        }
                    }
                    else
                    {
                        resources.chance_go = true;
                        show_chance();
                    }
                }
            }
        }
        //the button for the forgiveness value
        private void forgiveness_btn_Click(object sender, EventArgs e)
        {
            if (resources.turn)
            {
                if (!resources.chance_go)
                {
                    if (!test_chance())
                    {
                        if (player.list[0].Compare(ai.list[0].forgiveness, "forgiveness") == 0)
                        {
                            opponant.Text = "you won with " + player.list[0].forgiveness + " and your opponant had " + ai.list[0].forgiveness;
                            win();
                        }
                        else if (player.list[0].Compare(ai.list[0].forgiveness, "forgiveness") == 1)
                        {
                            opponant.Text = "you lost with " + player.list[0].forgiveness + " and your opponant had " + ai.list[0].forgiveness;
                            resources.turn = false;
                            lose(); 
                        }
                        else
                        {
                            opponant.Text = "you drew with " + player.list[0].forgiveness;
                            draw();
                        }
                    }
                    else
                    {
                        resources.chance_go = true;
                        show_chance();
                    }
                }
            }
        }
        # endregion player buttons
        //Ai methods
        # region Ai methods
        //creates a small variable wait before the computer takes its turn and then starts its timer
        private void wait(int time)
        {
            timer1.Interval = time * 1000;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // cheks if the player and the computer have cards
            if (ai.list.Count > 0 && player.list.Count > 0)
            {
                // uses the rand class to choose the value to use
                ai_type = rand.choose_type(ai.list[0]);
                // test to see if a chance roll chould occur
                if (!test_chance())
                {
                    // begins the switch to deal with all of the possible outcomes for all of the categories
                    switch (ai_type)
                    {
                        case 1:
                            opponant.Text = "Your opponant used " + ai.list[0].name + " chose smite with a value of " + ai.list[0].smite + ". You had " + player.list[0].smite;
                            if (ai.list[0].Compare(player.list[0].smite, "smite") == 0)
                            {
                                lose();
                                
                            }
                            else if (ai.list[0].Compare(player.list[0].smite, "smite") == 1)
                            {
                                resources.turn = true;
                                win();
                            }
                            else
                            {
                                draw();
                            }

                            break;

                        case 2:
                            
                            opponant.Text = "Your opponant used " + ai.list[0].name + " chose defence with a value of " + ai.list[0].defence + ". You had " + player.list[0].defence;
                            if (ai.list[0].Compare(player.list[0].defence, "defence") == 0)
                            {
                                lose();
                                
                            }
                            else if (ai.list[0].Compare(player.list[0].defence, "defence") == 1)
                            {
                                resources.turn = true;
                                win();
                            }
                            else
                            {
                                draw();
                            }
                            break;

                        case 3:
                            
                            opponant.Text = "Your opponant used " + ai.list[0].name + " chose followers with a value of " + ai.list[0].followers + ". You had " + player.list[0].followers;
                            if (ai.list[0].Compare(player.list[0].followers, "followers") == 0)
                            {
                                lose();
                                
                            }
                            else if (ai.list[0].Compare(player.list[0].followers, "followers") == 1)
                            {
                                resources.turn = true;
                                win();
                            }
                            else
                            {
                                draw();
                            }
                            break;

                        case 4:
                            
                            opponant.Text = "Your opponant used " + ai.list[0].name + " chose cruelty with a value of " + ai.list[0].cruelty + ". You had " + player.list[0].cruelty;
                            if (ai.list[0].Compare(player.list[0].cruelty, "cruelty") == 0)
                            {
                                lose();
                                
                            }
                            else if (ai.list[0].Compare(player.list[0].cruelty, "cruelty") == 1)
                            {
                                resources.turn = true;
                                win();
                            }
                            else
                            {
                                draw();
                            }
                            break;

                        case 5:
                            
                            opponant.Text = "Your opponant used " + ai.list[0].name + " chose forgiveness with a value of " + ai.list[0].forgiveness + ". You had " + player.list[0].forgiveness;
                            if (ai.list[0].Compare(player.list[0].forgiveness, "forgiveness") == 0)
                            {

                                lose();
                                
                            }
                            else if (ai.list[0].Compare(player.list[0].forgiveness, "forgiveness") == 1)
                            {
                                resources.turn = true;
                                win();
                            }
                            else
                            {
                                draw();
                            }
                            break;
                        default:
                            win();
                            opponant.Text = "error";
                            break;
                    }
                }
                else
                {
                    resources.chance_go = true;
                    show_chance();
                }
            }
        }
        # endregion Ai methods
        //chance methods
        # region chance
        public void show_chance()
        {
            //shows the buttons and shows some text to the player telling them what to do
            opponant.Text = "choose a dice roll or a change card";
            dice_btn.Visible = true;
            chance.Visible = true;
        }
        public void hide_chance(string type,int result,int player_result)
        {
            // allows regular play to continue
            resources.chance_go = false;
            string victory = "error";
            //sees who won and then use the appropraite outcome method
            if (result > player_result)
            {
                victory = "lost";
                resources.turn = false;
                lose();
                
            }
            else if (result < player_result)
            {
                victory = "won";
                resources.turn = true;
                win();
            }
            else if (result == player_result)
            {
                victory = "drew";
                draw();
            }
            //shows the outcome and then hides the buttons
            opponant.Text = "your opponat choose to use " + type + " and achieved " + result + " you achieved " + player_result + " and you " + victory;
            dice_btn.Visible = false;
            chance.Visible = false;
        }
        public bool test_chance()
        {
            //test to see if the current player gets a random chance
            temp = rnd.Next(0, 100);
            if (temp < resources.random_chance)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        //checks if the player clicks on the chance button
        private void chance_Click(object sender, EventArgs e)
        {
            if (resources.chance_go)
            {
                player_get = rand.chance_roll();
                temp = rnd.Next(0, 2);
                string type = "";
                if (temp < 1)
                {
                    type = "dice";
                    ai_get = rand.dice_roll();
                }
                else
                {
                    type = "chance";
                    ai_get = rand.chance_roll();
                }
                hide_chance(type, ai_get, player_get);
            }
        }
        //checks if the player clicks the dice button
        private void dice_btn_Click(object sender, EventArgs e)
        {
            if (resources.chance_go)
            {
                string type = "";
                player_get = rand.dice_roll();
                temp = rnd.Next(0, 2);
                if (temp < 1)
                {
                    type = "dice";
                    ai_get = rand.dice_roll();
                }
                else
                {
                    type = "chance";
                    ai_get = rand.chance_roll();
                }
                hide_chance(type, ai_get, player_get);
            }
        }
        # endregion chance        
    }
}
