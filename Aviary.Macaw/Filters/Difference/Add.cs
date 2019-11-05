﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Af = Accord.Imaging.Filters;

namespace Aviary.Macaw.Filters.Difference
{
    public class Add : Filter
    {

        #region members

        protected Bitmap overlay = new Bitmap(100, 100);

        #endregion

        #region constructors

        public Add() : base()
        {
            SetFilter();
        }

        public Add(Bitmap overlay) : base()
        {
            this.Overlay = overlay;

            SetFilter();
        }

        public Add(Add filter) : base(filter)
        {
            this.Overlay = filter.overlay;

            SetFilter();
        }

        #endregion

        #region properties

        public virtual Bitmap Overlay
        {
            get { return (Bitmap)overlay.Clone(); }
            set
            {
                overlay = value.ToAccordBitmap(ImageTypes.Rgb24bpp);
                SetFilter();
            }
        }

        #endregion

        #region methods

        private void SetFilter()
        {
            ImageType = ImageTypes.Rgb24bpp;
            Af.Add newFilter = new Af.Add();
            newFilter.OverlayImage = Overlay;
            imageFilter = newFilter;
        }

        #endregion

    }
}