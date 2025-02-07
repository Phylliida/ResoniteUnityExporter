# ResoniteUnityExporter

A Unity Plugin to easily export Avatars or Worlds from Unity into Resonite. (Under construction)

## How to use?

Start by opening up a scene with an avatar that's ready to be uploaded to a platform like VRChat.

Now import the unity package (TODO).

In the top of your Unity window you should see a `ResoniteUnityExporter` dropdown.

Click it and press `Open Resonite Unity Exporter`.

Now wait for it to connect to Resonite (Either run the standalone or install the mod)

Once it has connected, increase adjust near clip until you don't see parts of your avatar.

Then press `Export to Resonite` to export your avatar. It should appear at origin.

Look for an Avatar Creator window to appear next to where you are standing.

## Project Structure

`ExampleUnityProject` is a Unity project that has everything installed that you'll need,
feel free to open it up and add your avatar's unitypackage.

`ResoniteUnityExporterShared` contains the data structures used to represent mesh, texture, etc. data.
This library is used by the unity library and also by the mod and standalone.

`ImportFromUnityLib` is the library used in the Mod/Standalone, it contains the core of the code
to take the data and import it into Resonite.

`ResoniteBridgeMod` is the code for the Resonite mod, that uses `ImportFromUnityLib` to make the
avatar appear in whatever world you are in.

`ResoniteBridgeStandalone` is a standalone custom headless server, you can't connect to it and it's
anonomyous. This also uses `ImportFromUnityLib`, it's used to load resonite libraries needed to make a .resonitepackage.
This is also useful for debugging since startup time is much faster.

[https://github.com/Phylliida/ResoniteBridgeLib](https://github.com/Phylliida/ResoniteBridgeLib) is
a dependency of this library, it contains the inter-process communication and serialization code.

## I want to suggest a change

Feel free to submit a PR! Contributions are welcome.

## 