﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Af = Accord.Imaging.Filters;

namespace Aviary.Macaw.Filters.Edges
{
    public class Difference : Filter
    {

        #region members



        #endregion

        #region constructors

        public Difference() : base()
        {
            SetFilter();
        }

        public Difference(Difference filter) : base(filter)
        {
            SetFilter();
        }

        #endregion

        #region properties



        #endregion

        #region methods

        private void SetFilter()
        {
            ImageType = ImageTypes.GrayscaleBT709;
            Af.DifferenceEdgeDetector newFilter = new Af.DifferenceEdgeDetector();
            imageFilter = newFilter;
        }

        #endregion

        #region override

        public override string ToString()
        {
            return "Filter: Edges Difference";
        }

        #endregion

    }
}