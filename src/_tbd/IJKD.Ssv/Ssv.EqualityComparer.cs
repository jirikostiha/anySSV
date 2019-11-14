namespace Wayout.Ssv
{
    using System;
    using System.Collections.Generic;

    public class SsvEqualityComparer : IEqualityComparer<Ssv>
    {
        public bool Equals(Ssv x, Ssv y)
        {
            if (x == null && y == null)
                return true;

            if (x == null || y == null )
                return false;

            if (x.Lines.Count != y.Lines.Count)
                return false;

            var index = 0;


            for (int i = 0; i < x.Lines.Count; i++)
            {
                var xline = x.Lines[i];
                var yline = y.Lines[i];

                if (x.Lines[i].GetType() != y.Lines[i].GetType())
                    return false;

                switch (xline)
                {
                    case Ssv.Line xl:
                        if (xl.Values.Count != (yline).Values.Count)
                            return false;
                        break;
                    //case Ssv.Comment TableNameLine xl:
                    //    var yDataline = yline as Ssv.DataLine;
                    //    if (xl.Name != (yline as Ssv.TableNameLine).Name)
                    //        return false;
                    //    break;

                }
            }


            return true;
        }

        public int GetHashCode(Ssv obj)
        {
            throw new NotImplementedException();
        }
    }
}
