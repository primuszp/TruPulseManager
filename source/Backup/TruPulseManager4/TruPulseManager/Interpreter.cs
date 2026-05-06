using System;

namespace TruPulseManager
{
    public class Interpreter
    {
        public delegate void HVReceivedEventHandler(HVMessage hv);
        public event HVReceivedEventHandler HVReceived;

        public delegate void TruPulseReceivedEventHandler(string sentence);
        public event TruPulseReceivedEventHandler TruPulseReceived;


        // Processes information from the TruPulse receiver
        public bool Parse(string sentence)
        {
            if (sentence.Contains("$PLTIT"))
            {
                // Discard the sentence if its checksum does not match our calculated checksum
                if (!IsValid(sentence))
                {
                    return (false);
                }
            }
            else
            {
                ParseTruPulse(sentence);
                return (true);
            }

            // Look at the second word to decide where to go next
            switch (GetWords(sentence)[0])
            {
                case "$PLTIT":
                    {
                        switch (GetWords(sentence)[1])
                        {
                            case "HV":
                                return ParseHV(sentence);
                            default:
                                return false;
                        }
                    }
                default:
                    return false; // Indicate that the sentence was not recognized
            }
        }

        //Interprets a HV message
        public bool ParseHV(string sentence)
        {
            if (HVReceived != null)
            {
                HVReceived(new HVMessage(sentence));
                return (true);
            }
            return (false);
        }

        //Interprets a TruPulse message
        public bool ParseTruPulse(string sentence)
        {
            if (TruPulseReceived != null)
            {
                TruPulseReceived(sentence);
                return (true);
            }
            return (false);
        }

        //Divides a sentence into individual words
        public string[] GetWords(string sentence)
        {
            //strip off the final * + checksum
            sentence = sentence.Substring(0, sentence.IndexOf("*"));
            //now split it up
            return sentence.Split(',');
        }

        //Calculates the checksum for a sentence
        private static string getChecksum(string TruPulseSentence)
        {
            //Start with first Item
            int checksum = Convert.ToByte(TruPulseSentence[TruPulseSentence.IndexOf('$') + 1]);
            //Loop through all chars to get a checksum
            for (int i = TruPulseSentence.IndexOf('$') + 2; i < TruPulseSentence.IndexOf('*'); i++)
            {
                //No. XOR the checksum with this character's value
                checksum ^= Convert.ToByte(TruPulseSentence[i]);
            }
            //Return the checksum formatted as a two-character hexadecimal
            return checksum.ToString("X2");
        }

        //Returns true if a sentence's checksum matches the calculated checksum
        public bool IsValid(string TruPulseSentence)
        {
            //Compare the characters after the asterisk to the calculation
            return TruPulseSentence.Substring(TruPulseSentence.IndexOf("*") + 1) == getChecksum(TruPulseSentence);
        }
    }
}
