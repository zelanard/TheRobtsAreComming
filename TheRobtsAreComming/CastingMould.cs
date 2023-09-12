using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRobtsAreComming
{
    /// <summary>
    /// Robot CastingMould
    /// </summary>
    internal class CastingMould
    {
        private RobotType _robotType;   // Sparklebot, CleaningSpider, RubberRollOMatic, SignalSeaker
        private bool _sweep;            // Sparklebot, CleaningSpider, RubberRollOMatic, SignalSeaker
        private ConsoleColor _colour;   // Sparklebot, CleaningSpider, RubberRollOMatic
        private bool _hasBattery;       //             CleaningSpider, RubberRollOMatic, SignalSeaker
        private Size _size;             // Sparklebot,                 RubberRollOMatic
        private Chipset _chipset;       // Sparklebot,                 RubberRollOMatic
        private bool _hasWheels;        // Sparklebot,                 RubberRollOMatic
        private int _wheels;            // Sparklebot,                 RubberRollOMatic
        private bool _hasSope;          // Sparklebot
        private bool _hasWifi;          //                                               SignalSeaker


        //Sparklebot
        private CastingMould()
        {
            RobotType = RobotType.None;
            Size = Size.Small;
            Colour = ConsoleColor.White;
            Chipset = Chipset.Default;
            HasBattery = true;
            HasSope = false;
            HasWheels = false;
            HasWifi = false;
            Wheels = 0;
            Sweep = true;
        }
        private CastingMould(RobotType robotType) : this()
        {
            RobotType = robotType;
        }
        private CastingMould(RobotType robotType, bool sweep) : this(robotType)
        {
            Sweep = sweep;
        }
        private CastingMould(RobotType robotType, bool sweep, ConsoleColor colour) : this(robotType, sweep)
        {
            Colour = colour;
        }
        private CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, Size size) : this(robotType, sweep, colour)
        {
            Size = size;
        }
        private CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, Size size, Chipset chipset) : this(robotType, sweep, colour, size)
        {
            Chipset = chipset;
        }
        private CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, Size size, Chipset chipset, bool hasWheels) : this(robotType, sweep, colour, size, chipset)
        {
            HasWheels = hasWheels;
        }
        private CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, Size size, Chipset chipset, bool hasWheels, int wheels) : this(robotType, sweep, colour, size, chipset, hasWheels)
        {
            Wheels = wheels;
        }

        /// <summary>
        /// Sparklebot
        /// </summary>
        /// <param name="robotType"></param>
        /// <param name="sweep"></param>
        /// <param name="colour"></param>
        /// <param name="size"></param>
        /// <param name="chipset"></param>
        /// <param name="hasWheels"></param>
        /// <param name="wheels"></param>
        /// <param name="hasSope"></param>
        public CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, Size size, Chipset chipset, bool hasWheels, int wheels, bool hasSope) : this(robotType, sweep, colour, size, chipset, hasWheels, wheels)
        {
            HasSope = hasSope;
        }

        //CleaningSpider

        /// <summary>
        /// CleaningSpider
        /// </summary>
        /// <param name="robotType"></param>
        /// <param name="sweep"></param>
        /// <param name="colour"></param>
        /// <param name="hasBattery"></param>
        public CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, bool hasBattery) : this(robotType, sweep, colour)
        {
            HasBattery = hasBattery;
        }

        //RubberRollOMatic
        private CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, bool hasBattery, Size size) : this(robotType, sweep, colour, hasBattery)
        {
            Size = size;
        }
        private CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, bool hasBattery, Size size, Chipset chipset) : this(robotType, sweep, colour, hasBattery, size)
        {
            Chipset = chipset;
        }
        private CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, bool hasBattery, Size size, Chipset chipset, bool hasWheels) : this(robotType, sweep, colour, hasBattery, size, chipset)
        {
            HasWheels = hasWheels;
        }

        /// <summary>
        /// RubberRollOMatic
        /// </summary>
        /// <param name="robotType"></param>
        /// <param name="sweep"></param>
        /// <param name="colour"></param>
        /// <param name="hasBattery"></param>
        /// <param name="size"></param>
        /// <param name="chipset"></param>
        /// <param name="hasWheels"></param>
        /// <param name="wheels"></param>
        public CastingMould(RobotType robotType, bool sweep, ConsoleColor colour, bool hasBattery, Size size, Chipset chipset, bool hasWheels, int wheels) : this(robotType, sweep, colour, hasBattery, size, chipset, hasWheels)
        {
            Wheels = wheels;
        }

        //SignalSeaker
        private CastingMould(RobotType robotType, bool sweep, bool hasBattery) : this(robotType, sweep)
        {
            HasBattery = hasBattery;
        }

        /// <summary>
        /// SignalSeaker
        /// </summary>
        /// <param name="robotType"></param>
        /// <param name="sweep"></param>
        /// <param name="hasBattery"></param>
        /// <param name="hasWifi"></param>
        public CastingMould(RobotType robotType, bool sweep, bool hasBattery, bool hasWifi) : this(robotType, sweep, hasBattery)
        {
            HasWifi = hasWifi;
        }

        #region Properties
        public ConsoleColor Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        public bool HasBattery
        {
            get { return _hasBattery; }
            set { _hasBattery = value; }
        }
        public bool HasSope
        {
            get { return _hasSope; }
            set { _hasSope = value; }
        }
        public bool HasWheels
        {
            get { return _hasWheels; }
            set { _hasWheels = value; }
        }
        public bool HasWifi
        {
            get { return _hasWifi; }
            set { _hasWifi = value; }
        }
        public int Wheels
        {
            get { return _wheels; }
            set { _wheels = value; }
        }
        internal RobotType RobotType
        {
            get { return _robotType; }
            set { _robotType = value; }
        }
        internal Size Size
        {
            get { return _size; }
            set { _size = value; }
        }
        internal Chipset Chipset
        {
            get { return _chipset; }
            set { _chipset = value; }
        }
        public bool Sweep
        {
            get { return _sweep; }
            set { _sweep = value; }
        }

        #endregion
    }
    enum RobotType
    {
        None,
        CleaningSpider,
        SparkleBot,
        RubberRollOMatic,
        SignalSeaker
    }
    enum Chipset
    {
        Default,
        RX54667,
        QT8339
    }
    enum Size
    {
        Small,
        Large
    }
}

