/* This is a template for a basic EXILED plugin. You can use this as a starting point for your own plugin.
 * Make sure to change the Name, Author, and Version properties to match your plugin.
 * do not forget to change the namespace to match your plugin name as well.
 * This template has everything you need to get started, including a Config class.
 * 
 * This Template is made by gben5692 : https://github.com/gben5692
 * 
 */


using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace ScpExiledTemplate
{
    public class Plugin : Plugin<Config>
    {

        public override string Name => "Your Plugin Name Here"; // this is the name of the plugin
        public override string Author => "Your Name Here"; // this is the author of the plugin
        public override Version Version => new Version(1, 0, 0); // this is the version of the plugin

        // this is called when the plugin is enabled 
        public override void OnEnabled()
        {
            Log.Info("Plugin has been enabled!"); // log a message to the console that its enabled

            Exiled.Events.Handlers.Player.Verified += OnPlayerVerified; // subscribe to the Player.Verified event
        }

        // this is called when the plugin is disabled
        public override void OnDisabled()
        {
            Log.Info("Plugin has been disabled!"); // log a message to the console that its disabled

            Exiled.Events.Handlers.Player.Verified -= OnPlayerVerified; // Unsubscribe from the Player.Verified event
        }

        // this is an example event handler that is called when a player joins the server
        public void OnPlayerVerified(VerifiedEventArgs ev)
        {
            Log.Info($"Player {ev.Player.Nickname} has joined the server.");
        }

    }
}
