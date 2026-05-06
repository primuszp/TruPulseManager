using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TruPulseManager
{
    [Serializable()]
    public class Project : ISerializable
    {
        public enum Section { Add, Insert, Checked, None };

        #region Private Member Variables

        private static string name = "";
        private static string path = "";

        //private static Station station = new Station();
        private static Station station = null;
        
        //private static CrossSection crossSection = new CrossSection();
        private static CrossSection crossSection = null;

        private static List<MeasuredPoint> measurePoints = new List<MeasuredPoint>();
        private static List<Station> stationPoints = new List<Station>();
        private static List<CrossSection> crossSections = new List<CrossSection>();

        private static double markHeight = 0;
        private static double sectionDelta = 0;
        private static int startPointID = 0;

        //private static Section profile;
        private static Section profile = Section.None;

        private static bool dataReception = false;
        private static bool stationSetup = false;

        #endregion

        #region Public Properties

        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public static string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        public static Station Station
        {
            get
            {
                return station;
            }
            set
            {
                station = value;
            }
        }

        public static CrossSection CrossSection
        {
            get
            {
                return crossSection;
            }
            set
            {
                crossSection = value;
            }
        }

        public static List<MeasuredPoint> MeasurePoints
        {
            get
            {
                return measurePoints;
            }
            set
            {
                measurePoints = value;
            }
        }

        public static List<Station> StationPoints
        {
            get
            {
                return stationPoints;
            }
            set
            {
                stationPoints = value;
            }
        }

        public static List<CrossSection> CrossSections
        {
            get
            {
                return crossSections;
            }
            set
            {
                crossSections = value;
            }
        }

        public static double MarkHeight
        {
            get
            {
                return markHeight;
            }
            set
            {
                markHeight = value;
            }
        }
        
        public static double SectionDelta
        {
            get
            {
                return sectionDelta;
            }
            set
            {
                sectionDelta = value;
            }
        }

        public static int StartPointID
        {
            get
            {
                return startPointID;
            }
            set
            {
                startPointID = value;
            }
        }

        public static Section Profile
        {
            get
            {
                return profile;
            }
            set
            {
                profile = value;
            }
        }

        public static bool DataReception
        {
            get
            {
                return dataReception;
            }
            set
            {
                dataReception = value;
            }
        }

        public static bool StationSetup
        {
            get
            {
                return stationSetup;
            }
            set
            {
                stationSetup = value;
            }
        }

        #endregion

        #region Constructors

        public Project()
        {

        }

        #endregion

        #region Public Methods

        public static void Clear()
        {
            name = "";
            path = "";
            station = null;
            crossSection = null;
            measurePoints.Clear();
            stationPoints.Clear();
            crossSections.Clear();
            markHeight = 0;
            sectionDelta = 0;
            startPointID = 0;
            profile = Section.None;
            dataReception = false;
            stationSetup = false;
        }

        public static int GetMeasuredPoint(int id)
        {
            int count = 0;

            foreach (MeasuredPoint item in MeasurePoints)
            {
                if (id == item.ID)
                {
                    return (count);
                }
                count++;
            }
            return (-1);
        }

        #endregion

        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", name);
            info.AddValue("Station", station);
            info.AddValue("CrossSection", crossSection);
            info.AddValue("MeasurePoints", measurePoints);
            info.AddValue("StationPoints", stationPoints);
            info.AddValue("CrossSections", crossSections);
            info.AddValue("MarkHeight", markHeight);
            info.AddValue("SectionDelta", sectionDelta);
            info.AddValue("StartPointID", startPointID);
            info.AddValue("Profile", profile);
            info.AddValue("DataReception", dataReception);
            info.AddValue("StationSetup", stationSetup);
        }

        public Project(SerializationInfo info, StreamingContext context)
        {
            name = (string)info.GetValue("Name", typeof(string));
            station = (Station)info.GetValue("Station", typeof(Station));
            crossSection = (CrossSection)info.GetValue("CrossSection", typeof(CrossSection));
            measurePoints = (List<MeasuredPoint>)info.GetValue("MeasurePoints", typeof(List<MeasuredPoint>));
            stationPoints = (List<Station>)info.GetValue("StationPoints", typeof(List<Station>));
            crossSections = (List<CrossSection>)info.GetValue("CrossSections", typeof(List<CrossSection>));
            markHeight = (double)info.GetValue("MarkHeight", typeof(double));
            sectionDelta = (double)info.GetValue("SectionDelta", typeof(double));
            startPointID = (int)info.GetValue("StartPointID", typeof(int));
            profile = (Section)info.GetValue("Profile", typeof(Section));
            dataReception = (bool)info.GetValue("DataReception", typeof(bool));
            stationSetup = (bool)info.GetValue("StationSetup", typeof(bool));
        }

        #endregion
    }
}
