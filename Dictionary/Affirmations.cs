using Assertion_Assistant.JsonData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assertion_Assistant.Dictionary
{
    internal class Affirmations
    {

        public string GiveAffirmation()
        {
            // DeSearilization
            string input = File.ReadAllText("userData\\userProfile.json");
            var profile = JsonConvert.DeserializeObject<userProfile>(input);

            Random rand = new Random();
            int result = rand.Next(0, 9);

            switch (profile.Goal)
            {
                case "Uplifting the mood":
                    return GoodMoodAfir[result];
                case "Motivation to work":
                    return WorkAfir[result];
                case "Support in difficult situations":
                    return DifSitAfir[result];
                case "Solving health problems":
                    return HealthAfir[result];
                case "Development motivation":
                    return DevMotivationAfir[result];
                case "Motivation to go to your dream":
                    return DreamAfir[result];
                default: return "Error";
            }
        }

        List<string> WorkAfir = new List<string>()
        {
            "I am capable and confident in my abilities to complete my work.",
            "I choose to focus on my goals and take action towards achieving them.",
            "I am motivated and inspired to put in the effort to reach success.",
            "I trust in my ability to overcome any obstacle and achieve my aspirations.",
            "I am grateful for the opportunities and resources available to me to excel in my work.",
            "I am proud of my accomplishments and excited for the progress yet to come.",
            "I am determined to succeed and will not let setbacks discourage me.",
            "I believe in myself and my ability to achieve great things.",
            "I am committed to working hard and making my dreams a reality.",
            "I am filled with energy and motivation to tackle my work with enthusiasm.",
        };

        List<string> HealthAfir = new List<string>()
        {
            "I am committed to making healthy choices for my body and mind.",
            "I am grateful for my strong and capable body, and I will treat it with kindness and respect.",
            "I trust in my ability to overcome any obstacle and achieve my health goals.",
            "I am proud of myself for each step I take towards a healthier lifestyle.",
            "I am motivated to take care of my body, and I will not let setbacks discourage me.",
            "I am capable and confident in my ability to make healthy choices.",
            "I believe in myself and my ability to lead a healthy and fulfilling life.",
            "I choose to surround myself with positivity and support on my journey to wellness.",
            "I am excited to see the progress and benefits of my healthy habits.",
            "I am filled with energy and motivation to take care of my body and mind.",
        };

        List<string> GoodMoodAfir = new List<string>()
        {
            "I choose to focus on the present moment and let go of negative thoughts.",
            "I am surrounded by love and positivity.",
            "I am grateful for all the good in my life.",
            "I trust in my ability to overcome any challenges and find happiness.",
            "I am strong and capable of handling any situation.",
            "I am filled with joy and contentment.",
            "I choose to release any negative emotions and embrace positivity.",
            "I am surrounded by beauty and abundance.",
            "I am grateful for the opportunities and experiences that bring me happiness.",
            "I am worthy of love, joy and happiness.",
        };

        List<string> DevMotivationAfir = new List<string>()
        {
            "I am committed to personal growth and development.",
            "I am open to learning new things and expanding my knowledge.",
            "I trust in my ability to achieve my goals and reach my full potential.",
            "I am motivated to work hard and improve myself.",
            "I am proud of my accomplishments and excited for the progress yet to come.",
            "I am determined to succeed and will not let setbacks discourage me.",
            "I believe in myself and my ability to make positive changes.",
            "I am surrounded by opportunities for growth and development.",
            "I am excited to see the progress and benefits of my personal development journey.",
            "I am filled with energy and motivation to take action towards my goals.",
        };

        List<string> DifSitAfir = new List<string>()
        {
            "I am surrounded by a support system of loving and caring people.",
            "I trust in my ability to overcome any obstacle and handle any situation.",
            "I am grateful for the guidance and wisdom of those who support me.",
            "I am strong and capable of handling difficult situations.",
            "I am surrounded by positivity and love, even in difficult times.",
            "I choose to release any negative emotions and embrace positivity.",
            "I am grateful for the opportunities to learn and grow from difficult situations.",
            "I am confident in my ability to find solutions and overcome challenges.",
            "I believe in the power of support and know that I am never alone.",
            "I am filled with hope and determination to come out stronger from any difficult situation.",
        };

        List<string> DreamAfir = new List<string>()
        {
            "I am committed to making my dreams a reality.",
            "I trust in my abilities and the power of hard work to achieve my goals.",
            "I am motivated and inspired to take action towards my dreams.",
            "I am grateful for the opportunities and resources available to me to excel in my pursuits.",
            "I am proud of my accomplishments and excited for the progress yet to come.",
            "I am determined to succeed and will not let setbacks discourage me.",
            "I believe in myself and my ability to make my dreams come true.",
            "I am committed to working hard and making my aspirations a reality.",
            "I am filled with energy and motivation to pursue my dreams with enthusiasm.",
            "I am surrounded by positivity and support on my journey to fulfilling my dreams.",
        };
    }
}
