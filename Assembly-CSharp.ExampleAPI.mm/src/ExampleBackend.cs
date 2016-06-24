using System;

// This class is the "main" mod class. ETGMod will use the name and version inside it.
public class ExampleBackend : ETGBackend {

    public ExampleBackend()
        : base(
            "ExampleAPI", // The backend name. It shall not contain spaces - any other character is valid, though.
            new Version(1, 0) // The backend version. See the rules below regarding the version.
        ) { /* Initialization happens in Start! */ }
    
    /// <summary>
    /// Set this to a delegate / method being passed a string (current text) and returning a string (new).
    /// Set it to null to not change the text.
    /// 
    /// Game mods should be able to access this freely as long as the backend is injected.
    /// Making the setting fields removes the need for an instance holder.
    /// </summary>
    public static Func<string, string> SpeedrunText;

    public override void Start() {
        // Initialization code goes in here.
    }

    public override void Update() {
        // Update code goes in here.
    }

    public override void Exit() {
        // Disposal code goes in here.
    }

}
