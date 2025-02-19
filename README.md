# ResoniteUnityExporter

A Unity Plugin to easily export Avatars or Worlds from Unity into Resonite.

It does this by:
- Grabbing the raw mesh, material, blendshape, bone, dynamic bone, etc. data directly from unity,
- Sends that to Resonite via inter-process communication (using a memory mapped file),
- Decodes directly in Resonite

This lets us avoid any of the limitations of converting to an intermediate file first.

## Tutorial

### Installing the unitypackage

Go to the releases page

[https://github.com/Phylliida/ResoniteUnityExporter/releases](https://github.com/Phylliida/ResoniteUnityExporter/releases)

- Pick the most recent release
- Scroll down unitil you see `Assets`, expand it
- Download `ResoniteUnityExporter.unitypackage`

![download ResoniteUnityExporter.unitypackage](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/releases%20unity%20package.png?raw=true)

- Open Unity
- Open your scene containing your Avatar.
- In the top bar, click `Assets` -> `Import Package` -> `Custom Package`

![Assets -> Import Package -> Custom Package](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/Import%20Package.png?raw=true)

Select the downloaded `ResoniteUnityExporter.unitypackage` and press `Open`

![select downloaded resonite unity exporter](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/import%20package%20file.png?raw=true)

A window will pop up in Unity, press `Import`

![import package contents](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/import%20package%20popup.png?raw=true)

Click the new `ResoniteUnityExporter` tab at the top of the screen and click `Open Unity Resonite Exporter`.

![open unity resonite exporter](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/open%20resonite%20unity%20exporter.png?raw=true)

You should see a menu pop up.

Adjust the `Avatar/World Name` as needed, and follow the instructions to set your near clip.

![Adjust name and near clip](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/resonite%20exporter%20window.png?raw=true)

A correctly set near clip should be as small as possible while having nothing in the way.

For example:

![Correct near clip](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/near%20clip%20fixed.png?raw=true)

Now you are ready to import your avatar.

There are two options from here:

1. Run `ResoniteUnityExporterStandalone.exe`.

This is a standalone program that uses Resonite libraries to convert your avatar/world into a .resonitepackage.

You can later copy paste the .resonitepackage in game to import your avatar.

This is easier to get setup and does not require any mods.

See [Running Resonite Unity Exporter Standalone](#Running Resonite Unity Exporter Standalone)

2. Install `ResoniteUnityExporterMod`.

This is a `ResoniteModLoader` mod for Resonite.

This mod allows Resonite to communicate directly with Unity.

When you press "Export to Resonite" your avatar will pop up in the world you are in.

See [Installing Resonite Unity Exporter Mod](#Installing Resonite Unity Exporter Mod)

### Running Resonite Unity Exporter Standalone

Go to the releases page

[https://github.com/Phylliida/ResoniteUnityExporter/releases](https://github.com/Phylliida/ResoniteUnityExporter/releases)

- Pick the most recent release
- Scroll down unitil you see `Assets`, expand it
- Download `ResoniteUnityExporterStandalone.exe`

![Download ResoniteUnityExporterStandalone.exe](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/Download%20ResoniteUnityExporter%20Standalone.png?raw=true)

- Run it.
- It'll ask for your Resonite location, select `Resonite.exe` and press Ok.

(It needs this to use Resonite's libraries. This helps it be hopefully more forward compatible)

Now it should print out lots of text as it initializes things.

Eventually the text should calm down, once it does that you are ready to export your avatar!

Go to [Exporting your avatar](#Exporting your avatar)

### Installing Resonite Unity Exporter Mod

Go to the releases page

[https://github.com/Phylliida/ResoniteUnityExporter/releases](https://github.com/Phylliida/ResoniteUnityExporter/releases)

- Pick the most recent release
- Scroll down unitil you see `Assets`, expand it
- Download `rml_mods.zip`

![Download rml_mods.zip](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/Download%20rml%20mods.png?raw=true)

Now you need to install `Resonite Mod Loader`. The easiest way is to use [Resolute](https://github.com/Gawdl3y/Resolute).

Once it is installed, navigate to your Resonite directory. It's probably something like:

```
C:\Program Files (x86)\Steam\steamapps\common\Resonite
```

In there, create a `rml_mods` folder if it doesn't already exist.

Now unzip `rml_mods.zip` and still all the `.dll` files into `rml_mods`.

It should look like this when you are done:

![All the dlls are in the rml_mods folder](https://github.com/Phylliida/ResoniteUnityExporter/blob/main/TutorialAssets/rml%20mods%20done.png?raw=true)

(there may be more files if you also have other mods installed)

Now Unity can talk to Resonite. Go to [Exporting your avatar](#Exporting your avatar)

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