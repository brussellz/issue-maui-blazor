# MAUI & Blazor WebView Leak

## Purpose
The purpose of this project is to show there is an issue with the BlazorWebView not properly cleaning up behind itself once a MAUI page is closed in MAUI .NET 8.

If you open up 5 windows with a BlazorWebView control and close all 5 windows, you will still have 5 instances of the BlazorWebView, Handler, Razor pages, etc in memory.