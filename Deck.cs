using System;
using System.Collections.Generic;

namespace Deck{
    public class Deck{
        public List<Card> DeckofCards=new List<Card>(52);
        public List<Card> DealCards= new List<Card>(52);
        public string[] strVal={"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        public string[] suits={"Diamond","Hearts","Spades","Clubs"};

        public Deck(){

        }
        public void Create(){
            for (int i = 0; i < strVal.Length; i++)
            {   for (int j = 0; j < suits.Length; j++)
            {
                Card card1= new Card(strVal[i],suits[j],j+1);
                DeckofCards.Add(card1);
            }
            }
            
            
        }
        public Card Deal(){
            Card card1 = DeckofCards[0];
            DeckofCards.RemoveAt(0);
            DealCards.Add(card1);
            return card1;
        }
        public void Reset(){
            for( int i=0; i<DealCards.Count;i++){
                DeckofCards.Add(DealCards[i]);
                DealCards.RemoveAt(0);
                }
        }
        
        public void Shuffle()
        {
        Random rand = new Random();
        
             for(int i=0; i<DeckofCards.Count;i++)
             {
                 int randomidx= rand.Next(0,DeckofCards.Count);
                 Card temp=DeckofCards[i];
                 DeckofCards[i]=DeckofCards[randomidx];
                 DeckofCards[randomidx]=temp;
            }

        }

    }

    
}