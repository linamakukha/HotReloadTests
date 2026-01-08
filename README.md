# Hot Reload Sample (Rider)

Minimal .NET console application used to verify **Hot Reload** behavior in JetBrains Rider.

---

## Requirements

- .NET SDK 10
- JetBrains Rider (Hot Reload enabled)

---

## Run

1. Open the project in Rider
2. Ensure Hot Reload is enabled:  
   `Settings → .NET → Hot Reload`
3. Start the application using **Run** or **Debug**

---

## Hot Reload Scenarios
- Feature setup tests can all be tested
- To check that Hot Reload works both with the Run, Debug with and without breakpoints
- To check different ways of applying changes with Hot Reload
- To modify text outputs, if conditions, renamings, Thread sleep and make sure changes are accepted
- Check syntax errors
- Check method signature changes via Hot Reload and catch a runtime error
- Change already executed code 
- Check that user can modify and save changes in any code files but Hot Reload doesn’t apply any changes if Hot Reload is disabled in Settings


