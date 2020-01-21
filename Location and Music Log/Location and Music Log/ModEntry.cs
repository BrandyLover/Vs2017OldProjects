using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using System.IO;

namespace LMlog
{
   
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {

        private string playerLocation;

        private string musicPlaying;

        private string log;
        




        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            ModConfig config = helper.ReadConfig<ModConfig>();
            if (config.logTick)
            {
                GameEvents.HalfSecondTick += GameEvents_HalfSecondTick;
            }
            if (config.logEntering)
            {
                LocationEvents.CurrentLocationChanged += LocationEvents_CurrentLocationChanged;
            }
            
            
            

        }

       



        /*********
        ** Private methods
        *********/
        /// <summary>The method invoked when the player presses a keyboard button.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event data.</param>
        private void LocationEvents_CurrentLocationChanged(object sender, EventArgsCurrentLocationChanged e)
        {
            ModConfig config = this.Helper.ReadConfig<ModConfig>();
            if (Context.IsWorldReady)
            {
                if (config.logLocation)
                {
                    playerLocation = " at this coordinates: " + Game1.currentLocation.ToString() + "  also known as: " + Game1.currentLocation.name;
                    
                }
                else playerLocation = "";
                if (config.logMusic)
                {
                    musicPlaying = " this music: " + Game1.currentSong.Name;
                   
                }
                else musicPlaying = "";
                log = "Player entered" + playerLocation + " and" + musicPlaying;
                Monitor.Log(log);
            }
        }

        private void GameEvents_HalfSecondTick(object sender, EventArgs e)
        {
            if (Context.IsWorldReady)
            {
                ModConfig config = this.Helper.ReadConfig<ModConfig>();
                if (config.logLocation)
                {
                    playerLocation = "coordinates: " + Game1.currentLocation.ToString() + "  also known as: " + Game1.currentLocation.name;
                    
                }
                else playerLocation = "";
                if (config.logMusic)
                {
                    musicPlaying = " this music: " + Game1.currentSong.Name;
                   

                }
                log = "Player at this tick is at this " + playerLocation + " and" + musicPlaying;
                Monitor.Log(log);
            }
        }
    }

    class ModConfig
    {
        public bool logTick;
        public bool logEntering;
        public bool logLocation;
        public bool logMusic;

        public ModConfig()
        {
            
            this.logTick = false;
            this.logEntering = true;
            this.logLocation = true;
            this.logMusic = true;
        }
    }
}