# Mega Man Battle Network Save Editor

This is a program that can modify and create save files for games in the Mega Man Battle Network series. It can load and export both GBA saves and Mega Man Battle Network Legacy Collection saves, including loading one and exporting as the other, or for different game versions or languages. It aims to let you edit just about anything stored in the save that a player would want to edit.

Downloads are available on **[the releases page](https://github.com/vgperson/MMBNSaveEditor/releases)**.

## Supported Games

Both the **GBA** and **Legacy Collection** versions of the following are supported:

- Mega Man Battle Network (English) / Rockman EXE (Japanese)
- Mega Man Battle Network 2 (English) / Rockman EXE 2 (Japanese)
- Mega Man Battle Network 3 Blue/White (English) / Rockman EXE 3 original/Black (Japanese)
- Mega Man Battle Network 4 Red Sun/Blue Moon (English) / Rockman EXE 4 Tournament Red Sun/Blue Moon (Japanese)

Support for Mega Man Battle Network 5 and 6 may possibly be added in the future, but I make no promises. There are no plans to add support for the Mega Man Star Force games.

GBA saves should have the extension **.sav** (raw SRAM), **.sps/.xps** (SharkPort save for GameShark/Pro Action Replay), or **.gsv** (GameShark SP save). Encrypted SharkPort/GameShark SP saves, and any other GBA save formats not listed, are not supported; please convert them to a supported format first.

Legacy Collection saves should have the extension **.bin**. Both Steam and Switch saves should be supported. Steam saves are generally located in ".../Program Files/Steam/userdata/<your Steam ID>", with Volume 1 being the "1798010" folder there and Volume 2 the "1798020" folder.

Note that the games can have varying levels of support, particularly in terms of "identifying descriptors." While the Story Chapter (a value indicating progress in the story) and the Flags (an array of several thousand true/false values for each game) can be edited freely, descriptions for them are incomplete and may have inaccuracies. They are very likely to remain this way, more or less, given the amount of effort required to fully identify them. Mega Man Battle Network 3's are currently the most complete. In each game, I focused on making sure to at least identify flags related to obtained upgrades, and the most relevant story chapter values (i.e. corresponding to game-start and endgame states).

## Disclaimers and Warnings

Though I have tested to the best of my ability, there is no guarantee saves produced by this program will work in-game. **Be sure to keep a backup** of any saves you load into the program.

**I take no responsibility for possible consequences of using edited Legacy Collection saves, such as bans, especially if used to play online multiplayer.** While I have aimed to ensure you can't obtain invalid chip codes or break folder rules, there may be oversights, and many other things are not limited to fully legitimate bounds. Using edited saves may also trigger Steam achievements in such a way that indicates abnormal play.

Though I feel fairly confident in them now, saves created from scratch by the program are inherently at least slightly more likely to have issues than edited ones based on legitimate save files. This is because created saves can only fill in areas the program recognizes while the rest is left blank, whereas editing an existing save will only modify recognized areas as necessary and keep the rest as-is. From-scratch saves also tend to have more aspects that can be used to identify them as fabricated, as perfectly recreating each byte is less of a priority than it simply working as expected in-game. This also goes for saves converted between GBA and Legacy Collection formats - recognized data will be transplanted as-is, but just as with a created save, anything else will be left blank.

Switch Legacy Collection saves, while in theory only slightly different from Steam saves, have not been tested on hardware.

GBA saves exported in SharkPort (.sps/.xps) and GameShark SP (.gsv) formats have not been tested with actual GameShark/Pro Action Replay devices. GameShark SP saves in particular do not have proper checksum calculations, so there's a good chance they won't work on actual hardware (though emulators will usually ignore the checksum). If they don't work, you may want to save in the basic SRAM format (.sav) and find a different program to convert them.

This program is built as a console application operated by keyboard inputs, rather than something with a full graphical interface and mouse support. A future GUI version is not entirely out of the question, but it is not currently a priority.

Some text for Battle Network 2, 3, and 4 reflects edits I made in my Translation Revision patches for those games, rather than the original English release. The differences usually aren't great enough that they should cause confusion, and in the case of edited chip names, the Add Chips menu supports using the original names to search. (Some notable ones include JapanMan -> YamatoMan in MMBN3, the "Mission 1-3" jobs -> "Special Op 1-3" in MMBN3, and MelSquare -> TaleSquare in MMBN4.)

## Using the Program

Upon starting the program, you're prompted to load a save file or create a new one from scratch (which will have you select the game and other settings like version).
After successfully loading or creating a save, you'll be taken to the main editor menu, where you can edit the data how you like and then save it to a file when you're done.

The options offered vary considerably depending on the game, but the program will show instructions for most everything.

### Primary Menus

Editable data is broadly divided into six main menu categories:

#### [1] Base Stats and Money

Manage HP, Zenny, BugFrags, and Regular Memory. Note that depending on the game, changing HP and Regular Memory here may not stick; the program will provide details on this if so.

#### [2] MegaMan Customization

Manage buster stats in Battle Network 1/2, armors in Battle Network 1, styles in Battle Network 2/3, Navi Customizer effects in Battle Network 3+, and Patch Cards in Battle Network 4.

#### [3] Chips, Folders, Library

Give yourself chips, unlock and edit folders, and set what's registered in your Library.

#### [4] Progress and Location

Manage your current location, story chapter, playtime, flags used for a wide variety of things, and tournaments in Battle Network 4. The tournament menu provides options for editing a tournament board in progress, as well as a way to set up the random seed to produce a certain tournament board.

#### [5] Collected Items

Manage items of all types (upgrades, key items, SubChips, programs). Notably, the Upgrade Items menu lets you set items like HPMemories and RegUPs as "obtained," automatically setting associated flags; this can be used as a way to easily view which upgrades you have and haven't obtained.

#### [6] Miscellaneous

Anything else that doesn't fit elsewhere, often game-specific.

### Global Actions

Most menus offer the following always-available actions:

#### [Z] Save to File

Opens a file prompt to save the current save data to a file in the current format. (You can continue editing the same data afterward.)

#### [C] Copy Save Info to Clipboard

Compiles most information about the current save data as text that is copied to the clipboard.

#### [V] Game Version

Press this to toggle between game versions for games with two versions, changing certain things accordingly.

#### [B] Exporting As...

Press this to change other things about export settings (via a sub-prompt): whether the exported save should be for GBA or Legacy Collection, the language (for GBA), or the save format (for GBA).

#### [L] Load or Create New File

Shows the same prompt that's shown on startup to load or create a save. If you back out of this, you can continue editing the same save data.

#### [X] Quit

Shows a prompt to quit the program.

### General Controls

In most menus, you press number keys to select the corresponding options.
Pressing Backspace will usually take you back to a previous menu or back out of selections.
Some menus with multiple pages let you switch pages using the Arrow Keys or Enter.

When choosing to edit a value, you will often be prompted to type in a number or string and press Enter.
Entering nothing for these (or something invalid) will usually back you out of it without making changes.

### User Settings

The UserSettings.txt file in the program folder contains a few settings you can configure by editing it.
Most notably, you can provide your Steam ID there to make it automatically be set in any Legacy Collection saves you load/export.
Your Steam ID must match in order for saves to load in the Steam version, so this helps ensure it's always correct.

## Known Issues/Unintuitive Behaviors

### General: Area Warping

If intended plot progression is skipped to go to later areas, even if the Story Chapter is set accordingly, some areas (usually real-world ones) might not play their music. This seems related to flags or other values that would be set through normal game progression not being set, so it's sort of to be expected.

Similarly, if you go to an area with a Story Chapter value you couldn't normally have there, it might not have any NPCs due to the game not defining an NPC layout for that chapter.

### General: LocEnemy Target

The options for LocEnemy Target are limited to randomly-appearing ghost/secret Navis for the respective game, as those are the most obviously useful applications of the function. If a save is loaded with some other encounter targeted, it will show a generic descriptor, but there is currently no way to manually set "standard" encounters; this would require fully defining the encounter tables. Also, to my knowledge, it is probably not possible to target encounters that are not actually in the random encounter tables (i.e. ghost Navis triggered by a specfic spot).

There are some circumstances in which saves using LocEnemy can have strange behavior, including crashing the game. That's the gist of it; what follows is largely just a detailed explanation of the specific ways this applies if you want to know.

If the game version or language is not correctly set upon loading a save, and it has an active LocEnemy target (ones set manually should be fine), switching game version or language could result in a crash or wrong encounter. This is because the game stores the current target encounter as an address value pointing directly to an encounter in the game data, and the location of that data shifts between each game version. The editor will convert the encounter address to match the target version when saving, but this can become faulty if the version or language was not correctly recognized at first. Also, not all GBA version revisions may be accounted for, so if those revisions have different addresses than expected, that could also cause issues.

Related to the above, Battle Network 2 and 3 do not have a reliable means of automatic language detection (except when loading a special format like SharkPort saves, which provide extra info). If the program cannot detect whether a loaded save is for the English or Japanese version, it will assume English, but you will be prompted to press J to switch it to Japanese. If you don't select the correct language at that time (even if you then change it via the in-editor function), handling for the LocEnemy target will be incorrect unless you manually choose a new target.

Currently, encounter IDs for Battle Network 2 are based on subareas (and furthermore, "special" encounter groups in some subareas), while the other games are only broken up by area. This is because in BN2 only, the encounter data within areas did not line up between GBA/LC, so this was a necessary step to properly convert encounter addresses between them. I may eventually properly do this for the other games as well, as this theoretically lessens the likelihood of the aforementioned crashes - it just requires defining a bunch more addresses.

### Mega Man Battle Network 3: Shop Versions

Most shop inventories differ greatly between the Blue and White versions. Thus, if you switch the game version of a save, the program will fully restock (aside from purchased HPMemories) all shops that are different between versions to match the new version. There's no real way to know if you purchased something back when the save was a different version, so this ultimately seemed like the best approach.

### Mega Man Battle Network 4: Program Effects and Patch Cards

While some Patch Card mods do have effects that show up in the Program Effects menu and save info, these won't immediately appear when setting Patch Cards in the editor, only if you load a file that was saved with them active. Having the editor explicitly update the Program Effects values based on the active Patch Cards is ultimately an unnecessary effort, because the game itself will constantly do so.

For the same reason, effects exclusive to Patch Card mods (or exclusive values for "standard" effect types, even) are not offered as options in the Program Effects menu, as they would just get immediately reset without the associated mod installed. (Indeed, between this and each Patch Card only functioning in its intended slot, it would seem impossible to achieve any "unintended" combinations of Patch Card mod effects through save editing alone.)

And finally, HP+ is also not included as a Program Effects option for BN4 because it too is automatically reset on load according to installed programs and Patch Cards.

## Special Thanks

- The Rockman EXE Zone, used as a reference for all kinds of game data.
- Prof9's TextPet, used to extract game scripts for reference.
- Prof9's Mod Card Kit for compiling e-Reader card data.
- LuaGaia's collection of Switch Legacy Collection saves, used to aid in identifying LC data layouts.
- mGBA for testing, various debugging tools, and as a reference for handling other GBA save formats.
- Ghidra for use in analyzing GBA assembly code.
