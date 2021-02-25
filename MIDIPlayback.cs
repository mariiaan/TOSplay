using Midi;
using System;
using System.Threading;

namespace TOSPlay
{
    public class MIDIPlayback
    {
        public static void PrintDevices()
        {
            int i = 0;
            foreach (OutputDevice devIt in OutputDevice.InstalledDevices)
            {
                Console.WriteLine($"{i++}: {devIt.Name}");
            }
        }

        public static void PlayInstruction(Instruction instruction, OutputDevice outputDevice)
        {
            switch (instruction.octave)
            {
                case 0:
                    {
                        switch (instruction.note)
                        {
                            case Note.C:
                                NoteSimple(Pitch.C0, instruction.duration, outputDevice);
                                break;
                            case Note.D:
                                NoteSimple(Pitch.D0, instruction.duration, outputDevice);
                                break;
                            case Note.E:
                                NoteSimple(Pitch.E0, instruction.duration, outputDevice);
                                break;
                            case Note.F:
                                NoteSimple(Pitch.F0, instruction.duration, outputDevice);
                                break;
                            case Note.G:
                                NoteSimple(Pitch.G0, instruction.duration, outputDevice);
                                break;
                            case Note.A:
                                NoteSimple(Pitch.A0, instruction.duration, outputDevice);
                                break;
                            case Note.B:
                                NoteSimple(Pitch.B0, instruction.duration, outputDevice);
                                break;
                        }
                    }
                    break;
                case 1:
                    {
                        switch (instruction.note)
                        {
                            case Note.C:
                                NoteSimple(Pitch.C1, instruction.duration, outputDevice);
                                break;
                            case Note.D:
                                NoteSimple(Pitch.D1, instruction.duration, outputDevice);
                                break;
                            case Note.E:
                                NoteSimple(Pitch.E1, instruction.duration, outputDevice);
                                break;
                            case Note.F:
                                NoteSimple(Pitch.F1, instruction.duration, outputDevice);
                                break;
                            case Note.G:
                                NoteSimple(Pitch.G1, instruction.duration, outputDevice);
                                break;
                            case Note.A:
                                NoteSimple(Pitch.A1, instruction.duration, outputDevice);
                                break;
                            case Note.B:
                                NoteSimple(Pitch.B1, instruction.duration, outputDevice);
                                break;
                        }
                    }
                    break;
                case 2:
                    {
                        switch (instruction.note)
                        {
                            case Note.C:
                                NoteSimple(Pitch.C2, instruction.duration, outputDevice);
                                break;
                            case Note.D:
                                NoteSimple(Pitch.D2, instruction.duration, outputDevice);
                                break;
                            case Note.E:
                                NoteSimple(Pitch.E2, instruction.duration, outputDevice);
                                break;
                            case Note.F:
                                NoteSimple(Pitch.F2, instruction.duration, outputDevice);
                                break;
                            case Note.G:
                                NoteSimple(Pitch.G2, instruction.duration, outputDevice);
                                break;
                            case Note.A:
                                NoteSimple(Pitch.A2, instruction.duration, outputDevice);
                                break;
                            case Note.B:
                                NoteSimple(Pitch.B2, instruction.duration, outputDevice);
                                break;
                        }
                    }
                    break;
                case 3:
                    {
                        switch (instruction.note)
                        {
                            case Note.C:
                                NoteSimple(Pitch.C3, instruction.duration, outputDevice);
                                break;
                            case Note.D:
                                NoteSimple(Pitch.D3, instruction.duration, outputDevice);
                                break;
                            case Note.E:
                                NoteSimple(Pitch.E3, instruction.duration, outputDevice);
                                break;
                            case Note.F:
                                NoteSimple(Pitch.F3, instruction.duration, outputDevice);
                                break;
                            case Note.G:
                                NoteSimple(Pitch.G3, instruction.duration, outputDevice);
                                break;
                            case Note.A:
                                NoteSimple(Pitch.A3, instruction.duration, outputDevice);
                                break;
                            case Note.B:
                                NoteSimple(Pitch.B3, instruction.duration, outputDevice);
                                break;
                        }
                    }
                    break;
                case 4:
                    {
                        switch (instruction.note)
                        {
                            case Note.C:
                                NoteSimple(Pitch.C4, instruction.duration, outputDevice);
                                break;
                            case Note.D:
                                NoteSimple(Pitch.D4, instruction.duration, outputDevice);
                                break;
                            case Note.E:
                                NoteSimple(Pitch.E4, instruction.duration, outputDevice);
                                break;
                            case Note.F:
                                NoteSimple(Pitch.F4, instruction.duration, outputDevice);
                                break;
                            case Note.G:
                                NoteSimple(Pitch.G4, instruction.duration, outputDevice);
                                break;
                            case Note.A:
                                NoteSimple(Pitch.A4, instruction.duration, outputDevice);
                                break;
                            case Note.B:
                                NoteSimple(Pitch.B4, instruction.duration, outputDevice);
                                break;
                        }
                    }
                    break;
                case 5:
                    {
                        switch (instruction.note)
                        {
                            case Note.C:
                                NoteSimple(Pitch.C5, instruction.duration, outputDevice);
                                break;
                            case Note.D:
                                NoteSimple(Pitch.D5, instruction.duration, outputDevice);
                                break;
                            case Note.E:
                                NoteSimple(Pitch.E5, instruction.duration, outputDevice);
                                break;
                            case Note.F:
                                NoteSimple(Pitch.F5, instruction.duration, outputDevice);
                                break;
                            case Note.G:
                                NoteSimple(Pitch.G5, instruction.duration, outputDevice);
                                break;
                            case Note.A:
                                NoteSimple(Pitch.A5, instruction.duration, outputDevice);
                                break;
                            case Note.B:
                                NoteSimple(Pitch.B5, instruction.duration, outputDevice);
                                break;
                        }
                    }
                    break;
                case 6:
                    {
                        switch (instruction.note)
                        {
                            case Note.C:
                                NoteSimple(Pitch.C6, instruction.duration, outputDevice);
                                break;
                            case Note.D:
                                NoteSimple(Pitch.D6, instruction.duration, outputDevice);
                                break;
                            case Note.E:
                                NoteSimple(Pitch.E6, instruction.duration, outputDevice);
                                break;
                            case Note.F:
                                NoteSimple(Pitch.F6, instruction.duration, outputDevice);
                                break;
                            case Note.G:
                                NoteSimple(Pitch.G6, instruction.duration, outputDevice);
                                break;
                            case Note.A:
                                NoteSimple(Pitch.A6, instruction.duration, outputDevice);
                                break;
                            case Note.B:
                                NoteSimple(Pitch.B6, instruction.duration, outputDevice);
                                break;
                        }
                    }
                    break;
                case 7:
                    {
                        switch (instruction.note)
                        {
                            case Note.C:
                                NoteSimple(Pitch.C7, instruction.duration, outputDevice);
                                break;
                            case Note.D:
                                NoteSimple(Pitch.D7, instruction.duration, outputDevice);
                                break;
                            case Note.E:
                                NoteSimple(Pitch.E7, instruction.duration, outputDevice);
                                break;
                            case Note.F:
                                NoteSimple(Pitch.F7, instruction.duration, outputDevice);
                                break;
                            case Note.G:
                                NoteSimple(Pitch.G7, instruction.duration, outputDevice);
                                break;
                            case Note.A:
                                NoteSimple(Pitch.A7, instruction.duration, outputDevice);
                                break;
                            case Note.B:
                                NoteSimple(Pitch.B7, instruction.duration, outputDevice);
                                break;
                        }
                    }
                    break;
                case 8:
                    {
                        switch (instruction.note)
                        {
                            case Note.C:
                                NoteSimple(Pitch.C8, instruction.duration, outputDevice);
                                break;
                            case Note.D:
                                NoteSimple(Pitch.D8, instruction.duration, outputDevice);
                                break;
                            case Note.E:
                                NoteSimple(Pitch.E8, instruction.duration, outputDevice);
                                break;
                            case Note.F:
                                NoteSimple(Pitch.F8, instruction.duration, outputDevice);
                                break;
                            case Note.G:
                                NoteSimple(Pitch.G8, instruction.duration, outputDevice);
                                break;
                            case Note.A:
                                NoteSimple(Pitch.A8, instruction.duration, outputDevice);
                                break;
                            case Note.B:
                                NoteSimple(Pitch.B8, instruction.duration, outputDevice);
                                break;
                        }
                    }
                    break;
            }
        }

        private static void NoteSimple(Pitch p, int len, OutputDevice device)
        {
            device.SendNoteOn(Channel.Channel1, p, 80);
            Thread.Sleep(len);
            device.SendNoteOff(Channel.Channel1, Pitch.C4, 80);
        }
    }
}
