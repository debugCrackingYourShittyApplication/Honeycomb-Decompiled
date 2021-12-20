namespace Honeycomb
{
    using Asv1OSgJlkLbnxd4ojp0EoEUnGyBRaV4x6rxfee7;
    using Ezk6axIiK6QEPInfx8eQR09liwnJS8gN6mW4G5QN;
    using HoneyUI;
    using jKsTwQWyEwFf3DTgDHD7Qt4K0oupTlOcEkwAqHQa;
    using Jrb2Up7EnYMXm72tw0e7TWf4tVQzgaj6uPHaUUgd;
    using lOFCcguIvD90d5fTYWhu8fbFWAwGMUFrmtWNlfLI;
    using OdE47vSGBhLW9QZXqT8OwOkGPONqubDYJS4M1uXR;
    using OsjlkutNe2yR48psAsQy5NuGwLIkN1DjdwkDMB5J;
    using SimpleTCP;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using yTUPNuGVJWs6NJM4I7q9pd4HI04KqCfsgBXA7BzR;
    using ywT34ljUqBCjEc7JmMLPKAl0Qz0L0zWHl5Ifs44K;

    public class Login : honeyForm
    {
        private bool DxE4sadzUk72uzszRoj8qUCKLneJsSf3pdgbcghq;
        private Point 0guLPGeVS4TxwLFyOWsC7Y05trL3VVGh3uo6ntot;
        public static int chyju1OZPoNDrEfxbsGY5o9VhhEgQJJTDinKnPBd;
        public static string YkmG7esA3VIgnDoghkz1nw02Ex95rY5BcZaGNx0f;
        public static string rzxVpEt98sZoO6VqAAsDejvv1M17DTb4ZBBv9rMa;
        public static string j972tVjnFNfbpgqVF75AQuvTCIJWonqvJsxrmYlt;
        public static string EZwCkaWdFaWzimnqDEyUuUkfHNK82iToG17pCSfX;
        public static string CRuiHphvXsA0nC75quiZlCmUUDcjxhvagmWDApOU;
        public static string PwdKJFL23e9JTCRaqPSrC9zUVASyexYaIS18PDN3;
        public static string 3TcmjKUE0ME0IYMQlJ3jzD0OU8o34TZIMLplDKhu;
        private IContainer 3phl2GEe1jH3LP1kFBCkOFIxk4uNcZ7QAVv2cIH1;
        private honeyButton YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM;
        private gxFf77Wpa6sHtCfsCRFdRQQqCjWDktr7yDLgAKW3 t68TCoJEhijEUKm2nDwWy4827PJ9dyGLvk3DGdDq;
        private PictureBox baJtLZOZS3e9OXGq8uUfEJhpRIthVKffapctg3pY;
        private Yz89a64mbes51Ze3P1e8d7D3I9Lz4l7M6KTif5GS zgbmrGpDFLGOHnLLXUSqcmG4HB8nnP6t6zdfl5uB;
        private PictureBox bEStrHOQZFmKk9oKQRFgHWfrCPSFfTANnVC4KP0a;

        static Login()
        {
            goto Label_000D;
        Label_000D:
            chyju1OZPoNDrEfxbsGY5o9VhhEgQJJTDinKnPBd = 0;
            YkmG7esA3VIgnDoghkz1nw02Ex95rY5BcZaGNx0f = "";
            j972tVjnFNfbpgqVF75AQuvTCIJWonqvJsxrmYlt = "";
            EZwCkaWdFaWzimnqDEyUuUkfHNK82iToG17pCSfX = y1uhWzVknOtxWxQHzFm2ZOHptu8UBMYnBzTNweyO.1b1ph9sTutnkcUgxjLDXnD91Bi8L53TXY0hl3GbT(dZVsILmyOh5hIZnkL0Z3YndkRBeRl1JufdFaxk8K.w9jftOc4UXFcQoZChYLMJ0VJPNzxVn6Z2WPYp8f4(), GMyGhayKIOFKMHa8B0FLp8irYlJuevJGaAwJzE5j());
            CRuiHphvXsA0nC75quiZlCmUUDcjxhvagmWDApOU = y1uhWzVknOtxWxQHzFm2ZOHptu8UBMYnBzTNweyO.1RhdlPNtgeFRGiYYXh1SUehdeq1XiL2Nubwnk3NQ("1", GMyGhayKIOFKMHa8B0FLp8irYlJuevJGaAwJzE5j());
            PwdKJFL23e9JTCRaqPSrC9zUVASyexYaIS18PDN3 = "NULL";
            3TcmjKUE0ME0IYMQlJ3jzD0OU8o34TZIMLplDKhu = "NULL";
            return;
        }

        public Login()
        {
            string str;
            string str2;
            bool flag;
            bool flag2;
            goto Label_000D;
        Label_000D:
            this.3phl2GEe1jH3LP1kFBCkOFIxk4uNcZ7QAVv2cIH1 = null;
            base..ctor();
            this.0DPZzApCfjI1RiPKT0a0MNpAqejFaUIoBC57TSKV();
            str = Environment.GetEnvironmentVariable("PROGRAMDATA") + "/Honeycomb/";
        Label_0046:
            try
            {
                if ((File.Exists(str) == 0) == null)
                {
                    goto Label_0070;
                }
                Directory.CreateDirectory(str);
            Label_0070:
                goto Label_007E;
            }
            catch
            {
            Label_0076:
                goto Label_007E;
            }
        Label_007E:
            str2 = Environment.GetEnvironmentVariable("PROGRAMDATA") + "/Honeycomb/HoneyKey.ini";
            if ((File.Exists(str2) == 0) == null)
            {
                goto Label_00BA;
            }
            goto Label_00D4;
        Label_00BA:
            this.zgbmrGpDFLGOHnLLXUSqcmG4HB8nnP6t6zdfl5uB.Text = File.ReadAllText(str2);
        Label_00D4:
            this.RfTVnP83jcokckBvOot7cXVQG5hMnSeQfMSg4Qti();
            return;
        }

        private void 0DPZzApCfjI1RiPKT0a0MNpAqejFaUIoBC57TSKV()
        {
            object[] objArray1;
            ComponentResourceManager manager;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().QL0gkkW5MXnNSFBpG5EZGcMVSkBFrx5g4L2XH6Iw(0x145, "8UW6aGG2ET5FfXK17ZqyJ3QQvf3Wbaty4bkVq1NL", 11, objArray);
            return;
        }

        private void BmOXhr120HxNKGrv54DtPTivHqVBWaixPCY7W0He(string kTJoKmAesD9TP04mssytjro0I9h5ouDyhPVtB9Hc)
        {
            object[] objArray1;
            WebClient client;
            bool flag;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this, (string) kTJoKmAesD9TP04mssytjro0I9h5ouDyhPVtB9Hc };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().QL0gkkW5MXnNSFBpG5EZGcMVSkBFrx5g4L2XH6Iw(320, "AlOxOdRTuI8eGg4hxU6dbG6u54pOmADCCCG3NkpR", 0x4b, objArray);
            return;
        }

        public static void CIPgD1TmpeLbL97jhKKCQteLgXoHqM2Hoy9ZMu24()
        {
            string str;
            bool flag;
            FileStream stream;
            string str2;
            string[] strArray;
            bool flag2;
            bool flag3;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray = new object[0];
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().QL0gkkW5MXnNSFBpG5EZGcMVSkBFrx5g4L2XH6Iw(0x143, "dMfKRaf1ebgQrOzxeUVczKQh1fJlrdeq0K9yDtze", 0x34, objArray);
            return;
        }

        protected override void Dispose(bool disposing)
        {
            object[] objArray1;
            bool flag;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this, (bool) disposing };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().QL0gkkW5MXnNSFBpG5EZGcMVSkBFrx5g4L2XH6Iw(0x144, "CXjUqAhpIudvU8hTp80hw5VNctMxP6L8TXPhArtZ", 0x5c, objArray);
            return;
        }

        [vwdiSlwJxGqXH9b0vYKLtjV2MXSxz3m9qeN1dJzt("3Bhnq1naOQNH6iNvc3IxbWwaytHzv05RY7JRk8mu")]
        public static string GMyGhayKIOFKMHa8B0FLp8irYlJuevJGaAwJzE5j()
        {
            WebClient client;
            string str;
            object[] objArray;
            goto Label_000D;
        Label_000D:
            objArray = new object[0];
            return (string) new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().H0WrFjmFtMdgdpGgvdjRTYsBSdS74ki4nPylmokO(0x13e, 0x34, objArray);
        }

        private void IfjTUkyxBJgZ4ypBETEnZOiobI22PjL051UJopnn(object 1hqDNdbFNIj69ut8uou8bdXI7vUeORHmyrOsvTls, MouseEventArgs phreaX1BCIPaeAaGRDGZJxtc1616O2SSN4NppLId)
        {
            object[] objArray1;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this, (object) 1hqDNdbFNIj69ut8uou8bdXI7vUeORHmyrOsvTls, (MouseEventArgs) phreaX1BCIPaeAaGRDGZJxtc1616O2SSN4NppLId };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().QL0gkkW5MXnNSFBpG5EZGcMVSkBFrx5g4L2XH6Iw(0x13b, "8F3fblJO5C0gf0pvT75L4d5LCr3HYqqn3QuxxXo2", 240, objArray);
            return;
        }

        [vwdiSlwJxGqXH9b0vYKLtjV2MXSxz3m9qeN1dJzt("lPF0cyyxydZ87DI6UlO3ifjMjcw0EePKNRWMCL2d")]
        private void j3tMZauMV3b7z65LA3pTmhRGmIrFJQE8t7JEJtoF()
        {
            object[] objArray1;
            string str;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().H0WrFjmFtMdgdpGgvdjRTYsBSdS74ki4nPylmokO(0x138, 0x8b, objArray);
            return;
        }

        [NQfIRakK40SrS9euIwb0K9HZxqQFqUFKRD3RrjnL("4WvYbvOUvmGqwBTOa2sPlUbT7e8VdvgPTmAFDIcg", 0x35)]
        private void MrdSeauKg0QlwY6Bi2gzVDUDLDtrBAiSA3RusEVm(object XUch7lIoa4sUkkOiIP3n5r3VL92AzNDGy5jjjjGA, EventArgs y5e4hSwoxcPDPvvKFOI8AiiskUZczk0j5Ewaa9Ou)
        {
            object[] objArray1;
            bool flag;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this, (object) XUch7lIoa4sUkkOiIP3n5r3VL92AzNDGy5jjjjGA, (EventArgs) y5e4hSwoxcPDPvvKFOI8AiiskUZczk0j5Ewaa9Ou };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().ZJfp1kmCW5GvJN3g9eD9Ei2vNq43WrTKboa8oQ5w(0x13d, objArray);
            return;
        }

        [vwdiSlwJxGqXH9b0vYKLtjV2MXSxz3m9qeN1dJzt("qyaxBiM1xxte6m4yl3QaWh3eFWpR2BqBAcLed54o")]
        private void NU5UfyOkB3BzZQVznnn36RrfAA3rhEzcWYGVm7Ag(object 9CBVCZURpHrjGhKcRLuVsYzx1Zj65aLE9s4qGhA8, MouseEventArgs 3n3QnXKYBlwQ1FeTXR6wsPIp7QkRwILfli3CSA6u)
        {
            object[] objArray1;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this, (object) 9CBVCZURpHrjGhKcRLuVsYzx1Zj65aLE9s4qGhA8, (MouseEventArgs) 3n3QnXKYBlwQ1FeTXR6wsPIp7QkRwILfli3CSA6u };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().H0WrFjmFtMdgdpGgvdjRTYsBSdS74ki4nPylmokO(0x139, 0x5e, objArray);
            return;
        }

        public static void PSdToIVUZrG41KUZ0ehX8mxYCx6MTMN2CsIVPq3p()
        {
            string str;
            StreamWriter writer;
            int num;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray = new object[0];
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().QL0gkkW5MXnNSFBpG5EZGcMVSkBFrx5g4L2XH6Iw(0x142, "sBz0xFaUG1Ib1YA6Ts8sB0XYe9Dm5namKPEg3mwj", 0xf9, objArray);
            return;
        }

        [NQfIRakK40SrS9euIwb0K9HZxqQFqUFKRD3RrjnL("cyI0pOmBaceBMMF4dzYrlnOgkjZuOjuJR3kSxYde", 10)]
        private void RfTVnP83jcokckBvOot7cXVQG5hMnSeQfMSg4Qti()
        {
            object[] objArray1;
            string str;
            int num;
            SimpleTcpClient client;
            Message message;
            string str2;
            bool flag;
            bool flag2;
            bool flag3;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().ZJfp1kmCW5GvJN3g9eD9Ei2vNq43WrTKboa8oQ5w(0x137, objArray);
            return;
        }

        private void ULja3GjGe3LX00YVqJqr44h368qoQ1YWyE57ytEf(object Jd3Gq0X9be8EIRkSEcr5Rotsb7Hv5OLug7vLzQLu, EventArgs dsMO2efDsmYLaUMIiLjfqbt0m1gQyOQ2G7LlnUlc)
        {
            object[] objArray1;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this, (object) Jd3Gq0X9be8EIRkSEcr5Rotsb7Hv5OLug7vLzQLu, (EventArgs) dsMO2efDsmYLaUMIiLjfqbt0m1gQyOQ2G7LlnUlc };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().QL0gkkW5MXnNSFBpG5EZGcMVSkBFrx5g4L2XH6Iw(0x13c, "PtFVzGpol9CV0cfCKsZwbarXDZxDMBzMBrpNOiJo", 0xc4, objArray);
            return;
        }

        private void wWAL38Fp180PfcrYImlccF2eN0t4lXUjROFjHgMR(object 1IfTGOrikUOcqQbK1b2r4L1uEPuGMV0mPNYBnbvj, EventArgs C6DXdpu2q6bjxJPoJieyEnbTJhVwyPkEzSj7uu3l)
        {
            object[] objArray1;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this, (object) 1IfTGOrikUOcqQbK1b2r4L1uEPuGMV0mPNYBnbvj, (EventArgs) C6DXdpu2q6bjxJPoJieyEnbTJhVwyPkEzSj7uu3l };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().QL0gkkW5MXnNSFBpG5EZGcMVSkBFrx5g4L2XH6Iw(310, "VOvuHJtXFsyUNH5uppWGJ2xxQDbGdb4NyMiGaRJ0", 0x7b, objArray);
            return;
        }

        [NQfIRakK40SrS9euIwb0K9HZxqQFqUFKRD3RrjnL("1H23vtLxUEt9XjoCcZnGe5qJ4dh2PzntcEwMCeM0", 0x8b)]
        public static bool WWDozFCM1dXPWSCfc0QKtT4y94g9r0YdYMmYZ9B4(string fYr6wrwFCPL8b8kj0UoibCHzJPtzlkCczHTOA8W6)
        {
            object[] objArray1;
            string str;
            int num;
            string str2;
            SimpleTcpClient client;
            string str3;
            Message message;
            bool flag;
            bool flag2;
            bool flag3;
            bool flag4;
            bool flag5;
            bool flag6;
            string str4;
            string[] strArray;
            string str5;
            string str6;
            string str7;
            bool flag7;
            bool flag8;
            bool flag9;
            object[] objArray;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (string) fYr6wrwFCPL8b8kj0UoibCHzJPtzlkCczHTOA8W6 };
            objArray = objArray1;
            return (bool) new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().ZJfp1kmCW5GvJN3g9eD9Ei2vNq43WrTKboa8oQ5w(0x141, objArray);
        }

        [NQfIRakK40SrS9euIwb0K9HZxqQFqUFKRD3RrjnL("FRTu8UXUPGA2i2Z5s7Kt8h8IqhDPQ12c8ZckWCti", 0x55)]
        private void WWoFHiSxpAbqmuVw2WFBRfskQilMMj2wINPAZ4RN(object 95w4oI3smP31ViDIP0eON1D2ItFRIv27jBBI3jor, MouseEventArgs fuAqczInfe0Q249omZcr3nG6K6Q8ltFlL9xLAEUY)
        {
            object[] objArray1;
            bool flag;
            Point point;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this, (object) 95w4oI3smP31ViDIP0eON1D2ItFRIv27jBBI3jor, (MouseEventArgs) fuAqczInfe0Q249omZcr3nG6K6Q8ltFlL9xLAEUY };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().ZJfp1kmCW5GvJN3g9eD9Ei2vNq43WrTKboa8oQ5w(0x13a, objArray);
            return;
        }

        [AsyncStateMachine(typeof(<LoginClick>d__18)), DebuggerStepThrough]
        private void ZWBEGoIhEcdqcN7JSzp6w8Gp18Klxm6x4cjnpHnc(object XZGJsUlqEFy9m96EuHSHZg3pA0h9POI6DCs2w78x, EventArgs JUNLf6e5ABmTtM5UIYjwkmS4upvIVrooJh94ns5R)
        {
            object[] objArray1;
            CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS ys;
            object[] objArray;
            object obj2;
            goto Label_000D;
        Label_000D:
            objArray1 = new object[] { (Login) this, (object) XZGJsUlqEFy9m96EuHSHZg3pA0h9POI6DCs2w78x, (EventArgs) JUNLf6e5ABmTtM5UIYjwkmS4upvIVrooJh94ns5R };
            objArray = objArray1;
            obj2 = new YOMReAL4W7u6msISe9NJ60UMKWUhVTPnvfy4iYjJ().QL0gkkW5MXnNSFBpG5EZGcMVSkBFrx5g4L2XH6Iw(0x13f, "F8gSOOFvRekM9z0oTgwysvDLHxp9ZcuvPZLAYLEI", 0xd0, objArray);
            return;
        }

        [CompilerGenerated]
        private sealed class CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS : IAsyncStateMachine
        {
            public int 6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD;
            public AsyncVoidMethodBuilder 057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy;
            public object zSlE8t4iWCynNRoQwCXDc2SBswiBZHpLVWF28ofn;
            public EventArgs zHhvkDbTRBqiSSMp9TjF6uHtDvDt0jSdPcSJFgUO;
            public Login 6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ;
            private string jArxvix94JJERDOD9uAUR1s78iIp1po7SqFPhl0t;
            private WebClient DOxmvrkwptmHDeinhuvjQsoWOL1l89cJjx34U1P4;
            private string NdaCNExOrgwo4PRZAQXGd8xpLDnjpd2vURZbsx4y;
            private string vlhWGgCJ1ET5u5K000tfeyb0x7DZoyhyJHj3MSYT;
            private FileStream 0MbJL7jSXSIxjKrl3nbKSxOCfbhZGBihwQvmJLib;
            private string JaHUO4B9D89mdB2TqDRmLN67RkaHwMSsk9zSHzfl;
            private ProcessStartInfo QhBHBVeUL2ptgBJ0tLej4pH2cVefCkBpbsMEajoJ;
            private FileStream hR7ZQI6RmqU787bZQ6maXNMZraHrtfNVPcaAsflN;
            private TaskAwaiter 1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;

            public CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS()
            {
                goto Label_000D;
            Label_000D:
                base..ctor();
                return;
            }

            private unsafe void MoveNext()
            {
                int num;
                bool flag;
                TaskAwaiter awaiter;
                Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS ys;
                TaskAwaiter awaiter2;
                TaskAwaiter awaiter3;
                bool flag2;
                TaskAwaiter awaiter4;
                TaskAwaiter awaiter5;
                bool flag3;
                TaskAwaiter awaiter6;
                bool flag4;
                bool flag5;
                bool flag6;
                TaskAwaiter awaiter7;
                TaskAwaiter awaiter8;
                TaskAwaiter awaiter9;
                bool flag7;
                DateTime time;
                int num2;
                TaskAwaiter awaiter10;
                Exception exception;
                goto Label_000D;
            Label_000D:
                num = this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD;
            Label_0016:
                try
                {
                    switch (num)
                    {
                        case 0:
                            goto Label_0046;

                        case 1:
                            goto Label_004B;

                        case 2:
                            goto Label_0050;

                        case 3:
                            goto Label_0055;

                        case 4:
                            goto Label_005A;

                        case 5:
                            goto Label_005F;

                        case 6:
                            goto Label_0064;

                        case 7:
                            goto Label_0069;

                        case 8:
                            goto Label_006E;

                        case 9:
                            goto Label_0073;
                    }
                    goto Label_0078;
                Label_0046:
                    goto Label_013D;
                Label_004B:
                    goto Label_01B6;
                Label_0050:
                    goto Label_0230;
                Label_0055:
                    goto Label_02C1;
                Label_005A:
                    goto Label_0341;
                Label_005F:
                    goto Label_03FB;
                Label_0064:
                    goto Label_058E;
                Label_0069:
                    goto Label_0644;
                Label_006E:
                    goto Label_06B0;
                Label_0073:
                    goto Label_085E;
                Label_0078:
                    if (((this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.zgbmrGpDFLGOHnLLXUSqcmG4HB8nnP6t6zdfl5uB.Text == "") | (this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.zgbmrGpDFLGOHnLLXUSqcmG4HB8nnP6t6zdfl5uB.Text == "Key")) == null)
                    {
                        goto Label_00C6;
                    }
                    MessageBox.Show("Invalid input.");
                    Environment.Exit(0);
                Label_00C6:
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.Enabled = 0;
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.zgbmrGpDFLGOHnLLXUSqcmG4HB8nnP6t6zdfl5uB.IekwvNk7Zn1m77lHFpbMWaF0YQ6n3yWoSVZWSri6(1);
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng(".");
                    awaiter = Task.Delay(0x19).GetAwaiter();
                    if (&awaiter.get_IsCompleted() != null)
                    {
                        goto Label_0159;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 0;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter, &ys);
                    goto Label_08E3;
                Label_013D:
                    awaiter = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_0159:
                    &awaiter.GetResult();
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng("..");
                    awaiter2 = Task.Delay(0x19).GetAwaiter();
                    if (&awaiter2.get_IsCompleted() != null)
                    {
                        goto Label_01D3;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 1;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter2;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter2, &ys);
                    goto Label_08E3;
                Label_01B6:
                    awaiter2 = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_01D3:
                    &awaiter2.GetResult();
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng("...");
                    awaiter3 = Task.Delay(0x19).GetAwaiter();
                    if (&awaiter3.get_IsCompleted() != null)
                    {
                        goto Label_024D;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 2;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter3;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter3, &ys);
                    goto Label_08E3;
                Label_0230:
                    awaiter3 = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_024D:
                    &awaiter3.GetResult();
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng(".");
                    if ((xEwkb4Y2F1CnzY0yqaz64ZV096IiqvdkeLXU2ig0.ALOeFHl9a1DKsoit6gk3CCPDuYldo4d1IJKHYeh3() == 1) == null)
                    {
                        goto Label_0282;
                    }
                    Environment.Exit(0);
                Label_0282:
                    awaiter4 = Task.Delay(0x19).GetAwaiter();
                    if (&awaiter4.get_IsCompleted() != null)
                    {
                        goto Label_02DE;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 3;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter4;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter4, &ys);
                    goto Label_08E3;
                Label_02C1:
                    awaiter4 = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_02DE:
                    &awaiter4.GetResult();
                    PJ0GIxLOoCeAOhna4BxnOAInDftbHL4rLY8GLFif.JxEZg9G3st2VWK6xRMomTGP6uQ5zLkckrEJpZLfF();
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng("..");
                    awaiter5 = Task.Delay(0x19).GetAwaiter();
                    if (&awaiter5.get_IsCompleted() != null)
                    {
                        goto Label_035E;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 4;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter5;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter5, &ys);
                    goto Label_08E3;
                Label_0341:
                    awaiter5 = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_035E:
                    &awaiter5.GetResult();
                    60II2BOl6kS8vgR50TBMO5gnhCHWk2IBSNzGdHeh.glt7bkP2uMpeLYGaSolupBatMVcOfBMsEOTj0ja7();
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng("...");
                    if (Login.WWDozFCM1dXPWSCfc0QKtT4y94g9r0YdYMmYZ9B4(this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.zgbmrGpDFLGOHnLLXUSqcmG4HB8nnP6t6zdfl5uB.Text) == null)
                    {
                        goto Label_08AA;
                    }
                    Login.YkmG7esA3VIgnDoghkz1nw02Ex95rY5BcZaGNx0f = this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.zgbmrGpDFLGOHnLLXUSqcmG4HB8nnP6t6zdfl5uB.Text;
                    60II2BOl6kS8vgR50TBMO5gnhCHWk2IBSNzGdHeh.glt7bkP2uMpeLYGaSolupBatMVcOfBMsEOTj0ja7();
                    awaiter6 = Task.Delay(0x19).GetAwaiter();
                    if (&awaiter6.get_IsCompleted() != null)
                    {
                        goto Label_0418;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 5;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter6;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter6, &ys);
                    goto Label_08E3;
                Label_03FB:
                    awaiter6 = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_0418:
                    &awaiter6.GetResult();
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng(".");
                    this.jArxvix94JJERDOD9uAUR1s78iIp1po7SqFPhl0t = Environment.GetEnvironmentVariable("PROGRAMDATA") + "/Honeycomb/HoneyKey.ini";
                    if ((File.Exists(this.jArxvix94JJERDOD9uAUR1s78iIp1po7SqFPhl0t) == 0) == null)
                    {
                        goto Label_04A8;
                    }
                    this.0MbJL7jSXSIxjKrl3nbKSxOCfbhZGBihwQvmJLib = File.Create(this.jArxvix94JJERDOD9uAUR1s78iIp1po7SqFPhl0t);
                    this.0MbJL7jSXSIxjKrl3nbKSxOCfbhZGBihwQvmJLib.Close();
                    File.WriteAllText(this.jArxvix94JJERDOD9uAUR1s78iIp1po7SqFPhl0t, this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.zgbmrGpDFLGOHnLLXUSqcmG4HB8nnP6t6zdfl5uB.Text);
                    this.0MbJL7jSXSIxjKrl3nbKSxOCfbhZGBihwQvmJLib = null;
                    goto Label_04C6;
                Label_04A8:
                    File.WriteAllText(this.jArxvix94JJERDOD9uAUR1s78iIp1po7SqFPhl0t, this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.zgbmrGpDFLGOHnLLXUSqcmG4HB8nnP6t6zdfl5uB.Text);
                Label_04C6:
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng("..");
                    this.DOxmvrkwptmHDeinhuvjQsoWOL1l89cJjx34U1P4 = new WebClient();
                    this.NdaCNExOrgwo4PRZAQXGd8xpLDnjpd2vURZbsx4y = y1uhWzVknOtxWxQHzFm2ZOHptu8UBMYnBzTNweyO.CkZFib32q1jPPtTYLUMP38jb0foLoa4oc2gAbZoT.9IRkCCCbEVDGFU9N4URWRWGWqRhzu6VMUNUQAt2o(this.DOxmvrkwptmHDeinhuvjQsoWOL1l89cJjx34U1P4.DownloadString("https://raw.githubusercontent.com/feticks/123456789/main/version"), "D4,");
                    this.vlhWGgCJ1ET5u5K000tfeyb0x7DZoyhyJHj3MSYT = y1uhWzVknOtxWxQHzFm2ZOHptu8UBMYnBzTNweyO.CkZFib32q1jPPtTYLUMP38jb0foLoa4oc2gAbZoT.9IRkCCCbEVDGFU9N4URWRWGWqRhzu6VMUNUQAt2o("YdCUzGeGBlmgJqInb5gv9Bj0zGuOxoDJ11j0BKj2lmh/a65JVjB5++Tir6zyzqdyqcu0Z1N/iv06C0gLEOdcSdaNCNxxXOrbDfFPbi3KkfZKG325/zsr9Q7OyEwy2YII", "D4,");
                    if ((this.NdaCNExOrgwo4PRZAQXGd8xpLDnjpd2vURZbsx4y == this.vlhWGgCJ1ET5u5K000tfeyb0x7DZoyhyJHj3MSYT) == null)
                    {
                        goto Label_0809;
                    }
                    if ((Process.GetProcessesByName("lghub").Length != 0) == null)
                    {
                        goto Label_05E0;
                    }
                    awaiter7 = Task.Delay(50).GetAwaiter();
                    if (&awaiter7.get_IsCompleted() != null)
                    {
                        goto Label_05AB;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 6;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter7;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter7, &ys);
                    goto Label_08E3;
                Label_058E:
                    awaiter7 = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_05AB:
                    &awaiter7.GetResult();
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.BmOXhr120HxNKGrv54DtPTivHqVBWaixPCY7W0He(@"C:\Windows\System32\EmailReader.dll");
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng("...");
                    goto Label_0671;
                Label_05E0:
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng("...");
                    MessageBox.Show("Please download/start GHUB to continue.");
                    awaiter8 = Task.Delay(0x7d0).GetAwaiter();
                    if (&awaiter8.get_IsCompleted() != null)
                    {
                        goto Label_0661;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 7;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter8;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter8, &ys);
                    goto Label_08E3;
                Label_0644:
                    awaiter8 = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_0661:
                    &awaiter8.GetResult();
                    Environment.Exit(0);
                Label_0671:
                    awaiter9 = Task.Delay(50).GetAwaiter();
                    if (&awaiter9.get_IsCompleted() != null)
                    {
                        goto Label_06CD;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 8;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter9;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter9, &ys);
                    goto Label_08E3;
                Label_06B0:
                    awaiter9 = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_06CD:
                    &awaiter9.GetResult();
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.YuzGNONq11GB48IhS4z8OFJnmtE5d84yo5XES3UM.dYcmG7bVJioKNqNPybgTax4ckler2tuBVgb04vng("...");
                    tVLFPRUQGXb8P8sMyS8OOV9qhNkQJIZSj3zouEy0.s6DtEGJfoIIiNcikBIvWd63imVLJ6rDDUivSq4LS();
                    this.JaHUO4B9D89mdB2TqDRmLN67RkaHwMSsk9zSHzfl = Environment.GetEnvironmentVariable("PROGRAMDATA") + "/Honeycomb/HoneyCheck.ini";
                    if ((File.Exists(this.JaHUO4B9D89mdB2TqDRmLN67RkaHwMSsk9zSHzfl) == 0) == null)
                    {
                        goto Label_0766;
                    }
                    this.hR7ZQI6RmqU787bZQ6maXNMZraHrtfNVPcaAsflN = File.Create(this.JaHUO4B9D89mdB2TqDRmLN67RkaHwMSsk9zSHzfl);
                    this.hR7ZQI6RmqU787bZQ6maXNMZraHrtfNVPcaAsflN.Close();
                    File.WriteAllText(this.JaHUO4B9D89mdB2TqDRmLN67RkaHwMSsk9zSHzfl, Convert.ToString(&DateTime.Now.Minute));
                    this.hR7ZQI6RmqU787bZQ6maXNMZraHrtfNVPcaAsflN = null;
                    goto Label_0787;
                Label_0766:
                    File.WriteAllText(this.JaHUO4B9D89mdB2TqDRmLN67RkaHwMSsk9zSHzfl, Convert.ToString(&DateTime.Now.Minute));
                Label_0787:
                    this.QhBHBVeUL2ptgBJ0tLej4pH2cVefCkBpbsMEajoJ = new ProcessStartInfo();
                    this.QhBHBVeUL2ptgBJ0tLej4pH2cVefCkBpbsMEajoJ.FileName = Application.ExecutablePath;
                    this.QhBHBVeUL2ptgBJ0tLej4pH2cVefCkBpbsMEajoJ.Arguments = Login.YkmG7esA3VIgnDoghkz1nw02Ex95rY5BcZaGNx0f + " " + &Process.GetCurrentProcess().Id.ToString() + " Bpp7Rg0jmcHIesX6xWRjqI81T8djPVgbjK27bXBk8Q5OSXp0idqMgcg35KkcngzDLvkr0mkGzzVheUqnDnLsr+Bxgmqc3Y91625ClfMZb3tEzl5+Xno+Rc9NLm6WI12K";
                    this.6FwFTzusaT2T1PE4aqX4amGfd8OharYX7KKlCePQ.Hide();
                    Process.Start(this.QhBHBVeUL2ptgBJ0tLej4pH2cVefCkBpbsMEajoJ);
                    Environment.Exit(0);
                    this.JaHUO4B9D89mdB2TqDRmLN67RkaHwMSsk9zSHzfl = null;
                    this.QhBHBVeUL2ptgBJ0tLej4pH2cVefCkBpbsMEajoJ = null;
                    goto Label_088B;
                Label_0809:
                    MessageBox.Show("Outdated version, please update to continue.");
                    Login.PSdToIVUZrG41KUZ0ehX8mxYCx6MTMN2CsIVPq3p();
                    awaiter10 = Task.Delay(0x7d0).GetAwaiter();
                    if (&awaiter10.get_IsCompleted() != null)
                    {
                        goto Label_087B;
                    }
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = 9;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = awaiter10;
                    ys = this;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.AwaitUnsafeOnCompleted<TaskAwaiter, Login.CFWL1SIIGiHojv6wazIC7lWHRSsG302CXXKAqHyS>(&awaiter10, &ys);
                    goto Label_08E3;
                Label_085E:
                    awaiter10 = this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd;
                    this.1O3SW1qZCl1t7i5AMYbQ13byxMvD67hvFRpd6oKd = new TaskAwaiter();
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = num = -1;
                Label_087B:
                    &awaiter10.GetResult();
                    Environment.Exit(0);
                Label_088B:
                    this.jArxvix94JJERDOD9uAUR1s78iIp1po7SqFPhl0t = null;
                    this.DOxmvrkwptmHDeinhuvjQsoWOL1l89cJjx34U1P4 = null;
                    this.NdaCNExOrgwo4PRZAQXGd8xpLDnjpd2vURZbsx4y = null;
                    this.vlhWGgCJ1ET5u5K000tfeyb0x7DZoyhyJHj3MSYT = null;
                    goto Label_08B3;
                Label_08AA:
                    Environment.Exit(0);
                Label_08B3:
                    goto Label_08CF;
                }
                catch (Exception exception1)
                {
                Label_08B5:
                    exception = exception1;
                    this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = -2;
                    &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.SetException(exception);
                    goto Label_08E3;
                }
            Label_08CF:
                this.6W0yI1XhKFkM4aPT2yghA2FVg3vTHYqx650dEHiD = -2;
                &this.057hPp1XsfIyANstue0GTjQsR6C9pvef7DbY4vgy.SetResult();
            Label_08E3:
                return;
            }

            [DebuggerHidden]
            private void SetStateMachine(IAsyncStateMachine stateMachine)
            {
                goto Label_000D;
            Label_000D:
                return;
            }
        }
    }
}

