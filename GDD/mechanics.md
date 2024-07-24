# Gameplay Mechanics

## Core Mechanics

- **Movement**

  - _Player Movement_: The character can be moved using the arrow keys or the "WASD" keys. This allows for flexible control schemes catering to player preferences.

  - _Special Movement_:
    - _Dash_: The "F" key triggers a dash move, propelling the character swiftly towards the direction of the mouse pointer. This can be used for quick escapes or to close gaps rapidly.
    - _Sprint_: Holding down the Shift key enables the character to sprint. Sprinting increases the character's movement speed significantly and is infinite in duration. Pressing the Shift key again will cancel the sprint.

- **Combat**

  - _Close Combat_: Melee attacks are vital for surviving close encounters. These attacks do minimal damage but are effective in pushing enemies away, creating space for strategic positioning or retreat.
  - _Distance Combat_:
    - _Energy Pistol_: The primary ranged weapon is an energy-based automatic pistol. This pistol has different types of shots that can be selected and changed through the skill tree. Players can customize their weapon to suit their playstyle and can revert changes if desired. Types of shots may include standard energy blasts, piercing shots, explosive rounds, and more, each with unique effects and advantages.
    - _Grenades_:
      - _Standard Grenade_: Deals high damage within its explosion radius. Players need to be cautious, as being within the blast range will cause them to take damage as well.
      - _Flash Bang Grenade_: Emits a blinding flash and a loud bang that slows down enemies within its range. Players must also be cautious to avoid its effects, as it can slow them down if they are within its range.

- **Health and Shields**

  - _Health_: Health can be found throughout the map in the form of health packs or other restorative items. Health determines the player's survivability, and running out of health will result in the player's death.

  - _Shield_: Shields provide an additional layer of protection and can also be found around the map. Shields absorb damage before health is affected, offering a strategic buffer in combat. Both health and shields can be replenished by finding respective items scattered throughout the environment.

- **Environment Interactions**

  - _Cover_: Players can take cover behind objects to avoid enemy fire. The cover system provides strategic advantages and encourages tactical gameplay.

  - _Interactive Objects_: The game world includes objects that players can interact with, such as doors, switches, and items that can be picked up or manipulated.

  - _Destructible Objects_: Certain objects in the environment can be destroyed, affecting the battlefield dynamically. This can be used to create new pathways or eliminate enemy cover.

- **Enemy Behavior**

  - **Enemy Types**

    - _Basic Enemies_: Standard foes with simple attack patterns.
    - _Ranged Enemies_: Attack from a distance, requiring the player to use cover and strategy.
    - _Melee Enemies_: Engage in close combat, pushing the player to maintain distance.

  - _Mini Bosses_: Tougher enemies with more complex attack patterns and higher health, serving as mid-level challenges.

  - _Bosses_: Major adversaries with unique abilities, multi-phase battles, and significant narrative importance. [More info](GDD/characters.md)

- **Progression and Upgrades**

  - _Experience Points (XP)_: Players earn XP by defeating enemies and completing objectives. XP is used to level up and unlock new abilities.

  - _Skill Tree_: The skill tree allows players to customize their character's abilities and weapon types. Through the skill tree, players can unlock different types of shots for the energy pistol and other abilities. This allows for a tailored combat experience and strategic flexibility.

