﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeoTabControlLibrary
{
    public class DataGridViewEditorButtonColumn : DataGridViewButtonColumn
    {
        #region Constructor

        public DataGridViewEditorButtonColumn()
        {
            this.CellTemplate = new DataGridViewEditorButtonCell();
        }

        #endregion

        #region Destructor

        ~DataGridViewEditorButtonColumn()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    public class DataGridViewEditorButtonCell : DataGridViewButtonCell
    {
        #region Static Members Of The Class

        private static DataGridViewEditorButtonColumn editorButtonColumn;

        #endregion

        #region Constructor

        public DataGridViewEditorButtonCell() { ; }

        #endregion

        #region Destructor

        ~DataGridViewEditorButtonCell()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Property

        /// <summary>
        /// Determines whether this button cell is support renderer editing or not.
        /// </summary>
        public bool Enabled { get; set; }

        public DataGridViewEditorButtonColumn EditorButtonColumn
        {
            get
            {
                if (editorButtonColumn == null)
                {
                    // Instantiate a EditorButtonColumn instance from the base.OwningColumn property.
                    editorButtonColumn = base.OwningColumn as DataGridViewEditorButtonColumn;
                }
                return editorButtonColumn;
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                // The default value is.
                return "...";
            }
        }

        #endregion

        #region Override Methods

        // Override the Clone method so that the Enabled property is copied. 
        public override object Clone()
        {
            DataGridViewEditorButtonCell cell =
                (DataGridViewEditorButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        protected override void Paint(Graphics graphics,
        Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
        DataGridViewElementStates elementState, object value,
        object formattedValue, string errorText,
        DataGridViewCellStyle cellStyle,
        DataGridViewAdvancedBorderStyle advancedBorderStyle,
        DataGridViewPaintParts paintParts)
        {
            // The button cell is disabled, so paint the border,   
            // background, and disabled button for the cell. 
            if (!Enabled)
            {
                // Draw the cell background, if specified. 
                if ((paintParts & DataGridViewPaintParts.Background) ==
                    DataGridViewPaintParts.Background)
                {
                    SolidBrush cellBackground =
                        new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }

                // Draw the cell borders, if specified. 
                if ((paintParts & DataGridViewPaintParts.Border) ==
                    DataGridViewPaintParts.Border)
                {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                        advancedBorderStyle);
                }

                // Calculate the area in which to draw the button.
                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment =
                    this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                // Draw the disabled button.                
                ButtonRenderer.DrawButton(graphics, buttonArea,
                    System.Windows.Forms.VisualStyles.PushButtonState.Disabled);

                // Draw the disabled button text.  
                if (this.FormattedValue is String)
                {
                    TextRenderer.DrawText(graphics,
                        (string)this.FormattedValue,
                        this.DataGridView.Font,
                        buttonArea, SystemColors.GrayText);
                }
            }
            else
            {
                // The button cell is enabled, so let the base class  
                // handle the painting. 
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    elementState, value, formattedValue, errorText,
                    cellStyle, advancedBorderStyle, paintParts);
            }
        }

        #endregion
    }
}