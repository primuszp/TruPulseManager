using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TruPulseManager
{
    [Serializable()]
    public class CrossSection : ISerializable
    {
        #region Private Member Variables

        private double section;
        private List<int> indices = new List<int>();

        #endregion;

        #region Public Properties

        public double Section
        {
            get
            {
                return section;
            }
            set
            {
                section = value;
            }
        }

        public List<int> Indices
        {
            get
            {
                return indices;
            }
            set
            {
                indices = value;
            }
        }

        #endregion

        #region Constructors

        public CrossSection()
        {
        }

        public CrossSection(CrossSection crossSection)
        {
            this.section = crossSection.Section;
            this.indices = new List<int>(crossSection.Indices);
        }

        public CrossSection(double section, List<int> indices)
        {
            this.section = section;
            this.indices = new List<int>(indices);
        }

        #endregion

        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Section", section);
            info.AddValue("Indices", indices);
        }

        public CrossSection(SerializationInfo info, StreamingContext context)
        {
            section = (double)info.GetValue("Section", typeof(double));
            indices = (List<int>)info.GetValue("Indices", typeof(List<int>));
        }

        #endregion
    }
}
