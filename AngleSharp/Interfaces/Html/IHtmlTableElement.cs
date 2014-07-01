﻿namespace AngleSharp.DOM.Html
{
    using System;

    /// <summary>
    /// Represents the table HTML element.
    /// </summary>
    [DomName("HTMLTableElement")]
    public interface IHtmlTableElement : IHtmlElement
    {
        /// <summary>
        /// Gets or sets the assigned caption element.
        /// </summary>
        [DomName("caption")]
        IHtmlTableCaptionElement Caption { get; set; }

        /// <summary>
        /// Creates a new table caption object or returns the existing one.
        /// </summary>
        /// <returns>A caption element.</returns>
        [DomName("createCaption")]
        IHtmlElement CreateCaption();

        /// <summary>
        /// Deletes the table caption, if one exists.
        /// </summary>
        [DomName("deleteCaption")]
        void DeleteCaption();

        /// <summary>
        /// Gets or sets the assigned head section.
        /// </summary>
        [DomName("tHead")]
        IHtmlTableSectionElement THead { get; set; }

        /// <summary>
        /// Creates a new table header section or returns the existing one.
        /// </summary>
        /// <returns>A table header element.</returns>
        [DomName("createTHead")]
        IHtmlElement CreateTHead();

        /// <summary>
        /// Deletes the header from the table, if one exists. 
        /// </summary> 
        [DomName("deleteTHead")]
        void DeleteTHead();

        /// <summary>
        /// Gets or sets the assigned foot section.
        /// </summary>
        [DomName("tFoot")]
        IHtmlTableSectionElement TFoot { get; set; }

        /// <summary>
        /// Creates a table footer section or returns an existing one.
        /// </summary>
        /// <returns>A footer element.</returns>
        [DomName("createTFoot")]
        IHtmlElement CreateTFoot();

        /// <summary>
        /// Deletes the footer from the table, if one exists.
        /// </summary>
        [DomName("deleteTFoot")]
        void DeleteTFoot();

        /// <summary>
        /// Gets the assigned body sections.
        /// </summary>
        [DomName("tBodies")]
        IHtmlCollection TBodies { get; }

        /// <summary>
        /// Creates a new table body section.
        /// </summary>
        /// <returns>A body element.</returns>
        [DomName("createTBody")]
        IHtmlElement CreateTBody();

        /// <summary>
        /// Gets the assigned table rows.
        /// </summary>
        [DomName("rows")]
        IHtmlCollection Rows { get; }

        /// <summary>
        /// Inserts a new empty row in the table. The new row is inserted immediately before
        /// and in the same section as the current indexth row in the table. If index is -1
        /// or equal to the number of rows, the new row is appended. In addition, when the
        /// table is empty the row is inserted into a TBODY which is created and inserted
        /// into the table.
        /// </summary>
        /// <param name="index">
        /// The row number where to insert a new row. This index starts from 0 and is relative
        /// to the logical order (not document order) of all the rows contained inside the table.
        /// </param>
        /// <returns>The inserted table row.</returns>
        [DomName("insertRow")]
        IHtmlElement InsertRow(Int32 index = -1);

        /// <summary>
        /// Deletes a table row.
        /// </summary>
        /// <param name="index">
        /// The index of the row to be deleted. This index starts from 0 and is relative to the
        /// logical order (not document order) of all the rows contained inside the table. If the
        /// index is -1 the last row in the table is deleted.
        /// </param>
        [DomName("deleteRow")]
        void DeleteRow(Int32 index);

        /// <summary>
        /// Gets or sets the border attribute.
        /// </summary>
        [DomName("border")]
        UInt32 Border { get; set; }
    }
}
