﻿using System.Collections.Generic;

using mtgvrp.core;
using mtgvrp.player_manager;
using GrandTheftMultiplayer.Server.API;

namespace mtgvrp.component_manager
{
    class ComponentManager : Script
    {
        public static List<Component> ValidFemaleHair = new List<Component>();
        public static List<Component> ValidMaleHair = new List<Component>();

        public static List<Component> ValidMasks = new List<Component>();

        public static List<Component> ValidFemaleLegs = new List<Component>();
        public static List<Component> ValidMaleLegs = new List<Component>();

        // LISTS FOR CLOTHING CATEGORIES

        // MALE TROUSERS

        public static List<Component> ValidMaleJeans = new List<Component>();
        public static List<Component> ValidMaleWorkPants = new List<Component>();
        public static List<Component> ValidMaleShorts = new List<Component>();
        public static List<Component> ValidMaleCargoPants = new List<Component>();
        public static List<Component> ValidMaleSportsPants = new List<Component>();
        public static List<Component> ValidMaleSuitPants = new List<Component>();
        public static List<Component> ValidMaleChinos = new List<Component>();
        public static List<Component> ValidMaleSportShorts = new List<Component>();

        // MALE GLASSES

        public static List<Component> ValidMaleProfessionalGlasses = new List<Component>();
        public static List<Component> ValidMaleSportsGlasses = new List<Component>();
        public static List<Component> ValidMaleCasualGlasses = new List<Component>();
        public static List<Component> ValidMaleAviators = new List<Component>();
        public static List<Component> ValidMaleHipsterGlasses = new List<Component>();
        public static List<Component> ValidMaleHighEndGlasses = new List<Component>();
        public static List<Component> ValidMaleGunRangeGlasses = new List<Component>();

        // FEMALE TROUSERS

        public static List<Component> ValidFemaleJeans = new List<Component>();
        public static List<Component> ValidFemaleShorts = new List<Component>();
        public static List<Component> ValidFemaleCargoPants = new List<Component>();
        public static List<Component> ValidFemaleSportsPants = new List<Component>();
        public static List<Component> ValidFemaleSuitPants = new List<Component>();
        public static List<Component> ValidFemaleChinos = new List<Component>();
        public static List<Component> ValidFemaleSkirts = new List<Component>();
        public static List<Component> ValidFemaleBikiniBottoms = new List<Component>();
        public static List<Component> ValidFemaleSportShorts = new List<Component>();

        // FEMALE GLASSES

        public static List<Component> ValidFemaleSportsGlasses = new List<Component>();
        public static List<Component> ValidFemaleCasualGlasses = new List<Component>();
        public static List<Component> ValidFemaleAviators = new List<Component>();
        public static List<Component> ValidFemaleHipsterGlasses = new List<Component>();
        public static List<Component> ValidFemaleHighEndGlasses = new List<Component>();
        public static List<Component> ValidFemaleGunRangeGlasses = new List<Component>();

        public static List<Component> ValidBags = new List<Component>();

        public static List<Component> ValidFemaleShoes = new List<Component>();
        public static List<Component> ValidMaleShoes = new List<Component>();

        public static List<Component> ValidFemaleAccessories = new List<Component>();
        public static List<Component> ValidMaleAccessories = new List<Component>();

        public static List<Component> ValidFemaleUndershirt = new List<Component>();
        public static List<Component> ValidMaleUndershirt = new List<Component>();

        public static List<Component> ValidFemaleBodyarmor = new List<Component>();
        public static List<Component> ValidMaleBodyarmor = new List<Component>();

        public static List<Component> ValidFemaleTops = new List<Component>();
        public static List<Component> ValidMaleTops = new List<Component>();

        public static List<Component> ValidFemaleHats = new List<Component>();
        public static List<Component> ValidMaleHats = new List<Component>();

        public static List<Component> ValidFemaleGlasses = new List<Component>();
        public static List<Component> ValidMaleGlasses = new List<Component>();

        public static List<Component> ValidFemaleEars = new List<Component>();
        public static List<Component> ValidMaleEars = new List<Component>();

        private static int[] _forbiddenMasks = { };
        private static int[] _forbiddenBags = { };

