# MTStatusBarOverlay Xamarin Bindings

Xamarin iOS unified bindings for great objc library MTStatusBarOverlay
[MTStatusBarOverlay](https://github.com/myell0w/MTStatusBarOverlay)

Current binding is built against [commit 4974f12aff1443b4767a7ea4ccd8875adf974712](https://github.com/Slepter/MTStatusBarOverlay/commit/4974f12aff1443b4767a7ea4ccd8875adf974712)

Available as a Nuget by installing package **MTStatusBarOverlayBindings.iOS**

### Binding details
Binding was done by compiling MTStatusBarOverlay for arm64/armv7/i386, merging those 3 .a files into one (using `lipo`/`libtool` command, details [here](http://www.cvursache.com/2013/10/06/Combining-Multi-Arch-Binaries/))
`libtool -static libMTStatusBarOverlay.a.armv7a libMTStatusBarOverlay.a.arm64 libMTStatusBarOverlay.a.i386 libMTStatusBarOverlay.a.x86_64 -o libMTStatusBarOverlay.a`
To check the final .a file, run this and you should see
`lipo -info libMTStatusBarOverlay.a`
`Architectures in the fat file: libMTStatusBarOverlay.a are: armv7 arm64 i386 x86_64`

After that against source code we run [`sharpie`](http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/objective_sharpie/) to generate C# classes.

`sharpie bind -output Binding -v -sdk iphoneos8.2 -scope MTStatusBarOverlay MTStatusBarOverlay/MTStatusBarOverlay.h -c -IMTStatusBarOverlay -v`

Adding -v in the end helps a lot to understand why the sharpie crashes (and it does sometimes). Turns out, MTStatusBarOverlay.h didn't had `#import <UIKit/UIKit.h>` and it was compiling fine, but sharpie could not parse it.
After adding the import, sharpie generated ApiDefinition/StructsAndEnums files and we're good.

### Credits
Thank you, **myell0w**, for doing this simple yet amazing library. We're glad we can use it in Xamarin apps.
Thank you, **Slepter**, for fixing [iOS 9 black screen bug](https://github.com/myell0w/MTStatusBarOverlay/pull/99)
