using System;
using System.Text;

namespace JunkShop
{
    class JunkShopWorker
    {
        #region Declarations
        public static byte[] Kernel;

        public static int WeaponsDataOffset = -1;
        public static int OffsetToWeaponsSelected = -1;

        public static WeaponsData GetSelectedWeaponsData;

        static string[] _charstable;
        private static readonly string Chartable =
        @" , ,1,2,3,4,5,6,7,8,9,%,/,:,!,?,…,+,-,=,*,&,「,」,(,),·,.,,,~,“,”,‘,#,$,',_,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,À,Á,Â,Ä,Ç,È,É,Ê,Ë,Ì,Í,Î,Ï,Ñ,Ò,Ó,Ô,Ö,Ù,Ú,Û,Ü,Œ,ß,à,á,â,ä,ç,è,é,ê,ë,ì,í,î,ï,ñ,ò";


    public struct WeaponsData
        {
            public byte Price;
            public byte Item1;
            public byte Item2;
            public byte Item3;
            public byte Item4;
            public byte Quantity1;
            public byte Quantity2;
            public byte Quantity3;
            public byte Quantity4;
        }

        #endregion

        #region Write Variables

        public static void UpdateVariable_Weapons(int index, object variable)
        {
            if (!mainForm._loaded || Kernel == null)
                return;
            switch (index)
            {
                case 0:
                    Kernel[OffsetToWeaponsSelected + 3] = (byte)(Convert.ToInt32(variable) / 10); //Price
                    return;
                case 1:
                    Kernel[OffsetToWeaponsSelected + 4] = Convert.ToByte(variable); //Item 1
                    return;
                case 2:
                    Kernel[OffsetToWeaponsSelected + 5] = Convert.ToByte(variable); //Item Quantity 1
                    return;
                case 3:
                    Kernel[OffsetToWeaponsSelected + 6] = Convert.ToByte(variable); //Item 2
                    return;
                case 4:
                    Kernel[OffsetToWeaponsSelected + 7] = Convert.ToByte(variable); //Item Quantity 2
                    return;
                case 5:
                    Kernel[OffsetToWeaponsSelected + 8] = Convert.ToByte(variable); //Item 3
                    return;
                case 6:
                    Kernel[OffsetToWeaponsSelected + 9] = Convert.ToByte(variable); //Item Quantity 3
                    return;
                case 7:
                    Kernel[OffsetToWeaponsSelected + 10] = Convert.ToByte(variable); //Item 4
                    return;
                case 8:
                    Kernel[OffsetToWeaponsSelected + 11] = Convert.ToByte(variable); //Item Quantity 4
                    return;
            }
        }

        #endregion

        #region Read Variables

        public static void ReadJunkShop(byte[] kernel)
        {
            Kernel = kernel;
            WeaponsDataOffset = 0;
        }


        public static void ReadWeapons(int WeaponsID_List)
        {
            GetSelectedWeaponsData = new WeaponsData();
            int selectedWeaponsOffset = WeaponsDataOffset + (WeaponsID_List * 12);
            OffsetToWeaponsSelected = selectedWeaponsOffset;

            selectedWeaponsOffset += 3;
            GetSelectedWeaponsData.Price = Kernel[selectedWeaponsOffset++];
            GetSelectedWeaponsData.Item1 = Kernel[selectedWeaponsOffset++];
            GetSelectedWeaponsData.Quantity1 = Kernel[selectedWeaponsOffset++];
            GetSelectedWeaponsData.Item2 = Kernel[selectedWeaponsOffset++];
            GetSelectedWeaponsData.Quantity2 = Kernel[selectedWeaponsOffset++];
            GetSelectedWeaponsData.Item3 = Kernel[selectedWeaponsOffset++];
            GetSelectedWeaponsData.Quantity3 = Kernel[selectedWeaponsOffset++];
            GetSelectedWeaponsData.Item4 = Kernel[selectedWeaponsOffset++];
            GetSelectedWeaponsData.Quantity4 = Kernel[selectedWeaponsOffset++];
        }

        #endregion

        private static string BuildString(int index)
        {
            if (_charstable == null)
                _charstable = Chartable.Split(',');
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                if (Kernel[index] == 0x00)
                    return sb.ToString();
                char c = _charstable[Kernel[index++] - 31].ToCharArray()[0];
                sb.Append(c);
            }
        }
    }
}
