// OPTIONAL: Disabling some warnings
// Add this in every class using extern orig_ methods to tell the compiler to ignore the warnings.
#pragma warning disable 0626
// Add this in every class reimplementing fields that are never assigned to.
#pragma warning disable 0649
// END OPTIONAL

// Feel free to use what you're using - you're not limited to the usings of the injecting type!
using System;
using System.Collections.Generic;

// Gungeon / many Unity games don't use a namespace.
public class patch_SpeedrunTimer : SpeedrunTimer {

    private dfLabel dfLabel_0; // This field is private in SpeedrunTimer. It's the label.

    private extern void orig_Update(); // The original method will end up here.
    private void Update() {
        // Setup stuff happens in the original method.
        // Instead of copying it over, we just call it...
        orig_Update();

        // ... and replace the text.
        dfLabel_0.Text = "NEW WR! ALWAYS!";
    }

}
