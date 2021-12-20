namespace fKG6lKAfFsgJwnKy5Cwc9CnonKyjvaZpQezk9HeC
{
    using mscorlib;
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    internal class 9OZa0218gYGcKzVZlYIQDqNDMtulvnyjWOvZxbkI
    {
        [DllImport("kernel32.dll", EntryPoint="LoadLibrary")]
        public static extern IntPtr 1VsC7wyZxFsuJNOhu0Q1eKjHaSBj5cfmR4rIL9UM(string);
        [DllImport("kernel32.dll", EntryPoint="GetProcAddress")]
        public static extern IntPtr B0QjU5dgWuKE5mLpIUXxUBU8n1FCCaIuw1esiaoy(IntPtr, string);
        [DllImport("kernel32.dll", EntryPoint="IsDebuggerPresent", SetLastError=true, ExactSpelling=true)]
        private static extern bool EES29c1pHe1YoEVaiChrDx4H0RCIghKFldfNBPWf();
        public static unsafe void M9vgHIb525NUZheuO5zYPw4nwgd5h8sIzemF7Ham()
        {
            IntPtr ptr;
            int num;
            IntPtr ptr2;
            IntPtr ptr3;
            byte[] buffer;
            bool flag;
            bool flag2;
            bool flag3;
            bool flag4;
            bool flag5;
            bool flag6;
            bool flag7;
            bool flag8;
            int num2;
            System.Boolean ReflectorVariable0;
            num2 = 0x206d;
        Label_0009:
            switch (xCOol1MorC0sFWRrGp8gqGfe7ElOYCjKcbxPwNzb(num2))
            {
                case 0:
                    goto Label_00A0;

                case 1:
                    goto Label_00AF;

                case 2:
                    goto Label_00CB;

                case 3:
                    goto Label_00DA;

                case 4:
                    goto Label_00FF;

                case 5:
                    goto Label_011B;

                case 6:
                    goto Label_0137;

                case 7:
                    goto Label_015C;

                case 8:
                    goto Label_017F;

                case 9:
                    goto Label_019B;

                case 10:
                    goto Label_01CF;

                case 11:
                    goto Label_01DE;

                case 12:
                    goto Label_01F5;

                case 13:
                    goto Label_0204;

                case 14:
                    goto Label_021B;

                case 15:
                    goto Label_022A;

                case 0x10:
                    goto Label_024A;

                case 0x11:
                    goto Label_0262;

                case 0x12:
                    goto Label_0271;

                case 0x13:
                    goto Label_0280;

                case 20:
                    goto Label_02A0;

                case 0x15:
                    goto Label_02C5;

                case 0x16:
                    goto Label_02D4;

                case 0x17:
                    goto Label_02E3;

                case 0x18:
                    goto Label_02FA;

                case 0x19:
                    goto Label_0312;

                case 0x1a:
                    goto Label_0321;

                case 0x1b:
                    goto Label_03AD;

                case 0x1c:
                    goto Label_03BC;

                case 0x1d:
                    goto Label_03D8;

                case 30:
                    goto Label_03FB;

                case 0x1f:
                    goto Label_040A;

                case 0x20:
                    goto Label_0422;

                case 0x21:
                    goto Label_0431;
            }
        Label_00A0:
            num2 = 0x2079;
            goto Label_0009;
        Label_00AF:
            &ptr = new IntPtr(0);
            num2 = 0x2061;
            goto Label_0009;
        Label_00CB:
            num2 = 0x2049;
            goto Label_0009;
        Label_00DA:
            flag3 = ptr == new IntPtr(-1);
            num2 = 0x2063;
            goto Label_0009;
        Label_00FF:
            buffer = new byte[1];
            num2 = 0x207c;
            goto Label_0009;
        Label_011B:
            goto Label_0128;
        Label_0128:
            num2 = 0x2068;
            goto Label_0009;
        Label_0137:
            Marshal.Copy(ptr3, buffer, 0, 1);
            num2 = 0x207e;
            goto Label_0009;
        Label_015C:
            flag5 = buffer[0] == 0xe9;
            num2 = 0x2065;
            goto Label_0009;
        Label_017F:
            buffer = new byte[1];
            num2 = 0x206e;
            goto Label_0009;
        Label_019B:
            p2wGXwDqveT1OkqINGH4x4CTr3l53Kz2rlxVmYqX(Process.GetCurrentProcess().Handle, 7, &ptr, Marshal.SizeOf<IntPtr>(ptr), &num);
            num2 = 0x206b;
            goto Label_0009;
        Label_01CF:
            num2 = 0x2078;
            goto Label_0009;
        Label_01DE:
            if (flag3 == null)
            {
                goto Label_03BC;
            }
            num2 = 0x2062;
            goto Label_0009;
        Label_01F5:
            num2 = 0x2066;
            goto Label_0009;
        Label_0204:
            if (flag5 == null)
            {
                goto Label_0431;
            }
            num2 = 0x2071;
            goto Label_0009;
        Label_021B:
            num2 = 0x2074;
            goto Label_0009;
        Label_022A:
            ptr3 = B0QjU5dgWuKE5mLpIUXxUBU8n1FCCaIuw1esiaoy(ptr2, "IsDebuggerPresent");
            num2 = 0x2060;
            goto Label_0009;
        Label_024A:
            Environment.FailFast("");
            num2 = 0x2064;
            goto Label_0009;
        Label_0262:
            num2 = 0x2069;
            goto Label_0009;
        Label_0271:
            num2 = 0x206a;
            goto Label_0009;
        Label_0280:
            ptr3 = B0QjU5dgWuKE5mLpIUXxUBU8n1FCCaIuw1esiaoy(ptr2, "CheckRemoteDebuggerPresent");
            num2 = 0x206c;
            goto Label_0009;
        Label_02A0:
            Marshal.Copy(ptr3, buffer, 0, 1);
            num2 = 0x207d;
            goto Label_0009;
        Label_02C5:
            num2 = 0x206f;
            goto Label_0009;
        Label_02D4:
            num2 = 0x2075;
            goto Label_0009;
        Label_02E3:
            if (flag4 == null)
            {
                goto Label_0280;
            }
            num2 = 0x2076;
            goto Label_0009;
        Label_02FA:
            Environment.FailFast("");
            num2 = 0x2048;
            goto Label_0009;
        Label_0312:
            num2 = 0x2077;
            goto Label_0009;
        Label_0321:
            ReflectorVariable0 = true;
            goto Label_0330;
        Label_032B:
            ReflectorVariable0 = false;
        Label_0330:;
        Label_0330:
            if ((ReflectorVariable0 ? Debugger.IsLogging() : 1) == null)
            {
                goto Label_034A;
            }
            Environment.FailFast("");
        Label_034A:
            if (EES29c1pHe1YoEVaiChrDx4H0RCIghKFldfNBPWf() == null)
            {
                goto Label_0369;
            }
            Environment.FailFast("");
        Label_0369:
            flag = 0;
            if ((nPUBHWbqs3asgqdawS1HknEMPSorjUeUbJ66lKmG(Process.GetCurrentProcess().Handle, &flag) & flag) == null)
            {
                goto Label_03AC;
            }
            Environment.FailFast("");
        Label_03AC:
            return;
        Label_03AD:
            num2 = 0x207b;
            goto Label_0009;
        Label_03BC:
            ptr2 = 1VsC7wyZxFsuJNOhu0Q1eKjHaSBj5cfmR4rIL9UM("kernel32.dll");
            num2 = 0x2067;
            goto Label_0009;
        Label_03D8:
            flag4 = buffer[0] == 0xe9;
            num2 = 0x207f;
            goto Label_0009;
        Label_03FB:
            num2 = 0x2070;
            goto Label_0009;
        Label_040A:
            Environment.FailFast("");
            num2 = 0x207a;
            goto Label_0009;
        Label_0422:
            num2 = 0x2073;
            goto Label_0009;
        Label_0431:
            if (Debugger.IsAttached != null)
            {
                goto Label_032B;
            }
            num2 = 0x2072;
            goto Label_0009;
            goto Label_0009;
        }

        [DllImport("kernel32.dll", EntryPoint="CheckRemoteDebuggerPresent", SetLastError=true, ExactSpelling=true)]
        private static extern bool nPUBHWbqs3asgqdawS1HknEMPSorjUeUbJ66lKmG(IntPtr, ref bool);
        [DllImport("ntdll.dll", EntryPoint="NtQueryInformationProcess", SetLastError=true, ExactSpelling=true)]
        public static extern int p2wGXwDqveT1OkqINGH4x4CTr3l53Kz2rlxVmYqX(IntPtr, int, ref IntPtr, int, ref int);
    }
}

