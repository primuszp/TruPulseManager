using System;
using System.Collections.Generic;
using System.Text;

namespace TruPulseManager
{
    public class CrossSection
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
    }
}
