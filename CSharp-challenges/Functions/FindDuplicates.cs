using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_challenges.Functions
{
    public class FindDuplicates
    {
        public List<string> FindDuplicateCharacters(List<string> input) {

            return input.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();
        }
    }
}
