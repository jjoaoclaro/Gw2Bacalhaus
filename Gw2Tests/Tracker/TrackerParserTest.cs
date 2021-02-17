using Gw2.Models.Tracker;
using Gw2.Tracker;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2Tests.Tracker
{
    class TrackerParserTest
    {

        TrackerParser parser = new TrackerParser();

        [Test]
        public void TestParserWithValidInformation()
        {
            var result = parser.ParseTrackerSession(validTestInfo);

            Assert.That(result, Is.EqualTo(validTrackerItems));
        }


        private string validTestInfo = "ID,Rarity,Type,Name,Amount" + System.Environment.NewLine +
"\"1\",\"\",\"Currency\",\"Coin\",\"176\" " + System.Environment.NewLine +
"\"2\",\"\",\"Currency\",\"Karma\",\"17278\" " + System.Environment.NewLine +
"\"19\",\"\",\"Currency\",\"Airship Part\",\"6\" ";

        private List<TrackerItem> validTrackerItems = new List<TrackerItem> {
            new TrackerItem
        {
                Id = 1,
                Rarity = "",
                Type = "Currency",
                Name = "Coin",
                Amount = 176
        },new TrackerItem
        {
                Id = 2,
                Rarity = "",
                Type = "Currency",
                Name = "Karma",
                Amount = 17278
        },new TrackerItem
        {
                Id = 19,
                Rarity = "",
                Type = "Currency",
                Name = "Airship Part",
                Amount = 6
        } };
    }
}
