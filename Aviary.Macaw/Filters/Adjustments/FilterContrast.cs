﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Accord.Imaging.Filters;

namespace Aviary.Macaw.Filters
{
    public class FilterContrast : Filter
    {

        #region members

        protected int factor = 0;

        #endregion

        #region constructors

        public FilterContrast() : base()
        {
            SetFilter();
        }

        public FilterContrast(int factor) : base()
        {
            this.factor = factor;
            SetFilter();
        }

        public FilterContrast(FilterContrast filter) : base(filter)
        {
            this.factor = filter.factor;
            SetFilter();
        }

        #endregion

        #region properties

        public virtual int Factor
        {
            get { return factor; }
            set
            {
                factor = value;
                SetFilter();
            }
        }

        #endregion

        #region methods

        private void SetFilter()
        {
            ImageType = ImageTypes.Rgb32bpp;
            ContrastCorrection newFilter = new ContrastCorrection();
            newFilter.Factor = factor;
            imageFilter = newFilter;
        }

        #endregion

    }
}
