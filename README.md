# AutoInjector
Package for unity3d which allow auto inject instances for Zenject package.  

## Code examples
Examples see in `%Package%/Examples` folder

## Using
For start using this package add lines into `./Packages/manifest.json` like next sample:  
```json
{
  "dependencies": {
    "autoinjector": "https://github.com/k0dep/autoinjector.git#1.0.0"
  }
}
```
Instead `#1.0.0` paste version what you need.

> **Warning!** For unity 2018.3, After include dependency in manifest,
encies in manifest> you must manual add [TypeInspector](https://github.com/k0dep/type-inspector) and [UniRx](https://github.com/k0dep/Zenjct) depend