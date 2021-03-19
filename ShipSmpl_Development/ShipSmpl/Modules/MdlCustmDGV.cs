using Bunifu.UI.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShipSmpl
{
    static class MdlCustmDGV
    {
        public static void MergeEqualCells(DataGridViewCellPaintingEventArgs e, BunifuDataGridView dataGridView)
        {
            var fontStyle = new Font("Microsoft Sans Serif", 9f);

            // Units  with the same value

            // If e.RowIndex <> -1 Then

            // Using gridBrush As Brush = New SolidBrush(dataGridView.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

            // Using gridLinePen As Pen = New Pen(gridBrush)
            // ' Clear cell
            // e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

            // ' Draw line (bottom border and right border of current cell)
            // 'If next row cell has different content, only draw bottom border line of current cell
            // If (e.RowIndex < dataGridView.Rows.Count - 2 AndAlso dataGridView.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString()) Or
            // dataGridView.Rows.Count = e.RowIndex + 1 Then
            // e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
            // End If

            // ' Draw right border line of current cell
            // e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

            // ' draw/fill content in current cell, and fill only one cell of multiple same cells
            // If Not e.Value Is Nothing Then
            // If e.RowIndex > 0 AndAlso dataGridView.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
            // Else
            // e.Graphics.DrawString(CType(e.Value, String), fontStyle, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
            // End If
            // End If

            // e.Handled = True
            // End Using
            // End Using
            // End If
        }

        private static void CompareDelete(string strTagNumb, string strAtual, DataView dt, string columnName)
        {
            foreach (DataRowView row in dt)
            {
                if (row.Row["OrderId"].ToString().Equals(strAtual))
                {
                    string nl = Environment.NewLine;
                    row.Row[columnName] += string.Concat(nl, strTagNumb);
                    return;
                }
            }
        }
    }
}