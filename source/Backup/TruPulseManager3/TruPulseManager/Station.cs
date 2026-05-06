using System;
using System.Runtime.Serialization;

namespace TruPulseManager
{
    [Serializable()]
    public class Station : ISerializable
    {
        #region Private Member Variables

        private Vector coordinates;
        private double height;
        private int id;
        private string code;

        #endregion

        #region Public Properties

        public Vector Coordinates
        {
            get
            {
                return coordinates;
            }
            set
            {
                coordinates = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        #endregion

        #region Constructors

        public Station()
        {
            this.coordinates = new Vector();
            this.height = 1.7;
            this.code = "NULL";
            this.id = 0;
        }

        public Station(Vector coordinates, double height, string code, int id)
        {
            this.coordinates = coordinates;
            this.height = height;
            this.code = code;
            this.id = id;
        }

        #endregion

        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Coordinates", coordinates);
            info.AddValue("Height", height);
            info.AddValue("ID", id);
            info.AddValue("Code", code);
        }

        public Station(SerializationInfo info, StreamingContext context)
        {
            coordinates = (Vector)info.GetValue("Coordinates", typeof(Vector));
            height = (double)info.GetValue("Height", typeof(double));
            id = (int)info.GetValue("ID", typeof(int));
            code = (string)info.GetValue("Code", typeof(string));
        }

        #endregion
    }
}
