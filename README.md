# VR-Mini-Golf

Unity Version: 2018.2.17f1

Size On Disk: 807MB


Description:
VR Mini Golf brings you onto a 2-hole mini golf course. Putt the golf ball into the hole in serene wilderness, and then do it again with a hockey puck on a frozen Antarctic lake.
Developed in Unity for use with the HTC Vive through SteamVR.

To Run:
- Download this game as a zip file(green button above to the right)
- Unzip the zip file
- Navigate to /Builds/Windows
- Connect and power on your headset (if using one)
- Run the executable

or 

- Download and open with Unity 2018.2.17f1 and DO NOT update obsolete API's when asked.

Issues: 
Collisions between the golf club and the golf ball are strange. If you swing the club at a decent speed, the collision between the club and the ball doesn't register. So you have to swing slowly and gently.
Unity doesn't have cylindrical colliders as far as I can tell so I used a spherical collider for the puck. This is why the puck tumbles end over end instead of sliding across the ice.
"I haven't got the ball into the hole but level 2 starts" - Initially this was done for presenting but after 2 minutes and 45 seconds, level 2 will automatically start. If there are issues with hole 1 or the player can't get the ball in the hole, they still get to play level 2.

Sources:
See SOURCES.txt for a list of all external resources such as models, materials, etc.
