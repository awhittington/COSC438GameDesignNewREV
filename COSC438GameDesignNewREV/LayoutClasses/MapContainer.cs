﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace COSC438GameDesignNewREV
{

    public class MapContainer
    {
        private GraphicsDevice gd;
        private GraphicsDeviceManager gdm;
        private String item1;
        private String item2;
        private String item3;
        private String item4;
        private String item5;
        public MapContainer(Game1 game)
        {
            gd = game.GraphicsDevice;
            gdm = game.graphicsFunc;
            item1 = "Images/ItemImages/MiningAxe.png";
            item2 = "Images/ItemImages/MiningAxe.png";
            item3 = "Images/ItemImages/MiningAxe.png";
            item4 = "Images/ItemImages/MedKitTile.png";
            item5 = "Images/ItemImages/MiningAxe.png";
        }
        /*
        NOTE playerStartLocs are used for eventBased coordinates, after event 1 occurs you need to adjust starting and ending locations based off the terrain changes.
        NOTE Each Coordinate pair is for a given level
        I.E 0,1 are for LVL 1; 2,3 are for LVL 2; 3,4 are for LVL 3 ETC
        */
        public String Item1
        {
            get
            {
                return item1;
            }
            set
            {
                item1 = value;
            }
        }
        public String Item2
        {
            get
            {
                return item2;
            }
            set
            {
                item2 = value;
            }
        }
        public String Item3
        {
            get
            {
                return item3;
            }
            set
            {
                item1 = value;
            }
        }
        public String Item4
        {
            get
            {
                return item4;
            }
            set
            {
                item1 = value;
            }
        }
        public String Item5
        {
            get
            {
                return item5;
            }
            set
            {
                item5 = value;
            }
        }
        public Point[] playerStartLocs = { new Point(770, 359), new Point(10, 369), new Point(770, 359), new Point(10, 439), new Point(770, 369), new Point(10, 399), new Point(770, 439), new Point(10, 439) };
        //Used for drawing inventory items on the map and in our bag      
        //Positional coordinates for where each item belongs in the bag
        public Point[] bagLocs = {new Point(0, 0),new Point(0, 0),new Point(0, 0),new Point(400, 320) , new Point(480, 320), new Point(560, 320), new Point(640, 320), new Point(720, 320) , new Point(400,400),
            new Point(480, 400), new Point(560, 400), new Point(640, 400), new Point(720, 400)
        };
        //Map matricies for all levels
        public int[,] levelZero = new int[,]
                          {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-6},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-7},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-8},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-9},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-10},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-11},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-5},
                           { 2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-4}};
        public int[,] levelOne = new int[,]
                           {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-6},
                           { 0,0,0,0,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-7},
                           { 0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,-8},
                           { 0,0,0,0,0,0,2,2,0,0,0,0,0,0,0,0,0,0,0,-9},
                           { 0,0,0,0,0,0,2,2,2,0,0,0,0,0,0,0,0,0,0,-10},
                           { 0,3,0,0,0,0,0,2,2,2,0,0,0,0,0,0,0,0,0,-11},
                           { 0,2,2,0,0,0,0,0,0,2,2,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,2,2,0,0,0,0,0,0,0,0,0},
                           { -5,0,0,0,0,2,2,0,0,0,2,2,0,0,0,0,0,0,0,-5},
                           { -4,0,0,0,0,2,2,0,0,0,0,2,2,0,0,0,0,0,0,-4}};
        public int[,] dangerZone = new int[,]
                           {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-6},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-7},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-8},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-9},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-10},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-11},
                           { 0,0,0,0,2,0,0,2,0,0,0,0,2,0,2,2,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}};
        public int[,] levelOnePostEvent = new int[,]
                          {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-6},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-7},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-8},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-9},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-10},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-11},
                           { -5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { -4,0,0,0,0,0,2,2,2,2,2,2,2,2,0,0,0,0,0,0},
                           { 2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0,0,0,-5},
                           { 2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0,0,0,-4}};
        public int[,] levelTwo = new int[,]
                          {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8,0,-1,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,0,-1,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,0,0,-1,0,0},
                           { 0,0,0,0,0,0,2,2,0,0,0,0,0,0,0,0,0,-1,0,0},
                           { 0,0,0,0,0,0,2,2,0,0,0,0,2,2,0,0,0,-1,0,0},
                           { -5,0,0,0,0,0,2,2,0,0,2,2,0,0,0,0,0,-1,0,-5},
                           { -4,2,2,2,2,2,2,2,0,0,2,2,2,2,2,2,2,-1,2,-4}};
        public int[,] CraneLevel = new int[,]
                          {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,-83,-80,-83,-83,-83,-83,-80,-83,-83,-83,-83,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,-84,-84,-84,-81,-84,-84,-81,-84,-84,-84,-84,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,-85,-85,-85,-82,-85,-85,-82,-85,-85,-85,-85,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-88,-87,-86,-101},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-92,-91,-90,-89},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-96,-95,-94,-93}};
        public int[,] levelTwoPostEvent = new int[,]
                          {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8,0,-1,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,0,-1,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,0,0,-1,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,0,0},
                           { -5,0,0,0,0,0,0,0,0,0,0,0,2,2,0,0,0,-1,0,-5},
                           { -4,0,0,0,0,0,2,2,2,2,2,2,0,0,0,0,0,-1,0,-4},
                           { 2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,-1,2,2}};
        public int[,] levelThree = new int[,]
                         {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,2,2,0,0,0,0,0,0,7,0,-2,-2,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,2,2,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,2,2,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,9,0,0,0,0,2,2,0,0,0,0,0,0,0,0,0,0},
                           { -5,0,2,2,0,0,2,2,0,0,0,0,0,0,0,0,0,0,0,0},
                           { -4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-5},
                           { 2,2,2,2,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,-4}};
        public int[,] levelThreePostEvent = new int[,]
                        {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { -5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-5},
                           { -4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-4}};
        public int[,] levelFour = new int[,]
                           {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { -5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-5},
                           { -4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-4}};
        public int[,] levelFourPostEvent = new int[,]
                          {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { -5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-5},
                           { -4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-4}};
        public int[,] levelFive = new int[,]
                           {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { -5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-5},
                           { -4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-4}};
        public int[,] levelFivePostEvent = new int[,]
                           {{ -3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                           { -5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-5},
                           { -4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-4}};
        public int[,] shaderMap = new int[,]
                          {{ -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199},
                           { -199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199,-199}};
    }
}
