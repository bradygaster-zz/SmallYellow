# Small Yellow #
This is the home of Small Yellow, a simple robot built using a Netduino 2 and some other components. The original idea was inspired by [Monkey Robotics](https://github.com/xamarin/Monkey.Robotics/tree/master/Project%20Walkthroughs/BLE%20Remote%20Controlled%20Robot). This robot has a few of the same hardware components as the Monkey demo, but is far simpler. 

If Monkey is a Cadillac, Small Yellow is a Vespa. 

## Shopping List ##
Microcontroller and hardware integration coding is very specific. If you want to be able to download this code and it *just work* you'll need to use the exact shopping list below. Otherwise, you'll have to do some tweaking to your code. For example - this code contains a NETMF driver for the [SeeedStudio Motor Shield](http://www.seeedstudio.com/wiki/Motor_Shield_V2.0), which was ported directly from their [Arduino driver sketch](http://www.seeedstudio.com/wiki/File:MotorDriver20121210.zip). If you use some other motor driver you'll need to find - or author - the drivers for it. Nothing wrong with that, but if you want to grab-and-go... you know how it is. I've also included the prices so you know how much (around $100) you'll need to get approved by your purchasing department, manager, life partner(s), whoever...

1. [Seeed Motor Shield v2](http://www.seeedstudio.com/depot/motor-shield-v20-p-1377.html?cPath=132_134) ($19.50) **Note**: I would strongly encourage getting the pre-soldered version like I got from my local Radio Shack unless you are into soldering and you're good at it.
2. [Robot Chassis](http://www.aliexpress.com/item/New-Motor-Smart-Robot-Car-Chassis-Kit-Speed-Encoder-Battery-Box-For-Arduino-Free-Shipping/1924502066.html) ($11.27)
3. [Parallax Ping Sensor](http://www.parallax.com/product/28015) ($29.99)
4. [Netduino 2](http://www.netduino.com/netduino2/) ($34.99)
5. [USB Recharger](http://www.amazon.com/Portable-Ultra-compact-Aluminum-Capacity-Smartphones-Black/dp/B00KMONPEW/ref=sr_1_48?s=electronics&ie=UTF8&qid=1420914673&sr=1-48&keywords=usb+rechargeable+battery) ($12.99) 
6. A breadboard - any breadboard will do, just search Amazon or visit your local Radio Shack or other electronics store. 

## Setup ##
**Note: this project requires some soldering**. Just sayin'.

The initial setup is almost exactly the same as the Monkey project, since yellow makes use of the same hardware. If you use a different chassis you'll need to follow that one's instructions, but if you use the same one as these two projects, the [Monkey chassis instructions](https://github.com/xamarin/Monkey.Robotics/blob/master/Project%20Walkthroughs/BLE%20Remote%20Controlled%20Robot/AssembleChassis/Readme.md) are as good as you can get in a walk-through. 

### Subsequent Instructions ###
Once you get the chassis built, the remaining instructions should be pretty easy to follow. I've [uploaded a video to YouTube of the robot in action](https://www.youtube.com/watch?v=akr_rfLnkyQ&feature=youtu.be) so you can see the end result. From the chassis construction step it's really just tape, wire, and shield attachment. 

Here are a few pictures of the robot once it has been fully assembled. 

Top View: 

![](https://raw.githubusercontent.com/bradygaster/SmallYellow/master/images/robot-01.jpg)

Close-up:

![](https://raw.githubusercontent.com/bradygaster/SmallYellow/master/images/robot-02.jpg)

**Very important**: As you're connecting wires and inserting batteries, make sure your robot isn't sitting on top of your kitchen counter, on the plank of your pirate ship over the water, or on the ledge of a building. When the power hits the motors, the robot will roll, and very possibly roll very quickly. Then bad (or funny to the insensitive folks around you at the time) things will happen. 

1. Attach your breadboard, Netduino 2, and battery pack for the chassis to the chassis. I used double-sided tape, but you could use flex-ties through the chassis holes or screws. **Note**: make sure the breadboard is on the *front* of the robot chassis, and don't freak out if you end up having to reverse it later (you've got a 50/50 shot of getting it right the first time).
2. Attach the motor driver to the Netduino 2 - nothing special or difficult here, just *plug it in*
3. Attach the power source to the Extern Power Jack on the motor driver, and then attach the motors to the Motor A and Motor B interfaces. I followed the guidance on the [Motor Driver wiki page](http://www.seeedstudio.com/wiki/Motor_Shield_V2.0) *to the letter*. I didn't have to change any jumpers from the out-of-the-box state; it was ready for what I needed to do. 
4. Put the Ping sensor into the breadboard and wire the Netduino up to it
5. Connect your computer to the Netduino and deploy the code
6. Insert the batteries and let it rip