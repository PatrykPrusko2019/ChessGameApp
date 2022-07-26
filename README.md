# ChessGameApp

Description with photos -> Description_of_the_game_of_chess_with_photos/Description_of_the_game_of_chess.pdf
bin\publish -> exe file play of chess is located -> publish_file_exe.rar

Using C# + WPF in visual studio 2019.

Description of additional sub-branches:
1. first subbranch "action_of_pawn_figure" -> pawn figure movement programming.
2. second subbranch "action_of_tower_figure" -> tower/rook figure movement programming.
3. third subbranch "action_of_knight_figure" -> knight figure movement programming.
4. fourth subbranch "action_of_bishop_figure" -> bishop figure movement programming.
5. fifth subbranch "action_of_king_figure" -> king figure movement programming.
6. sixth subbranch "action_of_queen_figure" -> queen figure movement programming.


Game description:
Possibility to play between two players:
  - First White player
  - Second Black player

The player with white figures starts. Must click first
in a given figure. Then he should click on some empty field
or a field with a black figure. If the player executes illegal
move, an appropriate message will pop up:

- the message "Please choose good color of figure" →
The message in question will appear along with a short beep that
abnormal movement has occurred. Types
abnormal movements:
1. when the correct sequence of movements is not followed →
white figure, black figure, white figure, black figure.
2. when one of the players clicks on an empty field.

- message "wrong movement. Please choose new
white figure !!! " → the relevant message is displayed with
with a short beep that there has been an illegal movement.
Types of abnormal movements:
1. when one of the players clicks in the wrong place
while moving.

- the message "Player winner with black figures !!!" end
game ”→ The message that the player has won is displayed
(white player or black player) and a short song for
the winners. You must click "OK" and the application exits.

Description of the movements of the figures:

1. Pawn → at the start of the game, on the first move
the ability to move 2 squares forward. Only later
possibility to move 1 square forward. Collecting figures
opponent → move diagonally to the left or right (only
Forward).

2. Rook → the ability to move up, down, right, left. Movement
for any number of fields. Capturing opponent's pieces → move in
left, right, down, up.

3. Bishop → possibility to move diagonally left, right,
up and down. Movement for any number of fields. Collecting figures
opponent → move diagonally to the left, right, down,
top.

4. Knight → possibility to move in 8 different places:
- Movement performed 1 field up, down, left, right,
then 2 fields up, down, left, right.
- Movement performed 2 fields up, down, left, right,
then 1 space up, down, left, right. Must create
L-shaped movement. Same possibility
capturing opponent's pieces.

5. King → possibility to move one field up, down, left,
law. The same possibility of capturing figures.

6. Queen → the ability to move and capture the opponent's pieces in the same way as the ROOK and BISHOP pieces.
