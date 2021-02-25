using Midi;
using System;

namespace TOSPlay
{
    class Program
    {
        private static void Main(string[] args)
        {
            MIDIPlayback.PrintDevices();
            Console.Write("Dev#: ");
            OutputDevice outputDevice = OutputDevice.InstalledDevices[int.Parse(Console.ReadLine())];
            outputDevice.Open();

            Instruction[] tos = TOSSongParser.ParseInstructions(Songs.templeOSTheme, 50);
            Instruction[] talons = TOSSongParser.ParseInstructions(Songs.talonsTheme, 60);

            while (true)
            {
                foreach (Instruction instruction in tos)
                {
                    Console.WriteLine($"{instruction.note}{instruction.octave}, {instruction.duration}ms, {instruction.frequency}Hz");
                    MIDIPlayback.PlayInstruction(instruction, outputDevice);
                }
            }
        }
    }
}
