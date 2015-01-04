CoinZoom
==========

This project was an exercise to create a common mechanic you see in mobile and PC games where a coin or powerup spawns, and once clicked it bursts into a smaller group and flys off towards a counter.

In this project we use a coin, once you click it, the primary coin is destroyed and a burst of smaller coins is spawned where the old object was and then they zoom off towards the coin counter on screen and disappear once they get added. Right now each master coin has a value assigned and then randomly has 0-19 added, then that value is used to spawn the smaller coins. 

Usage
-----
You can right click anywhere to spawn a new coin, and then left click to collect it.

How it works
------------
There is a prefab for a Master Coin that has a coin value associated with it. Once you click on one of these master coins then it calls a function to spawn the burst of coins, and then destroys itself. It does this by pulling the coin value from the master coin then loops through and instantiates X amount of coins with a slightly random X/Y position to offset them a bit. Each coin that then spawns has its speed set with a random range of 0->0.5 to give some more randomness. Once the smaller coins spawn they have a MoveTowards() function in their Update() routine that zips them off towards an anchor point on the screen, which each coin finds as it spawns. (This would allow the anchor to move around, like a growing experience bar).

And that's pretty much it, if you have any questions feel free to shoot me an email at: leonard4@gmail.com

Credit
======
If you use this in a project, I'd ask that you drop me an email at leonard4@gmail.com saying Thanks! or crediting me somewhere, I don't really care but would be nice to hear if you use this! :)
