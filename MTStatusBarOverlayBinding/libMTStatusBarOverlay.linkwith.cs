using System;
using ObjCRuntime;

[assembly: LinkWith ("libMTStatusBarOverlay.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
