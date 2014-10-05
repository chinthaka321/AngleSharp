﻿namespace AngleSharp.DOM.Css.Properties
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Information:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/text-decoration-line
    /// </summary>
    sealed class CSSTextDecorationLineProperty : CSSProperty, ICssTextDecorationLineProperty
    {
        #region Fields

        List<TextDecorationLine> _line;

        #endregion

        #region ctor

        internal CSSTextDecorationLineProperty()
            : base(PropertyNames.TextDecorationLine)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the enumeration over all selected styles
        /// for text decoration lines.
        /// </summary>
        public IEnumerable<TextDecorationLine> Line
        {
            get { return _line; }
        }

        #endregion

        #region Methods

        protected override void Reset()
        {
            if (_line == null)
                _line = new List<TextDecorationLine>();
            else
                _line.Clear();
        }

        /// <summary>
        /// Determines if the given value represents a valid state of this property.
        /// </summary>
        /// <param name="value">The state that should be used.</param>
        /// <returns>True if the state is valid, otherwise false.</returns>
        protected override Boolean IsValid(CSSValue value)
        {
            var mode = value.ToDecorationLine();

            if (mode.HasValue)
            {
                _line.Clear();
                _line.Add(mode.Value);
            }
            else if (value.Is(Keywords.None))
            {
                _line.Clear();
            }
            else if (value is CSSValueList)
            {
                var values = (CSSValueList)value;
                var list = new List<TextDecorationLine>();

                foreach (var item in values)
                {
                    mode = item.ToDecorationLine();

                    if (mode == null)
                        return false;

                    list.Add(mode.Value);
                }

                _line = list;
            }
            else
                return false;

            return true;
        }

        #endregion
    }
}
