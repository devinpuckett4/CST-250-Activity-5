
[Devin Puckett]

[CST-250 Programming in C#2]

[Grand Canyon University]

[11/15/2025]

[Activity 5]

[https://github.com/devinpuckett4/CST-250-Activity-4/blob/main/Activity4.md]

[https://www.loom.com/share/8664eaf62dda4ff9855087f188529f27]






FLOW CHART
 
Figure 1: Flow chart Activity 5 
This flowchart is showing the basic flow of my game once it starts. First, the program launches and the main form appears on the screen. When I click the Start button, the timer begins running and ticks every second in the background. On every tick, the program checks if three seconds have passed; if they have, it moves the target and the decoy to new positions so the game stays active and challenging. After that, the game checks the current level and any conditions that would end the game, like time running out or the player reaching the goal. Once those conditions are met, the game ends and the program stops.




UML Class Diagram
 
Figure 2: UML Diagram Activity 5

This diagram shows how my stopwatch game is broken into three pieces. On the left is the FrmStopwatch form, which is the actual screen the player sees. It keeps track of how much time has passed, holds a Random object, and has references to a GameModel and GameLogic. All the button clicks and timer ticks are handled here as event handler methods. In the middle is GameLogic, which does the “thinking” for the game. When the form calls into it, GameLogic updates the score, updates the miss counter, checks if the game should end based on time and the model, and adjusts the level as time goes on. On the right is GameModel, which is just a simple data holder for the current Score, number of Misses, and Level. The form uses GameLogic, and GameLogic updates the GameModel, so the UI stays separate from the game rules and data.


 
Figure 3: Initial Startup

This screenshot shows the main window for my Whack-A-Mole stopwatch app. At the top it’s titled “Stopwatch Whack-A-Mole,” and the screen is clean and simple so it’s easy to focus on the game. On the left, there’s a large digital timer starting at 00:00, which will track how long the round has been running. On the right, I display the player’s Score and Misses, both starting at 0 so it’s clear this is the beginning of a new game. The big empty space in the middle is where the target and decoy buttons will appear once the game starts.



Figure 4: Game Initial Run
 
In this screenshot, my Whack-A-Mole stopwatch app is running with the timer at 00:01, so the game has just started. The Score and Misses labels are still at 0, showing that I haven’t hit or missed any targets yet. At the bottom left, you can see the Start, Stop, and Reset buttons that I use to control the timer and the round. The rest of the form is open space where the target and decoy buttons will appear and move around during gameplay.
 
Figure 5: Initial Difficulty of App
In this screenshot, my Whack-A-Mole game has been running for a few seconds, with the timer showing 00:04. The score and misses are still at 0, so I haven’t clicked anything yet. A green “Hit” button appears near the bottom area of the form as the main target I’m supposed to click. At the same time, an orange “Bomb” button shows up near the top, acting as the decoy that I need to avoid. The Start, Stop, and Reset buttons are still available at the bottom so I can control the round while the targets move around the screen. 
Figure 6: Misses
In this screenshot, my Whack-A-Mole stopwatch is at 00:06 and you can see how misclicks are tracked. The score is still 0, but the Misses counter has jumped up to 7, showing that I’ve clicked in the wrong place several times. A small green target button is in the middle of the screen, while a blue Bomb button sits near the bottom as a distraction. This view demonstrates that every wrong click, including hitting the bomb instead of the target, is recorded as a miss even when I don’t earn any points.


Figure 7: Method Of PizzaLogic
 
This screenshot shows my PizzaLogic class handling the rules for adding and saving pizzas. The AddPizzaToOrder method first checks that the name, crust, ingredients, sauce, and cheese are all set the way the guide requires. If anything is missing, it returns false and does not add the pizza. When the pizza is valid, it calls the DAO to store it and returns true along with the updated count. The GetPizzaOrder method gives the full list back to the forms, and WriteOrderToFile passes the order to the DAO to be written out to the text file. This keeps all the validation and order management in the business layer instead of in the UI.


Figure 8: Part PizzaMaker App Running
 In this screenshot, my Whack-A-Mole game has reached the one-minute mark, with the timer showing 01:00. The scoreboard at the top shows a Score of 18 and only 1 Miss, so this round went much better than the earlier examples. A gray Bomb button is visible near the center of the screen, while the small target button is tucked down in the bottom-right corner, showing how the targets and decoys keep moving around the play area. This view demonstrates normal gameplay when I’m scoring points, avoiding the bomb, and keeping my misses low over a full minute.


Figure 9: Game Finished With Score
 
This screenshot shows my PizzaMaker form in use with a sample custom order filled out. The customer name is entered, several ingredients are selected, and a couple of Strange Add Ons are highlighted to show how flexible the toppings can be. A stuffed crust option is chosen, the sliders are set to higher sauce and cheese levels, and the delivery time has been picked. The large colored box on the right represents the selected pizza box color that will be saved with the order. This screen demonstrates that all main inputs work together before I create and store the pizza.





ADD ON


1.	What was challenging?
The most challenging part of this project was getting the timer, game logic, and form to stay in sync. I had to make sure the stopwatch was updating every second, while the target and bomb buttons moved on the correct schedule and stayed inside the form when it was resized. It was also tricky to track hits and misses in a way that felt fair to the player. A small mistake, like not wiring the form click to count a miss, or forgetting to reset the GameModel when starting a new round, would throw off the score or game-over logic. I had to slow down, test one piece at a time, and double-check that FrmStopwatch called GameLogic correctly and that GameLogic updated GameModel the way I expected.
2.	What did you learn?
I learned a lot about how timers and event-driven code really work in a Windows Forms app. Instead of putting everything in the form, I let GameLogic handle the rules for scoring, misses, game over, and level changes, while GameModel stored the score, misses, and level. That separation made it easier to see what was going wrong when something didn’t update correctly. I also learned how to treat almost anything as an “event” in the game: clicking the target, clicking the bomb, clicking on empty space, or the timer tick all run through the same logic. Seeing the Game Over message pop up exactly when I hit 10 misses or when the time limit expired helped the layered design click for me.
3.	How would you improve on the project?
If I had more time, I would focus on making the game feel more polished for the player. I’d add better feedback when you hit the target or bomb, like quick color flashes or sounds, so it feels more satisfying and clearer. I’d also like to add difficulty levels where the target gets smaller or moves faster as your score goes up, instead of keeping everything the same speed. Another improvement would be to add a high-score screen that saves your best score and fewest misses, maybe to a JSON file, so players can see their progress over time. Finally, I’d clean up the layout so it scales nicely on different screen sizes while keeping the timer and scoreboard easy to read.
4.	How can you use what you learned on the job?
What I learned from this Whack-A-Mole project applies directly to a lot of real-world apps, not just games. Many programs need to react to user actions and time-based events at the same time, like dashboards that refresh live data or tools that track time and performance. Understanding how to keep the UI separate from the logic and data layers will help me build systems that are easier to test and maintain in a team environment. The way I used GameModel and GameLogic here is similar to how business apps track state, apply rules, and then update the screen. Being able to reason about timers, user clicks, and clear game-over conditions will carry over into any job where I need to build interactive, responsive software.


