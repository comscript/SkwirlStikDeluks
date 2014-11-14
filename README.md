SkwirlStikDeluks
================

Now with infinity percent more rocks!

## Visual Style

SkwirlStickDeluks (SSD) has a cel-shaded / toon-shaded look. The idea isn't to look cartoonish, per se, but simple in a clean, slightly surreal way. Unlike other cel-shaded styles, SSD will not be vibrant or colorful, but desaturated and washed out. Vibrant colors will be used as accents for visceral aspects of the game, like squirrel blood and fire.

## Player control

The view for the game is first person. Field of view is 95 degrees vertical by 135 degrees horizontal. Having a smaller field of view is a tactical disadvantage, so the largest possible field of view will be default, though we should consider having an option to lower field of view since a large FOV causes simulation sickness in some people.

WSAD motion with mouse for direction control. When moving, you move in the direction you are facing (as controlled by the mouse). When you are standing still, moving the mouse rotates the head / shoulders, using inverse kinematics, rather than rotating the whole body. Keep in mind that mouse motion rotates the head on a pivot; it does not rotate the camera in place. So when you look forward, your head is on top of your body. When you look down, your head is actually in front of your body. This allows you to see your body in-game, but also makes your head more vulnerable to certain dangers.

Double-tap WSAD to start sprinting in a direction. Over time, exhaustion will cause you to slow down. You can keep up speed by rapidly hitting WSA or D, though the longer you fight exhaustion, the harder it will be to keep going. 

Sprinting head-on into a tree will hurt.

Space jumps. Hitting space while sprinting makes you jump farther.

Shift crouches. Crouching after you jump lifts up your legs (good for clearing spike pits). Jumping after you crouch causes you to do a roll (extremely bad for clearing spike pits). 

Ctrl sets a resting position. If you press Ctrl+WSAD, you will lie prone in that direction. Ctrl without WSAD causes you to sit. Ctrl while sprinting will cause you to dive.

Hold F and click the mouse buttons to punch/hit/swing your weapon. Think "F" for "fight." Right button for your right hand, left button for your left hand. The longer you hold the mouse button, the harder you hit.

When fighting (holding F), if you hit both mouse buttons at the same time, you block.

You can swipe your mouse in the 4 directions to angle your attacks or blocks. 

Press Q and E to kick your left and right legs, respectively. I'm debating making these fancy but it might be better to keep it simple.

I'm not sure how fighting works while you're crouched but it's worth mentioning.

Hold C and click the mouse buttons to pick something up. Think "C" for "collect." Right click for right hand, left click for left hand, click both for both hands.

If you try to hold too many things in your hands, it becomes harder to hold them (you're more likely to drop things).

If you are holding things in each hand and try to pick up something with both hands, you will switch to holding everything in both hands.

Hold R and press a mouse button to throw them. Think "R" for "release." The longer you hold the mouse button, the harder you throw. 

Hold TAB and press a mouse button to use whatever is in your hand. I've got no mnemonic for this one, sorry.

If you press the middle mouse button while holding R, F, C or TAB, you will set that as the default action type, allowing you to perform that type of action simply by clicking the mouse.

If you tap the middle mouse button without holding anything, it'll reset the default to item-specific (sticks are good for fighting, squirrels are good for throwing)

If you try to perform an action that can't be performed (like "using" a rock on a squirrel), the item-specific default will be performed instead. If that fails, F is tried, then R.

# Squirrels

They are not to be trusted.

They are deadly in numbers.




