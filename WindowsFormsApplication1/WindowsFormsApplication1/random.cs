using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class random
    {
        Random rnd = new Random();
        int temp = 0;
        int[] names = {1,2,3,4,5};
        int big1 = 1;
        //preform a random test to see who goes first
        public void go_first()
        {
            temp = rnd.Next(0, 2);
            if (temp < 1)
            {
                resources.turn = true;
            }
            else
            {
                resources.turn = false;
            }
        }
        //choose what category to use depending on the difficulty
        public int choose_type(card temp_card)
        {
            //on easy a random category is chosen
            if (resources.difficulty == 0)
            {
                temp = rnd.Next(1, 6);
                return (temp);
            }
            //on hard the highest value is chosen
            if (resources.difficulty == 1)
            {
                if ((temp_card.smite > temp_card.defence) && (temp_card.smite > temp_card.followers) && (temp_card.smite > temp_card.cruelty) && (temp_card.smite > temp_card.forgiveness))
                {
                    big1 = 1;
                }else if ((temp_card.defence > temp_card.smite) && (temp_card.defence > temp_card.followers) && (temp_card.defence > temp_card.cruelty) && (temp_card.defence > temp_card.forgiveness))
                {
                    big1 = 2;
                }else if ((temp_card.followers > temp_card.smite) && (temp_card.followers > temp_card.defence) && (temp_card.followers > temp_card.cruelty) && (temp_card.followers > temp_card.forgiveness))
                {
                    big1 = 3;
                }else if ((temp_card.cruelty > temp_card.smite) && (temp_card.cruelty > temp_card.defence) && (temp_card.cruelty > temp_card.followers) && (temp_card.cruelty > temp_card.forgiveness))
                {
                    big1 = 4;
                }
                else if ((temp_card.forgiveness > temp_card.smite) && (temp_card.forgiveness > temp_card.defence) && (temp_card.forgiveness > temp_card.followers) && (temp_card.forgiveness > temp_card.cruelty))
                {
                    big1 = 5;
                }
                else
                {
                    big1 = 1;
                }

                return (big1);
            }
            return (0);
        }
        //create a chance card list 
        public void chance_initialize()
        {
            resources.chance.Clear();
            List<int> temp_chance = new List<int>();
            for (int i = 2; i < 6; i++)
            {
                temp_chance.Add(i);
                temp_chance.Add(i);
                temp_chance.Add(i);
                temp_chance.Add(i);
            }
            for (int i = 0; i < 16; i++)
            {
                temp = rnd.Next(0, temp_chance.Count);
                resources.chance.Add(temp_chance[temp]);
                temp_chance.RemoveAt(temp);
            }
        }
        public int chance_roll()
        {
            //choose a chance card and then then if the list is empty then re-initialize the list
            temp = rnd.Next(0, resources.chance.Count);
            if (resources.chance.Count == 0)
            {
                chance_initialize();
            }
            int num = resources.chance[temp];
            resources.chance.RemoveAt(temp);
            return (num);
        }
        public int dice_roll()
        {
            //return a number between 1 and 6
            temp = rnd.Next(1, 7);
            Console.WriteLine(" " + temp);
            return (temp);
            
        }
    }
}
