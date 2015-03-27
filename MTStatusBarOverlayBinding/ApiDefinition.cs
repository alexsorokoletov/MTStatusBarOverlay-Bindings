using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;


namespace MTStatusBarOverlayBinding
{
    // @interface MTStatusBarOverlay : UIWindow <UITableViewDataSource>
    [BaseType(typeof(UIWindow))]
    interface MTStatusBarOverlay : IUITableViewDataSource
    {
        // @property (nonatomic, strong) UIView * backgroundView;
        [Export("backgroundView", ArgumentSemantic.Strong)]
        UIView BackgroundView { get; set; }

        // @property (nonatomic, strong) UIView * detailView;
        [Export("detailView", ArgumentSemantic.Strong)]
        UIView DetailView { get; set; }

        // @property (assign, nonatomic) double progress;
        [Export("progress")]
        double Progress { get; set; }

        // @property (assign, nonatomic) CGRect smallFrame;
        [Export("smallFrame", ArgumentSemantic.Assign)]
        CGRect SmallFrame { get; set; }

        // @property (assign, nonatomic) MTStatusBarOverlayAnimation animation;
        [Export("animation", ArgumentSemantic.Assign)]
        MTStatusBarOverlayAnimation Animation { get; set; }

        // @property (nonatomic, strong) UILabel * finishedLabel;
        [Export("finishedLabel", ArgumentSemantic.Strong)]
        UILabel FinishedLabel { get; set; }

        // @property (assign, nonatomic) BOOL hidesActivity;
        [Export("hidesActivity")]
        bool HidesActivity { get; set; }

        // @property (nonatomic, strong) UIImage * defaultStatusBarImage;
        [Export("defaultStatusBarImage", ArgumentSemantic.Strong)]
        UIImage DefaultStatusBarImage { get; set; }

        // @property (nonatomic, strong) UIImage * defaultStatusBarImageShrinked;
        [Export("defaultStatusBarImageShrinked", ArgumentSemantic.Strong)]
        UIImage DefaultStatusBarImageShrinked { get; set; }

        // @property (readonly, getter = isShrinked, nonatomic) BOOL shrinked;
        [Export("shrinked")]
        bool Shrinked { [Bind ("isShrinked")] get; }

