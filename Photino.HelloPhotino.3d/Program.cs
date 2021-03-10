﻿using PhotinoNET;
using System;

namespace HelloPhotino.ThreeD
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Window title declared here for visibility
            string windowTitle = "Photino 3D Pong";

            // Creating a new PhotinoWindow instance with the fluent API
            var window = new PhotinoWindow(windowTitle)
                // Resize to a percentage of the main monitor work area
                .Resize(700, 525)
                // Center window in the middle of the screen
                .Center()
                // Users can resize windows by default.
                // Let's make this one fixed instead.
                .UserCanResize(false)
                .Load("wwwroot/index.html"); // Can be used with relative path strings or "new URI()" instance to load a website.

            window.WaitForClose(); // Starts the application event loop
        }
    }
}
