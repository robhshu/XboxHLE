/*
Copyright (C) 2015  Gabriel Maldonado

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or 
any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>

* Linkedin: https://www.linkedin.com/pub/gabriel-maldonado/63/457/866
* Github: https://github.com/Gabriel-Maldonado/XboxHLE
*/

using System;
namespace xboxhle.xbox
{
    public class emu
    {
        static int Execute = 0; // Execute the code
        public static bool isRunTime = false; // false = interpreter / true = jit compilation
        public static bool isRunning = false;
        public static bool Pause = false;
        public static bool hReset = false; // Hard reset

        public static int execute_x86()
        {
            if (xbox.emu.isRunTime == true)
            {
                Execute = xboxhle.xbox.i386.llvm.jit(); // Included for structuring reasons, but very early for now.
            }
            else if (xbox.emu.isRunTime == false)
            {
                Execute = xboxhle.xbox.i386.parse.translate(); // Execute translated instructions from our parser.
                if (hReset == true) reset_x86();
            }
            return Execute;
        }

        public static void reset_x86() {

            // Program Counter
            xboxhle.xbox.i386.parse.addr32.pc = xboxhle.xbe.SubtractOffset(xboxhle.xbe.entry_points, xboxhle.xbe.base_addr);
            
            // Registers
            xboxhle.xbox.i386.parse.reg32.eax = 0;
            xboxhle.xbox.i386.parse.reg32.ebx = 0;
            xboxhle.xbox.i386.parse.reg32.ecx = 0;
            xboxhle.xbox.i386.parse.reg32.edx = 0;

            // Segments
            xboxhle.xbox.i386.parse.seg16.cs = 0;
            xboxhle.xbox.i386.parse.seg16.ds = 0;
            xboxhle.xbox.i386.parse.seg16.es = 0;
            xboxhle.xbox.i386.parse.seg16.ss = 0;

            // Extended Index
            xboxhle.xbox.i386.parse.eIdx.edi = 0;
            xboxhle.xbox.i386.parse.eIdx.esi = 0;

            // Extended Pointers
            xboxhle.xbox.i386.parse.ePtr.ebp = 0;
            xboxhle.xbox.i386.parse.ePtr.esp = 0;
           
            // Clear Stack frame
            Array.Clear(xboxhle.xbox.i386.parse.arr, 0, xboxhle.xbox.i386.parse.arr.Length);
            
            // Clear FrameBuffer
            Array.Clear(xboxhle.xbox.video.video.arr, 0, xboxhle.xbox.video.video.arr.Length);
            
            hReset = false;
        }
    }
}
