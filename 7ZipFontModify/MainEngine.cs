using System;
using System.IO;

namespace SevenZipFontModify
{
    internal static class MainEngine
    {
        #region Internal Methods

        internal static int Replace(string fileName, byte[] before, byte[] after)
        {
            if (before.Length != after.Length)
            {
                throw new ArgumentException("The lengths of before and after are different.");
            }

            FileStream stream;
            int result = 0;

            using (stream = new FileStream(fileName, FileMode.Open))
            {
                for (int position = 0, matched = 0; position < stream.Length; ++position)
                {
                    byte value = (byte)stream.ReadByte();

                    if (value != before[matched])
                    {
                        matched = 0;
                        continue;
                    }

                    ++matched;

                    if (matched == before.Length)
                    {
                        stream.Position = (position - matched + 1);
                        stream.Write(after, 0, after.Length);
                        ++result;
                        matched = 0;
                    }
                }
            }

            return result;
        }

        internal static byte[] ToByte(string value)
        {
            string value_ = value.Replace(" ", string.Empty);

            if ((value_.Length % 2) != 0)
            {
                throw new Exception($"{value} can't be converted to binary.");
            }

            var result = new byte[value_.Length / 2];

            for (int i = 0; i < result.Length; ++i)
            {
                result[i] = Convert.ToByte(value_.Substring((i * 2), 2), 16);
            }

            return result;
        }

        #endregion
    }
}
