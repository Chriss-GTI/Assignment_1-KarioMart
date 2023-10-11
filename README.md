# Assignment_1-KarioMart

The intention of my game was that it should be a fun and satisfying game where the purpose is that you control a car and drive around in a track to achieve different goals. These goals are as follows:  

1. To master the controls of the car where you can do different moves to move around the track faster like accelerating but then also stop accelerating to be able to turn a corner instead of driving into a wall. The possibilities are endless. 

2. To go through every checkpoint and try to collect every powerup. 

3. Then do all of that but as fast as you can to challenge yourself. 
 


In order to play my game, you need to load the “Main Menu” scene. From there you can navigate yourself through all the different scenes. You are at any point during a level able to pause the game and use the menu to navigate yourself around the scenes. 



The structure of my code is as following: I have a PlayerController script that enables car movement, but the script also includes a list that tracks checkpoints so that you can only complete a lap by going through all checkpoints and then the finish line. This same script also includes a lap counter that is connected to a script in the finish line to see if the player has completed 3 laps to allow it to finish the race.
The checkpoint script includes a trigger that depending on which checkpoint is triggered, spawns a pickup on a game object called “Spawnpoint”. 



How to play the game: 

- Use the left mouse button to increase and decrease the Car's speed, press to increase and let go to decrease. 

- Use the right Mouse button to reverse (move backwards). 

- Move the mouse to make the Car turn. 

- Drive through (green) checkpoints to make powerups spawn. 

- Pick up (yellow) powerups to make the Car faster. 

- After driving through all checkpoints finish your lap by driving through the (blue) Finish line. 

- Rince and repeat 3 times to finish the race. 

- After you finish the race can you chose to replay the same level or pick a new one. 

- You can use ESC at any time during one of the levels to pause the game. 

- The Pause menu consists of a Resume, menu and quit option. 

 

My sources:  

https://assetstore.unity.com/packages/2d/textures-materials/nature/terrain-textures-pack-free-139542 (had to scale down the assets because they were way to big) 

https://www.youtube.com/watch?v=_BHX-8HAF34 (How to EXPORT a BLENDER MODEL with TEXTURES and IMPORT it in Unity) 

https://www.youtube.com/watch?v=CLSiRf_OrBk (POWER UPS in Unity) 

https://www.youtube.com/watch?v=JivuXdrIHK0 (PAUSE MENU in Unity) 
 
https://gamedevbeginner.com/async-in-unity/ (Async in Unity, better or worse than coroutines?) 


 
The Unity version for the project is: Unity 2022.3.8f1 

Name: Christoffer Persson 
