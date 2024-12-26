## Resonite Bridge

(this is the old attempt I made at making a remote execution wrapper of resonite's dlls. It is very cursed and not recommended, though compilation of wrapper only has 10 errors left that'll be fixed
with just these changes:
- look at protected/public/private values for types and correctly make things non-public as needed when we have internal things
- split wrappr dlls into seperate ones for each wrapped dll instead of one big dll 
-- (that is needed to resolve some ambiguities that come up when internal stuff are seen where they shouldn't be)
- final other todo: make certain classes (like float3, and generally most json stufF) not be wrapped in the same way
- so they can serialize nicely
it should work. But this has so much mantinence burden (need to manually specify all namespaces, need to specially handle cases, no support for spans and ref structs) that I decided to pursue
a different direction.)

Resonite Bridge is a tool for modders and content creators that allows you to work with internal Resonite functions/data via Inter-Process Communication.

It does this by creating a “remote proxy” DLL that can be used just like FrooxEngine/ProtoFlux/Elements libraries. Whenever you access any property or call any method, the property/method will be called remotely in Resonite instead.

# Why?

Built to be used in a Unity -> Resonite exporter, but works for other stuff too.

There are a few problems this solves;
- Can run mod-like code via an external program not attached to Resonite
- Unity only supports .NET 4x, while Resonite is eventually going to move most libraries to .NET 9. The wrapper dlls generated are .NET 4x so they’ll work in Unity.
- Unity and Resonite are separate processes, this allows them to talk to each other
- We still get nice autocomplete support and static type checking in IDEs

# How?

Communication happens via NamedPipes (with more pipes allocated as needed to let you have multiple senders and receivers).

The protocol for the named pipes is fairly simple. When a message is received, it can do one of the following things:
- LookupType
- CallConstructor
- CallMethod
- SetField
- GetField
- SetProperty
- GetProperty

Also sent across is the type data (as a string), the target object, and any arguments.

What’s returned is the result(s) of the call, if relevant.

## But how do you encode objects/parameters?

- For objects that can be serialized, they are sent across as binary json.
- Otherwise, they are represented as uuid.

Either way, we also send across type information.

## Isn’t that too verbose?

Yes, with only this protocol, consider the classic
FrooxEngine.Engine.WorldManager
    .FocusedWorld.RootSlot.AddSlot("hi");

The equivalent code is
var Engine = LookupType("FrooxEngine", "FrooxEngine.Engine");
var currentEngine = GetProperty(Engine, "Current");
var worldManager = GetProperty(currentEngine, "WorldManager");
var focusedWorld = GetProperty(worldManager, "FocusedWorld");
CallMethod(focusedWorld, "AddSlot", "hi");

Much less readable. To fix this, we create “wrapper DLLs”.

## Wrapper DLLs

We use ILSpy’s c# library to scan through all types in the various FrooxEngine DLLs (FrooxEngine, ProtoFlux.etc, Elements.Core, etc.) and generate new “wrapper” DLLs. These DLLs will look the same as before, but internally will use the CallMethod, GetProperty, etc instead of the original code.

Concretely, consider:
class Bee {
  int Test(int a) {
    return a + 1;
  }
}

In the wrapper DLL, this will instead look like
class Bee {
  ResoniteBridgeValue __backing;
  int Test(int a) {
    return CallMethod(__backing, “Test”, a);
  }
}

__backing stores the uuid representing the actual “Bee” object held in Resonite. CallMethod sends the data across IPC and gives us the result once it is done.

(The actual wrappers are slightly more complex because they need to handle types correctly and add a single constructor that takes a __backing. But this is the general idea)

Once we do this for every type in the Resonite DLLs, we are given new DLLs we can import. Importing these DLLs lets us write
FrooxEngine.Engine.WorldManager
    .FocusedWorld.RootSlot.AddSlot("hi");

Which will actually do something like
var Engine = LookupType("FrooxEngine", "FrooxEngine.Engine");
var currentEngine = GetProperty(Engine, "Current");
var worldManager = GetProperty(currentEngine, "WorldManager");
var focusedWorld = GetProperty(worldManager, "FocusedWorld");
CallMethod(focusedWorld, "AddSlot", "hi");

This gives us the best of both worlds: we can write code that looks identical to modded code, with autocomplete and types. Under the hood it’s actually just remotely executing on Resonite running on a separate process.

## Security

As described, this gives any process running on your machine the ability to connect to Resonite and run arbitrary code! This is not ideal.

To fix this, this mod supports Whitelist files. Whitelist files will store all methods/properties/fields that you allow to be accessed remotely.

Anything not in the whitelist will be ignored.

Whitelists can be tedious to create manually, so we provide a tool to create them automatically through parsing your code.

(this is todo, also isn't ideal because reflection lets you sorta bypass this in hacky ways)

## Performance 

Because every operation needs to send data to Resonite and wait for a response (and use Reflection to lookup what to call), there is some overhead.

For minor things this is not a big deal, it’s all local to your PC so quite fast. But it’ll still show up if you are doing something like modifying every vertex in a large array.

To get around this, in this case I recommend requesting the large array from Resonite, processing everything locally, and then only sending the final array back.

In general, just keep this overhead in mind when creating things. If you need loops calling Resonite functions, I recommend my other tool instead.

# FAQ

## Why not Netstandard 2.1?

I would love this, and if someone can figure out how to do this well I’m open to a PR. But as is, there are certain language features not supported in 2.1 that are a pain to wrap manually. Net 4.x significantly reduces the maintenance burden.

## Why not use Resonite’s data model?

An overhaul is planned so I didn’t want to rely on it. Also, this is more general.

## Isn’t there a better way to do this? These wrapper DLLs seem a bit cursed

I’m open to suggestions! This was the least bad option I could come up with. I did put in a lot of effort to make sure there isn’t too much maintenance burden as things are added to FrooxEngine, but it’s not perfect. 

The best alternative is sending code to Resonite and compiling and running it there, which is in progress.