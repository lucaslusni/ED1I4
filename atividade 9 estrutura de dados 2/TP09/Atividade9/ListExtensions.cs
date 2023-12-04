using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9
{
    public static class ListExtensions
    {
        public static T Current<T> (this Queue<T> queue) where T : class
        {
            if (queue.Count() <= 0)
                return null;

            foreach (var entidade in queue)
            {
                return entidade;
            }

            return null;
        }
    }
}
