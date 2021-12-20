namespace jCw5vNrgUqwWSBlpvdJhqPv18McfJIsyG8xEAgD7
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Text;

    internal class t4ePPg2mekf3QuEKnR7FE0I98huFE0MoQLsjUVlM
    {
        public static void ix5Aop5yfZIfHGs1vYcxzwiogDRk5lxrhuNMHWC0()
        {
            int num;
            num = 0x206b;
        Label_0009:
            switch (xCOol1MorC0sFWRrGp8gqGfe7ElOYCjKcbxPwNzb(num))
            {
                case 0:
                    goto Label_0030;

                case 1:
                    goto Label_0054;

                case 2:
                    goto Label_0063;

                case 3:
                    goto Label_0064;

                case 4:
                    goto Label_0080;

                case 5:
                    goto Label_008F;
            }
        Label_0030:
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(t4ePPg2mekf3QuEKnR7FE0I98huFE0MoQLsjUVlM.saPXbwRQ6jIaZtMVgVsYJGq5uR8PBEdFLYqzXxM3);
            num = 0x206d;
            goto Label_0009;
        Label_0054:
            num = 0x206c;
            goto Label_0009;
        Label_0063:
            return;
        Label_0064:
            goto Label_0071;
        Label_0071:
            num = 0x2069;
            goto Label_0009;
        Label_0080:
            num = 0x2068;
            goto Label_0009;
        Label_008F:
            num = 0x206a;
            goto Label_0009;
            goto Label_0009;
        }

        private static Assembly saPXbwRQ6jIaZtMVgVsYJGq5uR8PBEdFLYqzXxM3(object, ResolveEventArgs args1)
        {
            string str;
            bool flag;
            Assembly assembly;
            Stream stream;
            byte[] buffer;
            int num;
            num = 0x2069;
        Label_0009:
            switch (xCOol1MorC0sFWRrGp8gqGfe7ElOYCjKcbxPwNzb(num))
            {
                case 0:
                    goto Label_0028;

                case 1:
                    goto Label_0037;

                case 2:
                    goto Label_0053;

                case 3:
                    goto Label_0165;
            }
        Label_0028:
            num = 0x206b;
            goto Label_0009;
        Label_0037:
            goto Label_0044;
        Label_0044:
            num = 0x2068;
            goto Label_0009;
        Label_0053:
            try
            {
                str = (args1.Name.Contains(",") != null) ? args1.Name.Substring(0, args1.Name.IndexOf(0x2c)) : args1.Name.Replace(".dll", "");
                if (str.EndsWith("_resources") == null)
                {
                    goto Label_00D8;
                }
                assembly = null;
                goto Label_0160;
            Label_00D8:
                str = Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
                stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(str);
            Label_0101:
                try
                {
                    buffer = new byte[(IntPtr) stream.Length];
                    stream.Read(buffer, 0, (int) buffer.Length);
                    assembly = Assembly.Load(buffer);
                    goto Label_0160;
                }
                finally
                {
                Label_0140:
                    if (stream == null)
                    {
                        goto Label_0153;
                    }
                    stream.Dispose();
                Label_0153:;
                }
            }
            catch
            {
            Label_0154:
                assembly = null;
                goto Label_0160;
            }
        Label_0160:
            return assembly;
        Label_0165:
            num = 0x206a;
            goto Label_0009;
            goto Label_0009;
        }
    }
}

