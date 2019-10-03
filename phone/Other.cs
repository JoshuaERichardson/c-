using System;

namespace phone
{
    public abstract class Phone
        {
            private string _versionNumber {get; set;}
            private int _batteryPercentage {get; set;}
            private string _carrier {get; set;}
            private string _ringTone {get; set;}
            public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
            {
                _versionNumber = versionNumber;
                _batteryPercentage = batteryPercentage;
                _carrier = carrier;
                _ringTone = ringTone;
            }
            public abstract void DisplayInfo();
        }
        public interface IRingable
        {
            public string Ring();
            public string Unlock();
        }
        public class Nokia : Phone, IRingable
        {
            public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}
            public string Ring()
            {
                string ringSoundsLike = "Buuuurrrrrriiiiiinnnnnnggggg!!!";
                return ringSoundsLike;
            }
            public string Unlock()
            {
                string unlockFeature = "kachinggggg   <--------- phone unlocking sound with finger sensor thingamabob";
                return unlockFeature;
            }
            public override void DisplayInfo()
            {
                System.Console.WriteLine($"Phone is version number {}");
                
            }
        }
        public class Galaxy : Phone, IRingable
        {
            public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone){}
            public string Ring()
            {
                string ringSoundsLike = "DingALingALingALing";
                return ringSoundsLike;
            }
            public string Unlock()
            {
                string unlockFeature = "your password of 'P@ssword1' worked!";
                return unlockFeature;
            }
            public override void DisplayInfo()
            {
                // stuff and things
            }
        }
}