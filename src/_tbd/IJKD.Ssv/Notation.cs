namespace Wayout.Ssv
{
    using System;

    public class Notation
    {
        public static class Default
        {
            public const string ValueDelimiter = ";";
            public const string TableStartMark = "[[[";
            public const string TableEndMak = "]]]";
            public const string HeaderStartMark = "[[";
            public const string HeaderEndMark = "]]";
            public const string RowExcludeMark = "#";
            public const string RowBlockExcludeStartMark = "#>";
            public const string RowBlockExcludeEndMark = "<#";
            public const string ColumnExcludeMark = "$";
            public const string ColumnBlockExcludeStartMark = "$*"; //"$V"
            public const string ColumnBlockExcludeEndMark = "*$";   //"$^"
        }

        public Notation()
        {
            ValueDelimiter = Default.ValueDelimiter;
            LineDelimiter = Environment.NewLine;
            TableStartMark = Default.TableStartMark;
            TableEndMak = Default.TableEndMak;
            HeaderStartMark = Default.HeaderStartMark;
            HeaderEndMark = Default.HeaderEndMark;
            RowExcludeMark = Default.RowExcludeMark;
            RowBlockExcludeStartMark = Default.RowBlockExcludeStartMark;
            RowBlockExcludeEndMark = Default.RowBlockExcludeEndMark;
            ColumnExcludeMark = Default.ColumnExcludeMark;
            ColumnBlockExcludeStartMark = Default.ColumnBlockExcludeStartMark;
            ColumnBlockExcludeEndMark = Default.ColumnBlockExcludeEndMark;
        }

        /// <summary>
        /// Separator of an values.
        /// </summary>
        public string ValueDelimiter { get; set; }

        public string LineDelimiter { get; set; }

        public string TableStartMark { get; set; }
        public string TableEndMak { get; set; }

        public string HeaderStartMark { get; set; }
        public string HeaderEndMark { get; set; }

        /// <summary>
        /// Tag of a data row excluded from processing.
        /// </summary>
        public string RowExcludeMark { get; set; }

        /// <summary>
        /// Tag of a excluded column or cell.
        /// </summary>
        public string ColumnExcludeMark { get; set; }

        /// <summary>
        /// Tag of a start block comment.
        /// </summary>
        public string RowBlockExcludeStartMark { get; set; }

        /// <summary>
        /// Tag of a start block comment.
        /// </summary>
        public string RowBlockExcludeEndMark { get; set; }

        public string ColumnBlockExcludeStartMark { get; set; }

        public string ColumnBlockExcludeEndMark { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
