using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JosephusProblem.Tests
{
    public class CheckSurvivorJosephus
    {
        [Theory]
        [InlineData(10,3,4)]
        [InlineData(7, 2, 7)]
        public void the_person_left_behind_matches_expected(int numberOfPeople, int killingInterval, int survingMember)
        {
            var situation = new LastPersonStandingClass();
            var lps = situation.LastPersonStanding(numberOfPeople, killingInterval);
            Assert.Equal(survingMember, lps);
        }
    }
}
