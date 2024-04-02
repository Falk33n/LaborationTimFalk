using ConnectFour;
using static ConnectFour.GameState;

namespace ConnectFourTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            // Arrange
            var gameState = new GameState(); // Create instance of gamestate

            // Act
            var actualResult = gameState.CheckForWin(); // create the actual result of the test

            // Assert
            Assert.Equal(WinState.No_Winner, actualResult); // Test if the actualResult is equal to WinState.No_Winner
        }

        [Fact]
        public void CheckForWin_TieGame()
        {
            // In order for this test to actually work I needed to change where we are checking for a tie inside the CheckForWin()
            // Go there to see the changes I did

            // Arrange
            var gameState = new GameState(); // Create instance of gamestate

            // Create a full board and also alternate between the players
            for (int i = 0; i < 42; i++)
            {
                gameState.TheBoard[i] = (i % 2) + 1;
            }

            // Act
            var actualResult = gameState.CheckForWin(); // create the actual result of the test

            // Assert
            Assert.Equal(WinState.Tie, actualResult); // Test if the actualResult is equal to WinState.Tie
        }
    }
}