using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace WindowsFormsApplication3
{
    class pitchDetermination
    {
        public static Pitch notes(byte data)
        {
            Pitch realPitch;
            switch (data)
            {
                case 12: realPitch = Pitch.C0; return realPitch;
                case 13: realPitch = Pitch.CSharp0; return realPitch;
                case 14: realPitch = Pitch.D0; return realPitch;
                case 15: realPitch = Pitch.DSharp0; return realPitch;
                case 16: realPitch = Pitch.E0; return realPitch;
                case 17: realPitch = Pitch.F0; return realPitch;
                case 18: realPitch = Pitch.FSharp0; return realPitch;
                case 19: realPitch = Pitch.G0; return realPitch;
                case 20: realPitch = Pitch.GSharp0; return realPitch;
                case 21: realPitch = Pitch.A0; return realPitch;
                case 22: realPitch = Pitch.ASharp0; return realPitch;
                case 23: realPitch = Pitch.B0; return realPitch;
                case 24: realPitch = Pitch.C1; return realPitch;
                case 25: realPitch = Pitch.CSharp1; return realPitch;
                case 26: realPitch = Pitch.D1; return realPitch;
                case 27: realPitch = Pitch.DSharp1; return realPitch;
                case 28: realPitch = Pitch.E1; return realPitch;
                case 29: realPitch = Pitch.F1; return realPitch;
                case 30: realPitch = Pitch.FSharp1; return realPitch;
                case 31: realPitch = Pitch.G1; return realPitch;
                case 32: realPitch = Pitch.GSharp1; return realPitch;
                case 33: realPitch = Pitch.A1; return realPitch;
                case 34: realPitch = Pitch.ASharp1; return realPitch;
                case 35: realPitch = Pitch.B1; return realPitch;
                case 36: realPitch = Pitch.C1; return realPitch;
                case 37: realPitch = Pitch.CSharp2; return realPitch;
                case 38: realPitch = Pitch.D2; return realPitch;
                case 39: realPitch = Pitch.DSharp2; return realPitch;
                case 40: realPitch = Pitch.E2; return realPitch;
                case 41: realPitch = Pitch.F2; return realPitch;
                case 42: realPitch = Pitch.FSharp2; return realPitch;
                case 43: realPitch = Pitch.G2; return realPitch;
                case 44: realPitch = Pitch.GSharp2; return realPitch;
                case 45: realPitch = Pitch.A2; return realPitch;
                case 46: realPitch = Pitch.ASharp2; return realPitch;
                case 47: realPitch = Pitch.B2; return realPitch;
                case 48: realPitch = Pitch.C3; return realPitch;
                case 49: realPitch = Pitch.CSharp3; return realPitch;
                case 50: realPitch = Pitch.D3; return realPitch;
                case 51: realPitch = Pitch.DSharp3; return realPitch;
                case 52: realPitch = Pitch.E3; return realPitch;
                case 53: realPitch = Pitch.F3; return realPitch;
                case 54: realPitch = Pitch.FSharp3; return realPitch;
                case 55: realPitch = Pitch.G3; return realPitch;
                case 56: realPitch = Pitch.GSharp3; return realPitch;
                case 57: realPitch = Pitch.A3; return realPitch;
                case 58: realPitch = Pitch.ASharp3; return realPitch;
                case 59: realPitch = Pitch.B3; return realPitch;
                case 60: realPitch = Pitch.C4; return realPitch;
                case 61: realPitch = Pitch.CSharp4; return realPitch;
                case 62: realPitch = Pitch.D4; return realPitch;
                case 63: realPitch = Pitch.DSharp4; return realPitch;
                case 64: realPitch = Pitch.E4; return realPitch;
                case 65: realPitch = Pitch.F4; return realPitch;
                case 66: realPitch = Pitch.FSharp4; return realPitch;
                case 67: realPitch = Pitch.G4; return realPitch;
                case 68: realPitch = Pitch.GSharp4; return realPitch;
                case 69: realPitch = Pitch.A4; return realPitch;
                case 70: realPitch = Pitch.ASharp4; return realPitch;
                case 71: realPitch = Pitch.B4; return realPitch;
                case 72: realPitch = Pitch.C5; return realPitch;
                case 73: realPitch = Pitch.CSharp5; return realPitch;
                case 74: realPitch = Pitch.D5; return realPitch;
                case 75: realPitch = Pitch.DSharp5; return realPitch;
                case 76: realPitch = Pitch.E5; return realPitch;
                case 77: realPitch = Pitch.F5; return realPitch;
                case 78: realPitch = Pitch.FSharp5; return realPitch;
                case 79: realPitch = Pitch.G5; return realPitch;
                case 80: realPitch = Pitch.GSharp5; return realPitch;
                case 81: realPitch = Pitch.A5; return realPitch;
                case 82: realPitch = Pitch.ASharp5; return realPitch;
                case 83: realPitch = Pitch.B5; return realPitch;
                case 84: realPitch = Pitch.C6; return realPitch;
                case 85: realPitch = Pitch.CSharp6; return realPitch;
                case 86: realPitch = Pitch.D6; return realPitch;
                case 87: realPitch = Pitch.DSharp6; return realPitch;
                case 88: realPitch = Pitch.E6; return realPitch;
                case 89: realPitch = Pitch.F6; return realPitch;
                case 90: realPitch = Pitch.FSharp6; return realPitch;
                case 91: realPitch = Pitch.G6; return realPitch;
                case 92: realPitch = Pitch.GSharp6; return realPitch;
                case 93: realPitch = Pitch.A6; return realPitch;
                case 94: realPitch = Pitch.ASharp6; return realPitch;
                case 95: realPitch = Pitch.B6; return realPitch;
                case 96: realPitch = Pitch.C7; return realPitch;
                case 97: realPitch = Pitch.CSharp7; return realPitch;
                case 98: realPitch = Pitch.D7; return realPitch;
                case 99: realPitch = Pitch.DSharp7; return realPitch;
                case 100: realPitch = Pitch.E7; return realPitch;
                case 101: realPitch = Pitch.F7; return realPitch;
                case 102: realPitch = Pitch.FSharp7; return realPitch;
                case 103: realPitch = Pitch.G7; return realPitch;
                case 104: realPitch = Pitch.GSharp7; return realPitch;
                case 105: realPitch = Pitch.A7; return realPitch;
                case 106: realPitch = Pitch.ASharp7; return realPitch;
                case 107: realPitch = Pitch.B7; return realPitch;
                case 108: realPitch = Pitch.C8; return realPitch;
                case 109: realPitch = Pitch.CSharp8; return realPitch;
                case 110: realPitch = Pitch.D8; return realPitch;
                case 111: realPitch = Pitch.DSharp8; return realPitch;
                case 112: realPitch = Pitch.E8; return realPitch;
                case 113: realPitch = Pitch.F8; return realPitch;
                case 114: realPitch = Pitch.FSharp8; return realPitch;
                case 115: realPitch = Pitch.G8; return realPitch;
                case 116: realPitch = Pitch.GSharp8; return realPitch;
                case 117: realPitch = Pitch.A8; return realPitch;
                case 118: realPitch = Pitch.ASharp8; return realPitch;
                case 119: realPitch = Pitch.B8; return realPitch;
                case 120: realPitch = Pitch.C9; return realPitch;
                case 121: realPitch = Pitch.CSharp9; return realPitch;
                case 122: realPitch = Pitch.D9; return realPitch;
                case 123: realPitch = Pitch.DSharp9; return realPitch;
                case 124: realPitch = Pitch.E9; return realPitch;
                case 125: realPitch = Pitch.F9; return realPitch;
                case 126: realPitch = Pitch.FSharp9; return realPitch;
                case 127: realPitch = Pitch.G9; return realPitch;
                default:
                    return Pitch.GSharpNeg1;
            }

        }
    }
}
