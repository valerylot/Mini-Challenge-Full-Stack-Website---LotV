using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class MadLibServices : IMadLibServices
    {
        public string CreateMadLib(
            string madlib1,
            string madlib2,
            string madlib3,
            string madlib4,
            string madlib5,
            string madlib6,
            string madlib7,
            string madlib8,
            string madlib9,
            string madlib10)
        {
         return $"If you've ever met my {madlib1}, Snoopy, then you know he's not your average canine companion. Some kids might find it {madlib2} that their beagle has such a/an {madlib3} imagination, but not me! All I'ev ever wanted was a normal, {madlib4} dog. Why can't I have a/an {madlib5} just like everyone else? Instead, I've got a part-time pet, part-time World War I pilot, part-time {madlib6}, and a full-time pain! {madlib7} grief! Sometimes he looks at me like I'm chopped {madlib8} - good for nothing except bringing his dinner out to the {madlib9}. Still, it sure is nice to have someone with really {madlib10} ears around.";

        } 
    }
}