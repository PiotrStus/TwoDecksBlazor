namespace TwoDecksBlazor
{
    internal class TwoDecks
    {
        private Deck leftDeck = new Deck();
        private Deck rightDeck = new Deck();

        public int RightDeckCount { get { return rightDeck.Count; } }
        public int LeftDeckCount { get { return leftDeck.Count; } }

        public void Sort() 
        {
            rightDeck.Sort(new CardComparerByValue());
        }

        public string RightDeckCardName(int index)
        {
            return rightDeck[index].ToString();
        }

        public int RightCardSelected { get; set; }
        public int LeftCardSelected { get; set; }
        public string LeftDeckCardName(int i)
        {
            return leftDeck[i].ToString();
        }
        public void Shuffle()
        {
            leftDeck.Shuffle();

        }
        public void Reset()
        {
            leftDeck = new Deck();
        }

        public void Clear() 
        {
            rightDeck.Clear();
        }

        public void MoveCard(Direction direction)
        {
            if (direction == Direction.LeftToRight)
            {
                rightDeck.Add(leftDeck[LeftCardSelected]);
                leftDeck.RemoveAt(LeftCardSelected);
            }
            else
            {
                leftDeck.Add(rightDeck[RightCardSelected]);
                rightDeck.RemoveAt(RightCardSelected);
            }
        }
    }
}
