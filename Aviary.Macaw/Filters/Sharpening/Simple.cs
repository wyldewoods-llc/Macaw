﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Af= Accord.Imaging.Filters;

namespace Aviary.Macaw.Filters.Sharpening
{
    public class Simple : Filter
    {

        #region members

        protected int divisor = 1;
        protected int threshold = 0;

        #endregion

        #region constructors

        public Simple() : base()
        {
            SetFilter();
        }

        public Simple(int divisor, int threshold) : base()
        {
            this.divisor = divisor;
            this.threshold = threshold;
            SetFilter();
        }

        public Simple(Simple filter) : base(filter)
        {
            this.divisor = filter.divisor;
            this.threshold = filter.threshold;
            SetFilter();
        }

        #endregion

        #region properties

        public virtual int Divisor
        {
            get { return divisor; }
            set
            {
                divisor = value;
                SetFilter();
            }
        }

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
            ImageType = ImageTypes.Rgb32bpp;
            Af.Sharpen newFilter = new Af.Sharpen();
            newFilter.Divisor = divisor;
            newFilter.Threshold = threshold;
            imageFilter = newFilter;
        }

        #endregion

        #region override

        public override string ToString()
        {
            return "Filter: Simple Sharpening";
        }

        #endregion

    }
}
