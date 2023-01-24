using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assertion_Assistant.Dictionary
{
    internal class Advices
    {
        public string GiveAdvice()
        {
            Random random = new Random();
            int result = random.Next(0, 19);

            return AdviceForHealth[result];
        }

        List<string> AdviceForHealth = new List<string>()
        {
            "Practice gratitude by regularly reflecting on things you are thankful for.",
            "Make time for activities that bring you joy and relaxation.",
            "Prioritize self-care by getting enough sleep, eating healthy,\n and staying active.",
            "Connect with others through socializing, talking to friends or \nfamily, or joining a group or community.",
            "Practice mindfulness by staying present in the moment and \nfocusing on your breathing.",
            "Challenge negative thoughts and reframe them in a\n more positive light.",
            "Set realistic and achievable goals for yourself.",
            "Take breaks and make time for leisure\nctivities to reduce stress.",
            "Practice good sleep hygiene, including setting a regular \nschedule and avoiding screens before bed.",
            "Learn and practice relaxation techniques such as yoga, \nmeditation, or deep breathing exercises.",
            "Seek professional help if needed, such as talking to a \ntherapist or counselor.",
            "Keep a journal to reflect on your thoughts \nand feelings.",
            "Try to maintain a positive outlook and focus \non the good in your life.",
            "Practice self-compassion by being kind and\n understanding to yourself.",
            "Seek out new experiences and try new things\n to keep your mind stimulated.",
            "Be mindful of your thoughts and try to avoid\n rumination.",
            "Learn to set boundaries and\n prioritize self-care.",
            "Take on a hobby, such as painting,\n reading, or gardening, to relax and unwind.",
            "Make sure to find time to exercise and\n stay active.",
            "Surround yourself with positive and \nsupportive people.",
        };
    }
}
