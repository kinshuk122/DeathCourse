# About

# Description
Deathcourse is a 3D action casual game in which Jake must follow the map provided by a strange old man and navigate through various obstacles, including rocky terrain, 
a treacherous maze, and lava. As promised by the old man, there lies treasure at the end of the route.

The rocky terrain requires Jake to dodge boulders, mechanical objects, and spikes, using his agility and precision to avoid falling and losing his life. 
The maze in the second level has traps, and spike balls to crush Jake. It is a challenging maze that requires Jake to use his wits and memory to find the correct 
path to the exit. The lava in the third level tests Jake's endurance and timing as he fends off blades. The volcanic balls go up and down and walk through thin beams 
by balancing.

# Game Development
Each level of the game is designed to offer a new and unique experience. The game communicates with players through the text added at various points. It also gives a 
sense of personal touch to the player. I built the game using C# with Unity and all the 3D models were created from scratch using Blender.

I did not want to use a third-person template. Therefore, I implemented my own third-person camera which proved difficult at first. However, after a day of working on it 
and receiving help from the online gaming community, I finally fiqured out how to properly set everything up. The key to success was adding two empty objects for the 
camera to look over the player character's shoulder. I also learnt more about blend trees and parameters in animator.

I had to rotate an object along its corner. Hence, I learnt how to rotate an object along different axes by changing the pivot point. To achieve this, I inserted the 
game object into an empty object, allowing me to change the pivot point.

The maze in the second level was originally created in Blender, but I quickly realised that the mesh collider was not functioning like I would like to. To solve this 
issue, I created the maze in Unity using the pro builder tool.

I wanted to design a platform that moves on its own while the player is standing on it. I initially used animation for the platform movement, but I was mistaken. 
I eventually added two colliders, one with a trigger and one without, and changed the player transform to platform position to keep the player from falling off the 
platform.

Creating the lava scene was a difficult task on its own. I had to write code to loop a moving image over the terrain to make the lava move.

# Scripts
[tree/master/Assets/scripts](https://github.com/kinshuk122/DeathCourse/tree/main/Assets/Scenes)