- **Puzzles**

  - _Switch Puzzles_: The player must find and activate a series of switches scattered across a room to unlock a heavily fortified door.

    - **Components**

      - _Switches_: Interactive elements that can be toggled or adjusted to activate or deactivate certain mechanisms or pathways.
      - _Indicators_: Visual or auditory signals that show the status of each switch (e.g., on/off, active/inactive). These might include lights, symbols, or displays.
      - _Circuitry or Mechanisms_: Systems that are affected by the switches, such as doors, platforms, or traps. The configuration of switches impacts these mechanisms.
      - _Feedback Mechanism_: Provides immediate feedback on switch interactions, such as visual changes in the environment or auditory cues when switches are activated or deactivated.

    - **Mechanics**

      - **Switch Sequencing**:

        - _Objective_: Activate or deactivate a series of switches in a specific order to achieve a desired effect, such as opening a door or unlocking a mechanism.
        - _Interaction_: Players need to figure out the correct sequence of switches, often using clues or trial-and-error to determine the order.

      - **Switch Patterns**:

        - _Objective_: Arrange switches to complete a pattern or achieve a specific configuration. This might involve toggling switches to match a visual pattern or to create a functional setup.
        - _Interaction_: Players adjust switches to align with a pattern or configuration shown on a display or given as a clue.

      - **Complex Switch Mechanisms**:

        - _Objective_: Solve puzzles involving multiple switches that interact with each other. Activating one switch might impact the state of others or affect multiple mechanisms simultaneously.
        - _Interaction_: Players must manage the interdependencies between switches, understanding how changing one switch affects the overall system.

      - **Environmental Feedback**:

        - _Objective_: Ensure that players receive clear feedback on their switch interactions. This might include visual changes in the environment, sounds indicating activation or deactivation, or mechanisms responding to switch changes.
        - _Interaction_: The game provides immediate feedback, such as doors opening, lights changing color, or auditory signals when switches are correctly configured.

  - _Pattern Recognition Puzzle_: The player deciphers a pattern hidden in the environment, floor tiles, to unlock a door.

    - **Components**

      - Pattern Panels: These are interactive surfaces or objects that display patterns, symbols, or colors. Players must interact with these to replicate or match a given pattern.
      - Pattern Indicators: Visual or auditory clues that indicate the correct pattern or sequence to be matched. This could be in the form of a display, hologram, or reference card.
      - Pattern Elements: Objects or symbols that need to be manipulated to match the pattern. This could include tiles, buttons, levers, or lights.
      - Feedback Mechanism: Provides feedback on the player's actions, such as a visual cue (e.g., glowing lights) or an auditory signal (e.g., a chime) when the pattern is correct or incorrect.

    - **Mechanics**

      - **Pattern Matching**:

        - _Objective_: Replicate a given pattern using pattern panels or elements. This could involve arranging tiles, setting colors, or aligning symbols to match a reference pattern.
        - _Interaction_: Players interact with the pattern panels or elements to adjust their positions, colors, or states until the pattern matches the reference.

      - **Pattern Sequencing**:

        - _Objective_: Complete a sequence of patterns in the correct order. This could involve a series of actions or interactions that need to be performed in a specific sequence.
        - _Interaction_: Players must follow a sequence shown on a display or given through clues, adjusting elements accordingly to complete each step in the sequence.

      - **Dynamic Patterns**:

        - _Objective_: Solve patterns that change or evolve over time. This could involve patterns that shift, rotate, or animate, requiring players to adapt their approach.
        - _Interaction_: Players must observe and react to changing patterns, adjusting their actions to match the evolving design.

      - **Feedback and Validation**:

        - _Objective_: Ensure players receive immediate feedback on their actions. This includes visual or auditory signals indicating whether the pattern is correct or if adjustments are needed.
        - _Interaction_: The game provides feedback through cues such as lights turning green, sounds of success, or prompts guiding players toward the correct pattern.

  - _Laser Puzzle_: Laser puzzles involve directing beams of laser light to specific targets or aligning mirrors to unlock doors or reveal hidden areas. These puzzles often require players to manipulate objects in the environment to achieve the desired laser path.

    - **Components**

      - _Laser Emitters_: Devices that shoot laser beams in a fixed direction. Players can interact with these to change their orientation or activate them.
      - _Mirrors_: Reflective surfaces that can be rotated or repositioned to redirect laser beams.
      - _Targets_: Sensors or receivers that must be hit by laser beams to open doors, activate mechanisms, or reveal hidden items.
      - _Receptacles_: Points where lasers need to be directed to complete the puzzle, often tied to unlocking doors or triggering events.

    - **Mechanics**
      - _Mirror Rotation_: Mirrors can be rotated or repositioned to redirect laser beams. Players need to adjust these mirrors to align the laser with the targets.
      - _Laser Splitters_: Special components that split a single laser beam into multiple beams, adding complexity to the puzzle.
      - _Color Filters_: Lasers of different colors that must be directed through corresponding color filters or sensors. This can add an additional layer of complexity.
      - _Trigger Mechanisms_: Some puzzles might involve using laser beams to power up or activate mechanisms that open doors or reveal new areas.

- **Keys and Pass Codes**

  - _Keys_: Keys are rewards for completing certain in-game challenges such as solving puzzles or defeating mini-bosses. These keys unlock special treasure rooms, which contain valuable rewards and experience points (XP).

    - **Acquisition**:

      - _Puzzle Completion_: Keys can be obtained by solving complex environmental or logic puzzles scattered throughout the game world.
      - _Mini-Boss Defeat_: Some keys are rewarded after defeating mini-bosses, adding an additional layer of challenge and accomplishment.

    - **Function**:

      - _Treasure Rooms_: Use keys to access treasure rooms filled with XP and other valuable items. These rooms are designed to reward exploration and mastery of game mechanics.

  - _Pass Codes_: Pass codes are required to access certain high-security rooms or areas within the game. These codes can be found through exploration or by solving specific puzzles.

    - **Acquisition**:

      - _Puzzle Solving_: Pass codes can be revealed by completing various in-game puzzles that challenge the player's problem-solving skills.
      - _Exploration_: Hidden pass codes may be discovered while exploring the environment, such as on data logs, encrypted messages, or hidden terminals.

    - **Function**:

      - _Secure Areas_: Enter pass codes to unlock rooms or facilities that contain advanced gear, critical story elements, or rare collectibles.
