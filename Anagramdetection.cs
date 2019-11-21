//-----------------------------------------------------------------------
// <copyright file="Anagramdetection.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------

namespace Algorithm_Programs
{
    using System;
    /// <summary>
    /// Anagram detection string type.
    /// </summary>
    class Anagramdetection
    {
        Utility utility = new Utility();
        public void anagramDetection()
        {
            Console.WriteLine("Enter your string need to check");
            String str = Console.ReadLine();
            utility.AnagramDetection(str);
        }
    }
}
