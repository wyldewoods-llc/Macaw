﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Accord.Imaging.Filters;

namespace Aviary.Macaw.Filters
{
    public class Kuwahara : Filter
    {

        #region members

        protected int size = 0;

        #endregion

        #region constructors

        public Kuwahara() : base()
        {
            SetFilter();
        }

        public Kuwahara(int size) : base()
        {
            this.size = size;
            SetFilter();
        }

        public Kuwahara(Kuwahara filter) : base(filter)
        {
            this.size = filter.size;
            SetFilter();
        }

        #endregion

        #region properties

        public virtual int Size
        {
            get { return size; }
            set
            {
                size = value;
                SetFilter();
            }
        }

        #endregion

        #region methods

        private void SetFilter()
        {
            ImageType = ImageTypes.Rgb32bpp;
            Accord.Imaging.Filters.Kuwahara newFilter = new Accord.Imaging.Filters.Kuwahara();
            newFilter.Size = size;
            imageFilter = newFilter;
        }

        #endregion

    }
}