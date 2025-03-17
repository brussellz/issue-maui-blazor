# MAUI & Blazor WebView Leak

## Purpose
The purpose of this project is to show there is an issue with the BlazorWebView not properly cleaning up behind itself once a MAUI page is closed in MAUI .NET 8.

If you open up 5 windows with a BlazorWebView control and close all 5 windows, you will still have 5 instances of the BlazorWebView, Handler, Razor pages, etc in memory.

## Tools Used
* .NET 8.0.404
* VS Code
    * .NET Meteor (Profiling and Memory dump)
    * .NET MAUI
* dotnet-heapview (https://github.com/1hub/dotnet-heapview)
    * Used to profile the gcdump file on MacOS
* Target platforms:
    * iOS
    * Android

## Steps To Reproduce
1. From the MainPage click "Open Blazor Window" button
2. Observe the Blazor Window that comes up and then click the back button at the top
    * The window should close and the MainPage should be visible
3. Repeat this process as many times as you wish
4. In the Debug Console produce a dump file with .NET Meteor
5. Load up the gcdump file and look for any of the following objects and observe their counts:
    * BlazorWebView
    * HelloWorld
    * BlazorWindow