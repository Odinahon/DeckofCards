using System.Collections.Generic;

namespace Deck{
    public class Player{
        public string Name;
        public Player(string n){
            Name = n;
        }
            
        public List<Card> PlayerHand =new List<Card>(52);
        public void Draw(Deck deck){
            //reference to the object is like when we pass a parametr type of Deckto draw method 
            //we can access to the Deck methods
            PlayerHand.Add(deck.Deal());
        }
        public Card Discard(int num){
            
            if(num<PlayerHand.Count)
            {
            Card card1=PlayerHand[num];
             PlayerHand.RemoveAt(num);
             return card1;
            }
            else{
                return null;
            }
                
            
            
            
        }
        

    }
}