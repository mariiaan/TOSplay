using System.Collections.Generic;

namespace TOSPlay
{
    public static class TOSSongParser
    {
        public static Instruction[] ParseInstructions(string playString, int bpm)
        {
            List<Instruction> instructions = new List<Instruction>();

            int interval = (int)(60f / bpm * 1000);

            int currentOctave = 4;
            float currentDurationMultiplier = 1f;

            foreach (char c in playString)
            {
                switch (c)
                {
                    case '0':
                        currentOctave = 0;
                        break;
                    case '1':
                        currentOctave = 1;
                        break;
                    case '2':
                        currentOctave = 2;
                        break;
                    case '3':
                        currentOctave = 3;
                        break;
                    case '4':
                        currentOctave = 4;
                        break;
                    case '5':
                        currentOctave = 5;
                        break;
                    case '6':
                        currentOctave = 6;
                        break;
                    case '7':
                        currentOctave = 7;
                        break;
                    case '8':
                        currentOctave = 8;
                        break;
                    case 'w':
                        currentDurationMultiplier = 1;
                        break;
                    case 'h':
                        currentDurationMultiplier = 0.5f;
                        break;
                    case 'q':
                        currentDurationMultiplier = 0.25f;
                        break;
                    case 'e':
                        currentDurationMultiplier = 0.125f;
                        break;
                    case 't':
                        currentDurationMultiplier *= 2 / 3f;
                        break;
                    case '.':
                        currentDurationMultiplier *= 1.5f;
                        break;
                    case 'C':
                        instructions.Add(new Instruction(Pow(16.35f, currentOctave), (int)(currentDurationMultiplier * interval), currentOctave, Note.C));
                        break;
                    case 'D':
                        instructions.Add(new Instruction(Pow(18.35f, currentOctave), (int)(currentDurationMultiplier * interval), currentOctave, Note.D));
                        break;
                    case 'E':
                        instructions.Add(new Instruction(Pow(20.6f, currentOctave), (int)(currentDurationMultiplier * interval), currentOctave, Note.E));
                        break;
                    case 'F':
                        instructions.Add(new Instruction(Pow(21.83f, currentOctave), (int)(currentDurationMultiplier * interval), currentOctave, Note.F));
                        break;
                    case 'G':
                        instructions.Add(new Instruction(Pow(24.5f, currentOctave), (int)(currentDurationMultiplier * interval), currentOctave, Note.G));
                        break;
                    case 'A':
                        instructions.Add(new Instruction(Pow(27.5f, currentOctave), (int)(currentDurationMultiplier * interval), currentOctave, Note.A));
                        break;
                    case 'B':
                        instructions.Add(new Instruction(Pow(30.87f, currentOctave), (int)(currentDurationMultiplier * interval), currentOctave, Note.B));
                        break;
                    case '#':
                        {
                            Instruction lastInstruction = instructions[instructions.Count - 1];
                            switch (lastInstruction.note)
                            {
                                case Note.C:
                                    lastInstruction.note = Note.Cs;
                                    lastInstruction.frequency = Pow(16.35f, lastInstruction.octave);
                                    break;
                                case Note.D:
                                    lastInstruction.note = Note.Ds;
                                    lastInstruction.frequency = Pow(17.32f, lastInstruction.octave);
                                    break;
                                case Note.F:
                                    lastInstruction.note = Note.Fs;
                                    lastInstruction.frequency = Pow(23.12f, lastInstruction.octave);
                                    break;
                                case Note.G:
                                    lastInstruction.note = Note.Gs;
                                    lastInstruction.frequency = Pow(25.96f, lastInstruction.octave);
                                    break;
                                case Note.A:
                                    lastInstruction.note = Note.As;
                                    lastInstruction.frequency = Pow(29.14f, lastInstruction.octave);
                                    break;
                            }
                        }
                        break;
                    case 'b':
                        {
                            Instruction lastInstruction = instructions[instructions.Count - 1];
                            switch (lastInstruction.note)
                            {
                                case Note.D:
                                    lastInstruction.note = Note.Cs;
                                    lastInstruction.frequency = Pow(16.35f, lastInstruction.octave);
                                    break;
                                case Note.E:
                                    lastInstruction.note = Note.Ds;
                                    lastInstruction.frequency = Pow(17.32f, lastInstruction.octave);
                                    break;
                                case Note.G:
                                    lastInstruction.note = Note.Fs;
                                    lastInstruction.frequency = Pow(23.12f, lastInstruction.octave);
                                    break;
                                case Note.A:
                                    lastInstruction.note = Note.Gs;
                                    lastInstruction.frequency = Pow(25.96f, lastInstruction.octave);
                                    break;
                                case Note.B:
                                    lastInstruction.note = Note.As;
                                    lastInstruction.frequency = Pow(29.14f, lastInstruction.octave);
                                    break;
                            }
                        }
                        break;
                }
            }

            return instructions.ToArray();
        }

        private static int Pow(float b, int e)
        {
            for (int i = 0; i < e; i++)
            {
                b *= 2f;
            }
            return (int)b;
        }
    }

    public class Instruction
    {
        public int frequency;
        public int duration;
        public int octave;
        public Note note;

        public Instruction(int frequency, int duration, int octave, Note note)
        {
            this.frequency = frequency;
            this.duration = duration;
            this.octave = octave;
            this.note = note;
        }
    }

    public enum Note
    {
        C,
        Cs,
        D,
        Ds,
        E,
        F,
        Fs,
        G,
        Gs,
        A,
        As,
        B
    }
}
