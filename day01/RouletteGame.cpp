#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

void playRoulette() {
    srand(time(0));
    string colors[] = { "red", "black" };
    int winNumber = rand() % 37;
    string winColor = (winNumber == 0) ? "green" : colors[winNumber % 2];

    cout << "Winning number: " << winNumber << " (" << winColor << ")" << endl;
    cout << "Choose your bet (red/black/even/odd/exact number): ";

    string bet;
    cin >> bet;

    if ((bet == "red" && winColor == "red") || 
            (bet == "black" && winColor == "black") ||
            (bet == "even" && winNumber % 2 == 0 && winNumber != 0) ||
            (bet == "odd" && winNumber % 2 == 1) ||
            (isdigit(bet[0]) && stoi(bet) == winNumber))
        {
            cout << "You won! :D";
        } else {
            cout << "You've lost. Better luck next time! ;)";
        }
}

int main() {
    playRoulette();
    return 0;
}