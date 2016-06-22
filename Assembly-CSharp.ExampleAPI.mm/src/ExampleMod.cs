using System;

// This class is the "main" mod class. ETGMod will use the name and version inside it.
// It must extend ETGModule... yet ETGModule itself isn't done.
public class ExampleMod /*: ETGModule*/ {

    // The mod name. It shall not contain spaces - any other character is valid, though.
    public /*override*/ string Name { get { return "ExampleAPI"; } }

    /* The mod version. Following rules when adding API backends as dependencies in game mods:
     * The major (X.) version must be the same (breaking changes).
     * The minor (.X) version can be lower in the game mod metadata.
     * Example using ExampleAPI as API backend and UsingIt as game mod:
     *                               DEPends INStalled
     * UsingIt depends on ExampleAPI 1.0 and 1.0 is installed. Pass.
     * UsingIt depends on ExampleAPI 2.0 and 1.0 is installed. Fail.
     * UsingIt depends on ExampleAPI 1.0 and 2.0 is installed. Fail.
     * UsingIt depends on ExampleAPI 1.5 and 1.5 is installed. Fail.
     * UsingIt depends on ExampleAPI 1.5 and 1.6 is installed. Pass.
     * UsingIt depends on ExampleAPI 1.5 and 1.0 is installed. Fail.
     */
    public /*override*/ string Version { get { return "1.0"; } }

    public /*override*/ void Start() {
        // Initialization code goes in here.
    }

}
