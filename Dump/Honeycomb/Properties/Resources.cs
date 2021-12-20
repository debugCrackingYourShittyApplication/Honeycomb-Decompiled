namespace Honeycomb.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
    internal class Resources
    {
        private static System.Resources.ResourceManager MxbNygaule0ZG5vLFmt8FLku9yhBfw8P5KOsw5aO;
        private static CultureInfo n1nlT5YnQbouAdBark098d37tjU7vsvLlYOXm9Sr;

        internal Resources()
        {
            goto Label_000D;
        Label_000D:
            base..ctor();
            return;
        }

        [EditorBrowsable(2)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                bool flag;
                System.Resources.ResourceManager manager;
                System.Resources.ResourceManager manager2;
                goto Label_000D;
            Label_000D:
                if ((MxbNygaule0ZG5vLFmt8FLku9yhBfw8P5KOsw5aO == null) == null)
                {
                    goto Label_004D;
                }
                manager = new System.Resources.ResourceManager("Honeycomb.Properties.Resources", typeof(Resources).Assembly);
                MxbNygaule0ZG5vLFmt8FLku9yhBfw8P5KOsw5aO = manager;
            Label_004D:
                manager2 = MxbNygaule0ZG5vLFmt8FLku9yhBfw8P5KOsw5aO;
            Label_005B:
                return manager2;
            }
        }

        [EditorBrowsable(2)]
        internal static CultureInfo Culture
        {
            get
            {
                CultureInfo info;
                goto Label_000D;
            Label_000D:
                info = n1nlT5YnQbouAdBark098d37tjU7vsvLlYOXm9Sr;
            Label_001E:
                return info;
            }
            set
            {
                goto Label_000D;
            Label_000D:
                n1nlT5YnQbouAdBark098d37tjU7vsvLlYOXm9Sr = value;
                return;
            }
        }
    }
}

