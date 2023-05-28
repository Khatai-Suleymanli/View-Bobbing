## View Bobbing

This script provides a view bobbing effect in a Unity game, simulating the up and down motion of the player's view while moving. It enhances the player's immersion and adds a sense of realism to the game.

### Features

- Vertical and horizontal view bobbing effect.
- Customizable intensity and speed of the bobbing effect.
- Smooth transition between no movement and movement states.

### How it Works

The `ViewBobbing` script is attached to a game object and requires a `PositionFollower` component to be present. It calculates and applies the bobbing effect to the position offset of the `PositionFollower`, resulting in the desired view bobbing effect.

The main steps involved in the process are as follows:

1. Retrieving player input: The script captures the player's input in the vertical and horizontal axes, representing their movement.

2. Calculating the bobbing effect: If there is player input (movement is not zero), the script increments a `sinTime` value based on the elapsed time and the effect speed. This `sinTime` value is then used to calculate the vertical and horizontal bobbing amounts.

3. Applying the bobbing effect: The vertical bobbing amount is calculated using the sine function and the provided effect intensity. The horizontal bobbing amount is calculated using the cosine function, the effect intensity, and the right direction of the position follower.

4. Updating the position follower: The position follower's offset is modified to apply the vertical bobbing effect by adjusting the y-component of the offset. Additionally, the horizontal bobbing effect is applied by adding the calculated horizontal bobbing amount to the offset.

### Getting Started

To use the `ViewBobbing` script in your Unity project, follow these steps:

1. Attach the `ViewBobbing` script to a game object in your scene.

2. Make sure the game object also has a `PositionFollower` component attached to it.

3. Adjust the `effectIntensity`, `effectIntensityX`, and `effectSpeed` parameters to achieve the desired bobbing effect.

4. Run your game and observe the view bobbing effect when the player moves.

Thanks for using my script
