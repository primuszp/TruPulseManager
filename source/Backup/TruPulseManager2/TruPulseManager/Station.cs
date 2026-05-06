
namespace TruPulseManager
{
    public class Station
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
        }

        public Station(Vector coordinates, double height, string code, int id)
        {
            this.coordinates = coordinates;
            this.height = height;
            this.code = code;
            this.id = id;
        }

        #endregion
    }
}
