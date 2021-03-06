﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Af = Accord.Imaging.Filters;

namespace Aviary.Macaw.Filters.Dither
{
    public class Sierra : Filter
    {

        #region members

        protected int threshold = 4;

        #endregion

        #region constructors

        public Sierra() : base()
        {
            SetFilter();
        }

        public Sierra(int threshold) : base()
        {
            this.threshold = threshold;
            SetFilter();
        }

        public Sierra(Sierra filter) : base(filter)
        {
            this.threshold = filter.threshold;
            SetFilter();
        }

        #endregion

        #region properties

        public virtual int Threshold
        {
            get { return threshold; }
            set
            {
                threshold = value;
                SetFilter();
            }
        }

        #endregion

        #region methods

        private void SetFilter()
        {
            ImageType = ImageTypes.GrayscaleBT709;
            Af.SierraDithering newFilter = new Af.SierraDithering();
            newFilter.ThresholdValue = (byte)threshold;
            imageFilter = newFilter;
        }

        #endregion

        #region override

        public override string ToString()
        {
            return "Filter: Dither Sierra";
        }

        #endregion

    }
}