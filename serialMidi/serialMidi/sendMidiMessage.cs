using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;
using WindowsFormsApplication3;

namespace WindowsFormsApplication3
{
    class sendMidiMessage
    {
        public static void openMidiPort(int index)
        {
            OutputDevice outputMidi = OutputDevice.InstalledDevices[index];
           outputMidi.Open();
        }

        public static void closeMidiPort(int index)
        {
            OutputDevice outputMidi = OutputDevice.InstalledDevices[index];
            outputMidi.Close();        
        }

        private static string sendDebugMessage(string device, byte data)
        {
            string palabra = device + " " + data;
            return palabra;
        }

        public static string sendMessage(OutputDevice midiDevice, byte[] data)
        {
            int order = data[0];
            string debug;
            switch (order)
            {
                /*NoteOff Channels 1 to 16*/
                case 128:
                    midiDevice.SendNoteOff(Channel.Channel1, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 1";
                    return debug;
                case 129:
                    midiDevice.SendNoteOff(Channel.Channel2, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 2";
                    return debug;
                case 130:
                    midiDevice.SendNoteOff(Channel.Channel3, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 3"; 
                    return debug;
                case 131:
                    midiDevice.SendNoteOff(Channel.Channel4, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 4";
                    return debug;
                case 132:
                    midiDevice.SendNoteOff(Channel.Channel5, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 5"; 
                    return debug;
                case 133:
                    midiDevice.SendNoteOff(Channel.Channel6, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 6"; 
                    return debug;
                case 134:
                    midiDevice.SendNoteOff(Channel.Channel8, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 7"; 
                    return debug;
                case 135:                     
                    midiDevice.SendNoteOff(Channel.Channel8, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 8";
                    return debug;
                case 136:                     
                    midiDevice.SendNoteOff(Channel.Channel9, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 9";
                    return debug;
                case 137:                     
                    midiDevice.SendNoteOff(Channel.Channel10, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 10";
                    return debug;
                case 138:                    
                    midiDevice.SendNoteOff(Channel.Channel11, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 11";
                    return debug;
                case 139:                     
                    midiDevice.SendNoteOff(Channel.Channel2, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 12";
                    return debug;
                case 140:                     
                    midiDevice.SendNoteOff(Channel.Channel13, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 13";
                    return debug;
                case 141:
                    midiDevice.SendNoteOff(Channel.Channel14, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 14";
                    return debug;
                case 142:                     
                    midiDevice.SendNoteOff(Channel.Channel15, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 15";
                    return debug;
                case 143:                     
                    midiDevice.SendNoteOff(Channel.Channel16, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOff Message At Channel 16";
                    return debug;

                /*Note ON Channels 1 to 16*/                    
                case 144:
                    midiDevice.SendNoteOn(Channel.Channel1, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 1";
                    return debug;
                case 145:                     
                    midiDevice.SendNoteOn(Channel.Channel2, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 2";
                    return debug;
                case 146:                     
                    midiDevice.SendNoteOn(Channel.Channel3, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 3";
                    return debug;
                case 147:                     
                    midiDevice.SendNoteOn(Channel.Channel4, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 4";
                    return debug;
                case 148:                     
                    midiDevice.SendNoteOn(Channel.Channel5, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 5";
                    return debug;
                case 149:                     
                    midiDevice.SendNoteOn(Channel.Channel6, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 6";
                    return debug;
                case 150:                     
                    midiDevice.SendNoteOn(Channel.Channel7, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 7";
                    return debug;
                case 151:                     
                    midiDevice.SendNoteOn(Channel.Channel8, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 8";
                    return debug;
                case 152:     
                    midiDevice.SendNoteOn(Channel.Channel9, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 9";
                    return debug;
                case 153:                     
                    midiDevice.SendNoteOn(Channel.Channel10, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 10";
                    return debug;
                case 154:                     
                    midiDevice.SendNoteOn(Channel.Channel11, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 11";
                    return debug;
                case 155:                     
                    midiDevice.SendNoteOn(Channel.Channel12, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 12";
                    return debug;
                case 156:                     
                    midiDevice.SendNoteOn(Channel.Channel13, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 13";
                    return debug;
                case 157:                  
                    midiDevice.SendNoteOn(Channel.Channel14, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 14";
                    return debug;
                case 158:                     
                    midiDevice.SendNoteOn(Channel.Channel15, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 15";
                    return debug;
                case 159:                     
                    midiDevice.SendNoteOn(Channel.Channel16, pitchDetermination.notes(data[1]), data[2]);
                    debug = "Sending NoteOn Message At Channel 16";
                    return debug;
                case 176:
                    midiDevice.SendControlChange(Channel.Channel1, Control.Volume, data[1]);
                    debug = "Sending ControlChange At Channel 1";
                    return debug;
                default:
                     debug = "NO Valido";
                    return debug;
            }
        }
        
       /* private void UseOutputDevice(OutputDevice newOutputDevice)
        {
            if (clock.IsRunning)
            {
                clock.Stop();
                clock.Reset();
            }
            if (newOutputDevice != null)
            {
                if (newOutputDevice.IsOpen)
                {
                    newOutputDevice.Close();
                }
            }
            newOutputDevice.Open();
            clock.Start();
        }

            /* Switches input devices, turning off the old one (if any) and turning on the new one.
        private void UseInputDevice(InputDevice newInputDevice)
        {
            if (newInputDevice == inputDevice) {
                return;
            }
            if (inputDevice != null)
            {
                if (inputDevice.IsOpen)
                {
                    if (inputDevice.IsReceiving)
                    {
                        inputDevice.StopReceiving();
                    }
                    inputDevice.Close();
                }
                inputDevice.NoteOn -= noteOnHandler;
                inputDevice.NoteOff -= noteOffHandler;
            }
            inputDevice = newInputDevice;
            inputDevice.NoteOn += noteOnHandler;
            inputDevice.NoteOff += noteOffHandler;
            inputDevice.Open();
            inputDevice.StartReceiving(null);
        }

        */
        
        
        }
    }
