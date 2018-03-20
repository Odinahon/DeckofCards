namespace Deck{
    public class Card{
        public string stringVal{get;set;}
        public string suit{get; set;}
        public int val{get; set;}

        public Card(string strval, string s, int v){
            stringVal=strval;
            suit=s;
            val=v;
        }

    }
    //{"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
}