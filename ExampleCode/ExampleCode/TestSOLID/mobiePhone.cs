using System;
using System.Collections.Generic;


namespace ExampleCode.TestSOLID
{
    // Enum đại diện cho các tính năng của điện thoại
    public enum FeatureType
    {
        Call,
        Camera,
        Music,
        Internet
    }

    // Interface dùng chung cho các tính năng
    public interface IFeature
    {
        void Use();
    }

    // Tính năng gọi điện
    public class CallFeature : IFeature
    {
        public void Use()
        {
            Console.WriteLine("Making a call...");
        }
    }

    // Tính năng chụp ảnh
    public class CameraFeature : IFeature
    {
        public void Use()
        {
            Console.WriteLine("Taking a photo...");
        }
    }

    // Tính năng nghe nhạc
    public class MusicFeature : IFeature
    {
        public void Use()
        {
            Console.WriteLine("Playing music...");
        }
    }

    // Tính năng truy cập Internet
    public class InternetFeature : IFeature
    {
        public void Use()
        {
            Console.WriteLine("Browsing the internet...");
        }
    }

    // MobilePhone dùng composition để chứa các tính năng
    public class MobilePhone
    {
        private Dictionary<FeatureType, IFeature> featureDict = new Dictionary<FeatureType, IFeature>();
        private IFeature currentFeature;

        public void AddFeature(FeatureType featureType)
        {
            if (featureDict.ContainsKey(featureType))
                return;

            IFeature feature = null;
            switch (featureType)
            {
                case FeatureType.Call:
                    feature = new CallFeature();
                    break;
                case FeatureType.Camera:
                    feature = new CameraFeature();
                    break;
                case FeatureType.Music:
                    feature = new MusicFeature();
                    break;
                case FeatureType.Internet:
                    feature = new InternetFeature();
                    break;
            }

            if (feature != null)
                featureDict.Add(featureType, feature);
        }

        public void SwitchFeature(FeatureType featureType)
        {
            if (featureDict.TryGetValue(featureType, out var feature))
            {
                currentFeature = feature;
            }
            else
            {
                Console.WriteLine($"Feature {featureType} not available.");
            }
        }

        public void UseFeature()
        {
            if (currentFeature != null)
            {
                currentFeature.Use();
            }
            else
            {
                Console.WriteLine("No feature selected.");
            }
        }
    }
}