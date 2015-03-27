# MTStatusBarOverlay Xamarin Bindings

Xamarin iOS unified bindings for great objc library MTStatusBarOverlay
[MTStatusBarOverlay](https://github.com/myell0w/MTStatusBarOverlay)

Current binding is built against [commit c2002587ddefd75423bc766c172f2574575c0966](https://github.com/myell0w/MTStatusBarOverlay/commit/c2002587ddefd75423bc766c172f2574575c0966)

Available as a Nuget by installing package **MTStatusBarOverlayBindings.iOS**

### Binding details
Binding was done by compiling MTStatusBarOverlay for arm64/armv7/i386, merging those 3 .a files into one (using `lipo`/`libtool` command, details [here](www.cvursache.com/2013/10/06/Combining-Multi-Arch-Binaries/))
After that against source code we run [`sharpie`](developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/objective_sharpie/)

`sharpie bind -output Binding -v -sdk iphoneos8.2 -scope MTStatusBarOverlay MTStatusBarOverlay/MTStatusBarOverlay.h -c -IMTStatusBarOverlay -v`

Adding -v in the end helps a lot to understand why the sharpie crashes (and it does sometimes). Turns out, MTStatusBarOverlay.h didn't had `#import <UIKit/UIKit.h>` and it was compiling fine, but sharpie could not parse it.
After adding the import, sharpie generated ApiDefinition/StructsAndEnums files and we're good.

### Credits
Thank you, **myell0w**, for doing this simple yet amazing library. We're glad we can use it in Xamarin apps.
