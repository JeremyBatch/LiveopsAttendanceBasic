using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveopsAttendanceBasic
{
    class AnalyzerProcessor
    {
        public List<string> GetStringArrayPresent(string textBox)
        {
            string[] textToArray = textBox.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> agentsScheduled = new List<string>();
            List<string> agentsJoined = new List<string>();
            foreach (string line in textToArray)
            {
                agentsScheduled.Add(line);
            }
            for (int i = 0; i < agentsScheduled.Count; i += 2)
            {
                string joined = string.Concat(agentsScheduled[i] + "\t" + agentsScheduled[i + 1]);
                agentsJoined.Add(joined);
            }
            return agentsJoined;
        }
        public List<string> GetStringArray(string textBox)
        {
            string[] textToArray = textBox.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> agentsScheduled = new List<string>();
            foreach (string line in textToArray)
            {
                agentsScheduled.Add(line);
            }
            return agentsScheduled;
        }

        public List<string> IsAbsent(List<string> agentScheduled, List<string> agentPresent)
        {


            List<string> isAbsent = new List<string>();
            foreach (string scheduled in agentScheduled)
            {
                bool isPresent = false;
                foreach (string present in agentPresent)
                {

                    if (scheduled.ToLower() == present.ToLower())
                    {
                        isPresent = true;
                        break;
                    }
                }

                if (isPresent == false)
                {
                    isAbsent.Add(scheduled);
                }
            }
            return isAbsent;
        }

        public string DisplayAgents(List<string> isAbsent)
        {
            var absent = string.Join("\r\n", isAbsent);
            return absent;
        }


    }
}
