using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class Extensions
    {

        internal static IEnumerable<T> OuersWhere<T>(this IEnumerable<T> sourse, Func<T, bool> predicate)
        {
          
            foreach (T person in sourse)
            {
                if(predicate(person))
                {
                    yield return person;
                }
            }

        }
    }
}
