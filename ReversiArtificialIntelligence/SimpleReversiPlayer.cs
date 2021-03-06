namespace ReversiArtificialIntelligence
{
    /// <summary>
    /// This player calculates the move that guarentees the most allied discs on the next turn
    /// </summary>
    public class SimpleReversiPlayer : IReversiPlayer
    {
        public Point NextMove(Disc[,] board, Disc playerColor)
        {
            Point bestMove= new Point(0,0);
            int bestScore = int.MinValue;
            foreach (Point p in ReversiGame.ValidMoves(board, playerColor))
            {
                int score = ReversiGame.Score(ReversiGame.PlayTurn(board, p, playerColor), playerColor);
                if(score > bestScore)
                {
                    bestMove = p;
                    bestScore = score;
                }
            }
            return bestMove;
        }
    }
}