        public ComponentManager()
        {
            DebugManager.DebugMessage("[ComponentM] Initilazing component manager.");

            /* ================ MALE HAIR ================ */

            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 0, new List<int> { }, "Close Shave"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 1, new List<int> { }, "Buzzcut"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 2, new List<int> { }, "Faux Hawk"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 3, new List<int> { }, "Hipster"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 4, new List<int> { }, "Side Parting"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 5, new List<int> { }, "Shorter Cut"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 6, new List<int> { }, "Biker"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 7, new List<int> { }, "Ponytail"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 8, new List<int> { }, "Cornrows"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 9, new List<int> { }, "Slicked"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 10, new List<int> { }, "Short Brushed"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 11, new List<int> { }, "Spikey"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 12, new List<int> { }, "Caesar"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 13, new List<int> { }, "Chopped"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 14, new List<int> { }, "Dreads"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 15, new List<int> { }, "Long Hair"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 16, new List<int> { }, "Shaggy Curls"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 17, new List<int> { }, "Surfer Dude"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 18, new List<int> { }, "Short Side Part"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 19, new List<int> { }, "High Slicked Sides"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 20, new List<int> { }, "Long Slicked"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 21, new List<int> { }, "Hipster Youth"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 22, new List<int> { }, "Mullet"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 24, new List<int> { }, "Classic Cornrows"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 25, new List<int> { }, "Palm Cornrows"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 26, new List<int> { }, "Lightning Cornrows"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 27, new List<int> { }, "Whipped Cornrows"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 28, new List<int> { }, "Zig Zag Cornrows"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 29, new List<int> { }, "Snail Cornrows"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 30, new List<int> { }, "Hightop"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 31, new List<int> { }, "Loose Swept Back"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 32, new List<int> { }, "Undercut Swept Back"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 33, new List<int> { }, "Undercut Swept Side"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 34, new List<int> { }, "Spiked Mohawk"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 35, new List<int> { }, "Mod"));
            ValidMaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderMale, 36, new List<int> { }, "Layered Mod"));

            /* ================ MALE PANTS ================ */

            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 0, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 1"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 1, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 2"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 2, new List<int>() { 12 }, "Style 3"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 3, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 4"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 4, new List<int>() { 1, 2, 3, 5 }, "Style 5"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 5, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 6"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 6, new List<int>() { 1, 2, 3, 11 }, "Style 7"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 7, new List<int>() { 1, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 8"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 8, new List<int>() { 1, 4, 5, 15 }, "Style 9"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 9, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 10"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 10, new List<int>() { 1, 2, 3 }, "Style 11"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 12, new List<int>() { 1, 5, 6, 8, 13 }, "Style 12"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 13, new List<int>() { 1, 2, 3 }, "Style 13"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 14, new List<int>() { 1, 2, 4, 13 }, "Style 14"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 15, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 15"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 16, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 16"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 17, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 17"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 18, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 18"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 19, new List<int>() { 1, 2 }, "Style 19"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 20, new List<int>() { 1, 2, 3, 4 }, "Style 20"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 22, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 21"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 23, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 22"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 24, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 23"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 25, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 24"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 25"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 27, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 26"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 28, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 27"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 31, new List<int>() { 1, 2, 3, 4, 5 }, "Style 28"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 33, new List<int>() { 1 }, "Style 29"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 35, new List<int>() { 1 }, "Style 30"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 37, new List<int>() { 1, 2, 3, 4 }, "Style 31"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 38, new List<int>() { 1, 2, 3, 4 }, "Style 32"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 39, new List<int>() { 1, 2, 3, 4 }, "Style 33"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 40, new List<int>() { 1, 2, 3, 4 }, "Style 34"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 42, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 35"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 43, new List<int>() { 1, 2 }, "Style 36"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 45, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 37"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 46, new List<int>() { 1, 2 }, "Style 38"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 47, new List<int>() { 1, 2 }, "Style 39"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 48, new List<int>() { 1, 2, 3, 4, 5 }, "Style 40"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 49, new List<int>() { 1, 2, 3, 4, 5 }, "Style 41"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 50, new List<int>() { 1, 2, 3, 4 }, "Style 42"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 51, new List<int>() { 1 }, "Style 43"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 52, new List<int>() { 1, 2, 3, 4 }, "Style 44"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 53, new List<int>() { 1 }, "Style 45"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 54, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 46"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 55, new List<int>() { 1, 2, 3, 4 }, "Style 47"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 57, new List<int>() { 1, 2, 3 }, "Style 48"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 59, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 49"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 60, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 50"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 61, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, "Style 51"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 62, new List<int>() { 1, 2, 3, 4 }, "Style 52"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 63, new List<int>() { 1 }, "Style 53"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 64, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 54"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 65, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, "Style 55"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 75, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 56"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 76, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 57"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 78, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 58"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 79, new List<int>() { 1, 2, 3 }, "Style 59"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 80, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 60"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 81, new List<int>() { 1, 2, 3 }, "Style 61"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 82, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 62"));
            ValidMaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderMale, 83, new List<int>() { 1, 2, 3, 4 }, "Style 63"));

            /* ================ MALE SHOES ================ */

            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 0, new List<int>() { 11 }, "Style 1"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 1, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 2"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 2, new List<int>() { 7, 14 }, "Style 3"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 3, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 4"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 4, new List<int>() { 1, 2, 3, 5 }, "Style 5"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 5, new List<int>() { 1, 2, 3, 4 }, "Style 6"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 6, new List<int>() { 1, 2 }, "Style 7"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 7, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 8"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 8, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 9"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 9, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 10"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 10, new List<int>() { 1, 8, 13, 15 }, "Style 11"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 11, new List<int>() { 10, 13, 15, 16 }, "Style 12"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 12, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 13"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 14, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 14"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 15, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 15"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 16, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 16"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 18, new List<int>() { 1, 2 }, "Style 17"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 19, new List<int>() { 1 }, "Style 18"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 20, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 19"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 21, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 20"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 22, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 21"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 23, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 22"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 24, new List<int>() { 1 }, "Style 23"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 25, new List<int>() { 1 }, "Style 24"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 25"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 27, new List<int>() { 1 }, "Style 26"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 28, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 27"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 29, new List<int>() { 1 }, "Style 28"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 30, new List<int>() { 1, 2 }, "Style 29"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 31, new List<int>() { 1, 2, 3, 4, 5 }, "Style 30"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 32, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 31"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 34, new List<int>() { 1 }, "Style 32"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 35, new List<int>() { 1, 2 }, "Style 33"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 36, new List<int>() { 1, 2, 3, 4 }, "Style 34"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 37, new List<int>() { 1, 2, 3, 4, 5 }, "Style 35"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 38, new List<int>() { 1, 2, 3, 4, 5 }, "Style 36"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 39, new List<int>() { 1 }, "Style 37"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 40, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 38"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 41, new List<int>() { 1 }, "Style 39"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 42, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 40"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 43, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 41"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 44, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 42"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 45, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 43"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 46, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 44"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 47, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 45"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 48, new List<int>() { 1, 2 }, "Style 46"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 49, new List<int>() { 1, 2 }, "Style 47"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 50, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 48"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 51, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 49"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 52, new List<int>() { 1, 2 }, "Style 50"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 53, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 51"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 54, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 52"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 55, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 53"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 56, new List<int>() { 1, 2 }, "Style 54"));
            ValidMaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderMale, 57, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 55"));

            /* ================ MALE ACCESSORIES ================ */

            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 0, new List<int>() { 1 }, "None"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 10, new List<int>() { 1, 2, 3 }, "Style 1"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 11, new List<int>() { 3 }, "Style 2"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 12, new List<int>() { 1, 2, 3 }, "Style 4"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 16, new List<int>() { 1, 2, 3 }, "Style 5"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 17, new List<int>() { 1, 2, 3 }, "Style 6"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 18, new List<int>() { 1 }, "Style 7"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 19, new List<int>() { 1 }, "Style 8"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 20, new List<int>() { 1, 2, 3, 4, 5 }, "Style 9"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 21, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 10"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 22, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, "Style 11"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 23, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 12"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 24, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 13"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 25, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 14"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 15"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 27, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 16"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 28, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 17"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 29, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 18"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 30, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 19"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 31, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 20"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 32, new List<int>() { 1, 2, 3 }, "Style 21"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 34, new List<int>() { 1, 2, 3, 4 }, "Style 22"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 36, new List<int>() { 1 }, "Style 23"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 37, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 24"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 38, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 25"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 39, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 26"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 42, new List<int>() { 1, 2 }, "Style 27"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 43, new List<int>() { 1, 2 }, "Style 28"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 44, new List<int>() { 1 }, "Style 29"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 45, new List<int>() { 1, 2 }, "Style 30"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 46, new List<int>() { 1, 2 }, "Style 31"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 47, new List<int>() { 1, 2 }, "Style 32"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 48, new List<int>() { 1, 2 }, "Style 33"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 49, new List<int>() { 1, 2 }, "Style 34"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 50, new List<int>() { 1, 2 }, "Style 35"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 51, new List<int>() { 1 }, "Style 36"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 52, new List<int>() { 1, 2 }, "Style 37"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 53, new List<int>() { 1, 2 }, "Style 38"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 54, new List<int>() { 1, 2 }, "Style 39"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 55, new List<int>() { 1, 2 }, "Style 40"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 74, new List<int>() { 1, 2 }, "Style 41"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 75, new List<int>() { 1, 2 }, "Style 42"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 76, new List<int>() { 1, 2 }, "Style 43"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 77, new List<int>() { 1, 2 }, "Style 44"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 78, new List<int>() { 1, 2 }, "Style 45"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 79, new List<int>() { 1, 2 }, "Style 46"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 80, new List<int>() { 1, 2 }, "Style 47"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 81, new List<int>() { 1, 2 }, "Style 48"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 82, new List<int>() { 1, 2 }, "Style 49"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 83, new List<int>() { 1, 2 }, "Style 50"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 85, new List<int>() { 1, 2 }, "Style 51"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 86, new List<int>() { 1, 2 }, "Style 52"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 87, new List<int>() { 1, 2 }, "Style 53"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 88, new List<int>() { 1, 2 }, "Style 54"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 89, new List<int>() { 1, 2 }, "Style 55"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 90, new List<int>() { 1, 2 }, "Style 56"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 91, new List<int>() { 1, 2 }, "Style 57"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 92, new List<int>() { 1, 2 }, "Style 58"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 93, new List<int>() { 1, 2 }, "Style 59"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 94, new List<int>() { 1, 2 }, "Style 60"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 110, new List<int>() { 1, 2 }, "Style 61"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 111, new List<int>() { 1, 2 }, "Style 62"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 112, new List<int>() { 1, 2, 3 }, "Style 63"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 113, new List<int>() { 1 }, "Style 64"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 114, new List<int>() { 1 }, "Style 65"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 115, new List<int>() { 1, 2 }, "Style 66"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 116, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 67"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 117, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 68"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 118, new List<int>() { 1 }, "Style 69"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 119, new List<int>() { 1, 2 }, "Style 70"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 120, new List<int>() { 1, 2 }, "Style 71"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 121, new List<int>() { 1, 2 }, "Style 72"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 122, new List<int>() { 1, 2 }, "Style 73"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 123, new List<int>() { 1, 2 }, "Style 74"));
            ValidMaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderMale, 124, new List<int>() { 1, 2 }, "Style 75"));

            /* ================ MALE UNDERSHIRTS ================ */

            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 15, new List<int>() { 1 }, "None"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 0, new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 12 }, "Style 1"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 1, new List<int>() { 1, 2, 4, 5, 6, 7, 8, 9, 12, 13, 15 }, "Style 2"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 2, new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 12 }, "Style 3"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 3, new List<int>() { 1, 2, 3 }, "Style 4"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 4, new List<int>() { 1, 2, 3 }, "Style 5"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 5, new List<int>() { 1, 2, 3, 8 }, "Style 6"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 6, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 7"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 7, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 8"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 8, new List<int>() { 1, 11, 14, 15 }, "Style 9"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 9, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 10"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 10, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 11"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 11, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 12"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 12, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 13"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 13, new List<int>() { 1, 2, 3, 4, 6, 14 }, "Style 14"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 14, new List<int>() { 1, 2, 4, 5, 6, 7, 8, 9, 12, 13, 15 }, "Style 15"));
            //15 == none
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 16, new List<int>() { 1, 2, 3 }, "Style 16"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 17, new List<int>() { 1, 2, 3, 4, 6 }, "Style 17"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 18, new List<int>() { 1, 2, 3 }, "Style 18"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 21, new List<int>() { 1, 2, 3, 4, 5 }, "Style 19"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 22, new List<int>() { 1, 2, 3, 4, 5 }, "Style 20"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 23, new List<int>() { 1, 2, 3 }, "Style 21"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 24, new List<int>() { 1, 2, 3 }, "Style 22"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 25, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 23"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 24"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 27, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 25"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 28, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 26"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 29, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 27"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 30, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 28"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 31, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 29"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 32, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 30"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 33, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 31"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 34, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 32"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 35, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 33"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 36, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 34"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 37, new List<int>() { 1 }, "Style 35"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 38, new List<int>() { 1, 2 }, "Style 36"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 39, new List<int>() { 1 }, "Style 37"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 40, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 38"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 41, new List<int>() { 1, 2, 3, 4, 5 }, "Style 39"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 42, new List<int>() { 1, 2 }, "Style 40"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 43, new List<int>() { 1, 2, 3, 4 }, "Style 41"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 44, new List<int>() { 1, 2 }, "Style 42"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 45, new List<int>() { 1 }, "Style 43"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 46, new List<int>() { 1 }, "Style 44"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 47, new List<int>() { 1, 2, 3, 4 }, "Style 45"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 48, new List<int>() { 1, 2, 3, 4 }, "Style 46"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 49, new List<int>() { 1, 2 }, "Style 47"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 50, new List<int>() { 1, 2 }, "Style 48"));
            //57 == none
            //58 == cop radio
            //59 = construction vest
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 63, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 49"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 64, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 50"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 65, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, "Style 51"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 66, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, "Style 52"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 67, new List<int>() { 1 }, "Style 53"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 68, new List<int>() { 1 }, "Style 54"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 69, new List<int>() { 1, 2, 3, 4, 5 }, "Style 55"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 70, new List<int>() { 1 }, "Style 56"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 71, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 57"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 72, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 58"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 73, new List<int>() { 1, 2, 3 }, "Style 59"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 74, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 60"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 75, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 61"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 76, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Style 62"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 77, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Style 63"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 81, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 64"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 82, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }, "Style 65"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 83, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 66"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 84, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }, "Style 67"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 85, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 68"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 86, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }, "Style 69"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 87, new List<int>() { 1 }, "Style 70"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 88, new List<int>() { 1 }, "Style 71"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 89, new List<int>() { 1 }, "Style 72"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 90, new List<int>() { 1, 2 }, "Style 73"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 91, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 }, "Style 74"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 92, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 }, "Style 75"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 93, new List<int>() { 1, 2 }, "Style 75"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 94, new List<int>() { 1, 2 }, "Style 76"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 95, new List<int>() { 1, 2 }, "Style 77"));
            ValidMaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderMale, 96, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }, "Style 78"));

            /* ================ MALE TOPS ================ */

            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 0, new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 12 }, "Style 1"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 1, new List<int>() { 1, 2, 4, 5, 6, 7, 8, 9, 12, 13, 15 }, "Style 2"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 3, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 3"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 4, new List<int>() { 1, 3, 4, 12, 15 }, "Style 4"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 6, new List<int>() { 1, 2, 4, 5, 6, 7, 9, 10, 12 }, "Style 5"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 7, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 6"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 8, new List<int>() { 1, 11, 14, 15 }, "Style 7"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 9, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 8"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 10, new List<int>() { 1, 2, 3 }, "Style 9"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 11, new List<int>() { 1, 2, 8, 15 }, "Style 10"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 12, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 11"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 13, new List<int>() { 1, 2, 3, 4, 6, 14 }, "Style 12"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 14, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 13"));
            //15 == none
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 16, new List<int>() { 1, 2, 3 }, "Style 14"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 20, new List<int>() { 1, 2, 3, 4 }, "Style 15"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 21, new List<int>() { 1, 2, 3 }, "Style 16"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 22, new List<int>() { 1, 2, 3, 4 }, "Style 17"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 23, new List<int>() { 1, 2, 3, 4 }, "Style 18"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 24, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 19"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 25, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 20"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 21"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 27, new List<int>() { 1, 2, 3 }, "Style 22"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 28, new List<int>() { 1, 2, 3 }, "Style 23"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 29, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 24"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 30, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 25"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 31, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 26"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 32, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 27"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 33, new List<int>() { 1 }, "Style 28"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 34, new List<int>() { 1, 2 }, "Style 29"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 35, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 30"));
            //36 sleeveless
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 37, new List<int>() { 1, 2, 3 }, "Style 31"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 38, new List<int>() { 1, 2, 3, 4, 5 }, "Style 32"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 39, new List<int>() { 1, 2 }, "Style 33"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 41, new List<int>() { 1, 2, 3, 4 }, "Style 34"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 42, new List<int>() { 1 }, "Style 35"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 43, new List<int>() { 1 }, "Style 36"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 44, new List<int>() { 1, 2, 3, 4 }, "Style 37"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 47, new List<int>() { 1, 2 }, "Style 38"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 50, new List<int>() { 1, 2, 3, 4, 5 }, "Style 39"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 53, new List<int>() { 1, 2, 3, 4 }, "Style 40"));
            //55 == cop
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 56, new List<int>() { 1 }, "Style 41"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 57, new List<int>() { 1 }, "Style 42"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 58, new List<int>() { 1 }, "Style 43"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 59, new List<int>() { 1, 2, 3, 4 }, "Style 44"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 60, new List<int>() { 1, 2, 3, 4 }, "Style 45"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 61, new List<int>() { 1, 2, 3, 4 }, "Style 46"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 62, new List<int>() { 1 }, "Style 47"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 63, new List<int>() { 1 }, "Style 48"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 64, new List<int>() { 1 }, "Style 49"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 65, new List<int>() { 1, 2, 3, 4 }, "Style 50"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 66, new List<int>() { 1, 2, 3, 4 }, "Style 51"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 67, new List<int>() { 1, 2, 3, 4 }, "Style 52"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 68, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 53"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 69, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 54"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 70, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 55"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 71, new List<int>() { 1 }, "Style 56"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 72, new List<int>() { 1, 2, 3, 4 }, "Style 57"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 73, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, }, "Style 58"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 74, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 59"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 75, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 60"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 76, new List<int>() { 1, 2, 3, 4, 5 }, "Style 61"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 77, new List<int>() { 1, 2, 3, 4 }, "Style 62"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 78, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 63"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 79, new List<int>() { 1 }, "Style 64"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 80, new List<int>() { 1, 2, 3 }, "Style 65"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 81, new List<int>() { 1, 2, 3 }, "Style 66"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 82, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 67"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 83, new List<int>() { 1, 2, 3, 4, 5 }, "Style 68"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 84, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 69"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 85, new List<int>() { 1 }, "Style 70"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 86, new List<int>() { 1, 2, 3, 4, 5 }, "Style 71"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 87, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 72"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 88, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 73"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 89, new List<int>() { 1, 2, 3, 4 }, "Style 74"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 90, new List<int>() { 1 }, "Style 75"));
            //91 == none
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 92, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 76"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 93, new List<int>() { 1, 2, 3 }, "Style 77"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 94, new List<int>() { 1, 2, 3 }, "Style 78"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 95, new List<int>() { 1, 2, 3 }, "Style 79"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 96, new List<int>() { 1 }, "Style 80"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 97, new List<int>() { 1, 2 }, "Style 81"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 98, new List<int>() { 1, 2 }, "Style 82"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 99, new List<int>() { 1, 2, 3, 4, 5 }, "Style 83"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 100, new List<int>() { 1, 2, 3, 4, 5 }, "Style 84"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 101, new List<int>() { 1, 2, 3, 4 }, "Style 85"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 102, new List<int>() { 1, 2, 3, 4 }, "Style 86"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 103, new List<int>() { 1 }, "Style 87"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 104, new List<int>() { 1 }, "Style 88"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 105, new List<int>() { 1 }, "Style 89"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 106, new List<int>() { 1 }, "Style 90"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 107, new List<int>() { 1, 2, 3, 4, 5 }, "Style 91"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 110, new List<int>() { 1 }, "Style 92"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 111, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 93"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 112, new List<int>() { 1 }, "Style 94"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 113, new List<int>() { 1, 2, 3, 4 }, "Style 95"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 115, new List<int>() { 1 }, "Style 96"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 118, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 97"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 119, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 98"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 121, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 99"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 122, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, "Style 100"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 123, new List<int>() { 1, 2, 3 }, "Style 101"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 124, new List<int>() { 1 }, "Style 102"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 125, new List<int>() { 1 }, "Style 103"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 126, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, "Style 104"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 127, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, "Style 105"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 128, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 106"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 129, new List<int>() { 1 }, "Style 107"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 130, new List<int>() { 1 }, "Style 108"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 131, new List<int>() { 1 }, "Style 109"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 132, new List<int>() { 1 }, "Style 110"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 133, new List<int>() { 1 }, "Style 111"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 134, new List<int>() { 1, 2, 3 }, "Style 112"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 135, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 113"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 136, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 114"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 138, new List<int>() { 1, 2, 3 }, "Style 116"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 139, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 117"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 140, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, "Style 118"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 141, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 119"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 142, new List<int>() { 1, 2, 3 }, "Style 120"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 143, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 121"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 144, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, "Style 122"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 146, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Style 123"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 150, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 124"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 151, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 125"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 153, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 126"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 154, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 127"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 160, new List<int>() { 1, 2, 3, 4 }, "Style 128"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 163, new List<int>() { 1 }, "Style 129"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 164, new List<int>() { 1, 2, 3 }, "Style 130"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 166, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 131"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 167, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 132"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 168, new List<int>() { 1, 2, 3 }, "Style 133"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 169, new List<int>() { 1, 2, 3, 4 }, "Style 134"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 171, new List<int>() { 1, 2 }, "Style 135"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 172, new List<int>() { 1, 2, 3, 4 }, "Style 136"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 174, new List<int>() { 1, 2, 3, 4 }, "Style 137"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 181, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 138"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 182, new List<int>() { 1, 2 }, "Style 139"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 184, new List<int>() { 1, 2, 3, 4 }, "Style 140"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 185, new List<int>() { 1, 2, 3, 4 }, "Style 141"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 187, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 142"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 188, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 143"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 189, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 144"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 190, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 145"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 191, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 146"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 192, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 147"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 193, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 148"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 203, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 149"));
            ValidMaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderMale, 204, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 150"));

            /* ================ MALE HATS ================ */

            //None == 8
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 8, new List<int>() { 1 }, "None"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 2, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 1"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 3, new List<int>() { 2, 3 }, "Style 2"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 4, new List<int>() { 1, 2 }, "Style 3"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 5, new List<int>() { 1, 2 }, "Style 4"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 6, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 5"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 7, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 6"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 9, new List<int>() { 6, 8 }, "Style 7"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 10, new List<int>() { 6, 8 }, "Style 8"));
            //11 = none
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 12, new List<int>() { 1, 2, 3, 5, 6, 7, 8 }, "Style 9"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 13, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 10"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 14, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 11"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 20, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 12"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 21, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 13"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 25, new List<int>() { 1, 2, 3 }, "Style 14"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, "Style 15"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 27, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 148 }, "Style 16"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 28, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 17"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 29, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 18"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 30, new List<int>() { 1, 2 }, "Style 19"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 34, new List<int>() { 1 }, "Style 20"));
            //46 == cop hat
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 54, new List<int>() { 1, 2 }, "Style 21"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 55, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 22"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 56, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 23"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 58, new List<int>() { 1, 2, 3 }, "Style 24"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 60, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 25"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 61, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 26"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 63, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 27"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 64, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 28"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 65, new List<int>() { 1 }, "Style 29"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 66, new List<int>() { 1 }, "Style 30"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 76, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 }, "Style 31"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 77, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 }, "Style 32"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 83, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 33"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 94, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 34"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 95, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 35"));
            ValidMaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderMale, 96, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 36"));

            /* ================ MALE GLASSES ================ */

            //0 == none
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 0, new List<int>() { 1 }, "None"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 1, new List<int>() { 2 }, "Wraparounds 1"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Broker/Stank Glasses"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 3, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Janitor Frames"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 4, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Enemas"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 5, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Aviators"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 7, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Fuques"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 8, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Cop Frames"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 9, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Hawaiian"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 10, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Bull Emic"));
            //11 == none
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 12, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Elvis"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 13, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Hipsters"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 15, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Guns 1"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 16, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Wraparounds 2"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 17, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Refined"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 18, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Superior"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 19, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Two-Tone"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 20, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Sunset"));
            ValidMaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 23, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Guns 2"));

            // maybe use this later
            /*ValidMaleSportsGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 0, new List<int>() { 1 }, "None"));
            ValidMaleSportsGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 1, new List<int>() { 2 }, "Broker Black Wraparounds"));

            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 0, new List<int>() { 1 }, "None"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 1 }, "Stank Black Tint"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 2 }, "Broker Grey Tint"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 3 }, "Broker Brown Tint"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 4 }, "Stank Black Tint"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 5 }, "Broker Black Shades"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 6 }, "Stank White Tint"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 7 }, "Stank White Shades"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 8 }, "Stank Green Shades"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 9 }, "Stank Tortoiseshell Glasses"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 10 }, "Stank Black Glasses"));
            ValidMaleCasualGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderMale, 2, new List<int>() { 11 }, "Stank White Glasses"));*/


            /* ================ MALE EARS ================ */

            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 225, new List<int> { 1 }, "None"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 3, new List<int>() { 1, 2, 3 }, "Style 1"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 4, new List<int>() { 1, 2, 3 }, "Style 2"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 5, new List<int>() { 1, 2 }, "Style 3"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 6, new List<int>() { 1, 2 }, "Style 4"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 7, new List<int>() { 1, 2 }, "Style 5"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 8, new List<int>() { 1, 2 }, "Style 6"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 9, new List<int>() { 1, 2, 3 }, "Style 7"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 10, new List<int>() { 1, 2, 3 }, "Style 8"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 11, new List<int>() { 1, 2, 3 }, "Style 9"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 12, new List<int>() { 1, 2, 3 }, "Style 10"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 13, new List<int>() { 1, 2, 3 }, "Style 11"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 14, new List<int>() { 1, 2, 3 }, "Style 12"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 15, new List<int>() { 1, 2 }, "Style 13"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 16, new List<int>() { 1, 2 }, "Style 14"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 17, new List<int>() { 1, 2 }, "Style 15"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 18, new List<int>() { 1, 2, 3, 4, 5 }, "Style 16"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 19, new List<int>() { 1, 2, 3, 4, 5 }, "Style 17"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 20, new List<int>() { 1, 2, 3, 4, 5 }, "Style 18"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 21, new List<int>() { 1, 2 }, "Style 19"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 22, new List<int>() { 1, 2 }, "Style 20"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 23, new List<int>() { 1, 2 }, "Style 21"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 24, new List<int>() { 1, 2, 3, 4 }, "Style 22"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 25, new List<int>() { 1, 2, 3, 4 }, "Style 23"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 26, new List<int>() { 1, 2, 3, 4 }, "Style 24"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 27, new List<int>() { 1, 2 }, "Style 25"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 28, new List<int>() { 1, 2 }, "Style 26"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 29, new List<int>() { 1, 2 }, "Style 27"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 30, new List<int>() { 1, 2, 3 }, "Style 28"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 31, new List<int>() { 1, 2, 3 }, "Style 29"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 32, new List<int>() { 1, 2, 3 }, "Style 30"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 34, new List<int>() { 1, 2 }, "Style 31"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 35, new List<int>() { 1, 2 }, "Style 32"));
            ValidMaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderMale, 36, new List<int>() { 1, 2 }, "Style 33"));

            /* ================ FEMALE HAIR ================ */

            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 0, new List<int> { }, "Close Shave"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 1, new List<int> { }, "Short"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 2, new List<int> { }, "Layered Bob"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 3, new List<int> { }, "Pigtails"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 4, new List<int> { }, "Ponytail"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 5, new List<int> { }, "Braided Mohawk"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 6, new List<int> { }, "Braids"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 7, new List<int> { }, "Bob"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 8, new List<int> { }, "Faux Hawk"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 9, new List<int> { }, "French Twist"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 10, new List<int> { }, "Long Bob"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 11, new List<int> { }, "Loose Tied"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 12, new List<int> { }, "Pixie"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 13, new List<int> { }, "Shaved Bangs"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 14, new List<int> { }, "Top Knot"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 15, new List<int> { }, "Wavy Bob"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 16, new List<int> { }, "Pin Up Girl"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 17, new List<int> { }, "Messy Bun"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 18, new List<int> { }, "Flapper Bob"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 19, new List<int> { }, "Tight Bun"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 20, new List<int> { }, "Twisted Bob"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 21, new List<int> { }, "Big Bangs"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 22, new List<int> { }, "Braided Top Knot"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 23, new List<int> { }, "Mullet"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 25, new List<int> { }, "Pinched Cornrows"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 26, new List<int> { }, "Leaf Cornrows"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 27, new List<int> { }, "Zig Zag Cornrows"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 28, new List<int> { }, "Pigtail Bangs"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 29, new List<int> { }, "Wave Braids"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 30, new List<int> { }, "Coil Braids"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 31, new List<int> { }, "Rolled Quiff"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 32, new List<int> { }, "Loose Swept Back"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 33, new List<int> { }, "Undercut Swept Back"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 34, new List<int> { }, "Undercut Swept Side"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 35, new List<int> { }, "Spiked Mohawk"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 36, new List<int> { }, "Bandana and Braid"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 37, new List<int> { }, "Skinbyrd"));
            ValidFemaleHair.Add(new Component(Component.ComponentTypeHair, Character.GenderFemale, 38, new List<int> { }, "Layered Mod"));

            /* ================ FEMALE PANTS ================ */

            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 0, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 1"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 1, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 2"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 2, new List<int>() { 1, 2, 3 }, "Style 3"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 3, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 4"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 4, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 5"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 5, new List<int>() { 9, 15, 16 }, "Style 6"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 6, new List<int>() { 1, 2, 3 }, "Style 7"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 7, new List<int>() { 1, 2, 3 }, "Style 8"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 8, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 9"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 9, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 10"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 10, new List<int>() { 1, 2, 3 }, "Style 11"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 11, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 12"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 12, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 13"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 14, new List<int>() { 1, 2, 9, 10 }, "Style 14"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 16, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 15"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 18, new List<int>() { 1, 2 }, "Style 16"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 23, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 17"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 24, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 18"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 25, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 19"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 26, new List<int>() { 1 }, "Style 20"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 27, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 21"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 28, new List<int>() { 1 }, "Style 22"));
            //34 == police
            //35 == construction? worker of some sort
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 36, new List<int>() { 1 }, "Style 23"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 28, new List<int>() { 1 }, "Style 24"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 36, new List<int>() { 1 }, "Style 25"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 37, new List<int>() { 1, 2, 3, 4 }, "Style 26"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 38, new List<int>() { 1, 2, 3, 4 }, "Style 27"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 39, new List<int>() { 1, 2, 3, 4 }, "Style 28"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 40, new List<int>() { 1, 2, 3, 4 }, "Style 29"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 41, new List<int>() { 1 }, "Style 30"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 43, new List<int>() { 1, 2 }, "Style 31"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 44, new List<int>() { 1 }, "Style 32"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 45, new List<int>() { 1, 2, 3, 4 }, "Style 33"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 47, new List<int>() { 1, 2 }, "Style 33"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 48, new List<int>() { 1, 2 }, "Style 34"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 49, new List<int>() { 1, 2 }, "Style 35"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 50, new List<int>() { 1, 2, 3, 4 }, "Style 36"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 51, new List<int>() { 1 }, "Style 37"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 52, new List<int>() { 1, 2, 3, 4 }, "Style 38"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 53, new List<int>() { 1 }, "Style 39"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 54, new List<int>() { 1, 2, 3, 4 }, "Style 40"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 55, new List<int>() { 1 }, "Style 41"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 58, new List<int>() { 1, 2, 3, 4 }, "Style 42"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 61, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 43"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 64, new List<int>() { 1, 2, 3, 4 }, "Style 44"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 65, new List<int>() { 1, 2, 3 }, "Style 45"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 66, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 46"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 67, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 47"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 67, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 48"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 73, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 49"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 74, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 50"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 75, new List<int>() { 1, 2, 3 }, "Style 51"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 76, new List<int>() { 1, 2, 3 }, "Style 52"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 77, new List<int>() { 1, 2, 3 }, "Style 53"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 78, new List<int>() { 1, 2, 3, 4 }, "Style 54"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 80, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 55"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 81, new List<int>() { 1, 2, 3 }, "Style 56"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 82, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 57"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 83, new List<int>() { 1, 2, 3 }, "Style 58"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 84, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 59"));
            ValidFemaleLegs.Add(new Component(Component.ComponentTypeLegs, Character.GenderFemale, 85, new List<int>() { 1, 2, 3 }, "Style 60"));

            /* ================ FEMALE SHOES ================ */

            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 0, new List<int>() { 1, 2, 3, 4 }, "Style 1"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 1, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 2"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 2, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 3"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 3, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 4"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 4, new List<int>() { 1, 2, 3, 4 }, "Style 5"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 5, new List<int>() { 1, 2, 11, 14 }, "Style 6"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 6, new List<int>() { 1, 2, 3, 4 }, "Style 7"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 7, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 8"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 8, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 9"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 9, new List<int>() { 1, 2, 3, 4, 12, 13 }, "Style 10"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 10, new List<int>() { 1, 2, 3, 4 }, "Style 11"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 11, new List<int>() { 1, 2, 3, 4 }, "Style 12"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 13, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 13"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 14, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 14"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 15, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 15"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 16, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 16"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 19, new List<int>() { 1 }, "Style 17"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 20, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 18"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 21, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 19"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 22, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 20"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 23, new List<int>() { 1, 2, 3 }, "Style 21"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 24, new List<int>() { 1 }, "Style 22"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 25, new List<int>() { 1 }, "Style 23"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 26, new List<int>() { 1 }, "Style 24"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 27, new List<int>() { 1 }, "Style 25"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 28, new List<int>() { 1 }, "Style 26"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 29, new List<int>() { 1 }, "Style 27"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 30, new List<int>() { 1 }, "Style 28"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 31, new List<int>() { 1 }, "Style 29"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 32, new List<int>() { 1, 2, 3, 4, 5 }, "Style 30"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 33, new List<int>() { 1 }, "Style 31"));
            //37 == bare foot
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 36, new List<int>() { 1, 2 }, "Style 32"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 37, new List<int>() { 1, 2, 3, 4, 5 }, "Style 33"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 38, new List<int>() { 1, 2, 3, 4, 5 }, "Style 34"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 39, new List<int>() { 1 }, "Style 35"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 40, new List<int>() { 1 }, "Style 36"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 41, new List<int>() { 1 }, "Style 37"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 42, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 38"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 43, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 39"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 44, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 40"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 45, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 41"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 46, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 42"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 47, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 43"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 48, new List<int>() { 1, 2 }, "Style 44"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 49, new List<int>() { 1, 2 }, "Style 45"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 50, new List<int>() { 1, 2 }, "Style 46"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 51, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 47"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 52, new List<int>() { 1, 2 }, "Style 48"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 53, new List<int>() { 1, 2 }, "Style 49"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 54, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 50"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 55, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 51"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 56, new List<int>() { 1, 2 }, "Style 52"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 57, new List<int>() { 1, 2, 3 }, "Style 53"));
            ValidFemaleShoes.Add(new Component(Component.ComponentTypeShoes, Character.GenderFemale, 58, new List<int>() { 1, 2, 3 }, "Style 54"));

            /* ================ FEMALE ACCESSORIES ================ */

            //0 = none
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 0, new List<int>() { 1 }, "None"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 1, new List<int>() { 1, 2, 3 }, "Style 1"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 2, new List<int>() { 1, 2, 3 }, "Style 2"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 3, new List<int>() { 1, 2, 3 }, "Style 3"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 4, new List<int>() { 3, 4 }, "Style 4"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 5, new List<int>() { 5, 6 }, "Style 5"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 6, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 6"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 7, new List<int>() { 1 }, "Style 7"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 9, new List<int>() { 1 }, "Style 8"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 10, new List<int>() { 1, 2, 3, 4 }, "Style 9"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 11, new List<int>() { 1, 2, 3, 4 }, "Style 10"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 12, new List<int>() { 1, 2, 3 }, "Style 11"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 13, new List<int>() { 1 }, "Style 12"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 14, new List<int>() { 1 }, "Style 13"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 15, new List<int>() { 1 }, "Style 14"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 17, new List<int>() { 1, 2, 3 }, "Style 15"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 18, new List<int>() { 1 }, "Style 16"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 19, new List<int>() { 1 }, "Style 17"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 20, new List<int>() { 1, 2, 3, 4, 5 }, "Style 18"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 21, new List<int>() { 1, 2, 3 }, "Style 19"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 22, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, "Style 20"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 23, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 21"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 22"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 27, new List<int>() { 1, 2, 3 }, "Style 27"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 28, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 28"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 29, new List<int>() { 1, 2 }, "Style 29"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 30, new List<int>() { 1, 2 }, "Style 30"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 31, new List<int>() { 1 }, "Style 31"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 32, new List<int>() { 1, 2 }, "Style 32"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 33, new List<int>() { 1 }, "Style 33"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 34, new List<int>() { 1, 2 }, "Style 34"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 35, new List<int>() { 1, 2 }, "Style 35"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 36, new List<int>() { 1 }, "Style 36"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 37, new List<int>() { 1, 2 }, "Style 37"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 38, new List<int>() { 1 }, "Style 38"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 39, new List<int>() { 1, 2 }, "Style 39"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 40, new List<int>() { 1 }, "Style 40"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 41, new List<int>() { 1 }, "Style 41"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 42, new List<int>() { 1, 2 }, "Style 42"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 53, new List<int>() { 1, 2 }, "Style 43"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 54, new List<int>() { 1, 2 }, "Style 44"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 55, new List<int>() { 1, 2 }, "Style 45"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 56, new List<int>() { 1, 2 }, "Style 46"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 57, new List<int>() { 1, 2 }, "Style 47"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 58, new List<int>() { 1, 2 }, "Style 48"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 59, new List<int>() { 1, 2 }, "Style 49"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 60, new List<int>() { 1, 2 }, "Style 50"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 61, new List<int>() { 1, 2 }, "Style 51"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 62, new List<int>() { 1, 2 }, "Style 52"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 64, new List<int>() { 1, 2 }, "Style 53"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 65, new List<int>() { 1, 2 }, "Style 54"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 66, new List<int>() { 1, 2 }, "Style 55"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 67, new List<int>() { 1, 2 }, "Style 56"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 68, new List<int>() { 1, 2 }, "Style 57"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 69, new List<int>() { 1, 2 }, "Style 58"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 70, new List<int>() { 1, 2 }, "Style 59"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 71, new List<int>() { 1, 2 }, "Style 60"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 72, new List<int>() { 1, 2 }, "Style 61"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 73, new List<int>() { 1, 2 }, "Style 62"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 81, new List<int>() { 1, 2 }, "Style 63"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 82, new List<int>() { 1, 2 }, "Style 64"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 83, new List<int>() { 1, 2 }, "Style 65"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 84, new List<int>() { 1 }, "Style 66"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 85, new List<int>() { 1 }, "Style 67"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 86, new List<int>() { 1, 2 }, "Style 68"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 87, new List<int>() { 1, 2 }, "Style 69"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 88, new List<int>() { 1, 2 }, "Style 70"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 89, new List<int>() { 1, 2 }, "Style 71"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 90, new List<int>() { 1, 2 }, "Style 72"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 91, new List<int>() { 1, 2 }, "Style 73"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 92, new List<int>() { 1, 2 }, "Style 74"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 93, new List<int>() { 1, 2 }, "Style 75"));
            ValidFemaleAccessories.Add(new Component(Component.ComponentTypeAccessories, Character.GenderFemale, 94, new List<int>() { 1, 2 }, "Style 76"));

            /* ================ FEMALE UNDERSHIRTS ================ */

            //none = 3
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 3, new List<int>() { 1 }, "None"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 0, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 1"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 1, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 2"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 4, new List<int>() { 14, 15 }, "Style 3"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 5, new List<int>() { 1, 2, 8, 10 }, "Style 4"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 11, new List<int>() { 1, 2, 3, 11, 12, 16 }, "Style 5"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 12, new List<int>() { 8, 9, 10 }, "Style 6"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 16, new List<int>() { 1, 2, 3 }, "Style 7"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 20, new List<int>() { 1, 2, 3 }, "Style 8"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 21, new List<int>() { 1, 2, 3 }, "Style 9"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 23, new List<int>() { 1, 2, 3 }, "Style 10"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 24, new List<int>() { 1, 2, 3 }, "Style 11"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 25, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }, "Style 12"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 26, new List<int>() { 1, 2, 3 }, "Style 13"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 27, new List<int>() { 1, 2, 3 }, "Style 14"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 28, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Style 15"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 29, new List<int>() { 1, 2, 3, 4, 5 }, "Style 16"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 30, new List<int>() { 1, 2, 3, 4 }, "Style 17"));
            //35 = cop radio
            //36 = construction vest
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 31, new List<int>() { 1 }, "Style 18"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 37, new List<int>() { 1, 2 }, "Style 19"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 38, new List<int>() { 1, 2, 3 }, "Style 20"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 39, new List<int>() { 1 }, "Style 21"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 40, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 22"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 41, new List<int>() { 1, 2, 3, 4, 5 }, "Style 23"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 44, new List<int>() { 1, 2 }, "Style 24"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 45, new List<int>() { 1 }, "Style 25"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 46, new List<int>() { 1 }, "Style 26"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 47, new List<int>() { 1, 2, 3, 4 }, "Style 27"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 48, new List<int>() { 1 }, "Style 29"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 49, new List<int>() { 1 }, "Style 30"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 50, new List<int>() { 1, 2 }, "Style 31"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 51, new List<int>() { 1, 2 }, "Style 31"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 52, new List<int>() { 1, 2 }, "Style 32"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 53, new List<int>() { 1, 2 }, "Style 33"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 54, new List<int>() { 1 }, "Style 34"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 55, new List<int>() { 1 }, "Style 35"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 56, new List<int>() { 1 }, "Style 36"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 57, new List<int>() { 1 }, "Style 37"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 58, new List<int>() { 1 }, "Style 38"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 59, new List<int>() { 1, 2 }, "Style 39"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 60, new List<int>() { 1 }, "Style 40"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 61, new List<int>() { 1, 2, 3, 4 }, "Style 41"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 62, new List<int>() { 1, 2, 3, 4 }, "Style 42"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 63, new List<int>() { 1, 2, 3, 4 }, "Style 43"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 64, new List<int>() { 1, 2, 3, 4, 5 }, "Style 44"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 65, new List<int>() { 1 }, "Style 45"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 66, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 46"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 67, new List<int>() { 1 }, "Style 47"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 69, new List<int>() { 1, 2, 3 }, "Style 48"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 70, new List<int>() { 1 }, "Style 49"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 71, new List<int>() { 1, 2, 3 }, "Style 50"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 72, new List<int>() { 1, 2, 3 }, "Style 51"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 73, new List<int>() { 1, 2, 3 }, "Style 52"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 74, new List<int>() { 1, 2, 3 }, "Style 53"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 75, new List<int>() { 1, 2, 3 }, "Style 54"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 76, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 55"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 77, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 56"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 78, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 57"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 79, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 58"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 80, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 59"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 86, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 }, "Style 60"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 87, new List<int>() { 1 }, "Style 61"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 88, new List<int>() { 1 }, "Style 62"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 89, new List<int>() { 1 }, "Style 63"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 90, new List<int>() { 1, 2 }, "Style 64"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 91, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 65"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 92, new List<int>() { 1, 2, 3 }, "Style 66"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 93, new List<int>() { 1, 2 }, "Style 67"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 94, new List<int>() { 1, 2 }, "Style 68"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 95, new List<int>() { 1, 2 }, "Style 69"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 96, new List<int>() { 1, 2, 3, 4 }, "Style 70"));
            ValidFemaleUndershirt.Add(new Component(Component.ComponentTypeUndershirt, Character.GenderFemale, 97, new List<int>() { 1, 2, }, "Style 71"));

            /* ================ FEMALE TOPS ================ */

            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 0, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 1"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 1, new List<int>() { 1, 2, 3, 5, 6, 7, 10, 12, 15 }, "Style 2"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 2, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 3"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 3, new List<int>() { 1, 2, 3, 4, 5, 11, 12, 13, 14, 15 }, "Style 4"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 6, new List<int>() { 1, 2, 3, 5 }, "Style 5"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 7, new List<int>() { 1, 2, 3, 9 }, "Style 6"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 8, new List<int>() { 1, 2, 3, 14 }, "Style 7"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 9, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, "Style 8"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 10, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, "Style 9"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 14, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, "Style 10"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 17, new List<int>() { 1 }, "Style 11"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 23, new List<int>() { 1, 2, 3 }, "Style 12"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 24, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 13"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 14"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 27, new List<int>() { 1, 2, 3 }, "Style 15"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 29, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 16"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 31, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 17"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 34, new List<int>() { 1 }, "Style 18"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 35, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 19"));
            //48 == cop shirt
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 49, new List<int>() { 1, 2 }, "Style 20"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 50, new List<int>() { 1 }, "Style 21"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 51, new List<int>() { 1 }, "Style 22"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 52, new List<int>() { 1, 2, 3, 4 }, "Style 23"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 53, new List<int>() { 1, 2, 3, 4 }, "Style 24"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 54, new List<int>() { 1 }, "Style 25"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 55, new List<int>() { 1 }, "Style 26"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 56, new List<int>() { 1 }, "Style 27"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 57, new List<int>() { 1 }, "Style 28"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 58, new List<int>() { 1 }, "Style 29"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 59, new List<int>() { 1, 2, 3, 4 }, "Style 30"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 60, new List<int>() { 1, 2, 3, 4 }, "Style 31"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 61, new List<int>() { 1, 2, 3, 4 }, "Style 32"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 62, new List<int>() { 1 }, "Style 33"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 63, new List<int>() { 1 }, "Style 34"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 64, new List<int>() { 1 }, "Style 35"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 65, new List<int>() { 1, 2, 3, 4 }, "Style 36"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 66, new List<int>() { 1, 2, 3, 4 }, "Style 37"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 67, new List<int>() { 1 }, "Style 38"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 68, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 39"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 69, new List<int>() { 1 }, "Style 40"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 70, new List<int>() { 1, 2, 3, 4, 5 }, "Style 41"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 71, new List<int>() { 1 }, "Style 42"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 72, new List<int>() { 1 }, "Style 43"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 73, new List<int>() { 1, 2, 3 }, "Style 44"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 75, new List<int>() { 1, 2, 3, 4 }, "Style 45"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 76, new List<int>() { 1, 2, 3, 4, 5 }, "Style 46"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 77, new List<int>() { 1}, "Style 47"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 78, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 48"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 79, new List<int>() { 1 }, "Style 49"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 80, new List<int>() { 1 }, "Style 50"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 81, new List<int>() { 1, 2, 3 }, "Style 51"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 83, new List<int>() { 1, 2, 3, 4, 5 }, "Style 52"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 84, new List<int>() { 1, 2, 3 }, "Style 53"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 85, new List<int>() { 1 }, "Style 54"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 86, new List<int>() { 1, 2, 3 }, "Style 55"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 87, new List<int>() { 1 }, "Style 56"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 88, new List<int>() { 1, 2 }, "Style 57"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 89, new List<int>() { 1, 2 }, "Style 58"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 90, new List<int>() { 1 }, "Style 59"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 91, new List<int>() { 1 }, "Style 60"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 92, new List<int>() { 1, 2, 3, 4 }, "Style 61"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 93, new List<int>() { 1, 2, 3 }, "Style 62"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 94, new List<int>() { 1 }, "Style 63"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 95, new List<int>() { 1 }, "Style 64"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 96, new List<int>() { 1 }, "Style 65"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 97, new List<int>() { 1 }, "Style 66"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 98, new List<int>() { 1, 2 }, "Style 67"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 102, new List<int>() { 1 }, "Style 68"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 103, new List<int>() { 1 }, "Style 69"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 104, new List<int>() { 1 }, "Style 70"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 106, new List<int>() { 1 }, "Style 71"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 107, new List<int>() { 1 }, "Style 72"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 109, new List<int>() { 1 }, "Style 73"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 110, new List<int>() { 1 }, "Style 74"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 119, new List<int>() { 1, 2, 3 }, "Style 75"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 120, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 76"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 121, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 77"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 122, new List<int>() { 1 }, "Style 78"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 123, new List<int>() { 1, 2, 3 }, "Style 79"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 124, new List<int>() { 1 }, "Style 80"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 125, new List<int>() { 1 }, "Style 81"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 126, new List<int>() { 1, 2, 3 }, "Style 82"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 127, new List<int>() { 1 }, "Style 83"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 128, new List<int>() { 1 }, "Style 84"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 129, new List<int>() { 1 }, "Style 85"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 130, new List<int>() { 1 }, "Style 86"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 131, new List<int>() { 1 }, "Style 87"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 132, new List<int>() { 1 }, "Style 88"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 133, new List<int>() { 1 }, "Style 89"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 134, new List<int>() { 1, 2, 3 }, "Style 90"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 135, new List<int>() { 1, 2, 3 }, "Style 91"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 136, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 92"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 137, new List<int>() { 1, 2, 3 }, "Style 93"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 138, new List<int>() { 1, 2, 3 }, "Style 94"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 139, new List<int>() { 1, 2, 3 }, "Style 95"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 140, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 96"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 141, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 97"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 142, new List<int>() { 1, 2, 3 }, "Style 98"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 147, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 99"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 148, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 100"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 150, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 101"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 151, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 102"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 153, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 103"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 158, new List<int>() { 1, 2, 3 }, "Style 104"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 160, new List<int>() { 1 }, "Style 105"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 161, new List<int>() { 1, 2, 3 }, "Style 106"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 163, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 107"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 164, new List<int>() { 1, 2, 3 }, "Style 108"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 165, new List<int>() { 1, 2, 3 }, "Style 109"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 166, new List<int>() { 1, 2, 3, 4 }, "Style 110"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 169, new List<int>() { 1, 2, 3, 4 }, "Style 111"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 171, new List<int>() { 1, 2 }, "Style 112"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 172, new List<int>() { 1, 2 }, "Style 113"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 174, new List<int>() { 1, 2, 3, 4 }, "Style 114"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 176, new List<int>() { 1 }, "Style 115"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 183, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 116"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 184, new List<int>() { 1, 2 }, "Style 117"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 185, new List<int>() { 1, 2, 3, 4 }, "Style 118"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 186, new List<int>() { 1, 2, 3, 4 }, "Style 119"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 187, new List<int>() { 1, 2, 3, 4 }, "Style 120"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 189, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 121"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 190, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 122"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 191, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 123"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 192, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, "Style 124"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 193, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 125"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 194, new List<int>() { 1, 2, 3 }, "Style 126"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 195, new List<int>() { 1, 2, 3 }, "Style 127"));
            ValidFemaleTops.Add(new Component(Component.ComponentTypeTops, Character.GenderFemale, 202, new List<int>() { 1, 2, 3, 4, 5 }, "Style 128"));


            /* ================ FEMALE HATS ================ */

            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 57, new List<int>() { 1 }, "None"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 2, new List<int>() { 2 }, "Style 1"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 3, new List<int>() { 8 }, "Style 2"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 4, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 3"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 5, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 4"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 6, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 5"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 7, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 6"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 8, new List<int>() { 5 }, "Style 7"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 9, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 8"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 10, new List<int>() { 8 }, "Style 9"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 11, new List<int>() { 2 }, "Style 10"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 12, new List<int>() { 1, 7, 8 }, "Style 11"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 13, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 12"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 14, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 13"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 20, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 14"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 21, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 15"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 22, new List<int>() { 1, 2 }, "Style 16"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, "Style 17"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 27, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, "Style 18"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 28, new List<int>() { 1, 2, 3, 4, 5, 6 }, "Style 19"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 29, new List<int>() { 1, 2, 3, 4, 5 }, "Style 20"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 33, new List<int>() { 1 }, "Style 21"));
            //45 = cop
            //57 = none
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 53, new List<int>() { 1 }, "Style 22"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 54, new List<int>() { 1, 2 }, "Style 23"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 55, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Style 24"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 56, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 25"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 58, new List<int>() { 1, 2, 3 }, "Style 26"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 60, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 27"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 61, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 28"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 63, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 29"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 64, new List<int>() { 1 }, "Style 30"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 65, new List<int>() { 1 }, "Style 31"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 75, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "Style 32"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 77, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 }, "Style 33"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 82, new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, "Style 34"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 94, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 35"));
            ValidFemaleHats.Add(new Component(Component.ComponentTypeHats, Character.GenderFemale, 95, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 36"));

            /* ================ FEMALE GLASSES ================ */

            //5 = none
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 5, new List<int>() { 1 }, "None"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 0, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 1"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 1, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 2"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 2, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 3"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 3, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 4"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 4, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 5"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 6, new List<int>() { 1 }, "Style 6"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 7, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 7"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 8, new List<int>() { 1, 9, 10, 11 }, "Style 8"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 9, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 9"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 10, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 10"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 11, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 11"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 14, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 12"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 16, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "Style 13"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 17, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 14"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 18, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8}, "Style 15"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 19, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, "Style 16"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 20, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 17"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 21, new List<int>() { 1 }, "Style 18"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 24, new List<int>() { 1, 2, 3, 4, 5, 6}, "Style 19"));
            ValidFemaleGlasses.Add(new Component(Component.ComponentTypeGlasses, Character.GenderFemale, 25, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }, "Style 20"));

            /* ================ FEMALE EARS ================ */

            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 255, new List<int>() { -1 }, "None"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 0, new List<int>() { 1 }, "Style 1"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 1, new List<int>() { 1 }, "Style 2"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 2, new List<int>() { 1 }, "Style 3"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 3, new List<int>() { 1, 2, 3 }, "Style 4"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 4, new List<int>() { 1, 2, 3 }, "Style 5"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 5, new List<int>() { 1, 2, 3 }, "Style 6"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 6, new List<int>() { 1, 2 }, "Style 7"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 7, new List<int>() { 1, 2 }, "Style 8"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 8, new List<int>() { 1, 2 }, "Style 9"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 9, new List<int>() { 1, 2, 3 }, "Style 10"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 10, new List<int>() { 1, 2, 3 }, "Style 11"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 11, new List<int>() { 1, 2, 3 }, "Style 12"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 12, new List<int>() { 1, 2, 3 }, "Style 13"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 13, new List<int>() { 1, 2, 3 }, "Style 14"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 14, new List<int>() { 1, 2, 3 }, "Style 15"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 15, new List<int>() { 1, 2, 3 }, "Style 16"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 16, new List<int>() { 1, 2, 3 }, "Style 17"));
            ValidFemaleEars.Add(new Component(Component.ComponentTypeEars, Character.GenderFemale, 17, new List<int>() { 1, 2, 3 }, "Style 18"));

            /* ================ BAGS ================ */
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 0, new List<int>() { 1 }, "None"));

            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 1, new List<int>() { 1 }, "Colored Bag Size 1"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 2, new List<int>() { 1 }, "Colored Bag Size 2"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 3, new List<int>() { 1 }, "Colored Bag Size 3"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 4, new List<int>() { 1 }, "Colored Bag Size 4"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 5, new List<int>() { 1 }, "Colored Bag Size 5"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 6, new List<int>() { 1 }, "Colored Bag Size 6"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 7, new List<int>() { 1 }, "Colored Bag Size 7"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 19, new List<int>() { 1 }, "Colored Bag Size 8"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 48, new List<int>() { 1 }, "Colored Bag Size 9"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 62, new List<int>() { 1 }, "Colored Bag Size 10"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 63, new List<int>() { 1 }, "Colored Bag Size 11"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 68, new List<int>() { 1 }, "Colored Bag Size 12"));

            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 10, new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25, 26 }, "Backback With Flag Size 1"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 11, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 1"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 12, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 2"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 13, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 3"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 14, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 4"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 15, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 5"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 16, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 6"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 17, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 7"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 18, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 8"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 49, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 9"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 64, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 10"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 67, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag Size 11"));

            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 21, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 1"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 22, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 2"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 23, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 3"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 24, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 4"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 25, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 5"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 26, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 6"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 27, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 7"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 28, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 8"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 29, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 9"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 50, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 10"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 65, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }, "Backback With Flag 2 Size 11"));

            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 31, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 1"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 32, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 2"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 33, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 3"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 34, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 4"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 35, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 5"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 36, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 6"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 37, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 7"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 38, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 8"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 39, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 9"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 51, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 10"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 66, new List<int>() { 1, 2, 3, 4 }, "Colored Bag 2 Size 11"));

            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 40, new List<int>() { 1 }, "Duffle Bag 1"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 41, new List<int>() { 1 }, "Duffle Bag 2"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 44, new List<int>() { 1 }, "Duffle Bag 3"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 45, new List<int>() {1}, "Duffle Bag 4"));

            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 52, new List<int>() { 1,2,3,4,5,6,7,8,9 }, "Colored Bag 3 Size 1"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 53, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 2"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 54, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 3"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 55, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 4"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 56, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 5"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 57, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 6"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 58, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 7"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 59, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 8"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 60, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 9"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 61, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 10"));
            ValidBags.Add(new Component(Component.ComponentTypeBags, 0, 69, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, "Colored Bag 3 Size 11"));

            DebugManager.DebugMessage("[ComponentM] Component Manager initialized!");
        }
    }
}
