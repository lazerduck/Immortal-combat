using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class deck
    {
        //this class contains all of the cards
        public List<card> card_list = new List<card>();
        // if the constructor is blank it creates the maind deck
        public deck()
        {
            card_list = create_deck();
        }
        // if the constructor isnt blank then it creates the player and computer decks
        public deck(List<card> cards)
        {

        }
        private List<card> create_deck()
        {
            List<card> card_list = new List<card>();
            //read in the card data
            string[] details = File.ReadAllText(resources.location + "\\Content\\card_list.txt").Split(' ');
            //create all of the cards
            for (int i = 0; i < details.Length/6; i++)
            {
                card new_card = new card();
                new_card.name = details[i * 6];
                new_card.smite = Convert.ToInt32(details[i * 6 + 1]);
                new_card.defence = Convert.ToInt32(details[i * 6 + 2]);
                new_card.followers = Convert.ToInt32(details[i * 6 + 3]);
                new_card.cruelty = Convert.ToInt32(details[i * 6 + 4]);
                new_card.forgiveness = Convert.ToInt32(details[i * 6 + 5]);
                card_list.Add(new_card);
            }
                return(card_list);
        }
    }
}