        // @property (readonly, getter = isDetailViewHidden, nonatomic) BOOL detailViewHidden;
        [Export("detailViewHidden")]
        bool DetailViewHidden { [Bind ("isDetailViewHidden")] get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * messageHistory;
        [Export("messageHistory", ArgumentSemantic.Strong)]
        NSMutableArray MessageHistory { get; }

        // @property (getter = isHistoryEnabled, assign, nonatomic) BOOL historyEnabled;
        [Export("historyEnabled")]
        bool HistoryEnabled { [Bind ("isHistoryEnabled")] get; set; }

        // @property (copy, nonatomic) NSString * lastPostedMessage;
        [Export("lastPostedMessage")]
        string LastPostedMessage { get; set; }

        // @property (assign, nonatomic) BOOL canRemoveImmediateMessagesFromQueue;
        [Export("canRemoveImmediateMessagesFromQueue")]
        bool CanRemoveImmediateMessagesFromQueue { get; set; }

        // @property (assign, nonatomic) MTDetailViewMode detailViewMode;
        [Export("detailViewMode", ArgumentSemantic.Assign)]
        MTDetailViewMode DetailViewMode { get; set; }

        // @property (copy, nonatomic) NSString * detailText;
        [Export("detailText")]
        string DetailText { get; set; }

        [Wrap("WeakDelegate")]
        MTStatusBarOverlayDelegate Delegate { get; set; }

        // @property (nonatomic, unsafe_unretained) id<MTStatusBarOverlayDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIColor * customTextColor;
        [Export("customTextColor", ArgumentSemantic.Strong)]
        UIColor CustomTextColor { get; set; }

        // +(MTStatusBarOverlay *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
//        [Verify(MethodToProperty)]
        MTStatusBarOverlay SharedInstance { get; }

        // +(MTStatusBarOverlay *)sharedOverlay;
        [Static]
        [Export("sharedOverlay")]
//        [Verify(MethodToProperty)]
        MTStatusBarOverlay SharedOverlay { get; }

        // -(void)addSubviewToBackgroundView:(UIView *)view;
        [Export("addSubviewToBackgroundView:")]
        void AddSubviewToBackgroundView(UIView view);

        // -(void)addSubviewToBackgroundView:(UIView *)view atIndex:(NSInteger)index;
        [Export("addSubviewToBackgroundView:atIndex:")]
        void AddSubviewToBackgroundView(UIView view, nint index);

        // -(void)postMessageDictionary:(NSDictionary *)messageDictionary;
        [Export("postMessageDictionary:")]
        void PostMessageDictionary(NSDictionary messageDictionary);

        // -(void)postMessage:(NSString *)message;
        [Export("postMessage:")]
        void PostMessage(string message);

        // -(void)postMessage:(NSString *)message duration:(NSTimeInterval)duration;
        [Export("postMessage:duration:")]
        void PostMessage(string message, double duration);

        // -(void)postMessage:(NSString *)message duration:(NSTimeInterval)duration animated:(BOOL)animated;
        [Export("postMessage:duration:animated:")]
        void PostMessage(string message, double duration, bool animated);

        // -(void)postMessage:(NSString *)message animated:(BOOL)animated;
        [Export("postMessage:animated:")]
        void PostMessage(string message, bool animated);

        // -(void)postImmediateMessage:(NSString *)message animated:(BOOL)animated;
        [Export("postImmediateMessage:animated:")]
        void PostImmediateMessage(string message, bool animated);

        // -(void)postImmediateMessage:(NSString *)message duration:(NSTimeInterval)duration;
        [Export("postImmediateMessage:duration:")]
        void PostImmediateMessage(string message, double duration);

        // -(void)postImmediateMessage:(NSString *)message duration:(NSTimeInterval)duration animated:(BOOL)animated;
        [Export("postImmediateMessage:duration:animated:")]
        void PostImmediateMessage(string message, double duration, bool animated);

        // -(void)postFinishMessage:(NSString *)message duration:(NSTimeInterval)duration;
        [Export("postFinishMessage:duration:")]
        void PostFinishMessage(string message, double duration);

        // -(void)postFinishMessage:(NSString *)message duration:(NSTimeInterval)duration animated:(BOOL)animated;
        [Export("postFinishMessage:duration:animated:")]
        void PostFinishMessage(string message, double duration, bool animated);

        // -(void)postImmediateFinishMessage:(NSString *)message duration:(NSTimeInterval)duration animated:(BOOL)animated;
        [Export("postImmediateFinishMessage:duration:animated:")]
        void PostImmediateFinishMessage(string message, double duration, bool animated);

        // -(void)postErrorMessage:(NSString *)message duration:(NSTimeInterval)duration;
        [Export("postErrorMessage:duration:")]
        void PostErrorMessage(string message, double duration);

        // -(void)postErrorMessage:(NSString *)message duration:(NSTimeInterval)duration animated:(BOOL)animated;
        [Export("postErrorMessage:duration:animated:")]
        void PostErrorMessage(string message, double duration, bool animated);

        // -(void)postImmediateErrorMessage:(NSString *)message duration:(NSTimeInterval)duration animated:(BOOL)animated;
        [Export("postImmediateErrorMessage:duration:animated:")]
        void PostImmediateErrorMessage(string message, double duration, bool animated);

        // -(void)hide;
        [Export("hide")]
        void Hide();

        // -(void)hideTemporary;
        [Export("hideTemporary")]
        void HideTemporary();

        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)saveState;
        [Export("saveState")]
        void SaveState();

        // -(void)saveStateSynchronized:(BOOL)synchronizeAtEnd;
        [Export("saveStateSynchronized:")]
        void SaveStateSynchronized(bool synchronizeAtEnd);

        // -(void)restoreState;
        [Export("restoreState")]
        void RestoreState();
    }

    // @protocol MTStatusBarOverlayDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MTStatusBarOverlayDelegate
    {
        // @optional -(void)statusBarOverlayDidRecognizeGesture:(UIGestureRecognizer *)gestureRecognizer;
        [Export("statusBarOverlayDidRecognizeGesture:")]
        void StatusBarOverlayDidRecognizeGesture(UIGestureRecognizer gestureRecognizer);

        // @optional -(void)statusBarOverlayDidHide;
        [Export("statusBarOverlayDidHide")]
        void StatusBarOverlayDidHide();

        // @optional -(void)statusBarOverlayDidSwitchFromOldMessage:(NSString *)oldMessage toNewMessage:(NSString *)newMessage;
        [Export("statusBarOverlayDidSwitchFromOldMessage:toNewMessage:")]
        void StatusBarOverlayDidSwitchFromOldMessage(string oldMessage, string newMessage);

        // @optional -(void)statusBarOverlayDidClearMessageQueue:(NSArray *)messageQueue;
        [Export("statusBarOverlayDidClearMessageQueue:")]
//        [Verify(StronglyTypedNSArray)]
        void StatusBarOverlayDidClearMessageQueue(NSObject[] messageQueue);
    }

}